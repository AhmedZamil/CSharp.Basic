using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Turing
{
    public class SpecialInteger
    {
        public void Main()
        {
            // given k array of integer, find x such that x number of integer is greter than x

            string[] inputs = Console.ReadLine().Trim().Split(" ");
            int[] k = Array.ConvertAll(inputs, x => Int32.Parse(x));


            int x = Find(k);
            if (x > 0) Console.WriteLine(x);
            else Console.WriteLine("there is no");

        }

        public int Find(int[] k)
        {
            for (int i = 0; i < k.Length; i++)
            {
                int flag = 0;
                for (int j = 0; j < k.Length; j++)
                {
                    if (k[j] >= i) flag++;

                }
                if (i == flag) return i;
            }
            return 0;
        }
    }
}
