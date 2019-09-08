using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.AbstractFactory
{
    class FactoryProducer
    {
        public AbstractFactory GetFactory(string factoryType)
        {
          
                switch (factoryType.ToLower())
                {
                    case "normal":
                        return new NormalShapeFactory();

                    case "rounded":
                        return new RoundedShapeFactory();

                    default:
                        return null;
                }
            
        }
    }
}
