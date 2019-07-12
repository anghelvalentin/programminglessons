using System;
using System.Collections.Generic;
using System.Text;

namespace Observable
{
    class Channel : ISubject
    {
        IList<IObserver> subscribers = new List<IObserver>();
        public void AddObserver(IObserver observer)
        {
            subscribers.Add(observer);
        }

        public void DeleteObserver(IObserver observer)
        {
            subscribers.Remove(observer);
        }

        public void Notify(Message message)
        {
            for (int i = 0; i < subscribers.Count; i++)
            {
                subscribers[i].Notify(message);
            }
        }
    }
}
