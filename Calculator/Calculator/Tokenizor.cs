using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Tokenizor
    {
        public List<string> tokens = new List<string>()
        {    
            "(", ")", ",",
            "+", "-", "*", "/", "%", "^",
            "|", "&", "!", "->", "<-", "<->",
            "Sqrt", "Nroot" 
        };                      //token
        public static List<char> numberList = new List<char>()
        {
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
        };
        public static List<string> ignoredList = new List<string>()
        {
            "\n"
        };
        public Tokenizor()
        {

        }
        public Tokenizor(ICollection<string> list)
        {
            AddToken(list);
        }
        public void AddToken(ICollection<string> newtokens)
        {
            //this.tokens = this.tokens.AddRange(newtokens);
            foreach (string s in newtokens)
                tokens.Add(s);
        }
        //tokenization:
        public List<string> Tokenize(string input)
        {
            string token = "";
            var list = new List<string>();
            foreach (char c in input)
            {
                if (c != ' ')
                {
                    token += c;
                    if (tokens.Contains(token))
                    {
                        list.Add(token);
                        token = "";
                    }
                }
            }
            if (token.Trim() != "") throw new Exception("unexpected token!");
            return list;
        }

        public List<string> Tokenize(string input, List<char> composition)
        {
            string token = "";
            var list = new List<string>();
            var composite = "";
            foreach (char c in input)
            {
                if (c != ' ')
                {
                    if (composition.Contains(c))
                        composite += c;
                    else
                    {
                        token += c;
                        if (tokens.Contains(token))
                        {
                            if (composite != "") list.Add(composite);
                            composite = "";
                            list.Add(token);
                            token = "";
                        }
                        else if (ignoredList.Contains(token))
                            token = "";
                    }
                }
            }
            if (composite != "") list.Add(composite);
            if (token.Trim() != "") throw new Exception("unexpected token!");
            return list;
        }

        public List<string> TokenizeNumber(string input)
        {
            return Tokenize(input, numberList);
        }
    }
}
