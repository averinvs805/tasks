using System;

namespace Task4
{
    class Program
    {
        static double Factorial(int x)
        {
            if (x == 0 || x == 1)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }
        static void Main(string[] args)
        {
            int num;
            double result;
            Console.WriteLine("Введите число, факториал которого нужно вычислить:");
            num = Convert.ToInt32(Console.ReadLine());
            result = Factorial(num);
            Console.WriteLine("{0}! = {1}", num, result);
        }
    }
}
