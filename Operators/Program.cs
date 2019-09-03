using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = null;
            car?.IncreaseSpeed(10); //this statement returns null
            car = new Car();
            car?.IncreaseSpeed(10);
            Console.WriteLine(car?.Speed);//10

            car = null;
            Console.WriteLine(car?.Speed ?? 0); //0

            car = new Car();
            car.Speed = 100;
            Console.WriteLine(car?.Speed??0);//100

            Car[] cars = new Car[3];
            

            Console.WriteLine(nameof(car.Speed)+"="+car.Speed); //nameof express =>it prints Speed=100

            Console.WriteLine($"{nameof(car.Speed)}={car.Speed}"); //string interpolation + nameof expression
            int i = new int();
        }
    }
}
