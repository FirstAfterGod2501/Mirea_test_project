using System;
using System.Text;

namespace Passwords
{
    public class PasswordGenerator
    {
        private static readonly Random random = new Random();

        public string GenerateRandomPassword(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public string GeneratePasswordWithSpecialChars(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public string GenerateNumericPassword(int length)
        {
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public string GenerateAlphabeticPassword(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public string GenerateCustomPassword(int length, string customChars)
        {
            return new string(Enumerable.Repeat(customChars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public string GenerateCustomPassword(int length)
        {
            Console.WriteLine("Введите свои символы:");
            string customChars = Console.ReadLine();

            return new string(Enumerable.Repeat(customChars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PasswordGenerator generator = new PasswordGenerator();

            Console.WriteLine("Введите длину пароля:");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Выберите тип пароля: 1 - Случайный, 2 - С спец. символами, 3 - Числовой, 4 - Алфавитный, 5 - Пользовательский");
            int choice = Convert.ToInt32(Console.ReadLine());

            string password = choice switch
            {
                1 => generator.GenerateRandomPassword(length),
                2 => generator.GeneratePasswordWithSpecialChars(length),
                3 => generator.GenerateNumericPassword(length),
                4 => generator.GenerateAlphabeticPassword(length),
                5 => generator.GenerateCustomPassword(length),
                _ => throw new InvalidOperationException("Неверный выбор")
            };

            Console.WriteLine($"Сгенерированный пароль: {password}");
        }
    }
}