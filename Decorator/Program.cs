using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello, World!";

            XeroxMachine xeroxMachine = new XeroxMachine();
            xeroxMachine.Print(message);

            FaxMachine faxMachine = new FaxMachine(xeroxMachine);
            faxMachine.Print(message);
            faxMachine.SendFax("021-433-23-22");
        }
    }
}
