using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LibraryManagement.Tests
{
    [TestClass]
    public class LibraryFixtures
    {
        private static Librarian _librarian;
        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            _librarian = new Librarian();
            for(var index=0; index<5;index++)
            {
                _librarian.AddBook(GetBook(index + 1));
            }
        }

        [TestMethod]
        public void TestGetAllBooksWhen_NoBooksIssued()
        {
            var books = _librarian.GetAllBooks();
            Assert.IsNotNull(books);
            Assert.AreEqual(books.Count, 5);

        }

        [TestMethod]
        public void TestBookIssue()
        {
            var books = _librarian.GetAllBooks();
            var issued = _librarian.IssueBook(books[1].Id);
            Assert.IsTrue(issued);

            var remainingBooks = _librarian.GetAllBooks();
            Assert.IsNotNull(remainingBooks);
            Assert.AreEqual(remainingBooks.Count, 4);

        }

        private static Book GetBook(int index)
        {
            return new Book
            {
                Id = $"Id{index}",
                Name = $"Book{index}",
                Author = $"AuthorName",
                Edition = $"Edition-{index}",
                IsIssued = false,
                Genere = Genere.Fiction,
                Publication = $"Publication{index}"
            };
        }

    }
}
