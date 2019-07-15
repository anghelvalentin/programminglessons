using System;
using System.Collections.Generic;
using System.Text;

namespace Observable
{
    interface IObserver
    {
        void OnReceiveMessage(Message message);
    }
}
