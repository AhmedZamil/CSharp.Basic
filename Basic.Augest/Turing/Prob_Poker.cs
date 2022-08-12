using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Turing
{
    public class Prob_Poker
    {
        public void Main()
        {
            int n =Int32.Parse(Console.ReadLine());

            string[] cards = Console.ReadLine().Trim().Split(" ");
            string[] hand1 = new string[5];
            string[] hand2 = new string[5];
            int hand1_index = 0;
            int hand2_index = 0;
            for (int i=0;i<n;i++)
            {
                //i < 5 ? hand1.SetValue(cards[i], i) : hand2.SetValue(cards[i],i);
            }
        
        }
    }


}
