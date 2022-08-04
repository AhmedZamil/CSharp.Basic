using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Delegates
{
    public class Function
    {

        public static int SumOf(int x, int y) 
        {        
        return x + y;
        }

        public static void Use_Function() {

            Func<int, int, int> add = SumOf;

            int result = add(15, 16);
            Console.WriteLine("Using Delegate sum : {0}", result);
        
        
        }
    }
}
