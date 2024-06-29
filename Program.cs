using System;
using System.Collections.Generic;

namespace LibraryManagment
{
     class Program
    {
        static void Main(string[] args)
        {
            var bookService = new BookService(new BookFunctionality(new LibraryContext()));
            var userService = new UserService(new UserFunctionality(new LibraryContext()));
            var loanService = new LoanService(new LoaFunctionality(new LibraryContext()));

            while (true)
            {
                Console.WriteLine("Library Managment");
                Console.WriteLine("1. Add book");
                Console.WriteLine("2. View Books");
                Console.WriteLine("3. Add User");
                Console.WriteLine("4. View");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Choose an otion: ");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddBook(bookService);
                        break;
                    case "2":
                        ViewBooks(bookService);
                        break;
                    case "3":
                        AddUser(userService);
                        break;
                    case "4":
                        ViewUsers(userService);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;

                }
            }

        }
        static void AddBook(BookService bookService)
        {
            Console.Write("Enter book title: ");
            var title = Console.ReadLine();
            Console.Write("Enter book author: ");
            var author = Console.ReadLine();
            Console.Write("Enter book ISBN: ");
            var isbn = Console.ReadLine();
            Console.Write("Enter book Genre: ");
            var genre = Console.ReadLine();
            Console.Write("Enter a books`s year: ");
            var year = Convert.ToInt32(Console.ReadLine());
            

            var book = new Book { Title = title, Author = author, ISBN = isbn, Genre = genre, Year = year };
            bookService.AddBook(book);

            Console.WriteLine("Book added successfully.");
        }
        static void ViewBooks(BookService bookService)
        {
            var books = bookService.GetAllBooks();
            Console.WriteLine("Books in the library:");
            foreach (var book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}, Genre: {book.Genre}, Year: {book.Year} ");
            }
        }

        static void AddUser(UserService userService)
        {
            Console.Write("Enter user name: ");
            var name = Console.ReadLine();
            Console.Write("Enter user email: ");
            var email = Console.ReadLine();
            Console.Write("Enter user phone: ");
            var phone = Console.ReadLine();

            var user = new User { Name = name, Email = email, Phone = phone };
            userService.AddUser(user);

            Console.WriteLine("User added successfully.");
        }

        static void ViewUsers(UserService userService)
        {
            var users = userService.GetAllUsers();
            Console.WriteLine("Users in the system:");
            foreach (var user in users)
            {
                Console.WriteLine($"Name: {user.Name}, Email: {user.Email}");
            }
        }
    }
}
