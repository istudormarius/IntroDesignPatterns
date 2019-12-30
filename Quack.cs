using System;

namespace IntroDesignPatterns
{
    public class Quack : QuackBehavior
    {
        public override void QuackQuack()
        {
            Console.WriteLine("Quack quack");
        }
    }
}
