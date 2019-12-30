using System;

namespace IntroDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var modelDuck = new ModelDuck();
            modelDuck.SetFlyBehavior(new FlyRocketPowered());
            modelDuck.Swim();
            modelDuck.Display();
            modelDuck.PerformFly();
            modelDuck.PerformQuack();
        }
    }
}
