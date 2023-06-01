namespace JP_TS_13_MainConnsole
{
    public static class Algorithms
    {
        public static Vehicle[] Select(string[] collection)
        {
            Vehicle[] result = new Vehicle[collection.Length];
            for (int i = 0; i < collection.Length; i++)
            {
                result[i] = Vehicle.Parse(collection[i]);
            }

            return result;
        }


    }
}
