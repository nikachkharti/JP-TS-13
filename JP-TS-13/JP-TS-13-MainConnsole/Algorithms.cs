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
        public static List<T> MyTake<T>(this T[] collection, int count)
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
        public static T[] MyOrderBy<T>(this T[] collection, Func<T, T, bool> comparer)
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
        public static TResult[] MySelect<TSource, TResult>(this TSource[] collection, Func<TSource, TResult> selector)
        {
            TResult[] result = new TResult[collection.Length];
            for (int i = 0; i < collection.Length; i++)
            {
                result[i] = selector(collection[i]);
            }

            return result;
        }
        public static T[] MyFindAll<T>(this T[] carsCollection, Predicate<T> comparer)
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
        public static int MyFindIndex<T>(this T[] collection, Func<T, bool> comparer)
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
        public static int MyFindLastIndex<T>(this List<T> collection, Func<T, bool> predicate)
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
        public static T MyFirstOrDefault<T>(this List<T> collection, Func<T, bool> compareDelegate)
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
        public static T MyLastOrDefault<T>(this T[] collection, Func<T, bool> compareDelegate)
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
        public static bool MyAny<T>(this List<T> collection, Func<T, bool> predicate)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                if (predicate(collection[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool MyAll<T>(this List<T> collection, Func<T, bool> predicate)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                if (!predicate(collection[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public static List<T> MyDistinct<T>(this List<T> collection)
        {
            List<T> result = new();
            for (int i = 0; i < collection.Count; i++)
            {
                bool notUnique = false;
                for (int j = 0; j < collection.Count; j++)
                {
                    if (i != j && collection[i].Equals(collection[j]))
                    {
                        notUnique = true;
                        break;
                    }
                }
                if (!notUnique)
                {
                    result.Add(collection[i]);
                }
            }
            return result;
        }
    }
}
