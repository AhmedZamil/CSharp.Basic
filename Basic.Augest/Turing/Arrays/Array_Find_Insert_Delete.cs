using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Turing.Arrays
{
    public class Array_Find_Insert_Delete
    {
        public void Main()
        {
            int i;
            int[] arr = { 10, 50, 30, 40, 20 };

            int n = arr.Length;
            int key = 30;

            Console.Write("Array before deletion ");
            for (i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();

            n = deleteElement(arr, n, key);

            Console.Write("Array after deletion ");
            for (i = 0; i < n; i++)
                Console.Write(arr[i] + " ");


            //int[] arr = new int[20];
            //arr[0] = 12;
            //arr[1] = 16;
            //arr[2] = 20;
            //arr[3] = 40;
            //arr[4] = 50;
            //arr[5] = 70;
            int capacity = 20;
            //int n = 6;
            //int i, key = 26;

            Console.Write("Before Insertion: ");
            for (i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();

            // Inserting key
            n = insertSorted(arr, n, key, capacity);

            Console.Write("After Insertion: ");
            for (i = 0; i < n; i++)
                Console.Write(arr[i] + " ");

        }

        public int insertSorted(int[] arr, int n,
                         int key,
                         int capacity)
        {

            // Cannot insert more elements
            // if n is already more than
            // or equal to capacity
            if (n >= capacity)
                return n;

            arr[n] = key;
            return (n + 1);
        }

        public int findElement(int[] arr,
                        int n,
                        int key)
        {

            int i;
            for (i = 0; i < n; i++)
                if (arr[i] == key)
                    return i;

            return -1;
        }

        // Function to delete an element
        public int deleteElement(int[] arr,
                                 int n,
                                 int key)
        {
            // Find position of element
            // to be deleted
            int pos = findElement(arr, n, key);

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
    }
}
