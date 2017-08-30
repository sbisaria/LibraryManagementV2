using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public interface ILibraryManager
    {
        void AddBook(Book book);
        List<Book> GetAllBooks();
        bool IssueBook(string id);
        List<Book> GetAllIssuedBooks();
    }
}
