using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Turing.Search
{
    public class BinarySearch_Array
    {
        public void Main()
        {
            int[] v = { 1, 3, 4, 5, 6 };
            int To_Find = 1;
            binarySearch(v, To_Find);
            To_Find = 6;
            binarySearch(v, To_Find);
            To_Find = 10;
            binarySearch(v, To_Find);




            int[] arr = { 2, 3, 4, 10, 40 };
            int n = arr.Length;
            int x = 10;

            int result = binarySearch(arr, 0, n - 1, x);

            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at index "
                                  + result);

        }

        //Iterrative
        public void binarySearch(int[] v, int To_Find)
        {
            int lo = 0;
            int hi = v.Length - 1;
            int mid;
            // This below check covers all cases , so need to check
            // for mid=lo-(hi-lo)/2
            while (hi - lo > 1)
            {
                mid = (hi + lo) / 2;
                if (v[mid] < To_Find)
                {
                    lo = mid + 1;
                }
                else
                {
                    hi = mid;
                }
            }
            if (v[lo] == To_Find)
            {
                Console.WriteLine("Found At Index " + lo);
            }
            else if (v[hi] == To_Find)
            {
                Console.WriteLine("Found At Index " + hi);
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }

        //Recursive
        static int binarySearch(int[] arr, int l, int r, int x)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;

                // If the element is present at the
                // middle itself
                if (arr[mid] == x)
                    return mid;

                // If element is smaller than mid, then
                // it can only be present in left subarray
                if (arr[mid] > x)
                    return binarySearch(arr, l, mid - 1, x);

                // Else the element can only be present
                // in right subarray
                return binarySearch(arr, mid + 1, r, x);
            }

            // We reach here when element is not present
            // in array
            return -1;
        }
    }
}
