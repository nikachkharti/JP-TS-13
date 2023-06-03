using JP_TS_13_MainConnsole;


int[] intAr = { 1, 2, 3, 10, 5, 4 };

var result = Algorithms.FindIndex(intAr, x => x < 0);



Console.WriteLine(result);
