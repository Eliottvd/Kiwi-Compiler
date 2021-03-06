//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:\Eliott\Ecole\WK_Compiler\Kiwi-Compiler\Compilateur\DEMO.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Compilateur {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="DEMOParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IDEMOListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>DeclFunction</c>
	/// labeled alternative in <see cref="DEMOParser.declarationFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclFunction([NotNull] DEMOParser.DeclFunctionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>DeclFunction</c>
	/// labeled alternative in <see cref="DEMOParser.declarationFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclFunction([NotNull] DEMOParser.DeclFunctionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>DeclVar</c>
	/// labeled alternative in <see cref="DEMOParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclVar([NotNull] DEMOParser.DeclVarContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>DeclVar</c>
	/// labeled alternative in <see cref="DEMOParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclVar([NotNull] DEMOParser.DeclVarContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>DeclConst</c>
	/// labeled alternative in <see cref="DEMOParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclConst([NotNull] DEMOParser.DeclConstContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>DeclConst</c>
	/// labeled alternative in <see cref="DEMOParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclConst([NotNull] DEMOParser.DeclConstContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>InstExpr</c>
	/// labeled alternative in <see cref="DEMOParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInstExpr([NotNull] DEMOParser.InstExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>InstExpr</c>
	/// labeled alternative in <see cref="DEMOParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInstExpr([NotNull] DEMOParser.InstExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>InstPrint</c>
	/// labeled alternative in <see cref="DEMOParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInstPrint([NotNull] DEMOParser.InstPrintContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>InstPrint</c>
	/// labeled alternative in <see cref="DEMOParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInstPrint([NotNull] DEMOParser.InstPrintContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>InstAssignation</c>
	/// labeled alternative in <see cref="DEMOParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInstAssignation([NotNull] DEMOParser.InstAssignationContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>InstAssignation</c>
	/// labeled alternative in <see cref="DEMOParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInstAssignation([NotNull] DEMOParser.InstAssignationContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>InstNOP</c>
	/// labeled alternative in <see cref="DEMOParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInstNOP([NotNull] DEMOParser.InstNOPContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>InstNOP</c>
	/// labeled alternative in <see cref="DEMOParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInstNOP([NotNull] DEMOParser.InstNOPContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>RightExpPar</c>
	/// labeled alternative in <see cref="DEMOParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRightExpPar([NotNull] DEMOParser.RightExpParContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>RightExpPar</c>
	/// labeled alternative in <see cref="DEMOParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRightExpPar([NotNull] DEMOParser.RightExpParContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>RightExpMulDivMod</c>
	/// labeled alternative in <see cref="DEMOParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRightExpMulDivMod([NotNull] DEMOParser.RightExpMulDivModContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>RightExpMulDivMod</c>
	/// labeled alternative in <see cref="DEMOParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRightExpMulDivMod([NotNull] DEMOParser.RightExpMulDivModContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>RightExprPlusMinus</c>
	/// labeled alternative in <see cref="DEMOParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRightExprPlusMinus([NotNull] DEMOParser.RightExprPlusMinusContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>RightExprPlusMinus</c>
	/// labeled alternative in <see cref="DEMOParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRightExprPlusMinus([NotNull] DEMOParser.RightExprPlusMinusContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>RightExpIncrement</c>
	/// labeled alternative in <see cref="DEMOParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRightExpIncrement([NotNull] DEMOParser.RightExpIncrementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>RightExpIncrement</c>
	/// labeled alternative in <see cref="DEMOParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRightExpIncrement([NotNull] DEMOParser.RightExpIncrementContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>RightExpDecrement</c>
	/// labeled alternative in <see cref="DEMOParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRightExpDecrement([NotNull] DEMOParser.RightExpDecrementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>RightExpDecrement</c>
	/// labeled alternative in <see cref="DEMOParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRightExpDecrement([NotNull] DEMOParser.RightExpDecrementContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>RightExprAndOr</c>
	/// labeled alternative in <see cref="DEMOParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRightExprAndOr([NotNull] DEMOParser.RightExprAndOrContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>RightExprAndOr</c>
	/// labeled alternative in <see cref="DEMOParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRightExprAndOr([NotNull] DEMOParser.RightExprAndOrContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>RightExprShift</c>
	/// labeled alternative in <see cref="DEMOParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRightExprShift([NotNull] DEMOParser.RightExprShiftContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>RightExprShift</c>
	/// labeled alternative in <see cref="DEMOParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRightExprShift([NotNull] DEMOParser.RightExprShiftContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>RightExprEnt</c>
	/// labeled alternative in <see cref="DEMOParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRightExprEnt([NotNull] DEMOParser.RightExprEntContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>RightExprEnt</c>
	/// labeled alternative in <see cref="DEMOParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRightExprEnt([NotNull] DEMOParser.RightExprEntContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>RightExpID</c>
	/// labeled alternative in <see cref="DEMOParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRightExpID([NotNull] DEMOParser.RightExpIDContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>RightExpID</c>
	/// labeled alternative in <see cref="DEMOParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRightExpID([NotNull] DEMOParser.RightExpIDContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>RightExpNot</c>
	/// labeled alternative in <see cref="DEMOParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRightExpNot([NotNull] DEMOParser.RightExpNotContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>RightExpNot</c>
	/// labeled alternative in <see cref="DEMOParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRightExpNot([NotNull] DEMOParser.RightExpNotContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>RightExprFctCall</c>
	/// labeled alternative in <see cref="DEMOParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRightExprFctCall([NotNull] DEMOParser.RightExprFctCallContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>RightExprFctCall</c>
	/// labeled alternative in <see cref="DEMOParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRightExprFctCall([NotNull] DEMOParser.RightExprFctCallContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>RightExprNumber</c>
	/// labeled alternative in <see cref="DEMOParser.exprent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRightExprNumber([NotNull] DEMOParser.RightExprNumberContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>RightExprNumber</c>
	/// labeled alternative in <see cref="DEMOParser.exprent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRightExprNumber([NotNull] DEMOParser.RightExprNumberContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>RightExprHexa8</c>
	/// labeled alternative in <see cref="DEMOParser.exprent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRightExprHexa8([NotNull] DEMOParser.RightExprHexa8Context context);
	/// <summary>
	/// Exit a parse tree produced by the <c>RightExprHexa8</c>
	/// labeled alternative in <see cref="DEMOParser.exprent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRightExprHexa8([NotNull] DEMOParser.RightExprHexa8Context context);

	/// <summary>
	/// Enter a parse tree produced by the <c>RightExprHexa16</c>
	/// labeled alternative in <see cref="DEMOParser.exprent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRightExprHexa16([NotNull] DEMOParser.RightExprHexa16Context context);
	/// <summary>
	/// Exit a parse tree produced by the <c>RightExprHexa16</c>
	/// labeled alternative in <see cref="DEMOParser.exprent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRightExprHexa16([NotNull] DEMOParser.RightExprHexa16Context context);

	/// <summary>
	/// Enter a parse tree produced by the <c>RightExprBinary8</c>
	/// labeled alternative in <see cref="DEMOParser.exprent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRightExprBinary8([NotNull] DEMOParser.RightExprBinary8Context context);
	/// <summary>
	/// Exit a parse tree produced by the <c>RightExprBinary8</c>
	/// labeled alternative in <see cref="DEMOParser.exprent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRightExprBinary8([NotNull] DEMOParser.RightExprBinary8Context context);

	/// <summary>
	/// Enter a parse tree produced by the <c>RightExprBinary16</c>
	/// labeled alternative in <see cref="DEMOParser.exprent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRightExprBinary16([NotNull] DEMOParser.RightExprBinary16Context context);
	/// <summary>
	/// Exit a parse tree produced by the <c>RightExprBinary16</c>
	/// labeled alternative in <see cref="DEMOParser.exprent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRightExprBinary16([NotNull] DEMOParser.RightExprBinary16Context context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DEMOParser.demo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDemo([NotNull] DEMOParser.DemoContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DEMOParser.demo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDemo([NotNull] DEMOParser.DemoContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DEMOParser.declarationFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclarationFunction([NotNull] DEMOParser.DeclarationFunctionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DEMOParser.declarationFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclarationFunction([NotNull] DEMOParser.DeclarationFunctionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DEMOParser.parameterDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParameterDeclaration([NotNull] DEMOParser.ParameterDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DEMOParser.parameterDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParameterDeclaration([NotNull] DEMOParser.ParameterDeclarationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DEMOParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclaration([NotNull] DEMOParser.DeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DEMOParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclaration([NotNull] DEMOParser.DeclarationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DEMOParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInstruction([NotNull] DEMOParser.InstructionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DEMOParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInstruction([NotNull] DEMOParser.InstructionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DEMOParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpr([NotNull] DEMOParser.ExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DEMOParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpr([NotNull] DEMOParser.ExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DEMOParser.exprent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprent([NotNull] DEMOParser.ExprentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DEMOParser.exprent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprent([NotNull] DEMOParser.ExprentContext context);
}
} // namespace Compilateur
