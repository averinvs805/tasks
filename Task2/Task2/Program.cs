using System;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите отсортированный массив:");
            var arr = Console.ReadLine().Split(' ').Select(number => int.Parse(number)).ToArray();
            Console.WriteLine("Введите искомое число");
            int val = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Отсортированный массив: ");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
            Console.WriteLine("Искомое число: \n" + val);
            if (FindVal(arr, val, 0, arr.Length - 1))
                Console.WriteLine("Число найдено");
            else
                Console.WriteLine("Число не найдено");
            Console.ReadKey();
        }

        static bool FindVal(int[] arr, int val, int left, int right)
        {
            // если левая и правая метки встретились - проверяем их
            if (right - left <= 1)
                return (arr[right] == val || arr[left] == val);

            // если нет - берем середину отрезка
            int mid = (right - left) / 2;

            // проверяем ее
            if (val == arr[mid])
                return true;

            // если не наше число - проверяем отрезок с нужной стороны
            if (val < arr[mid])
                return FindVal(arr, val, left, mid);
            else
                return FindVal(arr, val, ++mid, right);
        }
    }
}