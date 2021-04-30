using System;
using System.Collections.Generic;
using System.Text;

namespace Compilateur.Table
{
    public class STParam : SymbolTableEntry
    {
        public STParam(Scope scope, string name) : base(scope, name)
        {
        }
    }
}
