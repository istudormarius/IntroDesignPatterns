using System;

namespace IntroDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var mallardDuck = new MallardDuck();
            mallardDuck.Swim();
            mallardDuck.Display();
            mallardDuck.PerformFly();
            mallardDuck.PerformQuack();

        }
    }
}
