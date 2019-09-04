using System;

namespace Exceptions
{
    class Program
    {

        static float Divide(int a,int b)
        {
            return a/b;

        }

        static void Calculate()
        {
            try
            {
                Divide(10,0);
            }
            catch (DivideByZeroException e)
            {
                //comment one by one
                throw; //stacktrace from Divide
                throw e;  //stacktrace from here
                throw new Exception("",e);
            }
        }

        
        static void Main(string[] args)
        {

            try
            {
                int n = 0;
                int x = 5 / n;
            }
            catch (DivideByZeroException ex)
            {
                Console.Error.WriteLine(ex.Message);
                Console.Error.WriteLine("StackTrace");
                Console.Error.WriteLine(ex.StackTrace);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            try
            {
                Calculate();
            }
            catch (DivideByZeroException ex)
            {
                Console.Error.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.StackTrace); // In this case, we have innner exception
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            // What does it print ?
            try
            {
                try
                {
                    throw new Exception("Exception try");
                }
                catch (Exception e)
                {
                    throw new Exception("Exception catch");
                }
                finally
                {
                    throw new Exception("Exception finally");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); //Exception finally
            }
        }
    }
}
