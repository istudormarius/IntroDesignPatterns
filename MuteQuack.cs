using System;

namespace IntroDesignPatterns
{
    public class MuteQuack : QuackBehavior
    {
        public override void QuackQuack()
        {
            Console.WriteLine("Doesn't quack");
        }
    }
}
