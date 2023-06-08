namespace JP_TS_13_MainConnsole
{
    //ჩემი დელეგატები

    //public delegate bool CompareDelegate(int parameter);
    //public delegate bool CarCompareDelegate(Vehicle parameter);
    //delegate int OperationDelegate(int arg1, int arg2);
    //delegate void VoidDelegate();



    // ჩაშენებული დელეგატები

    //Action - ინიჭებს ისეთ ფუნქციას რომელიც არის void ტიპის,
    //Func - ინიჭებს ისეთ ფუნქციას რომელიც რაიმე პარამეტრს აბრუნებს,
    //Predicate - ინიჭებს ისეთ ფუნქციას რომელიც კონკრეტულად Boolean -ს აბრუნებს


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
        public static Vehicle[] Sort(Vehicle[] collection)
        {
            for (int i = 0; i < collection.Length - 1; i++)
            {
                for (int j = i + 1; j < collection.Length; j++)
                {
                    if (collection[j].Combined > collection[i].Combined)
                    {
                        Vehicle t = collection[j];
                        collection[j] = collection[i];
                        collection[i] = t;
                    }
                }
            }

            return collection;
        }
        public static Vehicle[] FindAll(Vehicle[] carsCollection, Predicate<Vehicle> comparer)
        {
            List<Vehicle> result = new();
            for (int i = 0; i < carsCollection.Length; i++)
            {
                if (comparer(carsCollection[i]))
                {
                    result.Add(carsCollection[i]);
                }
            }

            return result.ToArray();
        }
        public static int FindIndex(int[] collection, Func<int, bool> comparer)
        {
            for (int i = 0; i < collection.Length; i++)
            {
                if (comparer(collection[i]))
                {
                    return i;
                }
            }

            return -1;
        }
        public static int LastOrDefault(int[] collection, Func<int, bool> compareDelegate)
        {
            for (int i = collection.Length - 1; i >= 0; i--)
            {
                if (compareDelegate(collection[i]))
                {
                    return collection[i];
                }
            }
            return default;
        }

        public static int FindLastIndex<T>(List<T> collection, Func<T, bool> predicate)
        {
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                if (predicate(collection[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public static int FirstOrDefault(List<int> collection, Func<int, bool> compareDelegate)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                if (compareDelegate(collection[i]))
                {
                    return collection[i];
                }
            }
            return default;
        }
    }
}
