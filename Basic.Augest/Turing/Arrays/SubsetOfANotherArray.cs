using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Turing.Arrays
{
    public class SubsetOfANotherArray
    {
        public void Main()
        {
            int[] arr1 = { 11, 1, 13, 21, 3, 7 };
            int[] arr2 = { 11, 3, 7, 1 };

            int m = arr1.Length;
            int n = arr2.Length;

            if (isSubset(arr1, arr2, m, n))
                Console.WriteLine("arr2[] is subset"
                                  + " of arr1[] ");
            else
                Console.WriteLine("arr2[] is not a "
                                  + "subset of arr1[]");


        }

        public bool isSubset(int[] arr1, int[] arr2, int m,
                     int n)
        {
            int i = 0;
            int j = 0;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                    if (arr2[i] == arr1[j])
                        break;

                /* If the above inner loop
                was not broken at all then
                arr2[i] is not present in
                arr1[] */
                if (j == m)
                    return false;
            }

            /* If we reach here then all
            elements of arr2[] are present
            in arr1[] */
            return true;
        }
    }
}
