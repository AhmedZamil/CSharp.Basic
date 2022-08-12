using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Turing.Arrays
{
    public class SortedArray_Search_Insert_Delete
    {
        public void Main()
        {
            //int[] arr = new int[] { 5, 6, 7, 8, 9, 10 };
            int[] arr = new int[] { 4,10,5,8,9,2,7 };
            Array.Sort(arr);
            int n, key;
            n = arr.Length;
            key = 10;

            Console.WriteLine("Index: "
                              + binarySearch(arr, 0, n - 1, key));

            int capacity = arr.Length;
            n = 6;
            key = 26;

            n = insertSorted(arr, n, key, capacity);

            Console.Write("\nAfter Insertion: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.Write("Array before deletion:\n");
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");

            n = deleteElement(arr, n, key);

            Console.Write("\n\nArray after deletion:\n");
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");

        }

        public int binarySearch(int[] arr, int low,
                               int high, int key)
        {
            if (high < low)
            {
                return -1;
            }

            /*low + (high - low)/2;*/
            int mid = (low + high) / 2;
            if (key == arr[mid])
            {
                return mid;
            }
            if (key > arr[mid])
            {
                return binarySearch(arr, (mid + 1), high, key);
            }
            return binarySearch(arr, low, (mid - 1), key);
        }

        public int deleteElement(int[] arr, int n, int key)
        {
            // Find position of element to be deleted
            int pos = binarySearch(arr, 0, n - 1, key);

            if (pos == -1)
            {
                Console.WriteLine("Element not found");
                return n;
            }

            // Deleting element
            int i;
            for (i = pos; i < n - 1; i++)
                arr[i] = arr[i + 1];

            return n - 1;
        }

        public  int insertSorted(int[] arr, int n, int key, int capacity)
        {
            // Cannot insert more elements if n is already
            // more than or equal to capacity
            if (n >= capacity)
            {
                return n;
            }

            int i;
            for (i = n - 1; (i >= 0 && arr[i] > key); i--)
            {
                arr[i + 1] = arr[i];
            }

            arr[i + 1] = key;

            return (n + 1);
        }
    }
}
