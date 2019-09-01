using System;
using System.Collections.Generic;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "()({[]()}[])";
            Console.WriteLine("Введите скобочную последовательность:");
            String s = Console.ReadLine();
            bool balanced = IsBalanced(s);

            if (balanced)
            {
                Console.WriteLine("Это правильная скобочная последовательность");
            }
            else
            {
                Console.WriteLine("Это неправильная скобочная последовательность");
            }
            Console.ReadLine();
        }

        public static bool IsBalanced(string input)
        {
            Dictionary<char, char> bracketPairs = new Dictionary<char, char>() {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' }
        };

            Stack<char> brackets = new Stack<char>();

            try
            {
                foreach (char c in input)
                {
                    // проверяем, является ли символ открывающей скобкой
                    if (bracketPairs.ContainsKey(c))
                    {
                        // если да, то кладем скобку в стек 
                        brackets.Push(c);                        
                    }
                    else
                    // проверяем, является ли символ закрывающей скобкой
                    if (bracketPairs.ContainsValue(c))
                    {
                        // проверяем, лежит ли в стеке совпадающая открывающая скобка
                        if (c == bracketPairs[brackets.Peek()])
                        {
                            // если да, извлекаем ее из стека
                            brackets.Pop();
                        }
                        else
                            // иначе последовательность неправильная
                            return false;
                    }
                }
            }
            catch
            {
                // последовательность неправильная, если закрывающая скобка встречается раньше любой открывающей
                return false;
            }

            // проверка, все ли открывающие скобки имеют пару
            return brackets.Count == 0 ? true : false;
        }
    }
}
