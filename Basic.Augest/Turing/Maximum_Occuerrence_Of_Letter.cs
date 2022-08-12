using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Turing
{
    public class Maximum_Occuerrence_Of_Letter
    {
        public void Main()
        {
            String str = "aaaaaaabc";
            int[] charCount = new int[256];
            int length = str.Length;
            for (int i = 0; i < length; i++)
            {
                charCount[str[i]]++;
            }
            int maxCount = -1;
            char character = ' ';
            for (int i = 0; i < length; i++)
            {
                if (maxCount < charCount[str[i]])
                {
                    maxCount = charCount[str[i]];
                    character = str[i];
                }
            }
            Console.WriteLine("The string is: " + str);
            Console.WriteLine("The highest occurring character in the above string is: " + character);
            Console.WriteLine("Number of times this character occurs: " + maxCount);


        }

        public void MaximumOccuerence()
        { 
        
        }
    }
}
