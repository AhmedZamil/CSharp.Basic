using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Generics.Methods
{
    public  class DataStorage <T>
    {
        public T[] Data { get; set; } = new T[10];


        public void AddOrUpdate(int index,T item)
        { 
            if(index >= 0 && index <= 10)
                Data[index] = item;
        }

        public T GetData(int index)
        {
            return Data[index];
        }
    }
}
