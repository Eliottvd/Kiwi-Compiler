using System;
using System.Collections.Generic;
using System.Text;
using Compilateur.Exception;
using Compilateur.Generator;
using Compilateur.Table;

namespace Compilateur
{
    public class DemoVisitor : DEMOBaseVisitor<string>
    {
        public AssemblyPrinter Printer { get; set; }
        public SymbolTable SymbolTable { get; set; }

        public DemoVisitor(AssemblyPrinter printer, SymbolTable symbolTable)
        {
            this.Printer = printer;
            this.SymbolTable = symbolTable;
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

            this.SymbolTable.Entries.Add(new STVar(null, context.ID().GetText()));
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

        public override string VisitInstAssignation(DEMOParser.InstAssignationContext context)
        {
            if(this.SymbolTable.Entries.Find(e => e.Name == context.ID().GetText()) != null)
            {
                Printer.PrintAssignation(context.ID().GetText(), Int32.Parse(context.expr().GetText()));
            }
            else
            {
                throw new NotFoundSymbolException("Cannot find " + context.ID().GetText() + ". Please make sure it has been declared.");
            }

            return base.VisitInstAssignation(context);
        }
    }
}
