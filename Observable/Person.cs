using System;
using System.Collections.Generic;
using System.Text;

namespace Observable
{
    class Person : IObserver
    {
        public void OnReceiveMessage(Message message)
        {
            Console.WriteLine($"The person received this message: {message.Text}");
        }
    }
}
