
int[] numbersArray = new int[3];
numbersArray[0] = 12;
numbersArray[1] = 9;
numbersArray[2] = 8;

int[] numbersArray2 = new int[3];
numbersArray2[0] = 50;
numbersArray2[1] = 70;
numbersArray2[2] = 90;

int[] numbersArray3 = new int[3];
numbersArray3[0] = 100;
numbersArray3[1] = 200;
numbersArray3[2] = 251;




string[] names2 = new string[3];
names2[0] = "Nika";
names2[1] = "Giorgi";
names2[2] = "Daviti";

var resultNames = FindNames(names2);


Console.ReadLine();

string[] FindNames(string[] namesCollection)
{
    List<string> result = new();
    for (int i = 0; i < namesCollection.Length; i++)
    {
        if (namesCollection[i].EndsWith('i'))
        {
            result.Add(namesCollection[i]);
        }
    }

    return result.ToArray();
}


List<int> FindOddElements(int[] collection)
{
    List<int> result = new();

    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] % 2 != 0)
        {
            result.Add(collection[i]);
        }
    }
    return result;
}
void Increase(List<int> list)
{
    for (int i = 0; i < list.Count; i++)
    {
        list[i] *= 2;
        Console.WriteLine(list[i]);
    }
}



