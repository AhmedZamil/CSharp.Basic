using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Stack
{
    public class Prob_Balanced_Brackets
    {

        public void Main()
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string s = Console.ReadLine();

                string result = isBalanced(s);

                Console.WriteLine(result);
            }

        }

        public string isBalanced(string s)
        {
            char[] braces = s.ToCharArray();
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < braces.Length; i++)
            {
                if (braces[i] == '(' || braces[i] == '{' || braces[i] == '[')
                {
                    stack.Push(braces[i]);
                }
                if (braces[i] == ')' || braces[i] == '}' || braces[i] == ']')
                {
                    if (stack.Count == 0) return "NO";
                    else if (!isMatchingPair(stack.Pop(), braces[i]))
                    {
                        return "NO";
                    }
                }


            }

            if (stack.Count == 0) return "YES";
            else return "NO";
        }

        public bool isMatchingPair(char char1, char char2)
        {
            if (char1 == '(' && char2 == ')') return true;
            else if (char1 == '{' && char2 == '}') return true;
            else if (char1 == '[' && char2 == ']') return true;
            else
            { return false; }

        }

        //public string isBalanced(string s)
        //{
        //    char[] braces = s.ToCharArray();

        //    Stack<char> stack = new Stack<char>();

        //    for (int i=0; i<braces.Length;i++)
        //    {
        //        if (braces[i]=='(' || braces[i] == '{'|| braces[i] == '[')
        //        { 
        //            stack.Push(braces[i]);
        //        }
        //        if (braces[i] == ')' || braces[i] == '}' || braces[i] == ']')
        //        {
        //            if (stack.Count == 0) return "NO";
        //            else if (!IsMatchedPair(stack.Pop(), braces[i])) {
        //                return "NO";
        //            }               
        //        }           
        //    }

        //    if (stack.Count == 0) return "YES";
        //    else return "NO";
        //}

        //public bool IsMatchedPair(char char1,char char2)
        //{
        //    if (char1 == '(' && char2 == ')') return true;
        //    else if (char1 == '{' && char2 == '}') return true;
        //    else if (char1 == '[' && char2 == ']') return true;
        //    else
        //    {
        //        return false;
        //    }

        //}
    }


}
