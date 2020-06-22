using Gradebook.App;
using System;
using Xunit;

namespace Gradebook.UnitTests
{
    public class BookTest
    {
        [Fact]
        public void BookCalculatesStats()
        {
            // Arrange
            var book = new InMemoryBook("");
            book.AddGrade(95.7);
            book.AddGrade(70.2);
            book.AddGrade(54.7);

            // Act
            var result = book.GetStatistics();

            // Assert
            Assert.Equal(54.7, result.Low);
            Assert.Equal(95.7, result.High);
            Assert.Equal(73.5, result.Average, 1);
            Assert.Equal('C', result.Letter);
        }

        //[Fact]
        //public void Over100Grade()
        //{
        //    var book = new Book("Too High");

        //    book.AddGrade(105);
        //    Assert.Empty(book.grades);
        //}
    }
}