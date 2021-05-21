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

            foreach (var declarationFunctionContext in context.declarationFunction())
            {
                this.Visit(declarationFunctionContext);
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
            var left = this.Visit(context.expr(0));
            var right = this.Visit(context.expr(1));
            var res = 0;

            switch (context.op.Type)
            {
                case DEMOLexer.PLUS:
                    Printer.PrintMov(AssemblyRegister.AX, Int16.Parse(left));
                    Printer.PrintMov(AssemblyRegister.BX, Int16.Parse(right));
                    Printer.PrintAdd(AssemblyRegister.AX, AssemblyRegister.BX);
                    res = Int16.Parse(left) + Int16.Parse(right);
                    break;
                case DEMOLexer.MINUS:
                    Printer.PrintMov(AssemblyRegister.AX, Int16.Parse(left));
                    Printer.PrintMov(AssemblyRegister.BX, Int16.Parse(right));
                    Printer.PrintSub(AssemblyRegister.AX, AssemblyRegister.BX);
                    res = Int16.Parse(left) - Int16.Parse(right);
                    break;
            }

            return res.ToString();
        }

        public override string VisitRightExpPar(DEMOParser.RightExpParContext context)
        {
            return this.Visit(context.expr());
        }

        public override string VisitRightExpNot(DEMOParser.RightExpNotContext context)
        {
            var exp = this.Visit(context.expr());
            Printer.PrintMov(AssemblyRegister.AX, byte.Parse(exp));
            Printer.PrintNot(AssemblyRegister.AX);
            return string.Empty;
        }

        public override string VisitRightExpIncrement(DEMOParser.RightExpIncrementContext context)
        {
            Printer.PrintMov(AssemblyRegister.AX, byte.Parse(this.Visit(context.expr())));
            Printer.PrintInc(AssemblyRegister.AX);
            return string.Empty;
        }

        public override string VisitRightExpDecrement(DEMOParser.RightExpDecrementContext context)
        {
            Printer.PrintMov(AssemblyRegister.AX, byte.Parse(this.Visit(context.expr())));
            Printer.PrintDec(AssemblyRegister.AX);
            return string.Empty;
        }

        public override string VisitRightExprNumber(DEMOParser.RightExprNumberContext context)
        {
            return context.NUMBER().GetText();
        }

        public override string VisitRightExprHexa8(DEMOParser.RightExprHexa8Context context)
        {
            return Convert.ToInt16(context.GetText().Substring(2), 16).ToString();
        }
        public override string VisitRightExprHexa16(DEMOParser.RightExprHexa16Context context)
        {
            return Convert.ToInt16(context.GetText().Substring(2), 16).ToString();
        }

        public override string VisitRightExprBinary8(DEMOParser.RightExprBinary8Context context)
        {
            return Convert.ToInt16(context.GetText().Substring(2), 2).ToString();
        }
        public override string VisitRightExprBinary16(DEMOParser.RightExprBinary16Context context)
        {
            return Convert.ToInt16(context.GetText().Substring(2), 2).ToString();
        }

        public override string VisitInstPrint(DEMOParser.InstPrintContext context)
        {
            Console.WriteLine(this.Visit(context.expr()));
            this.Printer.PrintCallPrintAX();
            this.Printer.PrintCallPrintEndl();
            return string.Empty;
        }

        public override string VisitDeclVar(DEMOParser.DeclVarContext context)
        {
            switch (context.type.Type)
            {
                case DEMOLexer.BYTE:
                    this.SymbolTable.Entries.Add(new STVar(null, context.ID().GetText(), VarType.VarByte));
                    Printer.PrintByteDeclaration(context.ID().GetText());
                    break;
                case DEMOLexer.WORD:
                    this.SymbolTable.Entries.Add(new STVar(null, context.ID().GetText(), VarType.VarWord));
                    Printer.PrintWordDeclaration(context.ID().GetText());
                    break;
                case DEMOLexer.STRING:
                    this.SymbolTable.Entries.Add(new STVar(null, context.ID().GetText(), VarType.VarWord));
                    Printer.PrintStringDeclaration(context.ID().GetText());
                    break;
            }

            return string.Empty;
        }

        public override string VisitDeclConst(DEMOParser.DeclConstContext context)
        {
            switch (context.type.Type)
            {
                case DEMOLexer.NUMBER:
                    this.SymbolTable.Entries.Add(new STConst(null, context.ID().GetText()));
                    Printer.PrintConstDeclarationStr(context.ID().GetText(), context.NUMBER().GetText());
                    break;
                case DEMOLexer.STRING_LITERAL:
                    this.SymbolTable.Entries.Add(new STConst(null, context.ID().GetText()));
                    Printer.PrintConstDeclarationStr(context.ID().GetText(), context.STRING_LITERAL().GetText());
                    break;
            }

            return string.Empty;
        }

        public override string VisitInstAssignation(DEMOParser.InstAssignationContext context)
        {
            if(this.SymbolTable.Entries.Find(e => e.Name == context.ID().GetText()) != null)
            {
                Printer.PrintAssignation(context.ID().GetText(), Int32.Parse(this.Visit(context.expr())));
            }
            else
            {
                throw new NotFoundSymbolException("Cannot find " + context.ID().GetText() + ". Please make sure it has been declared.");
            }

            return base.VisitInstAssignation(context);
        }


        public override string VisitRightExpID(DEMOParser.RightExpIDContext context)
        {
            if (this.SymbolTable.Entries.Find(e => e.Name == context.ID().GetText()) != null)
            {
                Printer.PrintId(context.ID().GetText());
            }
            else
            {
                throw new NotFoundSymbolException("Cannot find " + context.ID().GetText() + ". Please make sure it has been declared.");
            }
            return base.VisitRightExpID(context);
        }

        public override string VisitDeclFunction(DEMOParser.DeclFunctionContext context)
        {
            Scope scope = new Scope(context.ID().GetText(), context.type.Type == DEMOLexer.BYTE ? Scope.FctType.FctByte : Scope.FctType.FctWord);
            this.SymbolTable.Scopes.Add(scope);
            foreach (var paramDeclContext in context.parameterDeclaration())
            {
                this.SymbolTable.Scopes.Find(s => s.Name.Equals(scope.Name))?.Params.Add(
                new STParam(scope, 
                    paramDeclContext.ID().GetText(),
                    paramDeclContext.typeVar.Type == DEMOLexer.BYTE ? STParam.VarType.VarByte : STParam.VarType.VarWord));
            }

            foreach (var param in this.SymbolTable.Scopes.Find(s => s.Name.Equals(scope.Name))?.Params)
            {
                Console.WriteLine(param.ToString()); 
            }
            
            return base.VisitDeclFunction(context);
        }
    }
}
