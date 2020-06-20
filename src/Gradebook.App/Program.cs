using System;

namespace Gradebook.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Miu's Gradebook");

            while (true)
            {
                Console.WriteLine("Add a grade:");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }
                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("**");
                }
            }


            var stats = book.GetStatistics();

            Console.WriteLine($"For the book named:{book.Name}");
            Console.WriteLine($"the low grade: {stats.Low}");
            Console.WriteLine($"the high grade: {stats.High}");
            Console.WriteLine($"the average grade: {stats.Average}");
            Console.WriteLine($"the letter grade: {stats.Letter}");

        }
    }
}
