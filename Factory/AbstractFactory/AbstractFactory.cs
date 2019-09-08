using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.AbstractFactory
{
    abstract class AbstractFactory
    {
        abstract public IShape GetShape(string type);
    }
}
