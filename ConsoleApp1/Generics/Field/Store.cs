using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Generics.Field
{
    public class Store<T>
    {
        public T[] Data = new T[10];
    }
}
