using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class Triangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("A triangle was drawn");
        }
    }
}
