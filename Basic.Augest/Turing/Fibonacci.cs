using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Turing
{
    public class Fibonacci
    {
        public void Main()
        {
            // Initialize variable n.
            int n = 5;
            Console.Write("Fibonacci series of 5 numbers is: ");

            // for loop to print the fibonacci series.
            for (int i = 0; i < n; i++)
            {
                Console.Write(fib(i) + " ");
            }

        }

        public int fib(int n)
        {

            // Stop condition
            if (n == 0)
                return 0;

            // Stop condition
            if (n == 1 || n == 2)
                return 1;

            // Recursion function
            else
                return (fib(n - 1) + fib(n - 2));
        }
    }
}
