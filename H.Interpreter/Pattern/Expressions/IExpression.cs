using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.Interpreter.Pattern.Expressions
{
    interface IExpression
    {
        int Interpret(Context context);
    }
}
