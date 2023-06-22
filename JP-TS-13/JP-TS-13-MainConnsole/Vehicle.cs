using System.Diagnostics.CodeAnalysis;

namespace JP_TS_13_MainConnsole
{
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public byte Cylinder { get; set; }
        public float Engine { get; set; }
        public string Drive { get; set; }
        public string Transmission { get; set; }
        public byte City { get; set; }
        public byte Combined { get; set; }
        public byte Highway { get; set; }

        public static Vehicle Parse(string data)
        {
            string[] separatedData = data.Split(',');

            if (separatedData.Length == 9)
            {
                Vehicle result = new();
                result.Make = separatedData[0];
                result.Model = separatedData[1];
                result.Cylinder = byte.Parse(separatedData[2]);
                result.Engine = float.Parse(separatedData[3]);
                result.Drive = separatedData[4];
                result.Transmission = separatedData[5];
                result.City = byte.Parse(separatedData[6]);
                result.Combined = byte.Parse(separatedData[7]);
                result.Highway = byte.Parse(separatedData[8]);

                return result;
            }
            else
            {
                throw new FormatException("Car information is in incorrect format");
            }
        }

        public override bool Equals(object obj)
        {
            return new VehicleEquilityComparer().Equals(obj as Vehicle,this);
        }
        public override int GetHashCode()
        {
            return new VehicleEquilityComparer().GetHashCode(this);
        }

        public static int operator +(Vehicle v1, Vehicle v2)
        {
            return v1.Combined + v2.Combined;
        }

        public static int operator -(Vehicle v1, Vehicle v2)
        {
            return v1.Combined - v2.Combined;
        }

        public static int operator *(Vehicle v1, Vehicle v2)
        {
            return v1.Combined * v2.Combined;
        }

        public static int operator /(Vehicle v1, Vehicle v2)
        {
            return v1.Combined / v2.Combined;
        }

        public static bool operator ==(Vehicle v1, Vehicle v2)
        {
            return v1.Make == v2.Make;
        }

        public static bool operator !=(Vehicle v1, Vehicle v2)
        {
            return v1.Make != v2.Make;
        }
    }

    class VehicleEquilityComparer : IEqualityComparer<Vehicle>
    {
        public bool Equals(Vehicle x, Vehicle y)
        {
            return x.Make == y.Make;
        }

        public int GetHashCode([DisallowNull] Vehicle obj)
        {
            return obj.Make.Length;
        }
    }

}
