using System;

namespace Gradebook.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Book miuBook = new Book("Miu's Gradebook");

            miuBook.AddGrade(98.5);
            miuBook.AddGrade(55.8);

            var stats = miuBook.GetStatistics();

            Console.WriteLine($"the low grade: {stats.Low}");
            Console.WriteLine($"the high grade: {stats.High}");
            Console.WriteLine($"the average grade: {stats.Average}");
            Console.WriteLine($"the letter grade: {stats.Letter}");

        }
    }
}
