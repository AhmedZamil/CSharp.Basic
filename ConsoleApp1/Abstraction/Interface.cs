using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Abstraction
{

    interface IAnimal
    {
        void MakeSound();

    }

    interface IZooMember
    {
        void ZooCage();
    }


    public class Tiger : IAnimal, IZooMember
    {

        public void MakeSound()
        {
            Console.WriteLine("Tiger makes R O A R");
        }

        public void ZooCage() {
            Console.WriteLine("TIger in CELL : 01 ");
        }
    }
    public static class Interface
    {

        public static void Use()
        {
            Tiger tiger = new Tiger();

            tiger.MakeSound();
            tiger.ZooCage();
        }
    }
}
