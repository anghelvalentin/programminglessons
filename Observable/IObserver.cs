using System;
using System.Collections.Generic;
using System.Text;

namespace Observable
{
    interface IObserver
    {
        void Notify(Message message);
    }
}
