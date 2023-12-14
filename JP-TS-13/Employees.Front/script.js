let createBtn = document.querySelector('#createBtn');
let clearBtn = document.querySelector('#clearBtn');
let deleteBtn = document.querySelector('#deleteBtn');
let updateBtn = document.querySelector('#updateBtn');

let companyId;
let companyName = document.querySelector('#comapnyName');
let companyDescription = document.querySelector('#companyDescription');
let comapnyCreateDate = document.querySelector('#comapnyCreateDate');

let companiesContainer = document.querySelector('#companiesContainer');


function displayCompanyInForm(company) {
    companyId = company.id;
    companyName.value = company.name;
    companyDescription.value = company.description;

    const dateobject = new Date(company.createDate);
    const dateResult = dateobject.toISOString().split('T')[0];

    comapnyCreateDate.value = dateResult;
}


function getCardById(id) {
    fetch(`https://localhost:7242/api/companies/${id}`)
        .then(response => response.json())
        .then(data => {
            displayCompanyInForm(data.result)

            //ვშლით კომპანიას ფორმის შევსების შემდეგ
            deleteBtn.addEventListener('click', function () {
                if (!formIsEmpty()) {
                    fetch(`https://localhost:7242/api/companies/${id}`, {
                        method: 'DELETE',
                        headers: {
                            'content-type': 'application/json'
                        }
                    })
                        .then(response => response.json()) // Need to invoke json() to parse the response
                        .then(data => {
                            clearForm();
                            alert('Company deleted successfully');
                            getAllCompanies();
                        }) // Log the parsed JSON data
                        .catch(error => console.error('Error:', error)); // Catch any errors
                }
            });


        })
        .catch(error => console.error('Error:', error));
}

function populateForm(id) {
    getCardById(id);
}




function formIsEmpty() {
    return companyName.value === "" && companyDescription.value === "";
}

function displayCompanies(companies) {
    let allCompanies = '';
    companies.forEach(company => {

        const companyElement = `
        <div class="card m-3 main-card" data-id=${company.id}>
            <div class="card-body">
                <h5 class="card-title">${company.name}</h5>
                <h6 class="card-subtitle mb-2 text-body-secondary">${company.createDate}</h6>
                <p class="card-text">${company.description}</p>
            </div>
        </div>
        `
        allCompanies += companyElement;
    });

    companiesContainer.innerHTML = allCompanies;

    //add event listeners on each card
    document.querySelectorAll('.main-card').forEach(card => {
        card.addEventListener('click', function () {
            populateForm(card.dataset.id)
        });
    });

}

function getAllCompanies() {
    fetch('https://localhost:7242/api/companies')
        .then(response => response.json())
        .then(data => displayCompanies(data.result))
}
getAllCompanies();


function createCompany(name, description, createDate) {

    const body = {
        "name": name.value,
        "description": description.value,
        "createDate": createDate.value
    };

    fetch('https://localhost:7242/api/companies', {
        method: 'POST',
        body: JSON.stringify(body),
        headers: {
            'content-type': 'application/json'
        }
    })
        .then(response => response.json()) // Need to invoke json() to parse the response
        .then(data => {
            clearForm();
            //TODO Check status before alert...
            alert('Company added successfully');
            getAllCompanies();
        }) // Log the parsed JSON data
        .catch(error => console.error('Error:', error)); // Catch any errors
}

createBtn.addEventListener('click', function () {
    createCompany(companyName, companyDescription, comapnyCreateDate);
})




clearBtn.addEventListener('click', clearForm);

function clearForm() {
    companyName.value = ''
    companyDescription.value = ''
    comapnyCreateDate.value = new Date();
}




function updateCompany(id,name, description, createDate) {
    const body = {
        "id": id,
        "name": name.value,
        "description": description.value,
        "createDate": createDate.value
    };

    fetch('https://localhost:7242/api/companies', {
        method: 'PUT',
        body: JSON.stringify(body),
        headers: {
            'content-type': 'application/json'
        }
    })
        .then(response => response.json()) // Need to invoke json() to parse the response
        .then(data => {
            clearForm();
            //TODO Check status before alert...
            alert('Company updated successfully');
            getAllCompanies();
        }) // Log the parsed JSON data
        .catch(error => console.error('Error:', error)); // Catch any errors
}


updateBtn.addEventListener('click',function(e){
    console.log(e);
    updateCompany(companyId,companyName, companyDescription, comapnyCreateDate);
})


