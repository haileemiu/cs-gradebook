using System;

namespace Gradebook.App
{
    class Program
    {

        static void Main(string[] args)
        {
            InMemoryBook book = new InMemoryBook("Miu's Gradebook");
            book.GradeAdded += OnGradeAdded;

            EnterGrades(book);

            var stats = book.GetStatistics();

            Console.WriteLine(InMemoryBook.CATEGORY);
            Console.WriteLine($"the low grade: {stats.Low}");
            Console.WriteLine($"the high grade: {stats.High}");
            Console.WriteLine($"the average grade: {stats.Average}");
            Console.WriteLine($"the letter grade: {stats.Letter}");

        }

        private static void EnterGrades(IBook book)
        {
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
        }

        static void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("a grade was added");
        }
    }
}

