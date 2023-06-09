﻿using JP_TS_13_MainConnsole;
using JP_TS_13_MainConnsole.Shooter;
using JP_TS_13_MainConnsole.Shooter.Weapons;
#region Abstract class,Inheritence lecture code





//Person p1 = new()
//{ FirstName = "Davit", LastName = "Davitidze", Age = 17 };

//Student s1 = new()
//{ FirstName = "Nika", LastName = "Biwkinashvili", Age = 17, Score = 100 };
//s1.IntroduceYourself();

//Employee e1 = new()
//{ FirstName = "Giorgi", LastName = "Giorgadze", Age = 17, Salary = 1000 };

//Subject sub1 = new() { Name = "C#" };

//Administration ad1 = new()
//{
//    FirstName = "Ana",
//    LastName = "Giorgadze",
//    Age = 30,
//    Salary = 5000,
//    GroupID = "JP-TS-13"
//};
//ad1.IntroduceYourself();

//Lecturer lect1 = new()
//{
//    FirstName = "NIka",
//    LastName = "Chkhartishvili",
//    Age = 28,
//    Subject = sub1,
//    Salary = 5000
//};
//lect1.IntroduceYourself();






//void Greetings(Person obj) => Console.WriteLine($"Hello {obj.FirstName} {obj.LastName}");


//abstract class Bird
//{
//    public abstract void Fly();
//}

//class Eagle : Bird
//{
//    public override void Fly()
//    {
//        Console.WriteLine("HIGH FLYING...");
//    }
//}

//class Penguin : Bird
//{
//    public override void Fly()
//    {
//        throw new NotImplementedException();
//    }
//}



//abstract class Person
//{
//    public string FirstName { get; set; }
//    public string LastName { get; set; }
//    public int Age { get; set; }
//    public abstract void IntroduceYourself();
//}

//class Student : Person
//{
//    public double Score { get; set; }

//    public override void IntroduceYourself()
//    {
//        Console.WriteLine($"I am student my name is {FirstName} {LastName} I have Score {Score}");
//    }
//}

//abstract class Employee : Person
//{
//    public decimal Salary { get; set; }
//}

//class Subject
//{
//    public string Name { get; set; }
//}

//class Lecturer : Employee //მემკვიდრეობა
//{
//    // კომპოზიცია
//    public Subject Subject { get; set; }

//    public override void IntroduceYourself()
//    {
//        Console.WriteLine($"I am student my name is {FirstName} {LastName} I have Salary {Salary} Subject {Subject.Name}");
//    }
//}

//class Administration : Employee
//{
//    public string GroupID { get; set; }

//    public override void IntroduceYourself()
//    {
//        Console.WriteLine($"I am student my name is {FirstName} {LastName} I have Salary {Salary} I own group {GroupID}");
//    }
//}




#endregion

#region Shooter

/*
//1.დაამატეთ იარაღის გადატენვის ლოგიკა
//2.დაამატეთ ტყვიების ფუნქციონალი


Player playerNika = new()
{
    Status = Status.Terrorist,
    Name = "Nika"
};

Player playerGiorgi = new()
{
    Status = Status.CounterTerrorist,
    Name = "Giorgi"
};



playerNika.DisplayInfo();
playerGiorgi.DisplayInfo();

Console.WriteLine("----------------------------------");

playerNika.BuyWeapon(new Ak47());

playerNika.DisplayInfo();
playerGiorgi.DisplayInfo();


Console.WriteLine("----------------------------------");
playerNika.Shoot(playerGiorgi);
playerNika.DisplayInfo();
playerGiorgi.DisplayInfo();

*/

#endregion



#region Interfaces



//ChooseTarget(new Eagle() { Name = "Nika" });




//void ChooseTarget(IBird chosenTarget)
//{
//    Console.WriteLine($"TARGET IS {chosenTarget.Name}");
//}



//interface IBird
//{
//    public string Name { get; set; }
//}
//interface IFlyer
//{
//    public void Fly();
//}

//class Eagle : IBird, IFlyer
//{
//    public string Name { get; set; }

//    public void Fly()
//    {
//        Console.WriteLine("FLYING HIGH");
//    }
//}

//class Penguin : IBird
//{
//    public string Name { get; set; }
//}

//class Crow : IBird, IFlyer
//{
//    public string Name { get; set; }
//    public void Fly()
//    {
//        Console.WriteLine("CROW FLYING");
//    }
//}

//class Chicken : IBird
//{
//    public string Name { get; set; }
//}


//List<int> intList = new() { 1, 2, 3 };

//HashSet<int> set = new();
//set.Add(1);

//Dictionary<string, string> dict = new();
//dict.Add("CHemi saxeli", "Nika");
//dict.Add("sxvisi saxeli", "Grigi");


//Stack<int> intStack = new();
//intStack.Push(10);
//intStack.Push(20);
//intStack.Push(30);


//List<int> intList = new() { 1, 2, 3 };
//HashSet<int> intset = new() { 1, 2, 3 };
//int[] intArray = { 1, 2, 3 };


//var a = intList.GetEnumerator();

//List<string> n = new() { "1", "2", "3" };

//var x = Algorithms.MySelect(n, int.Parse);





//Console.ReadLine();




#endregion



#region Operator overloads

//int x = 10;
//int y = 10;

//Console.WriteLine(x + y);
//Console.WriteLine(x - y);
//Console.WriteLine(x * y);
//Console.WriteLine(x / y);


Vehicle v1 = Vehicle.Parse("BMW,750il,12,5,Rear-Wheel Drive,Automatic 4-spd,11,13,17");
Vehicle v2 = Vehicle.Parse("Mercedes,750il,12,5,Rear-Wheel Drive,Automatic 4-spd,11,13,17");


Console.WriteLine(v1.Equals(v2));





#endregion