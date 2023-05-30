using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main()
        {

            Price[] names = new Price[] { new Price("Свечка", "Яонский рай", 5476), new Price("Трактор", "Аврора", 5476) };




            Price[] sortedNames = names.OrderBy(name => name.StoreName).ToArray();

            foreach (var name in sortedNames)
            {
                Console.WriteLine(name.StoreName);
            }

            Console.ReadKey();
        }
    }
}
