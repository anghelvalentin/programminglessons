using System;
using System.Collections.Generic;
using System.Text;

namespace StackOverflowException
{
    class Car
    {
        private int _speed;
        public int Speed
        {
            get
            {
                return Speed >= 10 ? _speed : _speed - 1;
            }
            set
            {
                _speed = value;
            }
        }
    }
}
