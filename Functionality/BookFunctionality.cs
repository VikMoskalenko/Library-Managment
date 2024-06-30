using LibraryManagment.classes;
using LibraryManagment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.Functionality
{
    public class BookFunctionality : IBook
    {
        private readonly LibraryContext _context;
        public BookFunctionality(LibraryContext context)
        {

            _context = context;
        }

        public void AddBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }
        public void UpdateBook(Book book)
        {
            _context.Books.Update(book);
            _context.SaveChanges();
        }

        public void DeleteBook(int id)
        {
            var book = _context.Books.Find(id);
            if (book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
            }
        }
        public Book GetBookById(int id)
        {
            return _context.Books.Find(id);
        }
        public List<Book> GetAllBooks()
        {
            return _context.Books.ToList();
        }




    }
}
