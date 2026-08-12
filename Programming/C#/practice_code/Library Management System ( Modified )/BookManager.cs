using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Library_Management_System___Modified__
{
    public class BookManager : ISearchable
    {
        private readonly List<Book> _books = new();

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public void DeleteBook(string isbn)
        {
            Book? book = FindByISBN(isbn);

            if (book != null)
                _books.Remove(book);
        }

        public Book? FindByISBN(string isbn)
        {
            return _books.FirstOrDefault(b => b.ISBN == isbn);
        }

        public List<Book> GetAllBooks()
        {
            return _books;
        }

        public List<Book> GetAvailableBooks()
        {
            return _books
                .Where(b => b.IsAvailable)
                .ToList();
        }

        public List<Book> GetBorrowedBooks()
        {
            return _books
                .Where(b => !b.IsAvailable)
                .ToList();
        }

        public List<Book> SearchBook(string keyword)
        {
            return _books
                .Where(b =>
                    b.Title.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                    b.Author.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                    b.ISBN.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}
