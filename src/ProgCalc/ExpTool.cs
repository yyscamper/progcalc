using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using CalcEngine;

namespace yyscamper.ProgCalc
{
    public class CalcVar
    {
        public string name;
        public object value;

        public CalcVar()
        {
            this.name = string.Empty;
            this.value = 0;
        }

        public CalcVar(string name, object value, string desp)
        {
            this.name = name == null ? "unname" : name;
            this.value = value == null ? 0 : value;
        }

		public static object ParseValue(string str)
		{
			object varObj = null;
			try
			{
				varObj = Int64.Parse(str);
			}
			catch
			{
				try
				{
					varObj = Double.Parse(str);
				}
				catch
				{
					varObj = str.Trim();
				}
			}

			return varObj;
		}

		public static string ValidateName(string name)
		{
			if (name == null || name.Trim().Length <= 0)
			{
				throw new Exception("Variable Name Error: Emptry name");
			}
			string s = name.Trim();
			if (s[0] >= '0' && s[0] <= '9')
			{
				throw new Exception("Variable Name Error: First character should not be digit");
			}

			foreach (char ch in name)
			{
				if (ch >= '0' && ch <= '9'
					|| ch >= 'a' && ch <= 'z'
					|| ch >= 'A' && ch <= 'Z'
					|| ch == '_')
				{
					continue;
				}

				throw new Exception("Variable Name Error: Invalid character");
			}

			return name;
		}
    }

    public class ExpTool
    {
        public  IntegerFormat m_numFmt;
        private  CalcEngine.CalcEngine m_calcEngine;
        private static ExpTool m_instance = null;
        private  Dictionary<string, object> m_varList;

        private ExpTool()
        {
            m_numFmt = IntegerFormat.DEC;
            m_calcEngine = new CalcEngine.CalcEngine();
            m_varList = new Dictionary<string, object>();
        }

        public CalcVar[] GetAllVariables()
        {
            CalcVar[] allvar = new CalcVar[m_calcEngine.Variables.Count];
            int i = 0;

			if (m_calcEngine.Variables.ContainsKey("ans"))
			{
				allvar[i] = new CalcVar();
				allvar[i].name = "ans";
				allvar[i].value = m_calcEngine.Variables["ans"];
				i++;
			}

            foreach ( string key in m_calcEngine.Variables.Keys)
            {
				if (key.Equals("ans"))
					continue;

				allvar[i] = new CalcVar();

				allvar[i].name = key;
				allvar[i].value = m_calcEngine.Variables[key];
				i++;
            }
            return allvar;
        }

        public void SetVariables(CalcVar[] allvar)
        {
			m_calcEngine.Variables.Clear();

            foreach (CalcVar var in allvar)
            {
				m_calcEngine.Variables.Add(var.name, var.value);
            }
        }

		public void ClearVariables()
		{
			m_calcEngine.Variables.Clear();
		}

		public void DeleteVariable(string name)
		{
			m_calcEngine.Variables.Remove(name);
		}

        public void AddVariable(string name, object val)
        {
			if (name != null && val != null)
				m_calcEngine.Variables.Add(name, val);
        }

		public void UpdateVariable(string name, object val)
		{
			if (name == null || val == null)
				return;

			if (m_calcEngine.Variables.ContainsKey(name))
				m_calcEngine.Variables.Remove(name);
			else
				return;

			m_calcEngine.Variables.Add(name, val);
		}

        public CalcEngine.CalcEngine Engine
        {
            get { return m_calcEngine; }
        }

        static public ExpTool GetInstance()
        {
            if (m_instance == null)
                m_instance = new ExpTool();
            return m_instance;
        }

        static private bool ParseBinStr(string s, ref Int64 val)
        {
            Int64 tmp = 0;
            Int64 flag = 0x01;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                char ch = s[i];
                if (ch == ',' || ch == ' ')
                    continue;
                else if (ch == '1')
                    tmp |= flag;
                else if (ch != '0')
                    return false;
                flag = (flag << 1);
            }
            val = tmp;
            return true;
        }

        public Object Eva(String str, CalcMode calcMode, IntegerFormat fmt, IntegerBits numBits, bool updateAnswer)
        {
            Int64 result = 0;
            if (str.Length < 1)
                return false;
            try
            {
                m_numFmt = fmt;
                switch (fmt)
                {
                    case IntegerFormat.DEC:
                        Object obj = m_calcEngine.Evaluate(str, calcMode, numBits, fmt);
						if (obj != null && updateAnswer)
						{
							if (m_calcEngine.Variables.ContainsKey("ans"))
								UpdateVariable("ans", obj);
							else
								AddVariable("ans", obj);
						}
                        return obj;
                    case IntegerFormat.HEX:
                        return Int64.Parse(str, System.Globalization.NumberStyles.HexNumber);
                    case IntegerFormat.BIN:
                        if (ParseBinStr(str, ref result))
                            return result;
                        else
                            throw new ArgumentException();
                    default:
                        return null;
                }
            }
            catch (Exception _ex)
            {
                throw _ex;
            }
        }
    }
}
