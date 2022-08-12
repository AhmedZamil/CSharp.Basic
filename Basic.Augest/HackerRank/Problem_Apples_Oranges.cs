using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.HackerRank
{
    public static class Problem_Apples_Oranges
    {
        public static void Implement()
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int s = Convert.ToInt32(firstMultipleInput[0]);

            int t = Convert.ToInt32(firstMultipleInput[1]);

            string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int a = Convert.ToInt32(secondMultipleInput[0]);

            int b = Convert.ToInt32(secondMultipleInput[1]);

            string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int m = Convert.ToInt32(thirdMultipleInput[0]);

            int n = Convert.ToInt32(thirdMultipleInput[1]);

            List<int> apples = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();

            List<int> oranges = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

            countApplesAndOranges(s, t, a, b, apples, oranges);

        }

        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            // s --> t 
            // a --> b 

            int appleCount = 0;
            apples.ForEach(p=> {
                int point = a + (p);
                if (point >= s && point <= t) appleCount++;
                });

            int orangeCount = 0;
            oranges.ForEach(o => {
                int point = b + (o);
                if (point >= s && point <= t) orangeCount++;
            });



        }
    }
}
