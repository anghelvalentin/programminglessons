using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }
}
