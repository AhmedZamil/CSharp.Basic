using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Delegates
{
    public class DelegateTest
    {
        public delegate void MyDelegate(string msg);
        public delegate int SumDelegate(Stack<int> numbers);

       

        public static void TargetMethod(string message)
        { 
            Console.WriteLine(message);
        }

        public static int SumOfNumber(Stack<int> numbers) { 
        
          return numbers.Sum(x => x);
        }

        public static void Use_Delegate() {

            string numberLine = Console.ReadLine();
            string[] tokens = numberLine.Split(",");
            Stack<int> nums = new Stack<int>();
            int oneNum;
            foreach (string s in tokens)
            {
                if (Int32.TryParse(s, out oneNum))
                { 
                
                }
                    nums.Push(oneNum);
            }
            MyDelegate del = TargetMethod;
            SumDelegate del_Sum = SumOfNumber;
            int sum = del_Sum.Invoke(nums);
            Console.WriteLine("Sum Of all numbers {0},",sum);
            del.Invoke("Use of delegate");
        }
    }
}
