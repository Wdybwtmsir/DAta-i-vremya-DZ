using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите часы:");
        int hrs = int.Parse(Console.ReadLine());
        Console.Write("Введите минуты:");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Введите секунды:");
        int s = int.Parse(Console.ReadLine());
        Console.Write("Введите миллисекунды:");
        int ms = int.Parse(Console.ReadLine());
        TimeSpan time = new TimeSpan(hrs, min, s, ms);
        Console.WriteLine($"Время: {time}");

        Console.WriteLine("Введите год:");
        int year = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите месяц:");
        int month = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите день:");
        int day = int.Parse(Console.ReadLine());

        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine($"{year} - Ну это типа високосный год.");
        }
        else
        {
            int nextLeapYear = year;

            while (!DateTime.IsLeapYear(nextLeapYear))
            {
                nextLeapYear++;
            }

            int yearsUntilLeap = nextLeapYear - year;
            Console.WriteLine($"{year} - Не не не это не  високосный год. а вот следующий будет  через {yearsUntilLeap} лет.");
        }
    }
}