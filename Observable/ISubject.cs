using System;
using System.Collections.Generic;
using System.Text;

namespace Observable
{
    interface ISubject
    {
        void AddObserver(IObserver observer);
        void DeleteObserver(IObserver observer);
        void Notify(Message message);
    }
}
