namespace JPTS13Bank.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IdentityNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public CustomerType Type { get; set; }
    }

    internal static class CustomerExtension
    {
        internal static string ToCsv(this Customer input) =>
            $",\n{input.Id},{input.Name},{input.IdentityNumber},{input.PhoneNumber},{input.Email},{input.Type}".Trim();

        internal static Customer ToCustomer(this string input)
        {
            string[] csvInput = input.Split(',');

            Customer result = new();
            result.Id = int.Parse(csvInput[0]);
            result.Name = csvInput[1];
            result.IdentityNumber = csvInput[2];
            result.PhoneNumber = csvInput[3];
            result.Email = csvInput[4];
            result.Type = (CustomerType)Enum.Parse(typeof(CustomerType), csvInput[5]);

            return result;
        }
    }


}
