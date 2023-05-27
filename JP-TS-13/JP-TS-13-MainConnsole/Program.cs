using JP_TS_13_MainConnsole;

string[] rawData = File.ReadAllLines(@"../../../vehicles.csv");

Vehicle[] vehicles = new Vehicle[rawData.Length];
for (int i = 0; i < rawData.Length; i++)
{
    vehicles[i] = Vehicle.Parse(rawData[i]);
}





Console.ReadLine();
