using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Turing.Sort
{
    public class Sort_only_two_elements_are_swapped
    {
        // Driver Code
        public void Main()
        {
            int[] arr = {10, 30, 20,
                 40, 50, 60, 70};
            int n = arr.Length;

            Console.WriteLine("Given array is ");
            printArray(arr, n);

            sortByOneSwap(arr, n);

            Console.WriteLine("Sorted array is ");
            printArray(arr, n);
        }
        // This function sorts an array
        // that can be sorted by single swap
        public void sortByOneSwap(int[] arr,
                                  int n)
        {
            // Traverse the given array
            // from rightmost side
            for (int i = n - 1; i > 0; i--)
            {
                // Check if arr[i] is not in order
                if (arr[i] < arr[i - 1])
                {
                    // Find the other element to be
                    // swapped with arr[i]
                    int j = i - 1;
                    while (j >= 0 && arr[i] < arr[j])
                        j--;

                    // Swap the pair
                    int temp = arr[i];
                    arr[i] = arr[j + 1];
                    arr[j + 1] = temp;

                    break;
                }
            }
        }

        // A utility function to print an
        // array of size n
        public void printArray(int[] arr, int n)
        {
            int i;
            for (i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }


    }
}
