using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Turing
{
    public class Practice_2
    {
        public void main()
        {
            //// Function call
            if (IsValid(Console.ReadLine()))
                Console.WriteLine("Balanced ");
            else
                Console.WriteLine("Not Balanced ");

        }
        public bool isMatchingPair(char character1, char character2)
        {
            if (character1 == '(' && character2 == ')')
                return true;
            else if (character1 == '{' && character2 == '}')
                return true;
            else if (character1 == '[' && character2 == ']')
                return true;
            else
                return false;
        }


        // Return true if expression has balanced
        // Brackets
        public bool IsValid(string s)
        {
            char[] exp = s.ToCharArray();
            // Declare an empty character stack */
            Stack<char> st = new Stack<char>();

            // Traverse the given expression to
            //   check matching brackets
            for (int i = 0; i < exp.Length; i++)
            {
                // If the exp[i] is a starting
                // bracket then push it
                if (exp[i] == '{' || exp[i] == '('
                    || exp[i] == '[')
                    st.Push(exp[i]);

                //  If exp[i] is an ending bracket
                //  then pop from stack and check if the
                //   popped bracket is a matching pair
                if (exp[i] == '}' || exp[i] == ')'
                    || exp[i] == ']')
                {

                    // If we see an ending bracket without
                    //   a pair then return false
                    if (st.Count == 0)
                    {
                        return false;
                    }

                    // Pop the top element from stack, if
                    // it is not a pair brackets of
                    // character then there is a mismatch. This
                    // happens for expressions like {(})
                    else if (!isMatchingPair(st.Pop(),
                                             exp[i]))
                    {
                        return false;
                    }
                }
            }

            // If there is something left in expression
            // then there is a starting bracket without
            // a closing bracket

            if (st.Count == 0)
                return true; // balanced
            else
            {
                // not balanced
                return false;
            }
        }


        //public int CalPoints(string[] ops)
        //{
        //    int[] points = new int[ops.Length];
        //    int flag = 0;
        //    for (int i=0; i< ops.Length;i++)
        //    { 
        //      string current = ops[i];
        //        if (!string.IsNullOrEmpty(current) && current == "C")
        //        {
        //            if (i > 0)
        //            {
        //                int previous1 = points[flag - 1];
        //                //int previous2 = Int32.Parse(ops[i - 2]);
        //                points = points.Where(val => val != previous1).ToArray();
        //                flag--;
        //            }

        //        }
        //        else if (!string.IsNullOrEmpty(current) && current == "D")
        //        {
        //            if (i > 0)
        //            {
        //                int previous1 = points[flag - 1];
        //                int value = previous1 + previous1;
        //                points[flag] = value;
        //                flag++;
        //                //ops = ops.Where(val => Int32.Parse(val) != previous1).ToArray();

        //            }

        //        }
        //        else if (!string.IsNullOrEmpty(current) && current == "+")
        //        {
        //            if (i > 0)
        //            {
        //                int previous1 = points[flag - 1];
        //                int previous2 = points[flag - 2];
        //                int value = previous1 + previous2;
        //                points[flag] = value;
        //                flag++;

        //            }

        //        }
        //        else
        //        {
        //            points[flag] = Int32.Parse(current);
        //            flag++;

        //        }
        //    }
        //    //int sum = points.Sum();
        //    return points.Sum();
        //}
    }
}
