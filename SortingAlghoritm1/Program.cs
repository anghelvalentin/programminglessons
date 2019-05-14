using System;

namespace SortingAlghoritm1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 32, 12, 1, 2, 46, 21, 2, 3 };

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int aux = array[i];
                        array[i] = array[j];
                        array[j] = aux;
                    }
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
