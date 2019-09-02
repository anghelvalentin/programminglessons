using System;

namespace namegenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            NameGenerator nameGenerator = new NameGenerator("Anghel", "Valentin Gabriel");
            foreach (var item in nameGenerator.GenerateNames())
            {
                Console.WriteLine(item);
            } 
        }
    }
}