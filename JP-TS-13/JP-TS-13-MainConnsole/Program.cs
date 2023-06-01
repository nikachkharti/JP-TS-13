using JP_TS_13_MainConnsole;

string[] rawData = File.ReadAllLines(@"../../../vehicles.csv");
Vehicle[] parsedCars = Algorithms.Select(rawData);


var economicCars = Algorithms.Sort(parsedCars);


Console.ReadLine();










