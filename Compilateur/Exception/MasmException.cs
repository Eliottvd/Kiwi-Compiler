using System;
using System.Collections.Generic;
using System.Text;

namespace Compilateur.Exception
{

    public class MasmException : System.Exception
    {
        public MasmException()
        {
        }

        public MasmException(string message)
            : base(message)
        {
        }

        public MasmException(string message, System.Exception inner)
            : base(message, inner)
        {
        }
    }
}
