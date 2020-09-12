using Chapter1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter1
{
    class Squeak : IQuack
    {
        public void Quack()
        {
            Console.WriteLine($"Squeak");
        }
    }
}
