using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    abstract class PrintDecorator : IPrint
    {
        IPrint _printer;

        public PrintDecorator(IPrint print)
        {
            this._printer = print;
        }

        public virtual void Print(string message)
        {
            _printer.Print(message);
        }
    }
}
