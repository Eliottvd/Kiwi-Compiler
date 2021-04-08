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

            foreach (var instructionContext in context.instruction())
            {
                var left = this.Visit(instructionContext);
            }

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
                Printer.PrintMov(AssemblyRegister.BX, byte.Parse(right));
                Printer.PrintAdd(AssemblyRegister.AX, AssemblyRegister.BX);
            }

            if (context.op.Type == DEMOLexer.MINUS)
            {
                Printer.PrintMov(AssemblyRegister.AX, byte.Parse(left));
                Printer.PrintMov(AssemblyRegister.BX, byte.Parse(right));
                Printer.PrintSub(AssemblyRegister.AX, AssemblyRegister.BX);
            }

            return (string)("SUB " + left + "," + right);
        }

        public override string VisitRightExpNot(DEMOParser.RightExpNotContext context)
        {
            var exp = this.Visit(context.exprent());
            Printer.PrintMov(AssemblyRegister.AX, byte.Parse(exp));
            Printer.PrintNot(AssemblyRegister.AX);
            return string.Empty;
        }

        public override string VisitRightExprNumber(DEMOParser.RightExprNumberContext context)
        {
            return context.NUMBER().GetText();
        }

        public override string VisitInstPrint(DEMOParser.InstPrintContext context)
        {
            this.Visit(context.expr());
            this.Printer.PrintCallPrintAX();
            return "";
        }
    }
}
