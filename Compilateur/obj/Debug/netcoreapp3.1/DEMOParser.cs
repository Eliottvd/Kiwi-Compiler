﻿//------------------------------------------------------------------------------
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
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System.Collections.Generic;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class DEMOParser : Parser {
	public const int
		PRINT=1, LPAR=2, RPAR=3, COMMA=4, PLUS=5, MINUS=6, BEGIN=7, END=8, TRUE=9, 
		FALSE=10, NOP=11, NOT=12, INC=13, DEC=14, EQUAL=15, BYTE=16, WORD=17, 
		STRING=18, NUMBER=19, ID=20, COMMENT=21, NEWLINE=22, WS=23;
	public const int
		RULE_demo = 0, RULE_declaration = 1, RULE_instruction = 2, RULE_expr = 3, 
		RULE_exprent = 4;
	public static readonly string[] ruleNames = {
		"demo", "declaration", "instruction", "expr", "exprent"
	};

	private static readonly string[] _LiteralNames = {
		null, "'print'", "'('", "')'", "','", "'+'", "'-'", "'Begin'", "'End'", 
		"'TRUE'", "'FALSE'", "'NOP'", "'!'", "'++'", "'--'", "'='", "'byte'", 
		"'word'", "'string'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "PRINT", "LPAR", "RPAR", "COMMA", "PLUS", "MINUS", "BEGIN", "END", 
		"TRUE", "FALSE", "NOP", "NOT", "INC", "DEC", "EQUAL", "BYTE", "WORD", 
		"STRING", "NUMBER", "ID", "COMMENT", "NEWLINE", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete("Use IRecognizer.Vocabulary instead.")]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "DEMO.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public DEMOParser(ITokenStream input)
		: base(input)
	{
		_interp = new ParserATNSimulator(this,_ATN);
	}
	public partial class DemoContext : ParserRuleContext {
		public ITerminalNode BEGIN() { return GetToken(DEMOParser.BEGIN, 0); }
		public ITerminalNode END() { return GetToken(DEMOParser.END, 0); }
		public DeclarationContext[] declaration() {
			return GetRuleContexts<DeclarationContext>();
		}
		public DeclarationContext declaration(int i) {
			return GetRuleContext<DeclarationContext>(i);
		}
		public InstructionContext[] instruction() {
			return GetRuleContexts<InstructionContext>();
		}
		public InstructionContext instruction(int i) {
			return GetRuleContext<InstructionContext>(i);
		}
		public DemoContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_demo; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDEMOListener typedListener = listener as IDEMOListener;
			if (typedListener != null) typedListener.EnterDemo(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDEMOListener typedListener = listener as IDEMOListener;
			if (typedListener != null) typedListener.ExitDemo(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDEMOVisitor<TResult> typedVisitor = visitor as IDEMOVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDemo(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DemoContext demo() {
		DemoContext _localctx = new DemoContext(_ctx, State);
		EnterRule(_localctx, 0, RULE_demo);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 10; Match(BEGIN);
			State = 15;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << PRINT) | (1L << NOP) | (1L << NOT) | (1L << BYTE) | (1L << WORD) | (1L << STRING) | (1L << NUMBER) | (1L << ID))) != 0)) {
				{
				State = 13;
				_errHandler.Sync(this);
				switch (_input.La(1)) {
				case BYTE:
				case WORD:
				case STRING:
					{
					State = 11; declaration();
					}
					break;
				case PRINT:
				case NOP:
				case NOT:
				case NUMBER:
				case ID:
					{
					State = 12; instruction();
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				}
				State = 17;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			State = 18; Match(END);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DeclarationContext : ParserRuleContext {
		public DeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_declaration; } }
	 
		public DeclarationContext() { }
		public virtual void CopyFrom(DeclarationContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class DeclContext : DeclarationContext {
		public IToken type;
		public ITerminalNode ID() { return GetToken(DEMOParser.ID, 0); }
		public ITerminalNode BYTE() { return GetToken(DEMOParser.BYTE, 0); }
		public ITerminalNode WORD() { return GetToken(DEMOParser.WORD, 0); }
		public ITerminalNode STRING() { return GetToken(DEMOParser.STRING, 0); }
		public DeclContext(DeclarationContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IDEMOListener typedListener = listener as IDEMOListener;
			if (typedListener != null) typedListener.EnterDecl(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDEMOListener typedListener = listener as IDEMOListener;
			if (typedListener != null) typedListener.ExitDecl(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDEMOVisitor<TResult> typedVisitor = visitor as IDEMOVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDecl(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DeclarationContext declaration() {
		DeclarationContext _localctx = new DeclarationContext(_ctx, State);
		EnterRule(_localctx, 2, RULE_declaration);
		int _la;
		try {
			_localctx = new DeclContext(_localctx);
			EnterOuterAlt(_localctx, 1);
			{
			State = 20;
			((DeclContext)_localctx).type = _input.Lt(1);
			_la = _input.La(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BYTE) | (1L << WORD) | (1L << STRING))) != 0)) ) {
				((DeclContext)_localctx).type = _errHandler.RecoverInline(this);
			} else {
				if (_input.La(1) == TokenConstants.Eof) {
					matchedEOF = true;
				}

				_errHandler.ReportMatch(this);
				Consume();
			}
			State = 21; Match(ID);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class InstructionContext : ParserRuleContext {
		public InstructionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_instruction; } }
	 
		public InstructionContext() { }
		public virtual void CopyFrom(InstructionContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class InstExprContext : InstructionContext {
		public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public InstExprContext(InstructionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IDEMOListener typedListener = listener as IDEMOListener;
			if (typedListener != null) typedListener.EnterInstExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDEMOListener typedListener = listener as IDEMOListener;
			if (typedListener != null) typedListener.ExitInstExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDEMOVisitor<TResult> typedVisitor = visitor as IDEMOVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitInstExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class InstPrintContext : InstructionContext {
		public ITerminalNode PRINT() { return GetToken(DEMOParser.PRINT, 0); }
		public ITerminalNode LPAR() { return GetToken(DEMOParser.LPAR, 0); }
		public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public ITerminalNode RPAR() { return GetToken(DEMOParser.RPAR, 0); }
		public InstPrintContext(InstructionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IDEMOListener typedListener = listener as IDEMOListener;
			if (typedListener != null) typedListener.EnterInstPrint(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDEMOListener typedListener = listener as IDEMOListener;
			if (typedListener != null) typedListener.ExitInstPrint(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDEMOVisitor<TResult> typedVisitor = visitor as IDEMOVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitInstPrint(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class InstNOPContext : InstructionContext {
		public ITerminalNode NOP() { return GetToken(DEMOParser.NOP, 0); }
		public InstNOPContext(InstructionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IDEMOListener typedListener = listener as IDEMOListener;
			if (typedListener != null) typedListener.EnterInstNOP(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDEMOListener typedListener = listener as IDEMOListener;
			if (typedListener != null) typedListener.ExitInstNOP(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDEMOVisitor<TResult> typedVisitor = visitor as IDEMOVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitInstNOP(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class InstAssignationContext : InstructionContext {
		public ITerminalNode ID() { return GetToken(DEMOParser.ID, 0); }
		public ITerminalNode EQUAL() { return GetToken(DEMOParser.EQUAL, 0); }
		public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public InstAssignationContext(InstructionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IDEMOListener typedListener = listener as IDEMOListener;
			if (typedListener != null) typedListener.EnterInstAssignation(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDEMOListener typedListener = listener as IDEMOListener;
			if (typedListener != null) typedListener.ExitInstAssignation(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDEMOVisitor<TResult> typedVisitor = visitor as IDEMOVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitInstAssignation(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public InstructionContext instruction() {
		InstructionContext _localctx = new InstructionContext(_ctx, State);
		EnterRule(_localctx, 4, RULE_instruction);
		try {
			State = 33;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case NOT:
			case NUMBER:
				_localctx = new InstExprContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 23; expr();
				}
				break;
			case PRINT:
				_localctx = new InstPrintContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 24; Match(PRINT);
				State = 25; Match(LPAR);
				State = 26; expr();
				State = 27; Match(RPAR);
				}
				break;
			case NOP:
				_localctx = new InstNOPContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				State = 29; Match(NOP);
				}
				break;
			case ID:
				_localctx = new InstAssignationContext(_localctx);
				EnterOuterAlt(_localctx, 4);
				{
				State = 30; Match(ID);
				State = 31; Match(EQUAL);
				State = 32; expr();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExprContext : ParserRuleContext {
		public ExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expr; } }
	 
		public ExprContext() { }
		public virtual void CopyFrom(ExprContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class RightExprPlusMinusContext : ExprContext {
		public IToken op;
		public ExprentContext[] exprent() {
			return GetRuleContexts<ExprentContext>();
		}
		public ExprentContext exprent(int i) {
			return GetRuleContext<ExprentContext>(i);
		}
		public ITerminalNode PLUS() { return GetToken(DEMOParser.PLUS, 0); }
		public ITerminalNode MINUS() { return GetToken(DEMOParser.MINUS, 0); }
		public RightExprPlusMinusContext(ExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IDEMOListener typedListener = listener as IDEMOListener;
			if (typedListener != null) typedListener.EnterRightExprPlusMinus(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDEMOListener typedListener = listener as IDEMOListener;
			if (typedListener != null) typedListener.ExitRightExprPlusMinus(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDEMOVisitor<TResult> typedVisitor = visitor as IDEMOVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitRightExprPlusMinus(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class RightExprEntContext : ExprContext {
		public ExprentContext exprent() {
			return GetRuleContext<ExprentContext>(0);
		}
		public RightExprEntContext(ExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IDEMOListener typedListener = listener as IDEMOListener;
			if (typedListener != null) typedListener.EnterRightExprEnt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDEMOListener typedListener = listener as IDEMOListener;
			if (typedListener != null) typedListener.ExitRightExprEnt(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDEMOVisitor<TResult> typedVisitor = visitor as IDEMOVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitRightExprEnt(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class RightExpNotContext : ExprContext {
		public ITerminalNode NOT() { return GetToken(DEMOParser.NOT, 0); }
		public ExprentContext exprent() {
			return GetRuleContext<ExprentContext>(0);
		}
		public RightExpNotContext(ExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IDEMOListener typedListener = listener as IDEMOListener;
			if (typedListener != null) typedListener.EnterRightExpNot(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDEMOListener typedListener = listener as IDEMOListener;
			if (typedListener != null) typedListener.ExitRightExpNot(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDEMOVisitor<TResult> typedVisitor = visitor as IDEMOVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitRightExpNot(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class RightExpIncrementContext : ExprContext {
		public ExprentContext exprent() {
			return GetRuleContext<ExprentContext>(0);
		}
		public ITerminalNode INC() { return GetToken(DEMOParser.INC, 0); }
		public RightExpIncrementContext(ExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IDEMOListener typedListener = listener as IDEMOListener;
			if (typedListener != null) typedListener.EnterRightExpIncrement(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDEMOListener typedListener = listener as IDEMOListener;
			if (typedListener != null) typedListener.ExitRightExpIncrement(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDEMOVisitor<TResult> typedVisitor = visitor as IDEMOVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitRightExpIncrement(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class RightExpDecrementContext : ExprContext {
		public ExprentContext exprent() {
			return GetRuleContext<ExprentContext>(0);
		}
		public ITerminalNode DEC() { return GetToken(DEMOParser.DEC, 0); }
		public RightExpDecrementContext(ExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IDEMOListener typedListener = listener as IDEMOListener;
			if (typedListener != null) typedListener.EnterRightExpDecrement(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDEMOListener typedListener = listener as IDEMOListener;
			if (typedListener != null) typedListener.ExitRightExpDecrement(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDEMOVisitor<TResult> typedVisitor = visitor as IDEMOVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitRightExpDecrement(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExprContext expr() {
		ExprContext _localctx = new ExprContext(_ctx, State);
		EnterRule(_localctx, 6, RULE_expr);
		int _la;
		try {
			State = 48;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,3,_ctx) ) {
			case 1:
				_localctx = new RightExprPlusMinusContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 35; exprent();
				State = 36;
				((RightExprPlusMinusContext)_localctx).op = _input.Lt(1);
				_la = _input.La(1);
				if ( !(_la==PLUS || _la==MINUS) ) {
					((RightExprPlusMinusContext)_localctx).op = _errHandler.RecoverInline(this);
				} else {
					if (_input.La(1) == TokenConstants.Eof) {
						matchedEOF = true;
					}

					_errHandler.ReportMatch(this);
					Consume();
				}
				State = 37; exprent();
				}
				break;

			case 2:
				_localctx = new RightExprEntContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 39; exprent();
				}
				break;

			case 3:
				_localctx = new RightExpNotContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				State = 40; Match(NOT);
				State = 41; exprent();
				}
				break;

			case 4:
				_localctx = new RightExpIncrementContext(_localctx);
				EnterOuterAlt(_localctx, 4);
				{
				State = 42; exprent();
				State = 43; Match(INC);
				}
				break;

			case 5:
				_localctx = new RightExpDecrementContext(_localctx);
				EnterOuterAlt(_localctx, 5);
				{
				State = 45; exprent();
				State = 46; Match(DEC);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExprentContext : ParserRuleContext {
		public ExprentContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_exprent; } }
	 
		public ExprentContext() { }
		public virtual void CopyFrom(ExprentContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class RightExprNumberContext : ExprentContext {
		public ITerminalNode NUMBER() { return GetToken(DEMOParser.NUMBER, 0); }
		public RightExprNumberContext(ExprentContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IDEMOListener typedListener = listener as IDEMOListener;
			if (typedListener != null) typedListener.EnterRightExprNumber(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDEMOListener typedListener = listener as IDEMOListener;
			if (typedListener != null) typedListener.ExitRightExprNumber(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDEMOVisitor<TResult> typedVisitor = visitor as IDEMOVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitRightExprNumber(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExprentContext exprent() {
		ExprentContext _localctx = new ExprentContext(_ctx, State);
		EnterRule(_localctx, 8, RULE_exprent);
		try {
			_localctx = new RightExprNumberContext(_localctx);
			EnterOuterAlt(_localctx, 1);
			{
			State = 50; Match(NUMBER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x3\x19\x37\x4\x2\t"+
		"\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x3\x2\x3\x2\x3\x2\a\x2"+
		"\x10\n\x2\f\x2\xE\x2\x13\v\x2\x3\x2\x3\x2\x3\x3\x3\x3\x3\x3\x3\x4\x3\x4"+
		"\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x5\x4$\n\x4\x3\x5\x3"+
		"\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5"+
		"\x5\x5\x33\n\x5\x3\x6\x3\x6\x3\x6\x2\x2\x2\a\x2\x2\x4\x2\x6\x2\b\x2\n"+
		"\x2\x2\x4\x3\x2\x12\x14\x3\x2\a\b:\x2\f\x3\x2\x2\x2\x4\x16\x3\x2\x2\x2"+
		"\x6#\x3\x2\x2\x2\b\x32\x3\x2\x2\x2\n\x34\x3\x2\x2\x2\f\x11\a\t\x2\x2\r"+
		"\x10\x5\x4\x3\x2\xE\x10\x5\x6\x4\x2\xF\r\x3\x2\x2\x2\xF\xE\x3\x2\x2\x2"+
		"\x10\x13\x3\x2\x2\x2\x11\xF\x3\x2\x2\x2\x11\x12\x3\x2\x2\x2\x12\x14\x3"+
		"\x2\x2\x2\x13\x11\x3\x2\x2\x2\x14\x15\a\n\x2\x2\x15\x3\x3\x2\x2\x2\x16"+
		"\x17\t\x2\x2\x2\x17\x18\a\x16\x2\x2\x18\x5\x3\x2\x2\x2\x19$\x5\b\x5\x2"+
		"\x1A\x1B\a\x3\x2\x2\x1B\x1C\a\x4\x2\x2\x1C\x1D\x5\b\x5\x2\x1D\x1E\a\x5"+
		"\x2\x2\x1E$\x3\x2\x2\x2\x1F$\a\r\x2\x2 !\a\x16\x2\x2!\"\a\x11\x2\x2\""+
		"$\x5\b\x5\x2#\x19\x3\x2\x2\x2#\x1A\x3\x2\x2\x2#\x1F\x3\x2\x2\x2# \x3\x2"+
		"\x2\x2$\a\x3\x2\x2\x2%&\x5\n\x6\x2&\'\t\x3\x2\x2\'(\x5\n\x6\x2(\x33\x3"+
		"\x2\x2\x2)\x33\x5\n\x6\x2*+\a\xE\x2\x2+\x33\x5\n\x6\x2,-\x5\n\x6\x2-."+
		"\a\xF\x2\x2.\x33\x3\x2\x2\x2/\x30\x5\n\x6\x2\x30\x31\a\x10\x2\x2\x31\x33"+
		"\x3\x2\x2\x2\x32%\x3\x2\x2\x2\x32)\x3\x2\x2\x2\x32*\x3\x2\x2\x2\x32,\x3"+
		"\x2\x2\x2\x32/\x3\x2\x2\x2\x33\t\x3\x2\x2\x2\x34\x35\a\x15\x2\x2\x35\v"+
		"\x3\x2\x2\x2\x6\xF\x11#\x32";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace Compilateur
