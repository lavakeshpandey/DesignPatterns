using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter1
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            //FlyBehavior = new FlyWithWings();
            //QuackBehavior = new Quack();
        }
        public override void Display()
        {
            Console.WriteLine($"I am a real Mallard Duck.");
        }
    }
}
