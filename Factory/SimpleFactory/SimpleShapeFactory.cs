using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class SimpleShapeFactory
    {
        public IShape GetShape(string name)
        {
            
            switch (name.ToLower())
            {
                case "circle":
                    return new Circle();

                case "square":
                    return new Square();

                case "rectangle":
                    return new Rectangle();



                default:
                    return null;
            }
        }
    }
}
