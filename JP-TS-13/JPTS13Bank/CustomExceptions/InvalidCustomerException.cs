namespace JPTS13Bank.CustomExceptions
{
    public class InvalidCustomerException : Exception
    {
        public InvalidCustomerException(string message) : base(message)
        {
        }
    }
}
