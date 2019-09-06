using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class FaxMachine : PrintDecorator,IFax
    {
        public FaxMachine(IPrint print) : base(print)
        {
        }


        public override void Print(string message)
        {
            base.Print(message);
            Console.WriteLine("I also added some new functionality to printing");
        }

        public void SendFax(string adress)
        {
            Console.WriteLine("Sending a fax to this adress: "+adress);
        }
    }
}
