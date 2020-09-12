using Chapter1.Interfaces;
using System;

namespace Chapter1
{
    public abstract class Duck
    {
        //public IFly flyBehavior;
        //public IQuack quackBehavior;

        public IFly FlyBehavior { get; set; }
        public IQuack QuackBehavior { get; set; }

        public void PerformQuack()
        {
            //quackBehavior.Quack();
            QuackBehavior.Quack();
        }

        public void PerformFly()
        {
            //flyBehavior.Fly();
            FlyBehavior.Fly();
        }

        public abstract void Display();

        public void Swim()
        {
            Console.WriteLine($"All ducks float, even decoys.");
        }
    }
}
