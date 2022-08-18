using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Turing.Arrays
{
    public class Find_Single_element_Appare_Only
    {
        public void Main()
        {
            int[] ar = { 2, 3, 5, 4, 5, 3, 4 };
            int n = ar.Length;
            Console.Write("Element occurring once is " +
                                findSingle(ar, n) + " ");

        }

        public int single(int[] arr, int n)
        {
            int ones = 0, twos = 0;
            int common_bit_mask;

            for (int i = 0; i < n; i++)
            {
                twos = twos | (ones & arr[i]);
                ones = ones ^ arr[i];
                common_bit_mask = ~(ones & twos);
                ones &= common_bit_mask;
                twos &= common_bit_mask;
            }
            return ones;
        }

        public int findSingle(int[] ar, int ar_size)
        {
            // Do XOR of all elements and return
            int res = ar[0];
            for (int i = 1; i < ar_size; i++)
                res = res ^ ar[i];

            return res;
        }


    }
}
