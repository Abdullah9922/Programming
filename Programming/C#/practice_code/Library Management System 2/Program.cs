using System;
using System.Collections.Generic;

interface IBookRepository
{
    public void addBook(Book b);
    public bool removeBook(string isbn);
    public Book searchBook(string title);
}

public class Book
{
    public string isbn { get; set; }
    public string title { get; set; }
    public string author { get; set; }
    public bool isAvailable { get; set; }

    public Book(string isbn, string title, string author)
    {
        this.isbn = isbn;
        this.title = title;
        this.author = author;
        isAvailable = true;
    }


    public string GetDetails()
    {
        return $"[isbn] {isbn} | [Title] {title} | [Author] {author} | [Available] {isAvailable}";
    }

    public void markBorrowed()
    {
        isAvailable = false;
    }

    public void markReturned()
    {
        isAvailable = true;
    }
}

public class Member
{
    private string memberId { get; set; }
    private string name { get; set; }

    private List<Book> borrowedBooks;

    public Member(string id, string n)
    {
        memberId = id;
        name = n;
        borrowedBooks = new List<Book>();
    }

    public void borrowBook(Book b)
    {
        if (!b.isAvailable)
        {
            Console.WriteLine($"Sorry, \"{b.title}\" is not available right now.");
            return;
        }

        b.markBorrowed();
        borrowedBooks.Add(b);
        Console.WriteLine($"{name} borrowed \"{b.title}\".");
    }

    public void returnBook(Book book)
    {
        if (borrowedBooks.Contains(book))
        {
            book.markReturned();
            borrowedBooks.Remove(book);
            Console.WriteLine($"{name} returned \"{book.title}\".");
        }
        else
        {
            Console.WriteLine($"{name} did not borrow \"{book.title}\", nothing to return.");
        }
    }

    public List<Book> getBorrowedList()
    {
        return borrowedBooks;
    }
}

public class Library : IBookRepository
{
    private List<Book> books;
    private List<Member> members;

    public Library()
    {
        books = new List<Book>();
        members = new List<Member>();
    }

    public void addBook(Book item) => books.Add(item);

    public bool removeBook(string isbn) => books.RemoveAll(b => b.isbn == isbn) > 0;

    public Book searchBook(string title)
    {
        Book foundBook = books.Find(b => string.Equals(b.title, title, StringComparison.OrdinalIgnoreCase));
        return foundBook;
    }

    public void registerMember(Member m) => members.Add(m);

    public void ShowAllBooks()
    {
        Console.WriteLine("\n--- All Books ---");
        if (books.Count == 0)
        {
            Console.WriteLine("No Book found");
        }
        else
        {
            foreach (Book book in books)
            {
                
                Console.WriteLine(book.GetDetails());
            }
        }
    }
}

public class Mainn
{
    public static void Main(string[] args)
    {
        Console.WriteLine("===== Library Management System =====\n");

        Library library = new Library();

        Book book1 = new Book("978-1", "C# in Depth", "Jon Skeet");
        Book book2 = new Book("978-2", "Clean Code", "Robert Martin");
        Book book3 = new Book("978-3", "The Pragmatic Programmer", "David Thomas");

        library.addBook(book1);
        library.addBook(book2);
        library.addBook(book3);

        library.ShowAllBooks();

        Member member1 = new Member("M001", "Rohim");
        library.registerMember(member1);

        library.ShowAllBooks();

        Console.WriteLine();

        Book searchResult = library.searchBook("Clean Code");
        if (searchResult != null)
        {
            
            Console.WriteLine($"Congratulations, book found: {searchResult.GetDetails()}");
        }
        Console.WriteLine();

        
        member1.borrowBook(book1);
        library.ShowAllBooks();

        Console.WriteLine();

        member1.returnBook(book1);
        library.ShowAllBooks();

        Console.WriteLine();

        library.removeBook("978-3");
        library.ShowAllBooks();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}