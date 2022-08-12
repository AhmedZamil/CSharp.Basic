using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Turing.Arrays
{
    public class Rotation
    {
        public void Main()
        {
            int[] inputArr = { 1, 2, 3, 4, 5, 6, 7 };
            RotateInLeft(inputArr, 2, 7);
            print(inputArr, 7);

        }

        public void RotateInLeft(int[] inputArr, int t, int n)
        {
            int i, j, k, temp;
            /* To handle if d >= n */
            t = t % n;
            int gcd = CalGCD(t, n);
            for (i = 0; i < gcd; i++)
            {
                /* move i-th values of blocks */
                temp = inputArr[i];
                j = i;
                while (true)
                {
                    k = j + t;
                    if (k >= n)
                        k = k - n;
                    if (k == i)
                        break;
                    inputArr[j] = inputArr[k];
                    j = k;
                }
                inputArr[j] = temp;
            }
        }
        public void print(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
                Console.Write(arr[i] + " ");
        }

        public int CalGCD(int i, int j)
        {
            if (j == 0)
                return i;
            else
                return CalGCD(j, i % j);
        }


    }
}
