using System;
using System.Collections.Generic;
using System.Text;

namespace Compilateur.Table
{
    public class Scope
    { 
        public string Name { get; set; }

        public Scope(string name)
        {
            Name = name;
        }
    }
}
