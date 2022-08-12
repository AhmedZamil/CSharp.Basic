using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Arrays
{
    public class Prob_LeftRotation
    {
        public void Solution()
        { 

            string[] nd = Console.ReadLine().Trim().Split(" ");
            int n = int.Parse(nd[0]);
            int d = int.Parse(nd[1]);

            int[] arr = new int[n];

            string[] str = Console.ReadLine().Trim().Split();

            arr = Array.ConvertAll(str,x=> Int32.Parse(x));

            int[] result = rotateLeft(d,arr);

        
        }

        public  int[] rotateLeft(int d, int[] arr)
        {
            int[] rotated = new int[arr.Length]; 

            d = d% arr.Length;
            for (int i=0; i<arr.Length;i++)
            {
                int rotatedIndex = i - d;
                if (rotatedIndex < 0)
                {
                    rotatedIndex = rotatedIndex + arr.Length;

                }
                rotated[rotatedIndex] = arr[i];

            }

            return rotated;
        }
    }
}
