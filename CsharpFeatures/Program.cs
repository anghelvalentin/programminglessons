using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CsharpFeatures
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //LINQ
            List<string> cars = new List<string>() { "BMW", "Mercedes", "Ford", "Lexus", "Toyota" };
            cars = cars.Where(c => c.Length > 3).Select(c => c.Substring(0, 3)).ToList();
            cars.ForEach(c => Console.WriteLine(c));


            //Switch expression
            Car car = new Car()
            {
                Producer = "BMW"
            };

            Console.WriteLine(car.GetOriginCountry());

            Console.WriteLine();


            //Async task
            Console.WriteLine("German cars");
            cars = await GetGermanCars();
            foreach (string item in cars)
            {
                Console.WriteLine(item);
            }

            //Null operators
            car = null;
            Console.WriteLine(car?.Producer ?? "Unknown");

            //anonymous object
            Console.WriteLine();
            var anonymousCar = new { Producer = "BMW" };
            Console.WriteLine(anonymousCar.Producer);

            //Dynamic object
            Console.WriteLine();
            dynamic dynamicCar = new Car();
            dynamicCar.Producer = "BMW";
            Console.WriteLine(dynamicCar.Producer);
        }

        static async Task<List<string>> GetGermanCars()
        {
            List<string> cars = new List<string>() { "BMW", "Mercedes" };
            await Task.Delay(1000); //long time operatorion: Retrieve data from the database
            return cars;
        }
    }

}
