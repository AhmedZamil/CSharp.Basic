using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Abstraction
{
    public abstract class Animal
    {
        public abstract void MakeSound();
        public void Sleep() {
            Console.WriteLine("The sleep for need..");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound() {

            Console.WriteLine("Cat Make sounds Mew Mew");
        }
    
    }

    public class Cow : Animal
    {
        public override void MakeSound()
        {

            Console.WriteLine("Cow Make sounds Mow Mow");
        }

    }
    public static class Abstraction
    {
        public static void Use() {
            Cat cat = new Cat();
            Cow cow = new Cow();

            cat.MakeSound();
            cow.MakeSound();

        }


    }
}
