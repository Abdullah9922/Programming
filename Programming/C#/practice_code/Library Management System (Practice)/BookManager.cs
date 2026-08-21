using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Management_System__Practice_
{
    public class BookManager
    {
        private List<Book> _books = new();

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            _books.Remove(book);
        }

        public Book SearchBook(int isbn)
        {
            return _books.FirstOrDefault(b => b.ISBN == isbn);
        }

        public bool FindBook(int isbn)
        {
            return _books.Any(b => b.ISBN == isbn);
        }

        public List<Book> GetAllBooks()
        {
            return _books;
        }

        public List<Book> GetAllBorrowedBooks()
        {
            return _books.Where(b => b.IsAvailable == false).ToList(); 
        }

        public List<Book> GetAllAvailableBooks()
        {
            return _books.Where(b => b.IsAvailable == true).ToList();
        }
    }
}
