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
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class DEMOLexer : Lexer {
	public const int
		PRINT=1, LPAR=2, RPAR=3, LBRACKET=4, RBRACKET=5, COMMA=6, PLUS=7, MINUS=8, 
		MUL=9, DIV=10, MOD=11, OR=12, AND=13, LSHIFT=14, RSHIFT=15, BEGIN=16, 
		END=17, TRUE=18, FALSE=19, NOP=20, NOT=21, INC=22, DEC=23, EQUAL=24, BYTE=25, 
		WORD=26, STRING=27, STRING_LITERAL=28, CONST=29, NUMBER=30, ID=31, HEXA8=32, 
		HEXA16=33, BINARY8=34, BINARY16=35, COMMENT=36, NEWLINE=37, WS=38;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"PRINT", "LPAR", "RPAR", "LBRACKET", "RBRACKET", "COMMA", "PLUS", "MINUS", 
		"MUL", "DIV", "MOD", "OR", "AND", "LSHIFT", "RSHIFT", "BEGIN", "END", 
		"TRUE", "FALSE", "NOP", "NOT", "INC", "DEC", "EQUAL", "BYTE", "WORD", 
		"STRING", "STRING_LITERAL", "CONST", "NUMBER", "ID", "HEXA8", "HEXA16", 
		"BINARY8", "BINARY16", "LETTER", "DIGIT", "BIT", "HEXA", "COMMENT", "NEWLINE", 
		"WS"
	};


	public DEMOLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "'print'", "'('", "')'", "'{'", "'}'", "','", "'+'", "'-'", "'*'", 
		"'/'", "'%'", "'|'", "'&'", "'<<'", "'>>'", "'Begin'", "'End'", "'TRUE'", 
		"'FALSE'", "'NOP'", "'!'", "'++'", "'--'", "'='", "'byte'", "'word'", 
		"'string'", null, "'const'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "PRINT", "LPAR", "RPAR", "LBRACKET", "RBRACKET", "COMMA", "PLUS", 
		"MINUS", "MUL", "DIV", "MOD", "OR", "AND", "LSHIFT", "RSHIFT", "BEGIN", 
		"END", "TRUE", "FALSE", "NOP", "NOT", "INC", "DEC", "EQUAL", "BYTE", "WORD", 
		"STRING", "STRING_LITERAL", "CONST", "NUMBER", "ID", "HEXA8", "HEXA16", 
		"BINARY8", "BINARY16", "COMMENT", "NEWLINE", "WS"
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

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2(\x11E\b\x1\x4\x2"+
		"\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4"+
		"\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10"+
		"\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15\t\x15"+
		"\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A\x4\x1B"+
		"\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 \t \x4!"+
		"\t!\x4\"\t\"\x4#\t#\x4$\t$\x4%\t%\x4&\t&\x4\'\t\'\x4(\t(\x4)\t)\x4*\t"+
		"*\x4+\t+\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x3\x3\x3\x3\x4\x3\x4\x3"+
		"\x5\x3\x5\x3\x6\x3\x6\x3\a\x3\a\x3\b\x3\b\x3\t\x3\t\x3\n\x3\n\x3\v\x3"+
		"\v\x3\f\x3\f\x3\r\x3\r\x3\xE\x3\xE\x3\xF\x3\xF\x3\xF\x3\x10\x3\x10\x3"+
		"\x10\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x12\x3\x12\x3\x12\x3"+
		"\x12\x3\x13\x3\x13\x3\x13\x3\x13\x3\x13\x3\x14\x3\x14\x3\x14\x3\x14\x3"+
		"\x14\x3\x14\x3\x15\x3\x15\x3\x15\x3\x15\x3\x16\x3\x16\x3\x17\x3\x17\x3"+
		"\x17\x3\x18\x3\x18\x3\x18\x3\x19\x3\x19\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3"+
		"\x1A\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3"+
		"\x1C\x3\x1C\x3\x1C\x3\x1D\x3\x1D\a\x1D\xB2\n\x1D\f\x1D\xE\x1D\xB5\v\x1D"+
		"\x3\x1D\x3\x1D\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1F\x6\x1F"+
		"\xC0\n\x1F\r\x1F\xE\x1F\xC1\x3 \x3 \x3 \a \xC7\n \f \xE \xCA\v \x3!\x3"+
		"!\x3!\x3!\x3!\x3\"\x3\"\x3\"\x3\"\x3\"\x3\"\x3\"\x3#\x3#\x3#\x3#\x3#\x3"+
		"#\x3#\x3#\x3#\x3#\x3#\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x3$"+
		"\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x3%\x5%\xFF"+
		"\n%\x3&\x3&\x3\'\x3\'\x3(\x5(\x106\n(\x3)\x3)\a)\x10A\n)\f)\xE)\x10D\v"+
		")\x3)\x3)\x3*\x5*\x112\n*\x3*\x3*\x3*\x3*\x3+\x6+\x119\n+\r+\xE+\x11A"+
		"\x3+\x3+\x3\xB3\x2\x2,\x3\x2\x3\x5\x2\x4\a\x2\x5\t\x2\x6\v\x2\a\r\x2\b"+
		"\xF\x2\t\x11\x2\n\x13\x2\v\x15\x2\f\x17\x2\r\x19\x2\xE\x1B\x2\xF\x1D\x2"+
		"\x10\x1F\x2\x11!\x2\x12#\x2\x13%\x2\x14\'\x2\x15)\x2\x16+\x2\x17-\x2\x18"+
		"/\x2\x19\x31\x2\x1A\x33\x2\x1B\x35\x2\x1C\x37\x2\x1D\x39\x2\x1E;\x2\x1F"+
		"=\x2 ?\x2!\x41\x2\"\x43\x2#\x45\x2$G\x2%I\x2\x2K\x2\x2M\x2\x2O\x2\x2Q"+
		"\x2&S\x2\'U\x2(\x3\x2\t\x3\x2\x32\x32\x4\x2\x43\\\x63|\x3\x2\x32;\x3\x2"+
		"\x32\x33\x5\x2\x32;\x43H\x63h\x4\x2\f\f\xF\xF\x4\x2\v\v\"\"\x120\x2\x3"+
		"\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v"+
		"\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2"+
		"\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19\x3\x2\x2"+
		"\x2\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2\x1F\x3\x2\x2\x2\x2!\x3\x2"+
		"\x2\x2\x2#\x3\x2\x2\x2\x2%\x3\x2\x2\x2\x2\'\x3\x2\x2\x2\x2)\x3\x2\x2\x2"+
		"\x2+\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2/\x3\x2\x2\x2\x2\x31\x3\x2\x2\x2\x2"+
		"\x33\x3\x2\x2\x2\x2\x35\x3\x2\x2\x2\x2\x37\x3\x2\x2\x2\x2\x39\x3\x2\x2"+
		"\x2\x2;\x3\x2\x2\x2\x2=\x3\x2\x2\x2\x2?\x3\x2\x2\x2\x2\x41\x3\x2\x2\x2"+
		"\x2\x43\x3\x2\x2\x2\x2\x45\x3\x2\x2\x2\x2G\x3\x2\x2\x2\x2Q\x3\x2\x2\x2"+
		"\x2S\x3\x2\x2\x2\x2U\x3\x2\x2\x2\x3W\x3\x2\x2\x2\x5]\x3\x2\x2\x2\a_\x3"+
		"\x2\x2\x2\t\x61\x3\x2\x2\x2\v\x63\x3\x2\x2\x2\r\x65\x3\x2\x2\x2\xFg\x3"+
		"\x2\x2\x2\x11i\x3\x2\x2\x2\x13k\x3\x2\x2\x2\x15m\x3\x2\x2\x2\x17o\x3\x2"+
		"\x2\x2\x19q\x3\x2\x2\x2\x1Bs\x3\x2\x2\x2\x1Du\x3\x2\x2\x2\x1Fx\x3\x2\x2"+
		"\x2!{\x3\x2\x2\x2#\x81\x3\x2\x2\x2%\x85\x3\x2\x2\x2\'\x8A\x3\x2\x2\x2"+
		")\x90\x3\x2\x2\x2+\x94\x3\x2\x2\x2-\x96\x3\x2\x2\x2/\x99\x3\x2\x2\x2\x31"+
		"\x9C\x3\x2\x2\x2\x33\x9E\x3\x2\x2\x2\x35\xA3\x3\x2\x2\x2\x37\xA8\x3\x2"+
		"\x2\x2\x39\xAF\x3\x2\x2\x2;\xB8\x3\x2\x2\x2=\xBF\x3\x2\x2\x2?\xC3\x3\x2"+
		"\x2\x2\x41\xCB\x3\x2\x2\x2\x43\xD0\x3\x2\x2\x2\x45\xD7\x3\x2\x2\x2G\xE2"+
		"\x3\x2\x2\x2I\xFE\x3\x2\x2\x2K\x100\x3\x2\x2\x2M\x102\x3\x2\x2\x2O\x105"+
		"\x3\x2\x2\x2Q\x107\x3\x2\x2\x2S\x111\x3\x2\x2\x2U\x118\x3\x2\x2\x2WX\a"+
		"r\x2\x2XY\at\x2\x2YZ\ak\x2\x2Z[\ap\x2\x2[\\\av\x2\x2\\\x4\x3\x2\x2\x2"+
		"]^\a*\x2\x2^\x6\x3\x2\x2\x2_`\a+\x2\x2`\b\x3\x2\x2\x2\x61\x62\a}\x2\x2"+
		"\x62\n\x3\x2\x2\x2\x63\x64\a\x7F\x2\x2\x64\f\x3\x2\x2\x2\x65\x66\a.\x2"+
		"\x2\x66\xE\x3\x2\x2\x2gh\a-\x2\x2h\x10\x3\x2\x2\x2ij\a/\x2\x2j\x12\x3"+
		"\x2\x2\x2kl\a,\x2\x2l\x14\x3\x2\x2\x2mn\a\x31\x2\x2n\x16\x3\x2\x2\x2o"+
		"p\a\'\x2\x2p\x18\x3\x2\x2\x2qr\a~\x2\x2r\x1A\x3\x2\x2\x2st\a(\x2\x2t\x1C"+
		"\x3\x2\x2\x2uv\a>\x2\x2vw\a>\x2\x2w\x1E\x3\x2\x2\x2xy\a@\x2\x2yz\a@\x2"+
		"\x2z \x3\x2\x2\x2{|\a\x44\x2\x2|}\ag\x2\x2}~\ai\x2\x2~\x7F\ak\x2\x2\x7F"+
		"\x80\ap\x2\x2\x80\"\x3\x2\x2\x2\x81\x82\aG\x2\x2\x82\x83\ap\x2\x2\x83"+
		"\x84\a\x66\x2\x2\x84$\x3\x2\x2\x2\x85\x86\aV\x2\x2\x86\x87\aT\x2\x2\x87"+
		"\x88\aW\x2\x2\x88\x89\aG\x2\x2\x89&\x3\x2\x2\x2\x8A\x8B\aH\x2\x2\x8B\x8C"+
		"\a\x43\x2\x2\x8C\x8D\aN\x2\x2\x8D\x8E\aU\x2\x2\x8E\x8F\aG\x2\x2\x8F(\x3"+
		"\x2\x2\x2\x90\x91\aP\x2\x2\x91\x92\aQ\x2\x2\x92\x93\aR\x2\x2\x93*\x3\x2"+
		"\x2\x2\x94\x95\a#\x2\x2\x95,\x3\x2\x2\x2\x96\x97\a-\x2\x2\x97\x98\a-\x2"+
		"\x2\x98.\x3\x2\x2\x2\x99\x9A\a/\x2\x2\x9A\x9B\a/\x2\x2\x9B\x30\x3\x2\x2"+
		"\x2\x9C\x9D\a?\x2\x2\x9D\x32\x3\x2\x2\x2\x9E\x9F\a\x64\x2\x2\x9F\xA0\a"+
		"{\x2\x2\xA0\xA1\av\x2\x2\xA1\xA2\ag\x2\x2\xA2\x34\x3\x2\x2\x2\xA3\xA4"+
		"\ay\x2\x2\xA4\xA5\aq\x2\x2\xA5\xA6\at\x2\x2\xA6\xA7\a\x66\x2\x2\xA7\x36"+
		"\x3\x2\x2\x2\xA8\xA9\au\x2\x2\xA9\xAA\av\x2\x2\xAA\xAB\at\x2\x2\xAB\xAC"+
		"\ak\x2\x2\xAC\xAD\ap\x2\x2\xAD\xAE\ai\x2\x2\xAE\x38\x3\x2\x2\x2\xAF\xB3"+
		"\a$\x2\x2\xB0\xB2\v\x2\x2\x2\xB1\xB0\x3\x2\x2\x2\xB2\xB5\x3\x2\x2\x2\xB3"+
		"\xB4\x3\x2\x2\x2\xB3\xB1\x3\x2\x2\x2\xB4\xB6\x3\x2\x2\x2\xB5\xB3\x3\x2"+
		"\x2\x2\xB6\xB7\a$\x2\x2\xB7:\x3\x2\x2\x2\xB8\xB9\a\x65\x2\x2\xB9\xBA\a"+
		"q\x2\x2\xBA\xBB\ap\x2\x2\xBB\xBC\au\x2\x2\xBC\xBD\av\x2\x2\xBD<\x3\x2"+
		"\x2\x2\xBE\xC0\x5K&\x2\xBF\xBE\x3\x2\x2\x2\xC0\xC1\x3\x2\x2\x2\xC1\xBF"+
		"\x3\x2\x2\x2\xC1\xC2\x3\x2\x2\x2\xC2>\x3\x2\x2\x2\xC3\xC8\x5I%\x2\xC4"+
		"\xC7\x5I%\x2\xC5\xC7\x5K&\x2\xC6\xC4\x3\x2\x2\x2\xC6\xC5\x3\x2\x2\x2\xC7"+
		"\xCA\x3\x2\x2\x2\xC8\xC6\x3\x2\x2\x2\xC8\xC9\x3\x2\x2\x2\xC9@\x3\x2\x2"+
		"\x2\xCA\xC8\x3\x2\x2\x2\xCB\xCC\t\x2\x2\x2\xCC\xCD\az\x2\x2\xCD\xCE\x5"+
		"O(\x2\xCE\xCF\x5O(\x2\xCF\x42\x3\x2\x2\x2\xD0\xD1\t\x2\x2\x2\xD1\xD2\a"+
		"z\x2\x2\xD2\xD3\x5O(\x2\xD3\xD4\x5O(\x2\xD4\xD5\x5O(\x2\xD5\xD6\x5O(\x2"+
		"\xD6\x44\x3\x2\x2\x2\xD7\xD8\t\x2\x2\x2\xD8\xD9\a\x64\x2\x2\xD9\xDA\x5"+
		"M\'\x2\xDA\xDB\x5M\'\x2\xDB\xDC\x5M\'\x2\xDC\xDD\x5M\'\x2\xDD\xDE\x5M"+
		"\'\x2\xDE\xDF\x5M\'\x2\xDF\xE0\x5M\'\x2\xE0\xE1\x5M\'\x2\xE1\x46\x3\x2"+
		"\x2\x2\xE2\xE3\t\x2\x2\x2\xE3\xE4\a\x64\x2\x2\xE4\xE5\x5M\'\x2\xE5\xE6"+
		"\x5M\'\x2\xE6\xE7\x5M\'\x2\xE7\xE8\x5M\'\x2\xE8\xE9\x5M\'\x2\xE9\xEA\x5"+
		"M\'\x2\xEA\xEB\x5M\'\x2\xEB\xEC\x5M\'\x2\xEC\xED\x5M\'\x2\xED\xEE\x5M"+
		"\'\x2\xEE\xEF\x5M\'\x2\xEF\xF0\x5M\'\x2\xF0\xF1\x5M\'\x2\xF1\xF2\x5M\'"+
		"\x2\xF2\xF3\x5M\'\x2\xF3\xF4\x5M\'\x2\xF4\xF5\x5M\'\x2\xF5\xF6\x5M\'\x2"+
		"\xF6\xF7\x5M\'\x2\xF7\xF8\x5M\'\x2\xF8\xF9\x5M\'\x2\xF9\xFA\x5M\'\x2\xFA"+
		"\xFB\x5M\'\x2\xFB\xFC\x5M\'\x2\xFCH\x3\x2\x2\x2\xFD\xFF\t\x3\x2\x2\xFE"+
		"\xFD\x3\x2\x2\x2\xFFJ\x3\x2\x2\x2\x100\x101\t\x4\x2\x2\x101L\x3\x2\x2"+
		"\x2\x102\x103\t\x5\x2\x2\x103N\x3\x2\x2\x2\x104\x106\t\x6\x2\x2\x105\x104"+
		"\x3\x2\x2\x2\x106P\x3\x2\x2\x2\x107\x10B\a%\x2\x2\x108\x10A\n\a\x2\x2"+
		"\x109\x108\x3\x2\x2\x2\x10A\x10D\x3\x2\x2\x2\x10B\x109\x3\x2\x2\x2\x10B"+
		"\x10C\x3\x2\x2\x2\x10C\x10E\x3\x2\x2\x2\x10D\x10B\x3\x2\x2\x2\x10E\x10F"+
		"\b)\x2\x2\x10FR\x3\x2\x2\x2\x110\x112\a\xF\x2\x2\x111\x110\x3\x2\x2\x2"+
		"\x111\x112\x3\x2\x2\x2\x112\x113\x3\x2\x2\x2\x113\x114\a\f\x2\x2\x114"+
		"\x115\x3\x2\x2\x2\x115\x116\b*\x2\x2\x116T\x3\x2\x2\x2\x117\x119\t\b\x2"+
		"\x2\x118\x117\x3\x2\x2\x2\x119\x11A\x3\x2\x2\x2\x11A\x118\x3\x2\x2\x2"+
		"\x11A\x11B\x3\x2\x2\x2\x11B\x11C\x3\x2\x2\x2\x11C\x11D\b+\x2\x2\x11DV"+
		"\x3\x2\x2\x2\f\x2\xB3\xC1\xC6\xC8\xFE\x105\x10B\x111\x11A\x3\b\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace Compilateur
