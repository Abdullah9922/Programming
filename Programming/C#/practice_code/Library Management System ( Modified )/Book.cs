using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Management_System___Modified__
{
    public class Book
    {
        private string _isbn;
        private string _title;
        private string _author;
        private string _category;
        private bool _isAvailable;

        public string ISBN
        {
            get { return _isbn; }
            private set { _isbn = value; }
        }

        public string Title
        {
            get { return _title; }
            private set { _title = value; }
        }

        public string Author
        {
            get { return _author; }
            private set { _author = value; }
        }

        public string Category
        {
            get { return _category; }
            private set { _category = value; }
        }

        public bool IsAvailable
        {
            get { return _isAvailable; }
            private set { _isAvailable = value; }
        }

        public Book(string isbn, string title, string author, string category)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            Category = category;
            IsAvailable = true;
        }

        public void Borrow()
        {
            IsAvailable = false;
        }

        public void Return()
        {
            IsAvailable = true;
        }

        public void DisplayBook()
        {
            Console.WriteLine($"{ISBN} | {Title} | {Author} | {Category} | " +
                              $"{(IsAvailable ? "Available" : "Borrowed")}");
        }
    }
}
