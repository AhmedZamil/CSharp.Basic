using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Turing.Arrays
{
    public class SubArray_With_Given_Sum
    {

        public void Main()
        {
            int[] arr = { 15, 2, 4, 8, 9, 5, 10, 23 };
            int n = arr.Length;
            int sum = 23;
            int result = subArraySum(arr, n, sum);

        }

        public int subArraySum(int[] arr, int n, int sum)
        {
            int currentSum, i, j;

            // Pick a starting point
            for (i = 0; i < n; i++)
            {
                currentSum = arr[i];

                // try all subarrays
                // starting with 'i'
                for (j = i + 1; j <= n; j++)
                {
                    if (currentSum == sum)
                    {
                        int p = j - 1;
                        Console.Write("Sum found between "
                                      + "indexes " + i + " and "
                                      + p);
                        return 1;
                    }
                    if (currentSum > sum || j == n)
                        break;
                    currentSum = currentSum + arr[j];
                }
            }

            Console.Write("No subarray found");
            return 0;
        }
    }


}
