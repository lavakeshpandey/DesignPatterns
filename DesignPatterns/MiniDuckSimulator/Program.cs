using Chapter1;
using System;

namespace MiniDuckSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.FlyBehavior = new FlyWithWings();
            mallard.QuackBehavior = new Quack();

            mallard.PerformFly();
            mallard.PerformQuack();
            mallard.Swim();
        }
    }
}
