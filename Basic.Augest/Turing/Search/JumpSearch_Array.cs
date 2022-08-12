using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Turing.Search
{
    public class JumpSearch_Array
    {

        //Like Binary Search, Jump Search is a searching algorithm for sorted arrays.
        //The basic idea is to check fewer elements (than linear search) by jumping ahead
        //by fixed steps or skipping some elements in place of searching all elements.
        public void Main()
        {
            int[] arr = { 0, 1, 1, 2, 3, 5, 8, 13, 21,
                    34, 55, 89, 144, 233, 377, 610};
            int x = 55;

            // Find the index of 'x' using Jump Search
            int index = jumpSearch(arr, x);

            // Print the index where 'x' is located
            Console.Write("Number " + x +
                                " is at index " + index);

        }

        public int jumpSearch(int[] arr, int x)
        {
            int n = arr.Length;

            // Finding block size to be jumped
            int step = (int)Math.Sqrt(n);

            // Finding the block where element is
            // present (if it is present)
            int prev = 0;
            while (arr[Math.Min(step, n) - 1] < x)
            {
                prev = step;
                step += (int)Math.Sqrt(n);
                if (prev >= n)
                    return -1;
            }

            // Doing a linear search for x in block
            // beginning with prev.
            while (arr[prev] < x)
            {
                prev++;

                // If we reached next block or end of
                // array, element is not present.
                if (prev == Math.Min(step, n))
                    return -1;
            }

            // If element is found
            if (arr[prev] == x)
                return prev;

            return -1;
        }
    }
}
