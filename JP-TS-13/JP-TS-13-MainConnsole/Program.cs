using JP_TS_13_MainConnsole;


List<int> intList = new List<int>() { 1, 2, 3, 1, 4, -5, -10 };
List<string> names = new() { "Nika", "Giorgi", "Daviti", "Elene", "Nika", "Irakli", "Jemali" };
string[] namesArray = { "Nika", "Giorgi", "Daviti", "Elene", "Nika", "Irakli", "Jemali" };



var result = Algorithms.FindIndex(namesArray, x => x.EndsWith('i'));


Console.ReadLine();









