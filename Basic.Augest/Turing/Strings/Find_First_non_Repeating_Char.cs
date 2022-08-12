using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Turing.Strings
{
    public class Find_First_non_Repeating_Char
    {

        //Given a string, find the first non-repeating character in it.
        //For example, if the input string is “GeeksforGeeks”,
        //then output should be ‘f’ and if input string is “GeeksQuiz”,
        //then output should be ‘G’.
        public void Main()
        {
            String str = "geeksforgeeks";
            int index = firstNonRepeating(str);
            if (index == int.MaxValue)
                Console.Write("Either all characters are " +
                            "repeating or string is empty");
            else
                Console.Write("First non-repeating character" +
                                    " is " + str[index]);

        }

        public int firstNonRepeating(String str)
        {
            int NO_OF_CHARS = 256;

            // Initialize all characters
            // as absent.
            int[] arr = new int[NO_OF_CHARS];
            for (int i = 0; i < NO_OF_CHARS; i++)
                arr[i] = -1;

            // After below loop, the
            // value of arr[x] is going
            // to be index of x if x
            // appears only once. Else
            // the value is going to be
            // either -1 or -2.
            for (int i = 0; i < str.Length; i++)
            {
                if (arr[str[i]] == -1)
                    arr[str[i]] = i;
                else
                    arr[str[i]] = -2;
            }

            int res = int.MaxValue;
            for (int i = 0; i < NO_OF_CHARS; i++)

                // If this character occurs
                // only once and appears before
                // the current result, then
                // update the result
                if (arr[i] >= 0)
                    res = Math.Min(res, arr[i]);

            return res;
        }
    }
}
