using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Turing.Search
{
    public class Find_the_smallest_and_second_smallest
    {
        //Write an efficient C# program to find the smallest and second smallest element in an array.
        public void Main()
        {
            int[] arr = { 111, 13, 25, 9, 34, 1 };
            int n = arr.Length;

            // sorting the array using
            // in-built sort function
            Array.Sort(arr);

            // printing the desired element
            Console.WriteLine("smallest element is " + arr[0]);
            Console.WriteLine("second smallest element is " + arr[1]);


        }
    }
}
