using JP_TS_13_MainConnsole;

//Person p1 = new()
//{ FirstName = "Davit", LastName = "Davitidze", Age = 17 };

Student s1 = new()
{ FirstName = "Nika", LastName = "Biwkinashvili", Age = 17, Score = 100 };
s1.IntroduceYourself();

//Employee e1 = new()
//{ FirstName = "Giorgi", LastName = "Giorgadze", Age = 17, Salary = 1000 };

Subject sub1 = new() { Name = "C#" };

Administration ad1 = new()
{
    FirstName = "Ana",
    LastName = "Giorgadze",
    Age = 30,
    Salary = 5000,
    GroupID = "JP-TS-13"
};
ad1.IntroduceYourself();

Lecturer lect1 = new()
{
    FirstName = "NIka",
    LastName = "Chkhartishvili",
    Age = 28,
    Subject = sub1,
    Salary = 5000
};
lect1.IntroduceYourself();






void Greetings(Person obj) => Console.WriteLine($"Hello {obj.FirstName} {obj.LastName}");


abstract class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public abstract void IntroduceYourself();
}

class Student : Person
{
    public double Score { get; set; }

    public override void IntroduceYourself()
    {
        Console.WriteLine($"I am student my name is {FirstName} {LastName} I have Score {Score}");
    }
}

abstract class Employee : Person
{
    public decimal Salary { get; set; }
}

class Subject
{
    public string Name { get; set; }
}

class Lecturer : Employee //მემკვიდრეობა
{
    // კომპოზიცია
    public Subject Subject { get; set; }

    public override void IntroduceYourself()
    {
        Console.WriteLine($"I am student my name is {FirstName} {LastName} I have Salary {Salary} Subject {Subject.Name}");
    }
}

class Administration : Employee
{
    public string GroupID { get; set; }

    public override void IntroduceYourself()
    {
        Console.WriteLine($"I am student my name is {FirstName} {LastName} I have Salary {Salary} I own group {GroupID}");
    }
}












