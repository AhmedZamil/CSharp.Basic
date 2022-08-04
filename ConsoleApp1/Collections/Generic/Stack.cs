using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Collections.Generic
{
    public static class Stack
    {
        public static void Use_Stack() {

            Stack<int> numbers = new Stack<int>(new int[] { 1, 2, 3, 4 });

            numbers.Push(10);
            numbers.Push(20);
            numbers.Push(30);

            Console.WriteLine("Here are {0} numbers",numbers.Count);
            Console.WriteLine("Last IN First Out PEEK : {0} ", numbers.Peek());
            Console.WriteLine("Last IN First Out POP : {0} ", numbers.Pop());
            Console.WriteLine("Last IN First Out POP : {0} ", numbers.Pop());

            if(numbers.Contains(2))
                Console.WriteLine("Number Stack Contains : 2 ");

            foreach (int item in numbers)
            {
                var popItem = item > 5 ? item : 0;
                Console.WriteLine("Item :" + popItem);
            }

        }
    }
}
