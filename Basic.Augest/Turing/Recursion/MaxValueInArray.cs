using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Turing.Recursion
{
    public class MaxValueInArray
    {
        public void Main()
        {
            int[] arr = { 12, 10, 30, 50, 100 };
            Console.Write(" " + fun(arr, 5) + " ");

        }

        //fun() returns the maximum value in the input array a[] of size n.


        public int fun(int[] a, int n)
        {
            int x;
            if (n == 1)
                return a[0];
            else
                x = fun(a, n - 1);
            if (x > a[n - 1])
                return x;
            else
                return a[n - 1];
        }
    }
}
