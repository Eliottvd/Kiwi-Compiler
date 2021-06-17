using System;
using System.Collections.Generic;
using System.Text;

namespace Compilateur.Table
{
    public class STVar : SymbolTableEntry
    {
        public VarType Type { get; set; }
        public STVar(Scope scope, string name, VarType type) : base(scope, name)
        {
            Type = type;
        }
    }

    public enum VarType
    {
        VarByte,
        VarWord,
        VarString
    }
}
