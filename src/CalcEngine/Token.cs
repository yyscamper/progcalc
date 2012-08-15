using System;
using System.Reflection;
using System.Collections.Generic;
using System.Globalization;

namespace CalcEngine
{
    /// <summary>
	/// Represents a node in the expression tree.
    /// </summary>
    internal class Token
	{
        // ** fields
		public TKID ID;
        public TKTYPE Type;
        public object Value;

        // ** ctor
        public Token(object value, TKID id, TKTYPE type)
        {
            Value = value;
            ID = id;
			Type = type;
		}
    }
    /// <summary>
    /// Token types (used when building expressions, sequence defines operator priority)
    /// </summary>
    internal enum TKTYPE
    {
        LOGIC_BITS_OR,    // |
        LOGIC_BITS_AND,   // &
        COMPARE,	// < > = <= >=
        SHIFT,      // << >>
        ADDSUB,		// + -
        MULDIV,		// * /
        POWER,		// ^
        LOGIC_BITS_NOT,  //~
        NUM_MODE,   //@: hex mode
        GROUP,		// ( ) , .
        LITERAL,	// 123.32, "Hello", etc.
        IDENTIFIER  // functions, external objects, bindings
    }
    /// <summary>
    /// Token ID (used when evaluating expressions)
    /// </summary>
    internal enum TKID
    {
        BITSOR, //LOGICOR
        BITSAND, //LOGICAND
        GT, LT, GE, LE, EQ, NE, // COMPARE
        ADD, SUB, // ADDSUB
        LSHIFT, RSHIFT, //SHIFT
        MUL, DIV, DIVINT,// MULDIV
        POWER, // POWER
        BITSNOT,
        NUMHEX, NUMBIN, //NUM_MODE
        OPEN, CLOSE, END, COMMA, PERIOD, // GROUP
        ATOM, // LITERAL, IDENTIFIER
    }

    public enum NumberFormat : int
    {
        DEC = 0,
        HEX,
        BIN,
    };

    public enum OperationType : int
    {
        NATIVE = 0,

        INT_ANY,
        ROUND_ANY,
        CEIL_ANY,
        FLOOR_ANY,

        INT_FINAL,
        ROUND_FINAL,
        CEIL_FINAL,
        FLOOR_FINAL
    };

    public class FormatChar
    {
        public const char HEX_NUM = '#';
        public const char BIN_NUM = '?';
        public const char DATETIME = '@';
        public const char STRING = '\"';
    }
}
