using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Collections.Non_Generic
{
    public static class Hash_Table
    {
        public static void Use_HashTable() 
        {
            Hashtable numbernames = new Hashtable();

            numbernames.Add(1, "ONE");
            numbernames.Add(2,"TWO");
            numbernames.Add(3,"THREE");

            foreach (DictionaryEntry item in numbernames)
            {
                Console.WriteLine("Key : {0}  Value : {1}", item.Key,item.Value);
            }

            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "one");
            dict.Add(2, "two");
            dict.Add(3, "three");

            Hashtable ht = new Hashtable(dict);
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine("Key : {0}  Value : {1}", item.Key, item.Value);
            }

        }
    }
}
