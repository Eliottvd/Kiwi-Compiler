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
            Printer.PrintBeginData();

            foreach (var declarationContext in context.declaration())
            {
                this.Visit(declarationContext);
            }

            Printer.PrintBeginCode();

            foreach (var instructionContext in context.instruction())
            {
                this.Visit(instructionContext);
            }

            Printer.PrintEnd();
            return string.Empty;
        }

        public override string VisitRightExprPlusMinus(DEMOParser.RightExprPlusMinusContext context)
        {
            var left = this.Visit(context.exprent(0));
            var right = this.Visit(context.exprent(1));

            switch (context.op.Type)
            {
                case DEMOLexer.PLUS:
                    Printer.PrintMov(AssemblyRegister.AX, byte.Parse(left));
                    Printer.PrintMov(AssemblyRegister.BX, byte.Parse(right));
                    Printer.PrintAdd(AssemblyRegister.AX, AssemblyRegister.BX);
                    break;
                case DEMOLexer.MINUS:
                    Printer.PrintMov(AssemblyRegister.AX, byte.Parse(left));
                    Printer.PrintMov(AssemblyRegister.BX, byte.Parse(right));
                    Printer.PrintSub(AssemblyRegister.AX, AssemblyRegister.BX);
                    break;
            }

            return string.Empty;
        }

        public override string VisitRightExpNot(DEMOParser.RightExpNotContext context)
        {
            var exp = this.Visit(context.exprent());
            Printer.PrintMov(AssemblyRegister.AX, byte.Parse(exp));
            Printer.PrintNot(AssemblyRegister.AX);
            return string.Empty;
        }

        public override string VisitRightExpIncrement(DEMOParser.RightExpIncrementContext context)
        {
            Printer.PrintMov(AssemblyRegister.AX, byte.Parse(this.Visit(context.exprent())));
            Printer.PrintInc(AssemblyRegister.AX);
            return string.Empty;
        }

        public override string VisitRightExpDecrement(DEMOParser.RightExpDecrementContext context)
        {
            Printer.PrintMov(AssemblyRegister.AX, byte.Parse(this.Visit(context.exprent())));
            Printer.PrintDec(AssemblyRegister.AX);
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
            return string.Empty;
        }

        public override string VisitDecl(DEMOParser.DeclContext context)
        {
            switch (context.type.Type)
            {
                case DEMOLexer.BYTE:
                    Printer.PrintByteDeclaration(context.ID().GetText());
                    break;
                case DEMOLexer.WORD:
                    Printer.PrintWordDeclaration(context.ID().GetText());
                    break;
                case DEMOLexer.STRING:
                    Printer.PrintStringDeclaration(context.ID().GetText());
                    break;
            }

            return string.Empty;
        }
    }
}
