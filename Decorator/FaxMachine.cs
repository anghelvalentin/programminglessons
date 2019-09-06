using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class FaxMachine : IPrint,IFax
    {
        IPrint _xeroxMachine;
        public FaxMachine(IPrint xerox)
        {
            _xeroxMachine = xerox;
        }

        public void Print(string message)
        {
            _xeroxMachine.Print(message);
            Console.WriteLine("New functionality was added for xerox machine.");
        }

        public void SendFax(string adress)
        {
            Console.WriteLine("Sending a fax to this adress: "+adress);
        }
    }
}
