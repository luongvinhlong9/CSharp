using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt264
{
    internal class program
    {
        public void Main(String[] args)
        {
            int a=int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            ptBacHai pt = new ptBacHai();
            pt.nghiem();
            Cat cat = new Cat();
            cat.eat();
            cat.makeSound();
            cat.run();
            Bird bird = new Bird();
            bird.eat();
            bird.makeSound();
            bird.fly();
            Console.ReadKey();
        }
    }
}
