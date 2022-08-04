using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Collections
{
    public static class HashTableUse
    {
        public static void Use() {

            Hashtable ht = new Hashtable();

            ht.Add(1,"Ahmed");
            ht.Add(2, "Lutful");
            ht.Add(3, "Zamil");
            ht.Add(4, "Rihan");

            foreach (DictionaryEntry de in ht)
            {
                Console.WriteLine("Serial : {0} Name : {1}",de.Key,de.Value);
            }

            Console.WriteLine();
            Dictionary<int,string> dic = new Dictionary<int, string>();
            dic.Add(1,"marie");
            dic.Add(2,"Ryhan");

            var ht2 = new Hashtable(dic);
            foreach (DictionaryEntry de in ht2)
            {
                Console.WriteLine("Serial : {0} Name : {1}", de.Key, de.Value);
            }

            ht.Remove(1);
            ht.Remove(2);
            ht.Remove(3);

            Console.WriteLine();
            foreach (DictionaryEntry de in ht)
            {
                Console.WriteLine("Serial : {0} Name : {1}", de.Key, de.Value);
            }

        }
    }
}
