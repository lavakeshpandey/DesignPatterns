using Chapter1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter1
{
    public class Quack : QuackBehavior
    {
        void QuackBehavior.Quack()
        {
            throw new NotImplementedException();
        }
    }
}
