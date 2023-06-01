namespace JP_TS_13_MainConnsole
{
    public static class Algorithms
    {
        /// <summary>
        /// გარდაქმნის string -ის მასივს მანქანის მასივად
        /// </summary>
        /// <param name="collection">რაც უნდა გარდაიქმნას</param>
        /// <returns>მანქანების მასივს</returns>
        public static Vehicle[] Select(string[] collection)
        {
            Vehicle[] result = new Vehicle[collection.Length];
            for (int i = 0; i < collection.Length; i++)
            {
                result[i] = Vehicle.Parse(collection[i]);
            }

            return result;
        }

        /// <summary>
        /// ეძებს ყველა მანქანას გადაცემული პარამეტრის მიხედვით
        /// </summary>
        /// <param name="carsCollection">სადაც ეძებს</param>
        /// <param name="name">გადაცემული პარამეტრი (რასაც ეძებს)</param>
        /// <returns>მანქანების მასივს</returns>
        public static Vehicle[] FindAll(Vehicle[] carsCollection, string name)
        {
            List<Vehicle> result = new();
            for (int i = 0; i < carsCollection.Length; i++)
            {
                if (carsCollection[i].Make.Contains(name))
                {
                    result.Add(carsCollection[i]);
                }
            }

            return result.ToArray();
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
    }
}
