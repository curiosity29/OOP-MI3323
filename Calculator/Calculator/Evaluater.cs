using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Calculator.Interpreter;
using static System.Math;
namespace Calculator
{
    public class Evaluator
    {
        public static readonly List<string> binaryOperatorList = new List<string>
        {
            "+", "-", "*", "/", "^", "%",
            "Nroot"
        };
        public static readonly List<string> unaryOperatorList = new List<string>
        {
            "Sqrt"
        };
        public static readonly List<string> boolOperatorList = new List<string>
        {
            "|", "^", "&", "->", "<-", "<->"
        };
        #region evaluate operator
        public static double EvalBinaryOperator(double x, double y, string op)
        {
            switch (op)
            {
                case "+": return x + y;
                case "-": return x - y;
                case "*": return x * y;
                case "/": return x / y;
                case "^": return Math.Pow(x, y);
                case "%":
                    if (x == (int)x && y == (int)y)
                        return (int)x % (int)y;
                    else throw new InvalidOperationException("cant use % with non-integer number");
                case "Nroot": return Math.Pow(x, 1/y);
                default: throw new Exception("unrecognized operato" +
                    "r");
            }
        }
        public static bool EvalBoolOperator(bool x, bool y, string op)
        {
            switch (op)
            {
                case "|": return x || y;
                case "&": return x && y;
                case "^": return x ^ y;
                case "->": return !x || y;
                case "<->": return x = y;
                case "<-": return x || !y;
                default: throw new InvalidOperationException("unrecognized operator");
            }
        }
        public static double EvalUnaryOperator(double x, string op)
        {
            switch (op)
            {
                case "Sqrt": return Sqrt(x);

                default: throw new InvalidOperationException("unrecognized operator");
            }
        }
        #endregion

        public static double EvalPostfix(List<string> postfix, Dictionary<string, double> dict)
        {
            double result, d1, d2;
            Stack<object> stack = new Stack<object>();
            foreach (string s in postfix)
            {
                if (IsOperator(s))
                {
                    if(binaryOperatorList.Contains(s))
                    {
                        d1 = ReadValue(stack.Pop(), dict);
                        d2 = ReadValue(stack.Pop(), dict);
                        result = EvalBinaryOperator(d2, d1, s);
                        stack.Push(result);
                    }
                    if(unaryOperatorList.Contains(s))
                    {
                        d1 = ReadValue(stack.Pop(), dict);
                        result = EvalUnaryOperator(d1, s);
                        stack.Push(result);
                    }
                }
                else
                    stack.Push(s);
            }
            return double.Parse(stack.Pop().ToString());
        }

    }
    public class StringEvaluater
    {

        public static double Eval(string expression, Dictionary<string, double> dict)
        {
            return Evaluator.EvalPostfix(
                Interpreter.infixToPostfix2((new Tokenizor()).TokenizeNumber(expression))
                , dict);
        }
    }
}
