using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace yyscamper.ProgCalc
{
	public enum VarChangeMode : int
	{
		ADD_NEW = 1,
		UPDATE = 2
	};

    /// <summary>
    ///                        8        0
    /// --------------------------------
    /// </summary>
    public enum Operator : int {
        NULL = 0,
        LPAR = 1, // (
        RPAR,     // )
        ADD,
        SUB,
        MUL,
        DIV,
        SQRT,
        PER, //percent
        SQUARE, //x^2
        POW, //x^y
        RECIP, //1/x
        CUBE, //x^3
        LOG2, //log2
        LOG10, //log10
        LOG,   //log(x, y)
        POW2,  //2^x
        MOD    //mod
    };

    enum OperatorPriority : int
    {
        PRI0 = 0, // (, ), 
        PRI1 = 1, // sign(+-), &, !, ~, ^, log, sqrt, square, cube, 1/x
        PRI2 = 2, // *, /
        PRI3 = 3, // +, -

        LOWEST = 4
    };

    class OperatorConvert
    {
        static Operator Parse(String str)
        {
            str = str.ToLower();
            if (str.Equals('('))
                return Operator.LPAR;
            else if (str.Equals("+"))
            {
                return Operator.ADD;
            }
            else if (str.Equals("-"))
            {
                return Operator.SUB;
            }
            else if (str.Equals("*"))
            {
                return Operator.MUL;
            }
            else if (str.Equals("/"))
            {
                return Operator.DIV;
            }
            else if (str.Equals("sqrt"))
            {
                return Operator.SQRT;
            }
            else if (str.Equals("%"))
            {
                return Operator.PER;
            }
            else if (str.Equals("^"))
            {
                return Operator.POW;
            }
            return Operator.NULL;
        }
    }
}
