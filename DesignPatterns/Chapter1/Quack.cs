using Chapter1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter1
{
    public class Quack : IQuack
    {
        void IQuack.Quack()
        {
            Console.WriteLine($"Quack.");
        }
    }
}
