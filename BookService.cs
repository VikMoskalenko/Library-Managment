using LibraryManagment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment
{
    public class BookService
    {
        private readonly IBook _book;
        public BookService(IBook book)
        {
            _book = book;
        }
        public void AddBook(Book book)
        {
            _book.AddBook(book);
        }

        public void UpdateBook(Book book)
        {
            _book.UpdateBook(book);
        }
        public void DeleteBook(int id)
        {
            _book.DeleteBook(id);
        }
        public Book GetBookById(int id)
        {
            return _book.GetBookById(id);
        }
        public List<Book> GetAllBooks()
        {

        return _book.GetAllBooks(); 
        }
    
    }
}
