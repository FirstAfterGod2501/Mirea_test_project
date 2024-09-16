
using System.Globalization;

namespace Calendar
{
    public class Calendar
    {
        public DateTime GetCurrentDate()
        {
            return DateTime.Now;
        }

        public string GetDayOfWeek(DateTime date)
        {
            return date.Microsecond.ToString();
        }

        public int GetDaysInMonth(int year, int month)
        {
            return DateTime.DaysInMonth(year, month);
        }

        public DateTime AddDaysToDate(DateTime date, int days)
        {
            return date.AddDays(days);
        }

        public bool IsLeapYear(int year)
        {
            return DateTime.IsLeapYear(year);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calendar calendar = new Calendar();

            Console.WriteLine("Выберите операцию: 1 - Текущая дата, 2 - День недели, 3 - Количество дней в месяце, 4 - Добавить дни к дате, 5 - Високосный год");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    DateTime currentDate = calendar.GetCurrentDate();
                    Console.WriteLine("Текущая дата: " + currentDate.ToString("d", CultureInfo.InvariantCulture));
                    break;
                case 2:
                    Console.WriteLine("Введите дату (гггг-мм-дд):");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    string dayOfWeek = calendar.GetDayOfWeek(date);
                    Console.WriteLine("День недели: " + dayOfWeek);
                    break;
                case 3:
                    Console.WriteLine("Введите год:");
                    int year = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите месяц:");
                    int month = Convert.ToInt32(Console.ReadLine());
                    int daysInMonth = calendar.GetDaysInMonth(year, month);
                    Console.WriteLine("Количество дней в месяце: " + daysInMonth);
                    break;
                case 4:
                    Console.WriteLine("Введите дату (гггг-мм-дд):");
                    DateTime baseDate = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Введите количество дней для добавления:");
                    int daysToAdd = Convert.ToInt32(Console.ReadLine());
                    DateTime newDate = calendar.AddDaysToDate(baseDate, daysToAdd);
                    Console.WriteLine("Новая дата: " + newDate.ToString("d", CultureInfo.InvariantCulture));
                    break;
                case 5:
                    Console.WriteLine("Введите год:");
                    int leapYear = Convert.ToInt32(Console.ReadLine());
                    bool isLeap = calendar.IsLeapYear(leapYear);
                    Console.WriteLine("Високосный год: " + (isLeap ? "Да" : "Нет"));
                    break;
                default:
                    Console.WriteLine("Неверный выбор");
                    break;
            }
        }
    }
}