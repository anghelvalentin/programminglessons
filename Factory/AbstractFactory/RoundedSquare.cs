using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.AbstractFactory
{
    class RoundedSquare : IShape
    {
        public void Draw()
        {
            Console.WriteLine("A rounded square was drawn");
        }
    }
}
