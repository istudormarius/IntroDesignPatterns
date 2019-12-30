using System;
using System.Collections.Generic;
using System.Text;

namespace IntroDesignPatterns
{
    public class Squeak : QuackBehavior
    {
        public override void QuackQuack()
        {
            Console.WriteLine("Squeak Squeak");
        }
    }
}
