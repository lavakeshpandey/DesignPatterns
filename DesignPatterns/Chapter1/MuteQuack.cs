using Chapter1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter1
{
    class MuteQuack : IQuack
    {
        public void Quack()
        {
            Console.WriteLine($"<< Silence >>");
        }
    }
}
