using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.HackerRank
{
    public static class Day7_Array
    {
        public static void solution()
        {
            //int n = Convert.ToInt32(Console.ReadLine().Trim());

            //List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();


            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> list = new List<string>();
            list = Console.ReadLine().Trim().Split(' ').ToList();
            List<int> arr = list.ConvertAll(temp=> Convert.ToInt32(temp));

            arr.Reverse();

            arr.ForEach(x => Console.Write(x + " "));


        }
    }
}
