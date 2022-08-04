using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.HackerRank
{
    public static class Day8_Dictonary_Maps
    {

        public static void Solution()
        {

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            Dictionary<string,string> phonebook = new Dictionary<string,string>();

            for (int i =1;i<=n;i++)
            {
                List<string> line = Console.ReadLine().Trim().Split(" ").ToList();
                phonebook.Add(line[0],line[1]);
            }

            int index = 0;
            string queryName = string.Empty;
            //query[0] = Console.ReadLine().Trim();

            while (!string.IsNullOrEmpty(queryName = Console.ReadLine().Trim())) 
            {
                if (phonebook.ContainsKey(queryName))
                {
                    var number = phonebook[queryName];
                    Console.WriteLine($"{queryName}={number}");
                }
                else
                {
                    Console.WriteLine("Not found");
                }
                
            
            }
        
        
        }
    }
}
