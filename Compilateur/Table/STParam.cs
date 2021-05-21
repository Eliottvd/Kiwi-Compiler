using System;
using System.Collections.Generic;
using System.Text;

namespace Compilateur.Table
{
    public class STParam : SymbolTableEntry
    {
        public VarType Type { get; set; }
        public STParam(Scope scope, string name, VarType type) : base(scope, name)
        {
            Type = type;
        }

        public override string ToString()
        {
            return "Param : " + Name + "\nScope : " + Scope.Name + "\nType : " + Type + "\n";
        }

        public enum VarType
        {
            VarByte,
            VarWord,
            VarString
        }
    }
}
