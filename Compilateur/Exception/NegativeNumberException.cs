namespace Compilateur.Exception
{
    public class NegativeNumberException : System.Exception
    {
        public NegativeNumberException()
        {
        }

        public NegativeNumberException(string message)
            : base(message)
        {
        }

        public NegativeNumberException(string message, System.Exception inner)
            : base(message, inner)
        {
        }
    }
}
