using System;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите исходный массив:");
            var arr = Console.ReadLine().Split(' ').Select(number => int.Parse(number)).ToArray();
            Console.Clear();
            Console.WriteLine("Исходный массив: ");
            Print(arr);
            BubbleSort(arr);
            Console.WriteLine();
            Console.WriteLine("Отсортированный массив: ");
            Print(arr);
            Console.ReadKey();
        }

        static void BubbleSort(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length; i++)
                for (int j = 0; j < arr.Length - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
        }

        static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }
    }
}