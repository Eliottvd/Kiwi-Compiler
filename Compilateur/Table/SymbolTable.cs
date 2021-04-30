using System;
using System.Collections.Generic;
using System.Text;

namespace Compilateur.Table
{
    public class SymbolTable
    {
        public List<SymbolTableEntry> Entries { get; set; } = new List<SymbolTableEntry>();
        public List<Scope> Scopes { get; set; } = new List<Scope>();

        public SymbolTable()
        {
            Scopes.Add(new Scope("General"));
        }
    }
}
