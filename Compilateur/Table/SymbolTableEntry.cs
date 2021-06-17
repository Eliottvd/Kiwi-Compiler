using System;
using System.Collections.Generic;
using System.Text;

namespace Compilateur.Table
{
    public class SymbolTableEntry
    {
        public string Name { get; set; }
        public Scope Scope { get; set; }
        public int Value { get; set; }

        public SymbolTableEntry(Scope scope, string name)
        {
            Name = name;
            Scope = scope;
            Value = 0;
        }
    }
}
