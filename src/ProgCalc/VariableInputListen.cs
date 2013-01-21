using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace yyscamper.ProgCalc
{
	public interface VariableInputListen
	{
		void VariableInputCallback(string varName, object varValue, VarChangeMode mode);
	}
}
