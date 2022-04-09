using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj jakiś tekst");

            string t = Console.ReadLine();
            string[] text = t.Split(' ');

            Dictionary<int, List<string>> dictionary = new Dictionary<int, List<string>>();

            Console.WriteLine("-----------------------LINQ-------------------------");
            text.GroupBy(x => x.Length).ToList().ForEach(x => {
                Console.WriteLine(x.Key);
                x.ToList().ForEach(y => Console.WriteLine(y));
            });

    
            Console.WriteLine("-------------------------------------------------------");
            int[] intTable = { 3, 4, 7, 1, 3, 4, 5, 7, 5, 5, 3, 2, 3, 4, 9, 1, 2, 3 };
            intTable.Select(k => k * 2).ToList().ForEach(k => Console.WriteLine(k));
            intTable.Where(x => x > 6).Select(x => x*2).OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
