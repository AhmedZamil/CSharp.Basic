using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Turing.Strings
{
    public class Pangram_Checking
    {
        //Given a string check if it is Pangram or not.
        //A pangram is a sentence containing every letter in the English Alphabet.
        public void Main()
        {
            string str = "The quick brown fox jumps over the lazy dog";

            if (checkPangram(str) == true)
                Console.WriteLine(str + " is a pangram.");
            else
                Console.WriteLine(str + " is not a pangram.");

        }

        public  bool checkPangram(string str)
        {

            // Create a hash table to mark the
            // characters present in the string
            // By default all the elements of
            // mark would be false.
            bool[] mark = new bool[26];

            // For indexing in mark[]
            int index = 0;

            // Traverse all characters
            for (int i = 0; i < str.Length; i++)
            {
                // If uppercase character, subtract 'A'
                // to find index.
                if ('A' <= str[i] && str[i] <= 'Z')
                    index = str[i] - 'A';

                // If lowercase character,
                // subtract 'a' to find
                // index.
                else if ('a' <= str[i] && str[i] <= 'z')
                    index = str[i] - 'a';

                // If this character is other than english
                // lowercase and uppercase characters.
                else
                    continue;

                mark[index] = true;
            }

            // Return false if any
            // character is unmarked
            for (int i = 0; i <= 25; i++)
                if (mark[i] == false)
                    return (false);

            // If all characters
            // were present
            return (true);
        }
    }
}
