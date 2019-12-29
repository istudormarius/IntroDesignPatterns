using System;

namespace IntroDesignPatterns
{
    public abstract class Duck
    {
        /// <summary>
        /// All ducks quacks
        /// </summary>
        public void Quack()
        {
            Console.WriteLine("Base class - Quack");
        }

        /// <summary>
        /// All ducks swim
        /// </summary>
        public void Swim()
        {
            Console.WriteLine("Base class - Swim");
        }

        /// <summary>
        /// All ducks subtypes look different
        /// </summary>
        public virtual void Display()
        {

        }
    }
}
