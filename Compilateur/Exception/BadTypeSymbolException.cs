namespace Compilateur.Exception
{
    public class BadTypeSymbolException : System.Exception
    {
        public BadTypeSymbolException()
        {
        }

        public BadTypeSymbolException(string message)
            : base(message)
        {
        }

        public BadTypeSymbolException(string message, System.Exception inner)
            : base(message, inner)
        {
        }
    }
}
