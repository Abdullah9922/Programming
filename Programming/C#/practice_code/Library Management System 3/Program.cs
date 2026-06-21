public abstract class Person
{
    public string Name { get; protected set; }
    public string Email { get; protected set; }

    public Person(string name, string email)
    {
        Name = name;
        Email = email;
    }

    public abstract void DisplayInfo();
}


public class Student : Person
{
    public int StudentId { get; protected set; }

    public Student(string name, string email, int id)
        : base(name, email)
    {
        StudentId = id;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"[Name] {Name} | [Email] {Email} | [Id] {StudentId}");
    }
}


public class Librarian : Person
{
    public int EmployeeId { get; protected set; }

    public Librarian(string name, string email, int id)
        : base(name, email)
    {
        EmployeeId = id;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"[Name] {Name} | [Email] {Email} | [Id] {EmployeeId}");
    }
}


public interface IBorrowable
{
    public void Borrow();
    public void ReturnBook();
}


public class BorrowRecord
{
    public Student Student { get; private set; }
    public Book Book { get; private set; }

    public DateTime BorrowDate { get; private set; }
    public DateTime? ReturnDate { get; private set; }

    public BorrowRecord(Student student, Book book)
    {
        Student = student;
        Book = book;
        BorrowDate = DateTime.Now;
    }

    public void MarkAsReturned()
    {
        ReturnDate = DateTime.Now;
    }

    public void ShowRecord()
    {
        Console.WriteLine(
            $"{Student.Name} borrowed \"{Book.Title}\" on {BorrowDate}"
        );

        if (ReturnDate != null)
        {
            Console.WriteLine($"Returned on {ReturnDate}");
        }
        else
        {
            Console.WriteLine("Not returned yet.");
        }

        Console.WriteLine();
    }
}


public class Book : IBorrowable
{
    public int Id { get; private set; }
    public string Title { get; private set; }
    public string Author { get; private set; }
    public bool Isavailable { get; private set; }

    public Book(int id, string title, string author)
    {
        Id = id;
        Title = title;
        Author = author;
        Isavailable = true;
    }

    public void Borrow()
    {
        if (!Isavailable)
        {
            Console.WriteLine("Book is already borrowed.");
            return;
        }
        Isavailable = false;
    }

    public void ReturnBook()
    {
        Isavailable = true;
    }

    public void DisplayBook()
    {
        Console.WriteLine($"[Book Id] {Id} | [Book Title] {Title} | [Author] {Author} | [Availabiliy] {Isavailable} ");
    }

}


public class Library
{
    private List<Book> books;
    private List<Student> students;
    private List<BorrowRecord> records;

    public Library()
    {
        books = new List<Book>();
        students = new List<Student>();
        records = new List<BorrowRecord>();
    }

    public void AddBook(Book b)
    {
        books.Add(b);
    }

    public void RegisterStudent(Student s)
    {
        students.Add(s);
    }

    public void BorrowBook(int studentId, int bookId)
    {
        Student student = students.Find(s => s.StudentId == studentId);
        Book book = books.Find(b => b.Id == bookId);

        if (student == null)
        {
            Console.WriteLine("Student not found.");
            return;
        }

        if (book == null)
        {
            Console.WriteLine("Book not found.");
            return;
        }

        if (!book.Isavailable)
        {
            Console.WriteLine("Book is already borrowed.");
            return;
        }

        book.Borrow();

        records.Add(new BorrowRecord(student, book));

        Console.WriteLine("Book borrowed successfully.");
    }


    public void ReturnBook(int bookId)
    {
        BorrowRecord record = records.Find(r =>
            r.Book.Id == bookId &&
            r.ReturnDate == null);

        if (record == null)
        {
            Console.WriteLine("Borrow record not found.");
            return;
        }

        record.Book.ReturnBook();
        record.MarkAsReturned();

        Console.WriteLine("Book returned successfully.");
    }

    public void ShowAllBook()
    {
        Console.WriteLine($"Total Books: {books.Count}");
        foreach (Book book in books)
        {
            book.DisplayBook();
        }
        Console.WriteLine();
    }

    public void ShowBorrowRecords()
    {
        Console.WriteLine($"Total Records: {records.Count}");
        foreach (BorrowRecord record in records)
        {
            record.ShowRecord();
        }
    }

}


public class Mainn
{
    public static void Main(string[] args)
    {

        Library library = new Library();

        // add book
        library.AddBook(new Book(1, "Clean Code", "Robert C. Martin"));
        library.AddBook(new Book(2, "Head First C#", "Andrew Stellman"));
        library.AddBook(new Book(3, "Design Patterns", "GoF"));

        //add student
        library.RegisterStudent(new Student("Asif", "asif@example.com",101));

        library.RegisterStudent(new Student("Rahim", "rahim@example.com", 102));


        library.BorrowBook(101, 1);

        library.ShowAllBook();

        library.ReturnBook(1);

        library.ShowBorrowRecords();



        Console.WriteLine("=== Polymorphism Demo ===");
        Person p1 = new Student("Karim", "karim@example.com",201);

        Person p2 = new Librarian("Mr. Hasan", "hasan@example.com", 1);

        p1.DisplayInfo();
        Console.WriteLine();

        p2.DisplayInfo();

        Console.ReadKey();
    }
}
