using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Collections.Non_Generic
{
    public static class Array_List
    {
        public static void  Use_Array_List() { 
        
            ArrayList arrayList = new ArrayList();

            arrayList.Add(1);
            arrayList.Add("Mango Juice");
            arrayList.Add(350.88);

            foreach (var item in arrayList) {
                Console.WriteLine(item);
            }
        
        }

    }
}
