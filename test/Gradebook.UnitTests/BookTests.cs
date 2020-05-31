using Gradebook.App;
using System;
using Xunit;

namespace Gradebook.UnitTests
{
    public class BookTest
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var book = new Book("");
            book.AddGrade(95.7);
            book.AddGrade(70.2);
            book.AddGrade(54.7);

            // Act
            var result = book.GetStatistics();

            // Assert
            Assert.Equal(54.7, result.Low);
            Assert.Equal(95.7, result.High);
            Assert.Equal(73.5, result.Average, 1);
        }
    }
}
