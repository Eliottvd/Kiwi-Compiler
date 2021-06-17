using System;
using System.Collections.Generic;
using System.Text;

namespace Compilateur.Table
{
    public class STConst : SymbolTableEntry
    {
        public STConst(Scope scope, string name) : base(scope, name)
        {
        }
    }
}
