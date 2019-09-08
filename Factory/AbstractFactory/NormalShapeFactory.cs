using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.AbstractFactory
{
    class NormalShapeFactory:AbstractFactory
    {
        public override IShape GetShape(string type)
        {
            switch (type.ToLower())
            {
                case "triangle":
                    return new Triangle();

                case "square":
                    return new Square();

                default:
                    return null;
            }
        }
    }
}
