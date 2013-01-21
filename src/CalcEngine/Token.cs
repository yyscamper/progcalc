using System;
using System.Reflection;
using System.Collections.Generic;
using System.Globalization;

namespace CalcEngine
{
    /// <summary>
	/// Represents a node in the expression tree.
    /// </summary>
    public class Token
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

		static public object FormatValue(object val, 
									CalcMode  calcMode, 
									IntegerBits  intBits,
									IntegerFormat  intFmt)
		{
			double v;

            if (val is string)
                return val;

			if (val is double)
			{
				v = (double)val;
			}

			// handle booleans
			if (val is bool)
			{
				v = 1.0;
			}

			// handle nulls
			if (val == null)
			{
				v = 0;
			}

			// handle everything else
			v = (double)Convert.ChangeType(val, typeof(double));

			if (calcMode == CalcMode.FLOAT)
			{
				return (double)v;
			}
			else if (calcMode == CalcMode.INTEGER_SIGNED)
			{
				if (intBits == IntegerBits.BITS_64)
				{
					return (Int64)v;
				}
				else if (intBits == IntegerBits.BITS_32)
				{
					return (Int32)v;
				}
				else if (intBits == IntegerBits.BITS_16)
				{
					return (Int16)v;
				}
				else if (intBits == IntegerBits.BITS_8)
				{
					return (SByte)v;
				}
				else
				{
					throw new Exception("Invalid Integer Bits");
				}
			}
			else if (calcMode == CalcMode.INTEGER_UNSIGNED)
			{
				if (intBits == IntegerBits.BITS_64)
				{
					return (UInt64)v;
				}
				else if (intBits == IntegerBits.BITS_32)
				{
					return (UInt32)v;
				}
				else if (intBits == IntegerBits.BITS_16)
				{
					return (UInt16)v;
				}
				else if (intBits == IntegerBits.BITS_8)
				{
					return (Byte)v;
				}
				else
				{
					throw new Exception("Invalid Integer Bits");
				}
			}
			else
			{
				throw new Exception("Invalid Calculate Mode");
			}
		}
    }
    /// <summary>
    /// Token types (used when building expressions, sequence defines operator priority)
    /// </summary>
	public enum TKTYPE
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
	public enum TKID
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

    public enum IntegerFormat : int
    {
        DEC = 0,
        HEX,
        BIN,
        CHAR,
        BINBOX
    };

	public enum IntegerBits : int
	{
		BITS_8 = 8,
		BITS_16 = 16,
		BITS_32 = 32,
		BITS_64 = 64,
	};

    public enum CalcMode : int
    {
        FLOAT = 0,
		INTEGER_SIGNED = 1,
		INTEGER_UNSIGNED = 2,

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
