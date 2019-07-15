using System;
using System.Collections.Generic;
using System.Text;

namespace Observable
{
    class Computer : IObserver
    {
        public void OnReceiveMessage(Message message)
        {
            Console.WriteLine($"The computer received this message: {message.Text}");
        }
    }
}
