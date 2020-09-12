using Chapter1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter1
{
    public class FlyWithWings : IFly
    {
        public void Fly()
        {
            Console.WriteLine($"I'm flying.");
        }
    }
}
