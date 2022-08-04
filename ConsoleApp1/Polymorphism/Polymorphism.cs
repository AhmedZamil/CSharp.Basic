using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Polymorphism
{
    public class Animal
    {
        public string Name { get; set; }
        public virtual void MakeSound() {

            Console.WriteLine("Animal Make Sounds");       
        }
    }
    public class Cow : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cow make sounds MOW - MOW - MOW ..");
        
        }
    
    }

    public class Dog : Animal
    {

        //public void MakeSound()
        public override void MakeSound()
        {
            Console.WriteLine("Dogs make sound  voff voff voff");
        
        }
    }


    public static class Polymorphism
    {
        public static void Use() {

            Animal animal = new Animal();
            Animal cow = new Cow();
            Animal dog = new Dog();

            animal.MakeSound();
            cow.MakeSound();
            dog.MakeSound();
        }
    
    }
}
