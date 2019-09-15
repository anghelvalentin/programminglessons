using System;

namespace StackOverflowException
{
    class Program
    {
        static void RecursiveMethod()
        {
            RecursiveMethod();

            //Recursive property 
            Car car = new Car();
            car.Speed = 100;
            Console.WriteLine(car.Speed); //throws StackOverflowException
        }

        static void Main(string[] args)
        {
            RecursiveMethod();
        }
    }
}
