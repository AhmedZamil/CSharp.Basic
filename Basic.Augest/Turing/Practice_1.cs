using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Turing
{

    public class Practice_1
    {

        // Return true if expression has balanced
        // Brackets

        public void Main()
        {


        }


        public int CalPoints(string[] ops)
        {
            int[] points = new int[ops.Length];
            int flag = 0;
            for (int i = 0; i < ops.Length; i++)
            {
                string current = ops[i];
                if (!string.IsNullOrEmpty(current) && current == "C")
                {
                    if (i > 0)
                    {
                        int previous1 = points[flag - 1];
                        //int previous2 = Int32.Parse(ops[i - 2]);
                        points = points.Where(val => val != previous1).ToArray();
                        flag--;
                    }

                }
                else if (!string.IsNullOrEmpty(current) && current == "D")
                {
                    if (i > 0)
                    {
                        int previous1 = points[flag - 1];
                        int value = previous1 + previous1;
                        points[flag] = value;
                        flag++;
                        //ops = ops.Where(val => Int32.Parse(val) != previous1).ToArray();

                    }

                }
                else if (!string.IsNullOrEmpty(current) && current == "+")
                {
                    if (i > 0)
                    {
                        int previous1 = points[flag - 1];
                        int previous2 = points[flag - 2];
                        int value = previous1 + previous2;
                        points[flag] = value;
                        flag++;

                    }

                }
                else
                {
                    points[flag] = Int32.Parse(current);
                    flag++;

                }
            }
            //int sum = points.Sum();
            return points.Sum();
        }
    }
}
