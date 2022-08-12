using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Turing.Recursion
{
    public class Log2N
    {
        public void Main()
        { 
        
        }

        public int fun1(int n)
        {
            if (n == 1)
                return 0;
            else
                return 1 + fun1(n / 2);
        }
    }
}
