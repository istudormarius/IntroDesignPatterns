using System;
using System.Collections.Generic;
using System.Text;

namespace IntroDesignPatterns
{
    public class FlyRocketPowered : FlyBehavior
    {
        public override void Fly()
        {
            Console.WriteLine("I'm flying with a rocket");
        }
    }
}
