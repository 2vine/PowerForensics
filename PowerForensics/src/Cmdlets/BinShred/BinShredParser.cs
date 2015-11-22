//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from .\BinShred.g4 by ANTLR 4.5.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

using System;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.1")]
[System.CLSCompliant(false)]
public partial class BinShredParser : Parser {
	public const int
		QUOTEDVALUE=1, COMMA=2, QUOTE=3, COLON=4, SEMI=5, LPAREN=6, RPAREN=7, 
		BYTES=8, ITEMS=9, AS=10, DESCRIBED=11, BY=12, ASCII=13, UNICODE=14, UTF8=15, 
		UINT64=16, UINT32=17, UINT16=18, INT64=19, INT32=20, INT16=21, SINGLE=22, 
		FLOAT=23, DOUBLE=24, ADDITIONAL=25, PROPERTIES=26, IDENTIFIED=27, FROM=28, 
		WS=29, DOC_COMMENT=30, BLOCK_COMMENT=31, LINE_COMMENT=32, INT=33, HEXADECIMAL=34, 
		LABEL=35;
	public const int
		RULE_template = 0, RULE_templateEntry = 1, RULE_parseRule = 2, RULE_ruleBody = 3, 
		RULE_propertyName = 4, RULE_lookupTableName = 5, RULE_ruleOptions = 6, 
		RULE_byteOption = 7, RULE_sizeReference = 8, RULE_byteFormat = 9, RULE_lookupTable = 10, 
		RULE_lookupTableEntry = 11, RULE_lookupTableEntryKey = 12, RULE_label = 13;
	public static readonly string[] ruleNames = {
		"template", "templateEntry", "parseRule", "ruleBody", "propertyName", 
		"lookupTableName", "ruleOptions", "byteOption", "sizeReference", "byteFormat", 
		"lookupTable", "lookupTableEntry", "lookupTableEntryKey", "label"
	};

	private static readonly string[] _LiteralNames = {
		null, null, "','", "'\"'", "':'", "';'", "'('", "')'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "QUOTEDVALUE", "COMMA", "QUOTE", "COLON", "SEMI", "LPAREN", "RPAREN", 
		"BYTES", "ITEMS", "AS", "DESCRIBED", "BY", "ASCII", "UNICODE", "UTF8", 
		"UINT64", "UINT32", "UINT16", "INT64", "INT32", "INT16", "SINGLE", "FLOAT", 
		"DOUBLE", "ADDITIONAL", "PROPERTIES", "IDENTIFIED", "FROM", "WS", "DOC_COMMENT", 
		"BLOCK_COMMENT", "LINE_COMMENT", "INT", "HEXADECIMAL", "LABEL"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "BinShred.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public BinShredParser(ITokenStream input)
		: base(input)
	{
		Interpreter = new ParserATNSimulator(this,_ATN);
	}
	public partial class TemplateContext : ParserRuleContext {
		public TemplateEntryContext[] templateEntry() {
			return GetRuleContexts<TemplateEntryContext>();
		}
		public TemplateEntryContext templateEntry(int i) {
			return GetRuleContext<TemplateEntryContext>(i);
		}
		public ITerminalNode Eof() { return GetToken(BinShredParser.Eof, 0); }
		public TemplateContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_template; } }
		public override void EnterRule(IParseTreeListener listener) {
			IBinShredListener typedListener = listener as IBinShredListener;
			if (typedListener != null) typedListener.EnterTemplate(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBinShredListener typedListener = listener as IBinShredListener;
			if (typedListener != null) typedListener.ExitTemplate(this);
		}
	}

	[RuleVersion(0)]
	public TemplateContext template() {
		TemplateContext _localctx = new TemplateContext(Context, State);
		EnterRule(_localctx, 0, RULE_template);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 28; templateEntry();
			State = 32;
			ErrorHandler.Sync(this);
			_la = TokenStream.La(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BYTES) | (1L << ITEMS) | (1L << AS) | (1L << DESCRIBED) | (1L << BY) | (1L << ASCII) | (1L << UNICODE) | (1L << UTF8) | (1L << UINT64) | (1L << UINT32) | (1L << UINT16) | (1L << INT64) | (1L << INT32) | (1L << INT16) | (1L << SINGLE) | (1L << FLOAT) | (1L << DOUBLE) | (1L << ADDITIONAL) | (1L << PROPERTIES) | (1L << IDENTIFIED) | (1L << FROM) | (1L << LABEL))) != 0)) {
				{
				{
				State = 29; templateEntry();
				}
				}
				State = 34;
				ErrorHandler.Sync(this);
				_la = TokenStream.La(1);
			}
			State = 35; Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TemplateEntryContext : ParserRuleContext {
		public ParseRuleContext parseRule() {
			return GetRuleContext<ParseRuleContext>(0);
		}
		public LookupTableContext lookupTable() {
			return GetRuleContext<LookupTableContext>(0);
		}
		public TemplateEntryContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_templateEntry; } }
		public override void EnterRule(IParseTreeListener listener) {
			IBinShredListener typedListener = listener as IBinShredListener;
			if (typedListener != null) typedListener.EnterTemplateEntry(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBinShredListener typedListener = listener as IBinShredListener;
			if (typedListener != null) typedListener.ExitTemplateEntry(this);
		}
	}

	[RuleVersion(0)]
	public TemplateEntryContext templateEntry() {
		TemplateEntryContext _localctx = new TemplateEntryContext(Context, State);
		EnterRule(_localctx, 2, RULE_templateEntry);
		try {
			State = 39;
			switch ( Interpreter.AdaptivePredict(TokenStream,1,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 37; parseRule();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 38; lookupTable();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ParseRuleContext : ParserRuleContext {
		public LabelContext label() {
			return GetRuleContext<LabelContext>(0);
		}
		public ITerminalNode COLON() { return GetToken(BinShredParser.COLON, 0); }
		public RuleBodyContext[] ruleBody() {
			return GetRuleContexts<RuleBodyContext>();
		}
		public RuleBodyContext ruleBody(int i) {
			return GetRuleContext<RuleBodyContext>(i);
		}
		public ITerminalNode SEMI() { return GetToken(BinShredParser.SEMI, 0); }
		public ParseRuleContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_parseRule; } }
		public override void EnterRule(IParseTreeListener listener) {
			IBinShredListener typedListener = listener as IBinShredListener;
			if (typedListener != null) typedListener.EnterParseRule(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBinShredListener typedListener = listener as IBinShredListener;
			if (typedListener != null) typedListener.ExitParseRule(this);
		}
	}

	[RuleVersion(0)]
	public ParseRuleContext parseRule() {
		ParseRuleContext _localctx = new ParseRuleContext(Context, State);
		EnterRule(_localctx, 4, RULE_parseRule);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 41; label();
			State = 42; Match(COLON);
			State = 43; ruleBody();
			State = 47;
			ErrorHandler.Sync(this);
			_la = TokenStream.La(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << LPAREN) | (1L << BYTES) | (1L << ITEMS) | (1L << AS) | (1L << DESCRIBED) | (1L << BY) | (1L << ASCII) | (1L << UNICODE) | (1L << UTF8) | (1L << UINT64) | (1L << UINT32) | (1L << UINT16) | (1L << INT64) | (1L << INT32) | (1L << INT16) | (1L << SINGLE) | (1L << FLOAT) | (1L << DOUBLE) | (1L << ADDITIONAL) | (1L << PROPERTIES) | (1L << IDENTIFIED) | (1L << FROM) | (1L << DOC_COMMENT) | (1L << LABEL))) != 0)) {
				{
				{
				State = 44; ruleBody();
				}
				}
				State = 49;
				ErrorHandler.Sync(this);
				_la = TokenStream.La(1);
			}
			State = 50; Match(SEMI);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class RuleBodyContext : ParserRuleContext {
		public ITerminalNode DOC_COMMENT() { return GetToken(BinShredParser.DOC_COMMENT, 0); }
		public LabelContext label() {
			return GetRuleContext<LabelContext>(0);
		}
		public ITerminalNode LPAREN() { return GetToken(BinShredParser.LPAREN, 0); }
		public SizeReferenceContext sizeReference() {
			return GetRuleContext<SizeReferenceContext>(0);
		}
		public ITerminalNode ITEMS() { return GetToken(BinShredParser.ITEMS, 0); }
		public ITerminalNode RPAREN() { return GetToken(BinShredParser.RPAREN, 0); }
		public RuleOptionsContext ruleOptions() {
			return GetRuleContext<RuleOptionsContext>(0);
		}
		public ITerminalNode ADDITIONAL() { return GetToken(BinShredParser.ADDITIONAL, 0); }
		public ITerminalNode PROPERTIES() { return GetToken(BinShredParser.PROPERTIES, 0); }
		public ITerminalNode IDENTIFIED() { return GetToken(BinShredParser.IDENTIFIED, 0); }
		public ITerminalNode BY() { return GetToken(BinShredParser.BY, 0); }
		public PropertyNameContext propertyName() {
			return GetRuleContext<PropertyNameContext>(0);
		}
		public ITerminalNode FROM() { return GetToken(BinShredParser.FROM, 0); }
		public LookupTableNameContext lookupTableName() {
			return GetRuleContext<LookupTableNameContext>(0);
		}
		public RuleBodyContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_ruleBody; } }
		public override void EnterRule(IParseTreeListener listener) {
			IBinShredListener typedListener = listener as IBinShredListener;
			if (typedListener != null) typedListener.EnterRuleBody(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBinShredListener typedListener = listener as IBinShredListener;
			if (typedListener != null) typedListener.ExitRuleBody(this);
		}
	}

	[RuleVersion(0)]
	public RuleBodyContext ruleBody() {
		RuleBodyContext _localctx = new RuleBodyContext(Context, State);
		EnterRule(_localctx, 6, RULE_ruleBody);
		int _la;
		try {
			State = 80;
			switch (TokenStream.La(1)) {
			case BYTES:
			case ITEMS:
			case AS:
			case DESCRIBED:
			case BY:
			case ASCII:
			case UNICODE:
			case UTF8:
			case UINT64:
			case UINT32:
			case UINT16:
			case INT64:
			case INT32:
			case INT16:
			case SINGLE:
			case FLOAT:
			case DOUBLE:
			case ADDITIONAL:
			case PROPERTIES:
			case IDENTIFIED:
			case FROM:
			case DOC_COMMENT:
			case LABEL:
				EnterOuterAlt(_localctx, 1);
				{
				{
				State = 53;
				_la = TokenStream.La(1);
				if (_la==DOC_COMMENT) {
					{
					State = 52; Match(DOC_COMMENT);
					}
				}

				State = 68;
				switch ( Interpreter.AdaptivePredict(TokenStream,5,Context) ) {
				case 1:
					{
					{
					State = 55; label();
					State = 56; Match(LPAREN);
					State = 57; sizeReference();
					State = 58; Match(ITEMS);
					State = 59; Match(RPAREN);
					}
					}
					break;
				case 2:
					{
					{
					State = 61; label();
					State = 66;
					switch ( Interpreter.AdaptivePredict(TokenStream,4,Context) ) {
					case 1:
						{
						State = 62; Match(LPAREN);
						State = 63; ruleOptions();
						State = 64; Match(RPAREN);
						}
						break;
					}
					}
					}
					break;
				}
				}
				}
				break;
			case LPAREN:
				EnterOuterAlt(_localctx, 2);
				{
				{
				State = 70; Match(LPAREN);
				State = 71; Match(ADDITIONAL);
				State = 72; Match(PROPERTIES);
				State = 73; Match(IDENTIFIED);
				State = 74; Match(BY);
				State = 75; propertyName();
				State = 76; Match(FROM);
				State = 77; lookupTableName();
				State = 78; Match(RPAREN);
				}
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PropertyNameContext : ParserRuleContext {
		public LabelContext label() {
			return GetRuleContext<LabelContext>(0);
		}
		public PropertyNameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_propertyName; } }
		public override void EnterRule(IParseTreeListener listener) {
			IBinShredListener typedListener = listener as IBinShredListener;
			if (typedListener != null) typedListener.EnterPropertyName(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBinShredListener typedListener = listener as IBinShredListener;
			if (typedListener != null) typedListener.ExitPropertyName(this);
		}
	}

	[RuleVersion(0)]
	public PropertyNameContext propertyName() {
		PropertyNameContext _localctx = new PropertyNameContext(Context, State);
		EnterRule(_localctx, 8, RULE_propertyName);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 82; label();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class LookupTableNameContext : ParserRuleContext {
		public LabelContext label() {
			return GetRuleContext<LabelContext>(0);
		}
		public LookupTableNameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_lookupTableName; } }
		public override void EnterRule(IParseTreeListener listener) {
			IBinShredListener typedListener = listener as IBinShredListener;
			if (typedListener != null) typedListener.EnterLookupTableName(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBinShredListener typedListener = listener as IBinShredListener;
			if (typedListener != null) typedListener.ExitLookupTableName(this);
		}
	}

	[RuleVersion(0)]
	public LookupTableNameContext lookupTableName() {
		LookupTableNameContext _localctx = new LookupTableNameContext(Context, State);
		EnterRule(_localctx, 10, RULE_lookupTableName);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 84; label();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class RuleOptionsContext : ParserRuleContext {
		public ByteOptionContext byteOption() {
			return GetRuleContext<ByteOptionContext>(0);
		}
		public RuleOptionsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_ruleOptions; } }
		public override void EnterRule(IParseTreeListener listener) {
			IBinShredListener typedListener = listener as IBinShredListener;
			if (typedListener != null) typedListener.EnterRuleOptions(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBinShredListener typedListener = listener as IBinShredListener;
			if (typedListener != null) typedListener.ExitRuleOptions(this);
		}
	}

	[RuleVersion(0)]
	public RuleOptionsContext ruleOptions() {
		RuleOptionsContext _localctx = new RuleOptionsContext(Context, State);
		EnterRule(_localctx, 12, RULE_ruleOptions);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 86; byteOption();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ByteOptionContext : ParserRuleContext {
		public SizeReferenceContext sizeReference() {
			return GetRuleContext<SizeReferenceContext>(0);
		}
		public ITerminalNode BYTES() { return GetToken(BinShredParser.BYTES, 0); }
		public ITerminalNode AS() { return GetToken(BinShredParser.AS, 0); }
		public ByteFormatContext byteFormat() {
			return GetRuleContext<ByteFormatContext>(0);
		}
		public ITerminalNode DESCRIBED() { return GetToken(BinShredParser.DESCRIBED, 0); }
		public ITerminalNode BY() { return GetToken(BinShredParser.BY, 0); }
		public LabelContext label() {
			return GetRuleContext<LabelContext>(0);
		}
		public ByteOptionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_byteOption; } }
		public override void EnterRule(IParseTreeListener listener) {
			IBinShredListener typedListener = listener as IBinShredListener;
			if (typedListener != null) typedListener.EnterByteOption(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBinShredListener typedListener = listener as IBinShredListener;
			if (typedListener != null) typedListener.ExitByteOption(this);
		}
	}

	[RuleVersion(0)]
	public ByteOptionContext byteOption() {
		ByteOptionContext _localctx = new ByteOptionContext(Context, State);
		EnterRule(_localctx, 14, RULE_byteOption);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 88; sizeReference();
			State = 89; Match(BYTES);
			State = 97;
			_la = TokenStream.La(1);
			if (_la==AS) {
				{
				State = 90; Match(AS);
				State = 91; byteFormat();
				State = 95;
				_la = TokenStream.La(1);
				if (_la==DESCRIBED) {
					{
					State = 92; Match(DESCRIBED);
					State = 93; Match(BY);
					State = 94; label();
					}
				}

				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class SizeReferenceContext : ParserRuleContext {
		public LabelContext label() {
			return GetRuleContext<LabelContext>(0);
		}
		public ITerminalNode INT() { return GetToken(BinShredParser.INT, 0); }
		public SizeReferenceContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_sizeReference; } }
		public override void EnterRule(IParseTreeListener listener) {
			IBinShredListener typedListener = listener as IBinShredListener;
			if (typedListener != null) typedListener.EnterSizeReference(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBinShredListener typedListener = listener as IBinShredListener;
			if (typedListener != null) typedListener.ExitSizeReference(this);
		}
	}

	[RuleVersion(0)]
	public SizeReferenceContext sizeReference() {
		SizeReferenceContext _localctx = new SizeReferenceContext(Context, State);
		EnterRule(_localctx, 16, RULE_sizeReference);
		try {
			State = 101;
			switch (TokenStream.La(1)) {
			case BYTES:
			case ITEMS:
			case AS:
			case DESCRIBED:
			case BY:
			case ASCII:
			case UNICODE:
			case UTF8:
			case UINT64:
			case UINT32:
			case UINT16:
			case INT64:
			case INT32:
			case INT16:
			case SINGLE:
			case FLOAT:
			case DOUBLE:
			case ADDITIONAL:
			case PROPERTIES:
			case IDENTIFIED:
			case FROM:
			case LABEL:
				EnterOuterAlt(_localctx, 1);
				{
				State = 99; label();
				}
				break;
			case INT:
				EnterOuterAlt(_localctx, 2);
				{
				State = 100; Match(INT);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ByteFormatContext : ParserRuleContext {
		public ITerminalNode ASCII() { return GetToken(BinShredParser.ASCII, 0); }
		public ITerminalNode UNICODE() { return GetToken(BinShredParser.UNICODE, 0); }
		public ITerminalNode UTF8() { return GetToken(BinShredParser.UTF8, 0); }
		public ITerminalNode UINT64() { return GetToken(BinShredParser.UINT64, 0); }
		public ITerminalNode UINT32() { return GetToken(BinShredParser.UINT32, 0); }
		public ITerminalNode UINT16() { return GetToken(BinShredParser.UINT16, 0); }
		public ITerminalNode INT64() { return GetToken(BinShredParser.INT64, 0); }
		public ITerminalNode INT32() { return GetToken(BinShredParser.INT32, 0); }
		public ITerminalNode INT16() { return GetToken(BinShredParser.INT16, 0); }
		public ITerminalNode SINGLE() { return GetToken(BinShredParser.SINGLE, 0); }
		public ITerminalNode FLOAT() { return GetToken(BinShredParser.FLOAT, 0); }
		public ITerminalNode DOUBLE() { return GetToken(BinShredParser.DOUBLE, 0); }
		public ByteFormatContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_byteFormat; } }
		public override void EnterRule(IParseTreeListener listener) {
			IBinShredListener typedListener = listener as IBinShredListener;
			if (typedListener != null) typedListener.EnterByteFormat(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBinShredListener typedListener = listener as IBinShredListener;
			if (typedListener != null) typedListener.ExitByteFormat(this);
		}
	}

	[RuleVersion(0)]
	public ByteFormatContext byteFormat() {
		ByteFormatContext _localctx = new ByteFormatContext(Context, State);
		EnterRule(_localctx, 18, RULE_byteFormat);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 103;
			_la = TokenStream.La(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ASCII) | (1L << UNICODE) | (1L << UTF8) | (1L << UINT64) | (1L << UINT32) | (1L << UINT16) | (1L << INT64) | (1L << INT32) | (1L << INT16) | (1L << SINGLE) | (1L << FLOAT) | (1L << DOUBLE))) != 0)) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
			    Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class LookupTableContext : ParserRuleContext {
		public LookupTableNameContext lookupTableName() {
			return GetRuleContext<LookupTableNameContext>(0);
		}
		public ITerminalNode COLON() { return GetToken(BinShredParser.COLON, 0); }
		public LookupTableEntryContext[] lookupTableEntry() {
			return GetRuleContexts<LookupTableEntryContext>();
		}
		public LookupTableEntryContext lookupTableEntry(int i) {
			return GetRuleContext<LookupTableEntryContext>(i);
		}
		public ITerminalNode SEMI() { return GetToken(BinShredParser.SEMI, 0); }
		public LookupTableContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_lookupTable; } }
		public override void EnterRule(IParseTreeListener listener) {
			IBinShredListener typedListener = listener as IBinShredListener;
			if (typedListener != null) typedListener.EnterLookupTable(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBinShredListener typedListener = listener as IBinShredListener;
			if (typedListener != null) typedListener.ExitLookupTable(this);
		}
	}

	[RuleVersion(0)]
	public LookupTableContext lookupTable() {
		LookupTableContext _localctx = new LookupTableContext(Context, State);
		EnterRule(_localctx, 20, RULE_lookupTable);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 105; lookupTableName();
			State = 106; Match(COLON);
			State = 107; lookupTableEntry();
			State = 111;
			ErrorHandler.Sync(this);
			_la = TokenStream.La(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BYTES) | (1L << ITEMS) | (1L << AS) | (1L << DESCRIBED) | (1L << BY) | (1L << ASCII) | (1L << UNICODE) | (1L << UTF8) | (1L << UINT64) | (1L << UINT32) | (1L << UINT16) | (1L << INT64) | (1L << INT32) | (1L << INT16) | (1L << SINGLE) | (1L << FLOAT) | (1L << DOUBLE) | (1L << ADDITIONAL) | (1L << PROPERTIES) | (1L << IDENTIFIED) | (1L << FROM) | (1L << DOC_COMMENT) | (1L << INT) | (1L << HEXADECIMAL) | (1L << LABEL))) != 0)) {
				{
				{
				State = 108; lookupTableEntry();
				}
				}
				State = 113;
				ErrorHandler.Sync(this);
				_la = TokenStream.La(1);
			}
			State = 114; Match(SEMI);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class LookupTableEntryContext : ParserRuleContext {
		public LookupTableEntryKeyContext[] lookupTableEntryKey() {
			return GetRuleContexts<LookupTableEntryKeyContext>();
		}
		public LookupTableEntryKeyContext lookupTableEntryKey(int i) {
			return GetRuleContext<LookupTableEntryKeyContext>(i);
		}
		public ITerminalNode COLON() { return GetToken(BinShredParser.COLON, 0); }
		public ITerminalNode QUOTEDVALUE() { return GetToken(BinShredParser.QUOTEDVALUE, 0); }
		public LabelContext label() {
			return GetRuleContext<LabelContext>(0);
		}
		public ITerminalNode DOC_COMMENT() { return GetToken(BinShredParser.DOC_COMMENT, 0); }
		public ITerminalNode[] COMMA() { return GetTokens(BinShredParser.COMMA); }
		public ITerminalNode COMMA(int i) {
			return GetToken(BinShredParser.COMMA, i);
		}
		public LookupTableEntryContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_lookupTableEntry; } }
		public override void EnterRule(IParseTreeListener listener) {
			IBinShredListener typedListener = listener as IBinShredListener;
			if (typedListener != null) typedListener.EnterLookupTableEntry(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBinShredListener typedListener = listener as IBinShredListener;
			if (typedListener != null) typedListener.ExitLookupTableEntry(this);
		}
	}

	[RuleVersion(0)]
	public LookupTableEntryContext lookupTableEntry() {
		LookupTableEntryContext _localctx = new LookupTableEntryContext(Context, State);
		EnterRule(_localctx, 22, RULE_lookupTableEntry);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 117;
			_la = TokenStream.La(1);
			if (_la==DOC_COMMENT) {
				{
				State = 116; Match(DOC_COMMENT);
				}
			}

			State = 141;
			switch ( Interpreter.AdaptivePredict(TokenStream,14,Context) ) {
			case 1:
				{
				State = 119; lookupTableEntryKey();
				State = 124;
				ErrorHandler.Sync(this);
				_la = TokenStream.La(1);
				while (_la==COMMA) {
					{
					{
					State = 120; Match(COMMA);
					State = 121; lookupTableEntryKey();
					}
					}
					State = 126;
					ErrorHandler.Sync(this);
					_la = TokenStream.La(1);
				}
				State = 127; Match(COLON);
				State = 128; Match(QUOTEDVALUE);
				}
				break;
			case 2:
				{
				State = 130; lookupTableEntryKey();
				State = 135;
				ErrorHandler.Sync(this);
				_la = TokenStream.La(1);
				while (_la==COMMA) {
					{
					{
					State = 131; Match(COMMA);
					State = 132; lookupTableEntryKey();
					}
					}
					State = 137;
					ErrorHandler.Sync(this);
					_la = TokenStream.La(1);
				}
				State = 138; Match(COLON);
				State = 139; label();
				}
				break;
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class LookupTableEntryKeyContext : ParserRuleContext {
		public LabelContext label() {
			return GetRuleContext<LabelContext>(0);
		}
		public ITerminalNode INT() { return GetToken(BinShredParser.INT, 0); }
		public ITerminalNode HEXADECIMAL() { return GetToken(BinShredParser.HEXADECIMAL, 0); }
		public LookupTableEntryKeyContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_lookupTableEntryKey; } }
		public override void EnterRule(IParseTreeListener listener) {
			IBinShredListener typedListener = listener as IBinShredListener;
			if (typedListener != null) typedListener.EnterLookupTableEntryKey(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBinShredListener typedListener = listener as IBinShredListener;
			if (typedListener != null) typedListener.ExitLookupTableEntryKey(this);
		}
	}

	[RuleVersion(0)]
	public LookupTableEntryKeyContext lookupTableEntryKey() {
		LookupTableEntryKeyContext _localctx = new LookupTableEntryKeyContext(Context, State);
		EnterRule(_localctx, 24, RULE_lookupTableEntryKey);
		try {
			State = 146;
			switch (TokenStream.La(1)) {
			case BYTES:
			case ITEMS:
			case AS:
			case DESCRIBED:
			case BY:
			case ASCII:
			case UNICODE:
			case UTF8:
			case UINT64:
			case UINT32:
			case UINT16:
			case INT64:
			case INT32:
			case INT16:
			case SINGLE:
			case FLOAT:
			case DOUBLE:
			case ADDITIONAL:
			case PROPERTIES:
			case IDENTIFIED:
			case FROM:
			case LABEL:
				EnterOuterAlt(_localctx, 1);
				{
				State = 143; label();
				}
				break;
			case INT:
				EnterOuterAlt(_localctx, 2);
				{
				State = 144; Match(INT);
				}
				break;
			case HEXADECIMAL:
				EnterOuterAlt(_localctx, 3);
				{
				State = 145; Match(HEXADECIMAL);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class LabelContext : ParserRuleContext {
		public ITerminalNode LABEL() { return GetToken(BinShredParser.LABEL, 0); }
		public ITerminalNode BYTES() { return GetToken(BinShredParser.BYTES, 0); }
		public ITerminalNode ITEMS() { return GetToken(BinShredParser.ITEMS, 0); }
		public ITerminalNode AS() { return GetToken(BinShredParser.AS, 0); }
		public ITerminalNode DESCRIBED() { return GetToken(BinShredParser.DESCRIBED, 0); }
		public ITerminalNode BY() { return GetToken(BinShredParser.BY, 0); }
		public ITerminalNode ASCII() { return GetToken(BinShredParser.ASCII, 0); }
		public ITerminalNode UNICODE() { return GetToken(BinShredParser.UNICODE, 0); }
		public ITerminalNode UTF8() { return GetToken(BinShredParser.UTF8, 0); }
		public ITerminalNode UINT64() { return GetToken(BinShredParser.UINT64, 0); }
		public ITerminalNode UINT32() { return GetToken(BinShredParser.UINT32, 0); }
		public ITerminalNode UINT16() { return GetToken(BinShredParser.UINT16, 0); }
		public ITerminalNode INT64() { return GetToken(BinShredParser.INT64, 0); }
		public ITerminalNode INT32() { return GetToken(BinShredParser.INT32, 0); }
		public ITerminalNode INT16() { return GetToken(BinShredParser.INT16, 0); }
		public ITerminalNode SINGLE() { return GetToken(BinShredParser.SINGLE, 0); }
		public ITerminalNode FLOAT() { return GetToken(BinShredParser.FLOAT, 0); }
		public ITerminalNode DOUBLE() { return GetToken(BinShredParser.DOUBLE, 0); }
		public ITerminalNode ADDITIONAL() { return GetToken(BinShredParser.ADDITIONAL, 0); }
		public ITerminalNode PROPERTIES() { return GetToken(BinShredParser.PROPERTIES, 0); }
		public ITerminalNode IDENTIFIED() { return GetToken(BinShredParser.IDENTIFIED, 0); }
		public ITerminalNode FROM() { return GetToken(BinShredParser.FROM, 0); }
		public LabelContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_label; } }
		public override void EnterRule(IParseTreeListener listener) {
			IBinShredListener typedListener = listener as IBinShredListener;
			if (typedListener != null) typedListener.EnterLabel(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBinShredListener typedListener = listener as IBinShredListener;
			if (typedListener != null) typedListener.ExitLabel(this);
		}
	}

	[RuleVersion(0)]
	public LabelContext label() {
		LabelContext _localctx = new LabelContext(Context, State);
		EnterRule(_localctx, 26, RULE_label);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 148;
			_la = TokenStream.La(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BYTES) | (1L << ITEMS) | (1L << AS) | (1L << DESCRIBED) | (1L << BY) | (1L << ASCII) | (1L << UNICODE) | (1L << UTF8) | (1L << UINT64) | (1L << UINT32) | (1L << UINT16) | (1L << INT64) | (1L << INT32) | (1L << INT16) | (1L << SINGLE) | (1L << FLOAT) | (1L << DOUBLE) | (1L << ADDITIONAL) | (1L << PROPERTIES) | (1L << IDENTIFIED) | (1L << FROM) | (1L << LABEL))) != 0)) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
			    Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public static readonly string _serializedATN =
		"\x3\x430\xD6D1\x8206\xAD2D\x4417\xAEF1\x8D80\xAADD\x3%\x99\x4\x2\t\x2"+
		"\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4\t\t"+
		"\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x3\x2\x3"+
		"\x2\a\x2!\n\x2\f\x2\xE\x2$\v\x2\x3\x2\x3\x2\x3\x3\x3\x3\x5\x3*\n\x3\x3"+
		"\x4\x3\x4\x3\x4\x3\x4\a\x4\x30\n\x4\f\x4\xE\x4\x33\v\x4\x3\x4\x3\x4\x3"+
		"\x5\x5\x5\x38\n\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3"+
		"\x5\x3\x5\x3\x5\x5\x5\x45\n\x5\x5\x5G\n\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3"+
		"\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x5\x5S\n\x5\x3\x6\x3\x6\x3\a\x3\a\x3"+
		"\b\x3\b\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x5\t\x62\n\t\x5\t\x64\n\t\x3"+
		"\n\x3\n\x5\nh\n\n\x3\v\x3\v\x3\f\x3\f\x3\f\x3\f\a\fp\n\f\f\f\xE\fs\v\f"+
		"\x3\f\x3\f\x3\r\x5\rx\n\r\x3\r\x3\r\x3\r\a\r}\n\r\f\r\xE\r\x80\v\r\x3"+
		"\r\x3\r\x3\r\x3\r\x3\r\x3\r\a\r\x88\n\r\f\r\xE\r\x8B\v\r\x3\r\x3\r\x3"+
		"\r\x5\r\x90\n\r\x3\xE\x3\xE\x3\xE\x5\xE\x95\n\xE\x3\xF\x3\xF\x3\xF\x2"+
		"\x2\x10\x2\x4\x6\b\n\f\xE\x10\x12\x14\x16\x18\x1A\x1C\x2\x4\x3\x2\xF\x1A"+
		"\x4\x2\n\x1E%%\x9B\x2\x1E\x3\x2\x2\x2\x4)\x3\x2\x2\x2\x6+\x3\x2\x2\x2"+
		"\bR\x3\x2\x2\x2\nT\x3\x2\x2\x2\fV\x3\x2\x2\x2\xEX\x3\x2\x2\x2\x10Z\x3"+
		"\x2\x2\x2\x12g\x3\x2\x2\x2\x14i\x3\x2\x2\x2\x16k\x3\x2\x2\x2\x18w\x3\x2"+
		"\x2\x2\x1A\x94\x3\x2\x2\x2\x1C\x96\x3\x2\x2\x2\x1E\"\x5\x4\x3\x2\x1F!"+
		"\x5\x4\x3\x2 \x1F\x3\x2\x2\x2!$\x3\x2\x2\x2\" \x3\x2\x2\x2\"#\x3\x2\x2"+
		"\x2#%\x3\x2\x2\x2$\"\x3\x2\x2\x2%&\a\x2\x2\x3&\x3\x3\x2\x2\x2\'*\x5\x6"+
		"\x4\x2(*\x5\x16\f\x2)\'\x3\x2\x2\x2)(\x3\x2\x2\x2*\x5\x3\x2\x2\x2+,\x5"+
		"\x1C\xF\x2,-\a\x6\x2\x2-\x31\x5\b\x5\x2.\x30\x5\b\x5\x2/.\x3\x2\x2\x2"+
		"\x30\x33\x3\x2\x2\x2\x31/\x3\x2\x2\x2\x31\x32\x3\x2\x2\x2\x32\x34\x3\x2"+
		"\x2\x2\x33\x31\x3\x2\x2\x2\x34\x35\a\a\x2\x2\x35\a\x3\x2\x2\x2\x36\x38"+
		"\a \x2\x2\x37\x36\x3\x2\x2\x2\x37\x38\x3\x2\x2\x2\x38\x46\x3\x2\x2\x2"+
		"\x39:\x5\x1C\xF\x2:;\a\b\x2\x2;<\x5\x12\n\x2<=\a\v\x2\x2=>\a\t\x2\x2>"+
		"G\x3\x2\x2\x2?\x44\x5\x1C\xF\x2@\x41\a\b\x2\x2\x41\x42\x5\xE\b\x2\x42"+
		"\x43\a\t\x2\x2\x43\x45\x3\x2\x2\x2\x44@\x3\x2\x2\x2\x44\x45\x3\x2\x2\x2"+
		"\x45G\x3\x2\x2\x2\x46\x39\x3\x2\x2\x2\x46?\x3\x2\x2\x2GS\x3\x2\x2\x2H"+
		"I\a\b\x2\x2IJ\a\x1B\x2\x2JK\a\x1C\x2\x2KL\a\x1D\x2\x2LM\a\xE\x2\x2MN\x5"+
		"\n\x6\x2NO\a\x1E\x2\x2OP\x5\f\a\x2PQ\a\t\x2\x2QS\x3\x2\x2\x2R\x37\x3\x2"+
		"\x2\x2RH\x3\x2\x2\x2S\t\x3\x2\x2\x2TU\x5\x1C\xF\x2U\v\x3\x2\x2\x2VW\x5"+
		"\x1C\xF\x2W\r\x3\x2\x2\x2XY\x5\x10\t\x2Y\xF\x3\x2\x2\x2Z[\x5\x12\n\x2"+
		"[\x63\a\n\x2\x2\\]\a\f\x2\x2]\x61\x5\x14\v\x2^_\a\r\x2\x2_`\a\xE\x2\x2"+
		"`\x62\x5\x1C\xF\x2\x61^\x3\x2\x2\x2\x61\x62\x3\x2\x2\x2\x62\x64\x3\x2"+
		"\x2\x2\x63\\\x3\x2\x2\x2\x63\x64\x3\x2\x2\x2\x64\x11\x3\x2\x2\x2\x65h"+
		"\x5\x1C\xF\x2\x66h\a#\x2\x2g\x65\x3\x2\x2\x2g\x66\x3\x2\x2\x2h\x13\x3"+
		"\x2\x2\x2ij\t\x2\x2\x2j\x15\x3\x2\x2\x2kl\x5\f\a\x2lm\a\x6\x2\x2mq\x5"+
		"\x18\r\x2np\x5\x18\r\x2on\x3\x2\x2\x2ps\x3\x2\x2\x2qo\x3\x2\x2\x2qr\x3"+
		"\x2\x2\x2rt\x3\x2\x2\x2sq\x3\x2\x2\x2tu\a\a\x2\x2u\x17\x3\x2\x2\x2vx\a"+
		" \x2\x2wv\x3\x2\x2\x2wx\x3\x2\x2\x2x\x8F\x3\x2\x2\x2y~\x5\x1A\xE\x2z{"+
		"\a\x4\x2\x2{}\x5\x1A\xE\x2|z\x3\x2\x2\x2}\x80\x3\x2\x2\x2~|\x3\x2\x2\x2"+
		"~\x7F\x3\x2\x2\x2\x7F\x81\x3\x2\x2\x2\x80~\x3\x2\x2\x2\x81\x82\a\x6\x2"+
		"\x2\x82\x83\a\x3\x2\x2\x83\x90\x3\x2\x2\x2\x84\x89\x5\x1A\xE\x2\x85\x86"+
		"\a\x4\x2\x2\x86\x88\x5\x1A\xE\x2\x87\x85\x3\x2\x2\x2\x88\x8B\x3\x2\x2"+
		"\x2\x89\x87\x3\x2\x2\x2\x89\x8A\x3\x2\x2\x2\x8A\x8C\x3\x2\x2\x2\x8B\x89"+
		"\x3\x2\x2\x2\x8C\x8D\a\x6\x2\x2\x8D\x8E\x5\x1C\xF\x2\x8E\x90\x3\x2\x2"+
		"\x2\x8Fy\x3\x2\x2\x2\x8F\x84\x3\x2\x2\x2\x90\x19\x3\x2\x2\x2\x91\x95\x5"+
		"\x1C\xF\x2\x92\x95\a#\x2\x2\x93\x95\a$\x2\x2\x94\x91\x3\x2\x2\x2\x94\x92"+
		"\x3\x2\x2\x2\x94\x93\x3\x2\x2\x2\x95\x1B\x3\x2\x2\x2\x96\x97\t\x3\x2\x2"+
		"\x97\x1D\x3\x2\x2\x2\x12\")\x31\x37\x44\x46R\x61\x63gqw~\x89\x8F\x94";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
