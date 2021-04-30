using System;
using System.Collections.Generic;
using System.Text;
using Compilateur.Table;

namespace Compilateur
{
    public class DEMOSymbolListener : DEMOBaseListener
    {
        public SymbolTable SymbolTable { get; set; }

        public DEMOSymbolListener(SymbolTable symbolTable)
        {
            SymbolTable = symbolTable;
        }
        public override void EnterDecl(DEMOParser.DeclContext context)
        {
            base.EnterDecl(context);
        }
    }
}
