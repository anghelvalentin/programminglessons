using System;

namespace StringProblems
{
    class Program
    {
        static void AddSign(ref string nume)
        {
            nume += "TEST";
        }

        static void AddSign(string nume)
        {
            nume += "TEST";
        }

        static void Main(string[] args)
        {
            Console.WriteLine('a'+'b'+'c'); // Operator + is not overloaded for char, so this chars are converted to their asci code => a=97, b=98, c=99, it prints  294

            Console.WriteLine("A"+"B"+"C"); // In this case we have double quote so there are strings. The result ABC

            string carName = "Mercedes";
            AddSign(carName);
            Console.WriteLine(carName);

            AddSign(ref carName);
            Console.WriteLine(carName);

        }
    }
}
