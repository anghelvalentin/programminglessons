using Factory.AbstractFactory;
using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Simple factory
            SimpleShapeFactory shapeFactory = new SimpleShapeFactory();
            IShape shape = shapeFactory.GetShape("circle");
            shape.Draw();

            shape = shapeFactory.GetShape("square");
            shape.Draw();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Abstract Factory");

            //Abstract Factory
            FactoryProducer factoryProducer = new FactoryProducer();
            AbstractFactory.AbstractFactory factory = factoryProducer.GetFactory("normal");
            IShape shape1 = factory.GetShape("square");
            shape1.Draw();

            factory = factoryProducer.GetFactory("rounded");
            IShape shape2 = factory.GetShape("square");
            shape2.Draw();

        }
    }
}
