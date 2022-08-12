using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Turing.Search
{
    public class LinearSearch_Array
    {

        //Given an array arr[] of N elements,
        //the task is to write a function to search a given element x in arr[].
        public void Main()
        {
            int[] arr = { 2, 3, 4, 10, 40 };
            int x = 10;

            // Function call
            int result = LinearSearch(arr, x);
            if (result == -1)
                Console.WriteLine(
                    "Element is not present in array");
            else
                Console.WriteLine("Element is present at index "
                                  + result);

        }

        public  int LinearSearch(int[] arr, int x)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                    return i;
            }
            return -1;
        }
    }
}
