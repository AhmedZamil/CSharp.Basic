using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Stack
{
    public class Pro_MaxNumber
    {
        public void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            string[] ops = new string[n];

            for (int i = 0; i < n; i++)
            {
                string opsItem = Console.ReadLine();
                ops[i]=opsItem;
            }

            int[] res = getMax(ops);

            Console.WriteLine(String.Join("\n", res));


        }

        public  int[] getMax(string[] operations)
        {
            int[] res = new int[operations.Length];
            int index = 0;
            Stack<int> stack = new Stack<int>();

            foreach (string op in operations)
            {
                string[] singleOp = op.Split(" ");
                if (singleOp[0] == "1")
                { 
                  stack.Push(Int32.Parse(singleOp[1]));
                }
                else if (singleOp[0] == "2")
                {
                    stack.Pop();
                }
                else if (singleOp[0] == "3")
                {
                    //Console.WriteLine(stack.Max());
                    res[index++] = stack.Max();
                }

            }

            return res;
        }
    }
}
