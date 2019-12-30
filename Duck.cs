using System;

namespace IntroDesignPatterns
{
    public abstract class Duck
    {       
        /// <summary>
        /// All ducks swim
        /// </summary>
        public virtual void Swim()
        {
            Console.WriteLine("Base class - Swim");
        }

        /// <summary>
        /// All ducks subtypes look different
        /// </summary>
        public virtual void Display()
        {

        }

        //other duck-like methods
    }
}
