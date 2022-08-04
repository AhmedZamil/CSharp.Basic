// Solve Me First
using System;
using System.Collections.Generic;
using System.IO;
class SolveMeFirst
{
     static int solveMeFirst(int a, int b) { 
      return a+b;      
    }

     static void Main() {
        int val1 = Convert.ToInt32(Console.ReadLine());
        int val2 = Convert.ToInt32(Console.ReadLine());
        int sum = solveMeFirst(val1,val2);
        Console.WriteLine(sum);
    }
}      