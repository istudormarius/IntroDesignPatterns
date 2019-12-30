using System;

namespace IntroDesignPatterns
{
    public class MallardDuck : Duck, IFlyable, IQuackable
    {
        public override void Display()
        {
            Console.WriteLine("Looks like a mallard");
        }

        public void Fly()
        {
            Console.WriteLine("Mallard Duck - Fly");
        }

        public void Quack()
        {
            Console.WriteLine("MallardDuck - QUack");
        }
    }
}
