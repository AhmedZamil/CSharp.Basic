using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Turing.Recursion
{
    public class NumSeries
    {
        public void Main()
        {
            fun1(21);
        }

        //Total numbers of stars printed is
        //equal to 1 + 2 + …. (n-2) + (n-1) + n, which is n(n+1)/2. 
        public void fun1(int n)
        {
            int i = 0;
            if (n > 1)
                fun1(n - 1);
            for (i = 0; i < n; i++)
                Console.Write(" * ");
        }
    }
}
