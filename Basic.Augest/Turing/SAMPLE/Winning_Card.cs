using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Turing.SAMPLE
{
    public class Winning_Card
    {
        public void Main()
        {
            var input = Console.ReadLine();

            var components = input.Split(',');
            var myList = new List<List<int>>();

            var size = components.Length;
   

            for (int i = 0; i < size; i++)
            {
                string[] result = components[i].Split(' ');
                myList.Add(result.Select(r=>int.Parse(r)).ToList());
            }
            int[][] mtx = myList.Select(a=>a.ToArray()).ToArray();

            Solution_Winning_Cards Solution = new Solution_Winning_Cards();
            Console.WriteLine(Solution.solution(mtx));


        }
    }

    public class Solution_Winning_Cards
    {
        public int solution(int[][] cards)
        {
            //write your solution here

            int[] wincards = new int[cards.Length]; 

            for (int i =0;i< cards.Length;i++)
            {
                wincards[i] = FindOnceHeighestElement(cards[i]);
            }

            int res = -1;
            res = wincards.Max();

            return res == 0? -1: res;
            
        }

        public int FindOnceHeighestElement(int[] arr)
        {
            var result = arr.GroupBy(x => x)
                .Where(x => x.Count() == 1).ToList();
            
            return result.Count <1 ? 0 : result.Max(t => t.Key);
        }

        //public int single(int[] arr, int n)
        //{
        //    int ones = 0, twos = 0;
        //    int common_bit_mask;

        //    for (int i = 0; i < n; i++)
        //    {
        //        twos = twos | (ones & arr[i]);
        //        ones = ones ^ arr[i];
        //        common_bit_mask = ~(ones & twos);
        //        ones &= common_bit_mask;
        //        twos &= common_bit_mask;
        //    }
        //    return ones;
        //}


        //public int singleNumber(int[] a, int n)
        //{
        //    HashSet<int> s = new HashSet<int>();
        //    foreach (int i in a)
        //    {
        //        s.Add(i);
        //    }

        //    int arr_sum = 0; // sum of array
        //    foreach (int i in a)
        //    {
        //        arr_sum += i;
        //    }

        //    int set_sum = 0; // sum of set
        //    foreach (int i in s)
        //    {
        //        set_sum += i;
        //    }

        //    // applying the formula.
        //    return (3 * set_sum - arr_sum) / 2;
        //}
        //public int getSingle(int[] arr, int n)
        //{
        //    int result = 0;
        //    int x, sum;
        //    int INT_SIZE = 32;

        //    // Iterate through every bit
        //    for (int i = 0; i < INT_SIZE; i++)
        //    {
        //        sum = 0;
        //        x = (1 << i);
        //        for (int j = 0; j < n; j++)
        //        {
        //            if ((arr[j] & x) != 0)
        //                sum++;
        //        }
        //        if ((sum % 3) != 0)
        //            result |= x;
        //    }
        //    return result;
        //}

        //public int findSingle(int[] ar, int ar_size)
        //{
        //    // Do XOR of all elements and return
        //    int res = ar[0];
        //    for (int i = 1; i < ar_size; i++)
        //        res = res ^ ar[i];

        //    return res;
        //}

        //public int singleelement(int[] arr, int n)
        //{
        //    int low = 0, high = n - 2;
        //    int mid;

        //    while (low <= high)
        //    {
        //        mid = (low + high) / 2;

        //        if (arr[mid] == arr[mid ^ 1])
        //        {
        //            low = mid + 1;
        //        }
        //        else
        //        {
        //            high = mid - 1;
        //        }
        //    }
        //    return arr[low];
        //}

    }
}
