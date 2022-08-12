using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Turing
{
    public class Special_two_digit_number
    {
        //A special two-digit number is a number such
        //that when the sum of the digits of the number is added to the product of its digits,
        //the result is equal to the original two-digit number. 
        public void Main()
        {
            int num = Int32.Parse(Console.ReadLine());

            string result = IsSpecial(num);
            Console.WriteLine(result);
        }

        public string IsSpecial(int num)
        {
            if (num < 10 || num > 99)
            {
                return "NO";
            }
            else {
                int first = num / 10;
                int last = num % 10;

                int sum = first + last;
                int pro = first * last;

                if ((sum + pro) == num)
                {
                    return "YES";
                }
                else
                {
                    return "NO";
                }
            
            }

            return "NO";
        }
    }
}
