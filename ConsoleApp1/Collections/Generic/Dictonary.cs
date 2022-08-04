using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Collections.Generic
{
    public static class Dictonary
    {
        public static void Use_Dictonary()
        {

            IDictionary<int, string> numberNames = new Dictionary<int, string>();

            numberNames.Add(1, "One");
            numberNames.Add(3, "Three");
            numberNames.Add(5, "Five");
            numberNames.Add(4, "Four");


            foreach (KeyValuePair<int, string> item in numberNames)
            {

                Console.WriteLine("Key : {0}  Value : {1}", item.Key, item.Value);
            }


            var cities = new Dictionary<string, string>(){
                        {"UK", "London, Manchester, Birmingham"},
                        {"USA", "Chicago, New York, Washington"},
                        {"India", "Mumbai, New Delhi, Pune"}
                    };

            foreach (var kvp in cities)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
        }
    }
}
