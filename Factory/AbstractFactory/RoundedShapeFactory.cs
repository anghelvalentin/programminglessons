using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.AbstractFactory
{
    class RoundedShapeFactory : AbstractFactory
    {

        public override IShape GetShape(string type)
        {
            switch (type.ToLower())
            {
                case "triangle":
                    return new RoundedTriangle();

                case "square":
                    return new RoundedSquare();

                default:
                    return null;
            }
        }

    }
}
