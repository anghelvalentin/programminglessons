using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    internal sealed class SimpleSingleton : ISingletonSignature
    {
        private static SimpleSingleton _instace;

        private SimpleSingleton()
        {

        }


        public static SimpleSingleton GetInstance()
        {
            if (_instace == null)
            {
                _instace = new SimpleSingleton();
            }
            return _instace;
        }


        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
