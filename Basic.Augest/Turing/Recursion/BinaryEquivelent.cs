using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Turing.Recursion
{
    public class BinaryEquivelent
    {

        void fun2(int n)
        {
            if (n == 0)
                return;

            fun2(n / 2);
            Console.Write(n % 2);
        }
    }
}
