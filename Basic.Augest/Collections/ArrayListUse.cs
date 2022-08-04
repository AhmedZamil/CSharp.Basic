using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Collections
{
    public static class ArrayListUse
    {
        public static void Use() {

            ArrayList arrList1 = new ArrayList();
            arrList1.Add("the");
            arrList1.Add("master");
            arrList1.Add("piece");
            arrList1.Add("of");
            arrList1.Add("Rihan");

            foreach (var item in arrList1) {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            arrList1.Remove("the");

            foreach (var item in arrList1)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            arrList1.RemoveAt(1);

            foreach (var item in arrList1)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            arrList1.RemoveRange(0,3);
            foreach (var item in arrList1)
            {
                Console.Write(item + " ");
            }

            ArrayList list2 = new ArrayList() { "This","Is","Another","ART"};
            string[] arr = new string[2]{" BUT","SOMEONE" };
            Queue q = new Queue();
            q.Enqueue("Draw");
            q.Enqueue("this");

            arrList1.AddRange(list2);
            arrList1.AddRange(arr);
            arrList1.AddRange(q);
            Console.WriteLine();
            foreach (var item in arrList1)
            {
                Console.Write(item+" ");
            }

            Console.WriteLine();

            arrList1.Reverse();
            foreach (var item in arrList1)
            {
                Console.Write(item + " ");
            }
            string[] arr2 = new string[10];
            arrList1.Reverse();

            arrList1.CopyTo(arr2);
            Console.WriteLine();
            foreach (var item in arr2)
            {
                Console.Write(item + " ");
            }

            
        }


    }
}
