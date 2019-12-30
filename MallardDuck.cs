using System;

namespace IntroDesignPatterns
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            base.flyBehavior = new FlyWithWings();
            base.quackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("Super set: I'm a real mallard duck");
        }
    }
}
