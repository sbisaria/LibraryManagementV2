using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Librarian : ILibraryManager
    {
        private Library _library;//receipt for transaction log
        public Librarian()
        {
            _library = new Library();
        }
        public void AddBook(Book book)
        {
            _library.Books.Add(book);//can be seperated for inventory manager or worker
        }
        public List<Book> GetAllBooks()
        {
            return _library.Books.Where(book => book.IsIssued == false).ToList();
        }

        public List<Book> GetAllIssuedBooks()
        {
            return _library.Books.Where(book => book.IsIssued == true).ToList();
        }

        public bool IssueBook(string id)
        {
            var isIssueSuccessful = false;
            foreach(var book in _library.Books)
            {
                if (book.Id.Equals(id, StringComparison.OrdinalIgnoreCase) && book.IsIssued == false)
                {
                    book.IsIssued = true;
                    isIssueSuccessful = true;
                    break;
                }
            }
            return isIssueSuccessful;
        }
    }
}
