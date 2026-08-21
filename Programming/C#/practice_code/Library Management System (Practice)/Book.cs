using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Library_Management_System__Practice_
{
    public class Book
    {
        private int _isbn;
        private string _title;
        private string _author;
        private bool _isAvailable;

        public int ISBN { get { return _isbn; } private set { if (value >= 0) _isbn = value; } }
        public string Title { get { return _title; } private set { if (value != null) _title = value; } }
        public string Author { get { return _author; } private set { if (value != null) _author = value; } }
        public bool IsAvailable { get { return _isAvailable; } private set { _isAvailable = value; } }

        public Book() : this(0) { }
        public Book(int isbn) : this(isbn, "Unknown") { }
        public Book(int isbn,string title) : this(isbn,title, "Unknown") { }
        public Book(int isbn,string title,string author)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            IsAvailable = true;
        }

        public void Borrow(Book b)
        {
            b._isAvailable = false;
        }

        public void Return(Book b)
        {
            b._isAvailable = true;
        }

        public void DisplayBook()
        {
            Console.WriteLine();
            Console.WriteLine($"{ISBN} | {Title} | {Author} |  " + $"{(IsAvailable ? "Available" : "Borrowed")}");
        }
    }
}
