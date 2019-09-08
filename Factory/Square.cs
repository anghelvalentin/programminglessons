using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a square");
        }
    }
}
