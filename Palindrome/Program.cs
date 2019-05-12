using System;

namespace AlgoritmiProgramare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value");
            string readedValue = Console.ReadLine();
            int number;
            if (int.TryParse(readedValue, out number))
            {
                Console.WriteLine($"{number} {(IsPalindrome(number) == true ? "is" : "isn't")} a palindrome");

            }
            else
            {
                Console.WriteLine($"{readedValue} {(IsPalindrome(readedValue) == true ? "is" : "isn't")} a palindrome");
            }

        }

        /// <summary>
        /// Check if a number is palindrome
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private static bool IsPalindrome(int number)
        {
            int tempNumber = number;
            int inverseNumber = 0;
            while (tempNumber != 0)
            {
                inverseNumber = inverseNumber * 10 + tempNumber % 10;
                tempNumber = tempNumber / 10;
            }

            return inverseNumber == number;
        }

        /// <summary>
        /// Check if a string is palindrome. Can be used also for numbers
        /// </summary>
        /// <param name="readedValue"></param>
        /// <returns></returns>
        private static bool IsPalindrome(string readedValue)
        {
            bool isPalindrom = true;
            readedValue = readedValue.ToLower(); // This line is optional
            for (int i = 0; i < readedValue.Length / 2; i++)
            {
                if (!readedValue[i].Equals(readedValue[readedValue.Length - 1 - i]))
                {
                    isPalindrom = false;
                }
            }

            return isPalindrom;
        }
    }
}
