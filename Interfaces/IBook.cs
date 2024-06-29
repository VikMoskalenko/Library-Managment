using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.Interfaces
{
    public interface IBook
    {
        void AddBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(int id);
        Book GetBookId(int id);
        List<Book> GetAllBooks();
    }
}
