using Basic.Augest.Generices.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Generices
{
    public static class UseGenerices
    {
        public static void Implement()
        {
            DataStore<string> ds = new DataStore<string>();
            ds.Data = "This is a generic Class field";

            DataStore<int> ds2 = new DataStore<int>();
            ds2.Data = 100;
            Console.WriteLine(ds.Data);
            Console.WriteLine(ds2.Data);
            Console.ReadLine();
        }

    }
}
