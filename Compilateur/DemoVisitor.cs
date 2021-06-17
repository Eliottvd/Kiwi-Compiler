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
            try
            {
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
            }
            catch(OverflowException e)
            {
                throw new ValueOverflowException("Value is too large for a word (16 bits maximum).");
            }
            return string.Empty;
        }

        public override string VisitRightExprPlusMinus(DEMOParser.RightExprPlusMinusContext context)
        {
            //Console.WriteLine(context.GetText());
            this.Visit(context.expr(0));
            this.Visit(context.expr(1));
            Printer.PrintPopRegister(AssemblyRegister.BX);
            Printer.PrintPopRegister(AssemblyRegister.AX);
            
            
            switch (context.op.Type)
            {
                case DEMOLexer.PLUS:
                    Printer.PrintAdd(AssemblyRegister.AX, AssemblyRegister.BX);
                    break;
                case DEMOLexer.MINUS:
                    Printer.PrintSub(AssemblyRegister.AX, AssemblyRegister.BX);
                    break;
            }

            Printer.PrintPushRegister(AssemblyRegister.AX);
            return string.Empty;
        }

        public override string VisitRightExpMulDivMod(DEMOParser.RightExpMulDivModContext context)
        {
            this.Visit(context.expr(0));
            this.Visit(context.expr(1));
            Printer.PrintPopRegister(AssemblyRegister.BX);
            Printer.PrintPopRegister(AssemblyRegister.AX);

            switch (context.op.Type)
            {
                case DEMOLexer.MUL:
                    Printer.PrintMul(AssemblyRegister.BX);
                    Printer.PrintPushRegister(AssemblyRegister.AX);
                    break;
                case DEMOLexer.DIV:
                    Printer.PrintDiv(AssemblyRegister.BX);
                    Printer.PrintPushRegister(AssemblyRegister.AX); ;
                    break;
                case DEMOLexer.MOD:
                    Printer.PrintDiv(AssemblyRegister.BX);
                    Printer.PrintPushRegister(AssemblyRegister.DX);
                    break;
            }

            return string.Empty;
        }

        public override string VisitRightExprAndOr(DEMOParser.RightExprAndOrContext context)
        {
            this.Visit(context.expr(0));
            this.Visit(context.expr(1));
            Printer.PrintPopRegister(AssemblyRegister.BX);
            Printer.PrintPopRegister(AssemblyRegister.AX);


            switch (context.op.Type)
            {
                case DEMOLexer.AND:
                    Printer.PrintAnd(AssemblyRegister.AX, AssemblyRegister.BX);
                    break;
                case DEMOLexer.OR:
                    Printer.PrintOr(AssemblyRegister.AX, AssemblyRegister.BX);
                    break;
            }
            Printer.PrintPushRegister(AssemblyRegister.AX); ;

            return string.Empty;
        }

        public override string VisitRightExprShift(DEMOParser.RightExprShiftContext context)
        {
            this.Visit(context.expr());
            this.Visit(context.exprent());
            Printer.PrintPopRegister(AssemblyRegister.CX);  //Increment
            Printer.PrintPopRegister(AssemblyRegister.AX);  
            switch (context.op.Type)
            {
                case DEMOLexer.LSHIFT:
                    Printer.PrintShl(AssemblyRegister.AX, AssemblyRegister.CL);
                    break;
                case DEMOLexer.RSHIFT:
                    Printer.PrintShr(AssemblyRegister.AX, AssemblyRegister.CL);
                    break;
            }
            Printer.PrintPushRegister(AssemblyRegister.AX);
            return string.Empty;
        }

        public override string VisitRightExpPar(DEMOParser.RightExpParContext context)
        {
            return this.Visit(context.expr());
        }

        public override string VisitRightExpNot(DEMOParser.RightExpNotContext context)
        { 
            this.Visit(context.expr());
            Printer.PrintPopRegister(AssemblyRegister.AX);
            Printer.PrintNot(AssemblyRegister.AX);
            Printer.PrintPushRegister(AssemblyRegister.AX);



            return string.Empty;
        }

        public override string VisitRightExpIncrement(DEMOParser.RightExpIncrementContext context)
        {
            this.Visit(context.expr());
            Printer.PrintPopRegister(AssemblyRegister.AX);
            Printer.PrintInc(AssemblyRegister.AX);
            Printer.PrintPushRegister(AssemblyRegister.AX);
            return string.Empty;
        }

        public override string VisitRightExpDecrement(DEMOParser.RightExpDecrementContext context)
        {
            this.Visit(context.expr());
            Printer.PrintPopRegister(AssemblyRegister.AX);
            Printer.PrintDec(AssemblyRegister.AX);
            Printer.PrintPushRegister(AssemblyRegister.AX);
            return string.Empty;
        }

        public override string VisitRightExprNumber(DEMOParser.RightExprNumberContext context)
        {
            Printer.PrintMov(AssemblyRegister.AX, Convert.ToInt16(context.NUMBER().GetText()));
            Printer.PrintPushRegister(register:AssemblyRegister.AX);
            
            return string.Empty;
        }


        public override string VisitRightExprHexa8(DEMOParser.RightExprHexa8Context context)
        {
            Printer.PrintMov(AssemblyRegister.AX, Convert.ToInt16(context.GetText().Substring(2), 16));
            Printer.PrintPushRegister(register: AssemblyRegister.AX);

            return string.Empty;
        }
        public override string VisitRightExprHexa16(DEMOParser.RightExprHexa16Context context)
        {
            Printer.PrintMov(AssemblyRegister.AX, Convert.ToInt16(context.GetText().Substring(2), 16));
            Printer.PrintPushRegister(register: AssemblyRegister.AX);

            return string.Empty;
        }

        public override string VisitRightExprBinary8(DEMOParser.RightExprBinary8Context context)
        {
            Printer.PrintMov(AssemblyRegister.AX, Convert.ToInt16(context.GetText().Substring(2), 2));
            Printer.PrintPushRegister(register: AssemblyRegister.AX);

            return string.Empty;
        }
        public override string VisitRightExprBinary16(DEMOParser.RightExprBinary16Context context)
        {
            Printer.PrintMov(AssemblyRegister.AX, Convert.ToInt16(context.GetText().Substring(2), 2));
            Printer.PrintPushRegister(register: AssemblyRegister.AX);

            return string.Empty;
        }

        public override string VisitInstPrint(DEMOParser.InstPrintContext context)
        {
            Console.WriteLine(this.Visit(context.expr()));
            this.Printer.PrintPopRegister(AssemblyRegister.AX);
            this.Printer.PrintCallPrintAX();
            this.Printer.PrintCallPrintEndl();
            return string.Empty;
        }

        public override string VisitDeclVar(DEMOParser.DeclVarContext context)
        {
            if (this.SymbolTable.Entries.Find(e => e.Name == context.ID().GetText()) != null)
            {
                throw new SymbolAlreadyDefinedException("The variable " + context.ID().GetText() + " already exists.");
            }
            else
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
            this.Visit(context.expr());
            if (this.SymbolTable.Entries.Find(e => e.Name == context.ID().GetText()) != null)
            {
                Printer.PrintAssignation(context.ID().GetText(), AssemblyRegister.AX);
            }
            else
            {
                throw new NotFoundSymbolException("Cannot find " + context.ID().GetText() + ". Please make sure it has been declared.");
            }
            
            return string.Empty;
        }


        public override string VisitRightExpID(DEMOParser.RightExpIDContext context)
        {
            if (this.SymbolTable.Entries.Find(e => e.Name == context.ID().GetText()) != null)
            {

                Printer.PrintId(context.ID().GetText());
                Printer.PrintPushRegister(AssemblyRegister.AX);
            }
            else
            {
                throw new NotFoundSymbolException("Cannot find " + context.ID().GetText() + ". Please make sure it has been declared.");
            }
            return string.Empty;
        }

        public override string VisitDeclFunction(DEMOParser.DeclFunctionContext context)
        {
            Scope scope = new Scope(context.ID().GetText(), 
                context.type.Type == DEMOLexer.BYTE ? Scope.FctType.FctByte : Scope.FctType.FctWord);

            this.SymbolTable.Scopes.Add(scope);
            foreach (var paramDeclContext in context.parameterDeclaration())
            {
                this.SymbolTable.Scopes.Find(s => s.Name.Equals(scope.Name))?.Params.Add(
                new STParam(scope,
                    paramDeclContext.ID().GetText(),
                    paramDeclContext.typeVar.Type == DEMOLexer.BYTE ? STParam.VarType.VarByte : STParam.VarType.VarWord));
            }

            this.Printer.PrintStartProc(scope.Name);
            
            //Ecrire le depush des parametres

            foreach (var instructionContext in context.instruction())
            {
                this.Visit(instructionContext);
            }

            this.Printer.PrintEndProc(scope.Name);

            foreach (var param in this.SymbolTable.Scopes.Find(s => s.Name.Equals(scope.Name))?.Params)
            {
                Console.WriteLine(param.ToString());
            }

            return "";
        }

        public override string VisitRightExprFctCall(DEMOParser.RightExprFctCallContext context)
        {
            return string.Empty;
        }
    }
}
