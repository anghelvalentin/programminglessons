using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.AbstractFactory
{
    class RoundedTriangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("A rounded triangle was drawn");
        }
    }
}
