using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Turing.SAMPLE
{
    public class ReverseOnlyLetters
    {
        public void Main()
        { 
            string s = Console.ReadLine();

            Solution_ReverseOnlyLetters Solution = new Solution_ReverseOnlyLetters();
            Console.WriteLine(Solution.ReverseOnlyLetters(s));
        }

    }

    public class Solution_ReverseOnlyLetters
    {

        public string ReverseOnlyLetters(string s)
        {
            char[] str = s.ToCharArray();
            // Initialize left and right pointers
            int r = str.Length - 1, l = 0;

            // Traverse string from both ends until
            // 'l' and 'r'
            while (l < r)
            {
                // Ignore special characters
                if (!char.IsLetter(str[l]))
                    l++;
                else if (!char.IsLetter(str[r]))
                    r--;

                // Both str[l] and str[r] are not spacial
                else
                {
                    char tmp = str[l];
                    str[l] = str[r];
                    str[r] = tmp;
                    l++;
                    r--;
                }
            }

            return s = new string(str);

        }
    
    }
}
