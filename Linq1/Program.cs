using System;
using System.Linq;

namespace Linq1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Steven", "James", "Yan" };
            var selectedName = (from name in names
                                where name[4].Equals('e')
                                select name); //daca dai aici to list, iti va crapa de aici
            foreach (var item in selectedName)
            {
                Console.WriteLine(item); // Iti va afisa Steven
            }

            int[] resultNumbers = { 2, 2, 3, 5, 5,5 };

            var distinctNumbers = resultNumbers.Distinct();

            foreach (var f in distinctNumbers)
            {
                Console.WriteLine(f);
            }
        }
    }
}
