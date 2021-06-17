using System;
using System.Collections.Generic;
using System.Text;

namespace Compilateur.Table
{
    public class Scope
    { 
        public string Name { get; set; }
        public FctType Type { get; set; }
        public List<STParam> Params { get; set; } = new List<STParam>();

        public Scope(string name, FctType type)
        {
            Name = name;
            Type = type;
        }
        public enum FctType
        {
            FctByte,
            FctWord,
        }
    }
}
