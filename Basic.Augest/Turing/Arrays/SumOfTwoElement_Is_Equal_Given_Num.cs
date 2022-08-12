using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Turing.Arrays
{
    public class SumOfTwoElement_Is_Equal_Given_Num
    {
        public void Main()
        {
            int[] A = { 0, -1, 2, -3, 1 };
            int x = -2;
            int size = A.Length;

            if (chkPair(A, size, x))
            {
                Console.WriteLine("Valid pair exists");
            }
            else
            {
                Console.WriteLine("No valid pair exists for " + x);
            }

        }

        public bool chkPair(int[] A, int size, int x)
        {
            for (int i = 0; i < (size - 1); i++)
            {
                for (int j = (i + 1); j < size; j++)
                {
                    if (A[i] + A[j] == x)
                    {
                        Console.WriteLine("Pair with a given sum " + x +
                                           " is (" + A[i] + ", " + A[j] + ")");


                        return true;
                    }
                }
            }

            return false;
        }
    }
}
