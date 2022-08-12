using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Turing.Strings
{
    public class Missing_Char_To_Make_Panagram
    {
        //Pangram is a sentence containing every letter in the English alphabet.

        //Given a string, find all characters that are missing from the string, i.e.,
        //the characters that can make the string a Pangram.
        //We need to print output in alphabetic order.
        public void Main()
        {
            String str = "The quick brown fox jumps over the dog";
            List<char> missing = missingChars(str,
                                              str.Length);
            if (missing.Count >= 1)
            {
                foreach (var i in missing)
                {
                    Console.Write(i);
                }
            }

        }

        public List<char> missingChars(String str,
                               int strLength)
        {
            int MAX_CHARS = 26;

            // A boolean array to store
            // characters present in string.
            bool[] present = new bool[MAX_CHARS];
            List<char> charsList = new List<char>();

            // Traverse string and mark
            // characters present in string.
            for (int i = 0; i < strLength; i++)
            {
                if ('A' <= str[i] &&
                    str[i] <= 'Z')
                    present[str[i] - 'A'] = true;
                else if ('a' <= str[i] &&
                         str[i] <= 'z')
                    present[str[i] - 'a'] = true;
            }

            // Store missing characters
            // in alphabetic order.
            for (int i = 0; i < 26; i++)
            {
                if (present[i] == false)
                {
                    charsList.Add((char)(i + 'a'));
                }
            }
            return charsList;
        }
    }
}
