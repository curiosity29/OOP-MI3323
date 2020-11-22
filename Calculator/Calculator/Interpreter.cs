using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Calculator
{
    public class Interpreter
    {
        #region basic identifier
        static List<string> operatorList = new List<string>()
        {
            "+", "-", "*", "/", "^", 
            "|", "&", "!", "%", "->", "<->",
            "Sqrt", "Nroot"
        };                           //operator
        static int GetPriority(string s)
        {
            switch (s)
            {
                case "+":
                case "-":
                    return 1;
                case "*":
                case "/":
                    return 2;
                case "^":
                    return 3;
                case "Sqrt": return 4;
                case "Nroot": return 4;
                default: throw new Exception("unrecognized operator");
            }
        }

        public static bool IsOperator(string s)
        {
            foreach (string op in operatorList) if (s == op) return true;
            return false;
        }
        public static bool IsOperand(string s)
        {
            throw new NotImplementedException("khong lam ma doi co an");
        }

        #endregion
        public static double ReadValue(object x, Dictionary<string, double> dict)
        {
            double a;
            if (double.TryParse(x.ToString(), out a))
                return double.Parse(x.ToString());
            else
                return dict[x.ToString()];

        }

        // convert infix notation (input) to postfix notation
        public static List<string> infixToPostfix(List<string> expression)
        {
            var result = new List<string>();
            var stack = new Stack<string>();
            foreach (string s in expression)
            {
                if (IsOperator(s))
                {
                    //push all operator got more priority than s to stack then push s
                    while (stack.Count > 0 && GetPriority(s) <= GetPriority(stack.Peek())) result.Add(stack.Pop());    // a*a+b --> meet + push(*)
                    stack.Push(s);
                }
                else if (s == "(") stack.Push(s);
                //  If s is ")", pop and output from the stack   
                // until an "(" is encountered.  
                else if (s == ")")
                {
                    while (stack.Peek() != "(") result.Add(stack.Pop());
                    stack.Pop();
                }
                //  push opperand
                else result.Add(s);
            }
            //push remain
            while (stack.Count > 0) result.Add(stack.Pop());
            return result;
        }
        public static List<string> infixToPostfix2(List<string> expression)
        {
            var result = new List<string>();
            var stack = new Stack<string>();
            foreach (string s in expression)
            {
                if (IsOperator(s))
                {
                    //push all operator got more priority than s to stack then push s
                    while (stack.Count > 0 && GetPriority(s) <= GetPriority(stack.Peek())) result.Add(stack.Pop());    // a*a+b --> meet + push(*)
                    stack.Push(s);
                }
                else if (s == "(") stack.Push(s);
                //  If s is ")", pop and output from the stack   
                // until an "(" is encountered.  
                else if (s == ")")
                {
                    while (stack.Peek() != "(") result.Add(stack.Pop());
                    stack.Pop();
                }
                else if(s == ",")   // complete var in each slot (x,y)
                    while (stack.Peek() != "(") result.Add(stack.Pop());
                //  push opperand
                else result.Add(s);
            }
            //push remain
            while (stack.Count > 0) result.Add(stack.Pop());
            return result;
        }
        
    }
}
