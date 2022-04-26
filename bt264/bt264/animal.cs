using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt264
{
    class animal
    {
        public virtual void eat()
        {           
        }
        public virtual void makeSound()
        {
        }
    }
    class Cat:animal
    {
        public override void eat()
        {
            Console.WriteLine("Cat eat fisch");
        }
        public override void makeSound()
        {
            Console.WriteLine("Meow meow");
        }
        public void run()
        {
            Console.WriteLine("By 4 legs");
        }
    }
    class bird : animal
    {
        public override void eat()
        {
            Console.WriteLine("Cat eat rice");
        }
        public override void makeSound()
        {
            Console.WriteLine("Chip chip");
        }
        public void fly()
        {
            Console.WriteLine("By 2 wings");
        }
    }
}
