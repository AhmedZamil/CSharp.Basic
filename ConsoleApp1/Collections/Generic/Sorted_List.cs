using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Collections.Generic
{
    public static class Sorted_List
    {
        public static void Use_SortedList() {
            SortedList<int, string> numberNames = new SortedList<int, string>();

            numberNames.Add(1, "One");
            numberNames.Add(9, "Nine");
            numberNames.Add(7, "Seven");
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");
            numberNames.Add(4, "Four");
            numberNames.Add(5, "Five");
            numberNames.Add(6, "Six");

            foreach (KeyValuePair<int, string> kvp in numberNames)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);
        }
    }
}
