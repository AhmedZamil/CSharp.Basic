using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Collections
{
    public static class ListUse
    {
        public static void BasicUse() { 
        
            List<int> list = new List<int>();
            List<int> list2 = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            list.ForEach(x => list2.Add(x));

            list2.ForEach(x=> Print<int>(x));
            Console.WriteLine();

            var cities = new List<string>();
            cities.Add("New York");
            cities.Add("London");
            cities.Add("Mumbai");
            cities.Add("Chicago");

            cities.Insert(4,"DHAKA");

            cities.ForEach(city=> 
            { if(city !=null && city.Contains("D"))
                Print<string>(city); 
            });
            cities.Sort();

            int index = cities.BinarySearch("Mumbai");

            var found = cities.Find(x => x.Contains("D"));
            var foundAll = cities.Find(x => x.Contains("o"));

            if (cities.BinarySearch("DHAKA") > -1)
            {
                var result = cities.BinarySearch("DHAKA");
                Print<int>(result);
                Console.Write(cities[result]);
            }



        }

        public static void Print<T>(T item)
        {
            Console.Write(item + " , ");

        }
    }
}
