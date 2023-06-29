namespace JPTS13Bank.CustomExceptions
{
    public class InvalidAccountException : Exception
    {
        public InvalidAccountException(string message) : base(message)
        {
        }
    }
}
