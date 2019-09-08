using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }
    }
}
