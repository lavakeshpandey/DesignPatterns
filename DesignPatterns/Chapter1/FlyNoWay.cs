using Chapter1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter1
{
    public class FlyNoWay : FlyBehavior
    {
        public void Fly()
        {
            throw new NotImplementedException();
        }
    }
}
