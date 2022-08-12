using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Turing
{
    public class CountSpecialString
    {
        /*Given the length N of the string,
         * we have to find the number of special strings of length N. 
A string is called a special string if it consists only of lowercase 
        letters a and b and there is at least one b between two a’s in the string.
        Since the number 
        of strings may be very large, therefore print it modulo 10^9+7. */

        public void Main()
        {
            // Initialise n
            int n = 3;

            Console.Write(count_special(n) + "\n");

        }

        public int count_special(int n)
        {
            const int mod = 1000000007;
            // Stores the answer for a
            // particular value of n
            int[] fib = new int[n + 1];

            // For n = 0 we have empty String
            fib[0] = 1;

            // For n = 1 we have
            // 2 special Strings
            fib[1] = 2;

            for (int i = 2; i <= n; i++)
            {

                // Calculate count of special
                // String of length i
                fib[i] = (fib[i - 1] % mod +
                          fib[i - 2] % mod) % mod;
            }

            // fib[n] stores the count of
            // special Strings of length n
            return fib[n];
        }
    }
}
