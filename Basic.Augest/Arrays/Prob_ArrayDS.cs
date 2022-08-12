using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Arrays
{
    public  class Prob_ArrayDS
    {
        public  void Solution()
        {

            int n = Int32.Parse(Console.ReadLine().Trim());

            string[] inputs = Console.ReadLine().Trim().Split(" ");

            int[] a = Array.ConvertAll(inputs,x => Int32.Parse(x));

            int[] result = reverseArray(a);
            foreach (int item in result)
            {
                Console.Write(item + " ");
            }
        
        
        
        }

        public  int[] reverseArray(int[] a)
        {
            Array.Reverse(a);
            //a = a.Reverse();
            return a;
        }
    }
}
