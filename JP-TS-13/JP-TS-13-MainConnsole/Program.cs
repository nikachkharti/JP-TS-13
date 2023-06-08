using JP_TS_13_MainConnsole;


//int[] intList = { 10, 1, 1, 2 };
//List<string> names = new() { "Nika", "Giorgi", "Daviti", "Elene", "Nika", "Irakli", "Jemali" };
//string[] namesArray = { "Nika", "Giorgi", "Daviti", "Elene", "Nika", "Irakli", "Jemali" };

string[] carsAsStrings = File.ReadAllLines(@"../../../vehicles.csv");
Vehicle[] cars = Algorithms.Select(carsAsStrings, Vehicle.Parse);
var bmws = Algorithms.FindAll(cars, x => x.Make.Contains("BMW"));

var economicCars = Algorithms.Sort(cars, (x, y) => x.Combined > y.Combined);
var topTenEconomicCars = Algorithms.Take(economicCars, 100000);





Console.ReadKey();



















