using System;
using System.Collections.Generic;
using System.Text;

namespace Compilateur.Table
{
    public class STVar : SymbolTableEntry
    {
        public STVar(Scope scope, string name) : base(scope, name)
        {
        }
    }
}
