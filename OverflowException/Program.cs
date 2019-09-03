using System;

namespace OverflowException
{
    class Program
    {
        static void Main(string[] args)
        {

            //Int32.MaxValue +1
            int rezultat = Int32.MaxValue;
            rezultat += 1;
            Console.WriteLine(rezultat);


            //Checked and OverflowException
            try
            {
                checked
                {
                    for (int i = 1; i <= Int32.MaxValue; i++)
                    {

                    }
                    Console.WriteLine("Does it print?");
                }
            }
            catch (System.OverflowException e)
            {
                Console.WriteLine("Hurrey. The exception was raised and caught");
            }
        }
    }
}
