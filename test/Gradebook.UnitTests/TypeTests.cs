using Gradebook.App;
using System;
using Xunit;

namespace Gradebook.UnitTests
{
    public class TypeTests
    {
        [Fact]
        public void ValueTypesAlsoPassByValue()
        {
            var x = GetInt();
            SetInt(ref x);
            Assert.Equal(42, x);
        }

        private void SetInt(ref int x)
        {
            x = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CSharpCanPassByRef()
        {
            var book1 = GetBook("Book 1");
            GetBookSetNameRef(ref book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        void GetBookSetNameRef(ref Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            Assert.Equal("Book 1", book1.Name);
        }

        void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            string name = "hailee"; // this is a pointer to a string that is allocated in memory
            var upper = MakeUppercase(name);
            Assert.Equal("HAILEE", upper);
        }

        private string MakeUppercase(string parameter)
        {
            return parameter.ToUpper(); // returns a copy
        }

        [Fact]
        public void CanSetNameFromReference ()
        {
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        void SetName(Book book, string name)
        {
            book.Name = name;
        }


        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.NotSame(book1, book2);
        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;

            Assert.Same(book1, book2);
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }

    }
}