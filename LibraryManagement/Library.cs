using System.Collections.Generic;

namespace LibraryManagement
{
    public class Library
    {
        public Library() { }

        public Library(List<Book> books)
        {
            Books.AddRange(books);
        }
        public List<Book> Books { get; } = new List<Book>();
    }
}
