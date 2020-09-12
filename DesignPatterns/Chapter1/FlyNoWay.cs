using Chapter1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter1
{
    public class FlyNoWay : IFly
    {
        public void Fly()
        {
            Console.WriteLine($"I can't fly.");
        }
    }
}
