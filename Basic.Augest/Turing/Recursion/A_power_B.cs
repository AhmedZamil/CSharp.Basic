using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Turing.Recursion
{
    public class A_power_B
    {
        public void Main()
        {
            Console.WriteLine(fun(4, 3));

        }
        public int fun(int a, int b)
        {
            if (b == 0)
                return 1;
            if (b % 2 == 0)
                return fun(a * a, b / 2);

            return fun(a * a, b / 2) * a;
        }
    }
}
