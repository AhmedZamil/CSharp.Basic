using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Turing.SAMPLE
{
    public class Find_The_Judge
    {
        public void Main()
        {
            var N = Console.ReadLine();
            var input = Console.ReadLine();

            var components = input.Split(',');
            var myList = new List<int[]>();

            var size = components.Length;
            int[][] trust = new int[1][];
            int[] arr = new int[size];

            for (int i=0; i<size;i++)
            { 
                string[] result = components[i].Split(' ');
                myList.Insert(i, new int[] { int.Parse(result[0]), int.Parse(result[1]) });
            }
            trust = myList.Select(a=>a.ToArray()).ToArray();
            Console.WriteLine(Solution.findJudge(int.Parse(N),trust));
        
        }
    }

    public class Solution
    {
        public static int findJudge(int N, int[][] trust)
        {
            int[] ind = new int[N+1];
            int[] outd = new int[N + 1];

            int judge = -1;

            foreach (int[] person in trust)
            {
                ind[person[1]]++;
                outd[person[0]]++;
            
            }

            for (int i =1;i <= N; i++)
            {
                if (ind[i] == N - 1 && outd[i] == 0 && judge == -1) judge = i;
            
            }
            return judge;
        }
    
    }
}


//