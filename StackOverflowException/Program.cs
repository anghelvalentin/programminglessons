using System;

namespace StackOverflowException
{
    class Program
    {
        static void RecursiveMethod()
        {
            RecursiveMethod();
        }

        static void Main(string[] args)
        {
            RecursiveMethod();
        }
    }
}
