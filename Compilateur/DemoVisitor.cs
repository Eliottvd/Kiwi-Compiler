using System;
using System.Collections.Generic;
using System.Text;
using Compilateur.Generator;

namespace Compilateur
{
    public class DemoVisitor : DEMOBaseVisitor<string>
    {
        public AssemblyPrinter Printer { get; set; }

        public DemoVisitor(AssemblyPrinter printer)
        {
            this.Printer = printer;
        }

        public override string VisitDemo(DEMOParser.DemoContext context)
        {
            Printer.PrintBegin();

            var left = this.Visit(context.instruction());

            Printer.PrintEnd();
            return string.Empty;
        }

        public override string VisitRightExprPlusMinus(DEMOParser.RightExprPlusMinusContext context)
        {
            var left = this.Visit(context.exprent(0));
            var right = this.Visit(context.exprent(1));

            if (context.op.Type == DEMOLexer.PLUS)
            {
                Printer.PrintMov(AssemblyRegister.AX, byte.Parse(left));
                Printer.PrintAdd(AssemblyRegister.DX, byte.Parse(right));
            }

            return (string)("SUB " + left + "," + right);
        }

        public override string VisitRightExprNumber(DEMOParser.RightExprNumberContext context)
        {
            return context.NUMBER().GetText();
        }
    }
}
