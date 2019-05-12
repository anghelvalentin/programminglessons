using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    internal class ThreadSafeSingleton : ISingletonSignature
    {
        private static ThreadSafeSingleton _instace;
        private static object padLock = new object();

        private ThreadSafeSingleton()
        {
        }


        public static ThreadSafeSingleton GetInstance()
        {
            lock (padLock)
            {
                if (_instace == null)
                {
                    _instace = new ThreadSafeSingleton();
                }

                return _instace;
            }
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
