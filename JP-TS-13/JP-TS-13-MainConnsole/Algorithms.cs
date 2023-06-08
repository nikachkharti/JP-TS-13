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
        public static List<T> Take<T>(T[] collection, int count)
        {
            if (count > collection.Length)
                throw new ArgumentOutOfRangeException();

            List<T> result = new();
            for (int i = 0; i < count; i++)
            {
                result.Add(collection[i]);
            }

            return result;
        }
        public static T[] Sort<T>(T[] collection, Func<T, T, bool> comparer)
        {
            for (int i = 0; i < collection.Length - 1; i++)
            {
                for (int j = i + 1; j < collection.Length; j++)
                {
                    if (comparer(collection[j], collection[i]))
                    {
                        T t = collection[j];
                        collection[j] = collection[i];
                        collection[i] = t;
                    }
                }
            }

            return collection;
        }
        public static TResult[] Select<TSource, TResult>(TSource[] collection, Func<TSource, TResult> selector)
        {
            TResult[] result = new TResult[collection.Length];
            for (int i = 0; i < collection.Length; i++)
            {
                result[i] = selector(collection[i]);
            }

            return result;
        }
        public static T[] FindAll<T>(T[] carsCollection, Predicate<T> comparer)
        {
            List<T> result = new();
            for (int i = 0; i < carsCollection.Length; i++)
            {
                if (comparer(carsCollection[i]))
                {
                    result.Add(carsCollection[i]);
                }
            }

            return result.ToArray();
        }
        public static int FindIndex<T>(T[] collection, Func<T, bool> comparer)
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
        public static T FirstOrDefault<T>(List<T> collection, Func<T, bool> compareDelegate)
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
        public static T LastOrDefault<T>(T[] collection, Func<T, bool> compareDelegate)
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


        // დაწერეთ უნიკალური ელემენტის პოვნის ფუნქცია სახელად Distinct უნდა იყოს ჯენერიკი ანუ არ იყოს ტიპზე დამოკიდებული.
        // დაწერეთ ფუნქცია Any რომელიც გაარკვევს ლისტის რომელიმე ელემენტი აკმაყოფილებს თუ არა გადაცემულ პირობას. (ჯენერიკი)
        // დაწერეთ ფუნქცია All რომელიც გაარკვევს ლისტის ყველა ელემენტი აკმაყოფილებს თუ არა გადაცემულ პირობას. (ჯენერიკი)
    }
}
