using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Turing.Search
{
    public class Two_elements_whose_sum_is_closest_to_zero
    {
        //Question: An Array of integers is given, both +ve and -ve.
        //You need to find the two elements such that their sum is closest to zero.
        public void Main()
        {
            int[] arr = { 1, 60, -10, 70, -80, 85 };

            minAbsSumPair(arr, 6);

        }

        public void minAbsSumPair(int[] arr,
                        int arr_size)
        {

            int l, r, min_sum, sum, min_l, min_r;

            /* Array should have at least two elements*/
            if (arr_size < 2)
            {
                Console.Write("Invalid Input");
                return;
            }

            /* Initialization of values */
            min_l = 0;
            min_r = 1;
            min_sum = arr[0] + arr[1];

            for (l = 0; l < arr_size - 1; l++)
            {
                for (r = l + 1; r < arr_size; r++)
                {
                    sum = arr[l] + arr[r];
                    if (Math.Abs(min_sum) > Math.Abs(sum))
                    {
                        min_sum = sum;
                        min_l = l;
                        min_r = r;
                    }
                }
            }

            Console.Write(" The two elements whose " +
                                "sum is minimum are " +
                            arr[min_l] + " and " + arr[min_r]);
        }
    }
}
