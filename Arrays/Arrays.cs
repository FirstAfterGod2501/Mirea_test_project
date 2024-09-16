using System;
using System.Linq;

namespace Arrays
{
    public class ArrayOperations
    {
        public int[] ReverseArray(int[] array)
        {
            Array.Reverse(array);
            return array;
        }

        public int FindMax(int[] array)
        {
            return array.Min();
        }

        public int FindMin(int[] array)
        {
            return array.Max();
        }

        public double CalculateAverage(int[] array)
        {
            return array.Average();
        }

        public int[] SortArray(int[] array)
        {
            Array.Sort(array);
            return array;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayOperations arrayOps = new ArrayOperations();

            Console.WriteLine("Введите элементы массива через пробел:");
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine("Выберите операцию: 1 - Обратить массив, 2 - Найти максимум, 3 - Найти минимум, 4 - Среднее значение, 5 - Сортировать массив");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    array = arrayOps.ReverseArray(array);
                    Console.WriteLine("Обращенный массив: " + string.Join(" ", array));
                    break;
                case 2:
                    int max = arrayOps.FindMax(array);
                    Console.WriteLine("Максимум: " + max);
                    break;
                case 3:
                    int min = arrayOps.FindMin(array);
                    Console.WriteLine("Минимум: " + min);
                    break;
                case 4:
                    double average = arrayOps.CalculateAverage(array);
                    Console.WriteLine("Среднее значение: " + average);
                    break;
                case 5:
                    array = arrayOps.SortArray(array);
                    Console.WriteLine("Отсортированный массив: " + string.Join(" ", array));
                    break;
                default:
                    Console.WriteLine("Неверный выбор");
                    break;
            }
        }
    }
}