using System;
using System.Linq;

namespace Strings
{
    public class StringOperations
    {
        public string ReverseString(string input)
        {
            return new string(input.Reverse().ToArray());
        }

        public int CountWords(string input)
        {
            return input.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public string ToUpperCase(string input)
        {
            return input.ToUpper();
        }

        public string ToLowerCase(string input)
        {
            return input.ToLower();
        }

        public bool IsPalindrome(string input)
        {
            string reversed = new string(input.Reverse().ToArray());
            return input.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StringOperations stringOps = new StringOperations();

            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();

            Console.WriteLine("Выберите операцию: 1 - Обратить строку, 2 - Подсчитать количество слов, 3 - Преобразовать в верхний регистр, 4 - Преобразовать в нижний регистр, 5 - Проверить на палиндром");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    string reversed = stringOps.ReverseString(input);
                    Console.WriteLine("Обращенная строка: " + reversed);
                    break;
                case 2:
                    int wordCount = stringOps.CountWords(input);
                    Console.WriteLine("Количество слов: " + wordCount);
                    break;
                case 3:
                    string upper = stringOps.ToUpperCase(input);
                    Console.WriteLine("Верхний регистр: " + upper);
                    break;
                case 4:
                    string lower = stringOps.ToLowerCase(input);
                    Console.WriteLine("Нижний регистр: " + lower);
                    break;
                case 5:
                    bool isPalindrome = stringOps.IsPalindrome(input);
                    Console.WriteLine("Палиндром: " + (isPalindrome ? "Да" : "Нет"));
                    break;
                default:
                    Console.WriteLine("Неверный выбор");
                    break;
            }
        }
    }
}