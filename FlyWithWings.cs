using System;
using System.Collections.Generic;
using System.Text;

namespace IntroDesignPatterns
{
    public class FlyWithWings : FlyBehavior
    {
        public override void Fly()
        {
            Console.WriteLine("Fly with wings");
        }
    }

    public class FlyNoWay : FlyBehavior
    {
        public override void Fly()
        {
            Console.WriteLine("Does not fly");
        }
    }
}
