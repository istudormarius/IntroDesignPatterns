using System;

namespace IntroDesignPatterns
{
    public abstract class Duck
    {
        public QuackBehavior quackBehavior;
        public FlyBehavior flyBehavior;

        public abstract void Display();

        public void Swim()
        {
            Console.WriteLine("Base class - All ducks float, even decoys");
        }

        public void PerformQuack()
        {
            quackBehavior.QuackQuack();
        }

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void SetFlyBehavior(FlyBehavior flyBehavior)
        {
           this.flyBehavior = flyBehavior;
        }

        public void SetQuackBehavior(QuackBehavior quackBehavior)
        {
            this.quackBehavior = quackBehavior;
        }
    }
}
