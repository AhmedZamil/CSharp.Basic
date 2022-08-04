using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Collections
{
    public static class SortedListUse
    {
        public static void Use()
        {

            SortedList<int,string> sl1 = new SortedList<int,string>();

            sl1.Add(5,"Ahmed");
            sl1.Add(2, "Rihan");
            sl1.Add(1, "Zamil");
            sl1.Add(3, "Marie");
            sl1.Add(4, "Munabih");

            foreach (KeyValuePair<int,string> kvp in sl1)
            {
                Console.WriteLine($"Serial:{kvp.Key} Name : {kvp.Value}");
            }
            Console.WriteLine("Another Way of Writting");

            foreach (var kvp in sl1)
            {
                Console.WriteLine($"Serial:{kvp.Key} Name : {kvp.Value}");
            }
            if (sl1.ContainsKey(4))
            {
                sl1.RemoveAt(4);
            }
            sl1.Remove(2);
            foreach (var kvp in sl1)
            {
                Console.WriteLine($"Serial:{kvp.Key} Name : {kvp.Value}");
            }

        }
    }
}
