namespace Compilateur.Exception
{

    public class StringCannotBeAssign : System.Exception
    {
        public StringCannotBeAssign()
        {
        }

        public StringCannotBeAssign(string message)
            : base(message)
        {
        }

        public StringCannotBeAssign(string message, System.Exception inner)
            : base(message, inner)
        {
        }
    }
}
