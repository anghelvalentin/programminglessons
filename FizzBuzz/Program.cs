using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizz = new FizzBuzz(Console.Out);
            fizz.PrintNumbers(100);
        }
    }
}