using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Generics.Methods
{
    public class NonGeneric
    {
        public void Print<T>(T Data)
        { 
         Console.WriteLine(Data);
        }
    }
}
