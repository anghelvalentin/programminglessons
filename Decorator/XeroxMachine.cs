using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    sealed class XeroxMachine : IPrint
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
