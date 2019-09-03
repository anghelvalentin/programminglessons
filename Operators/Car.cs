using System;
using System.Collections.Generic;
using System.Text;

namespace Operators
{
    class Car
    {
        public int Speed { get; set; }

        public int IncreaseSpeed(int increase)
        {
            Speed += increase;
            return Speed;
        }
    }
}
