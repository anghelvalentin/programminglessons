using System;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //Simple Singleton
            SimpleSingleton simpleSingleton = SimpleSingleton.GetInstance();
            simpleSingleton.ShowMessage("simple singleton");
            SimpleSingleton simpleSingleton2 = SimpleSingleton.GetInstance();
            if (simpleSingleton == simpleSingleton2)
            {
                Console.WriteLine("This is the same instance");
            }

            //Thread Safe Singleton, call from the master thread
            ThreadSafeSingleton threadSafeSingleton = ThreadSafeSingleton.GetInstance();
            threadSafeSingleton.ShowMessage("thread safe singleton");
            ThreadSafeSingleton threadSafeSingleton2 = ThreadSafeSingleton.GetInstance();
            if (threadSafeSingleton == threadSafeSingleton2)
            {
                Console.WriteLine("This is the same instance");
            }

            //Get object from different threads. 
            Parallel.For(0, 10000, (i) =>
            {
                ThreadSafeSingleton threadSingleton = ThreadSafeSingleton.GetInstance();
                ThreadSafeSingleton threadSingleton2 = ThreadSafeSingleton.GetInstance();
                if (threadSingleton != threadSingleton2)
                {
                    throw new Exception("The threads broke the program");
                }

            });

        }
    }
}
