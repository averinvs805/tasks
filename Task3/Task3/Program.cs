using System;
using System.Linq;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            var words = str.Split(new[] { '.', ',', ' ', ';', ':', '!', '?' },
                StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Слова, встречающиеся в строке только один раз:");
            foreach (var w in words.Where(x => words.Count(v => v == x) == 1))
            {
                Console.WriteLine(w);
            }
            Console.ReadLine();
        }
    }
}