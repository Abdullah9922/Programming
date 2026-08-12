using Library_Management_System___Modified__;

BookManager bookManager = new BookManager();
MemberManager memberManager = new MemberManager();
IFineCalculator fineCalculator = new FineCalculator();

Library library = new Library(
    bookManager,
    memberManager,
    fineCalculator
);


// ---- Seed some default Books ----
bookManager.AddBook(new Book("101", "The Alchemist", "Paulo Coelho", "Fiction"));
bookManager.AddBook(new Book("102", "Clean Code", "Robert C. Martin", "Programming"));
bookManager.AddBook(new Book("103", "Sapiens", "Yuval Noah Harari", "History"));
bookManager.AddBook(new Book("104", "Atomic Habits", "James Clear", "Self-Help"));
bookManager.AddBook(new Book("105", "1984", "George Orwell", "Fiction"));

// ---- Seed some default Members ----
memberManager.RegisterMember(new Member(1, "Rahim Uddin", "01711111111", "rahim@example.com"));
memberManager.RegisterMember(new Member(2, "Karim Hossain", "01722222222", "karim@example.com"));
memberManager.RegisterMember(new Member(3, "Ayesha Akter", "01733333333", "ayesha@example.com"));



Menu menu = new Menu();

int exitFlag = 0;

while (true)
{
    
    menu.ShowMainMenu();

    int ch;
    while (!int.TryParse(Console.ReadLine(), out ch))
    {
        Console.WriteLine("Invalid input. Enter a number:");
    }

    switch (ch)
    {
        case 1:

            while (true)
            {
                menu.ShowLibrarianMenu();

                int ch1;
                while (!int.TryParse(Console.ReadLine(), out ch1))
                {
                    Console.WriteLine("Invalid input. Enter a number:");
                }

                switch (ch1)
                {
                    case 1: // Add Book
                        Console.Write("ISBN: ");
                        string isbn = Console.ReadLine()!;
                        Console.Write("Title: ");
                        string title = Console.ReadLine()!;
                        Console.Write("Author: ");
                        string author = Console.ReadLine()!;
                        Console.Write("Category: ");
                        string category = Console.ReadLine()!;

                        bookManager.AddBook(new Book(isbn, title, author, category));
                        Console.WriteLine("Book added successfully.");
                        break;

                    case 2: // Delete Book
                        Console.Write("Enter ISBN to delete: ");
                        string deleteIsbn = Console.ReadLine()!;
                        bookManager.DeleteBook(deleteIsbn);
                        Console.WriteLine("Book deleted (if it existed).");
                        break;

                    case 3: // Register Member
                        Console.Write("Member ID: ");
                        int memberId = int.Parse(Console.ReadLine()!);
                        Console.Write("Name: ");
                        string name = Console.ReadLine()!;
                        Console.Write("Phone: ");
                        string phone = Console.ReadLine()!;
                        Console.Write("Email: ");
                        string email = Console.ReadLine()!;

                        memberManager.RegisterMember(new Member(memberId, name, phone, email));
                        Console.WriteLine("Member registered successfully.");
                        break;

                    case 4: // Calculate Fine
                        Console.Write("Member ID: ");
                        int fineMemberId = int.Parse(Console.ReadLine()!);
                        Console.Write("ISBN: ");
                        string fineIsbn = Console.ReadLine()!;

                        Member? fineMember = memberManager.FindMember(fineMemberId);
                        Book? fineBook = bookManager.FindByISBN(fineIsbn);

                        if (fineMember == null || fineBook == null)
                            Console.WriteLine("Member or Book not found.");
                        else
                            library.Return(fineBook, fineMember);
                        break;

                    case 5: // Show Available Books
                        foreach (Book b in bookManager.GetAvailableBooks())
                            b.DisplayBook();
                        break;

                    case 6: // Show Borrowed Books
                        foreach (Book b in bookManager.GetBorrowedBooks())
                            b.DisplayBook();
                        break;

                    case 7:
                        exitFlag = 1;
                        break;

                    default:
                        Console.WriteLine("Invalid Input. Please try again.");
                        break;
                }

                if (exitFlag == 1)
                {
                    exitFlag = 0;
                    break;
                }
            }

            break;

        case 2:

            while (true)
            {
                menu.ShowMemberMenu();

                int ch2;
                while (!int.TryParse(Console.ReadLine(), out ch2))
                {
                    Console.WriteLine("Invalid input. Enter a number:");
                }

                switch (ch2)
                {
                    case 1: // Show All Books
                        foreach (Book b in bookManager.GetAllBooks())
                            b.DisplayBook();
                        break;

                    case 2: // Search Book
                        Console.Write("Enter keyword: ");
                        string keyword = Console.ReadLine()!;
                        foreach (Book b in bookManager.SearchBook(keyword))
                            b.DisplayBook();
                        break;

                    case 3: // Borrow Book
                        Console.Write("Member ID: ");
                        int borrowMemberId = int.Parse(Console.ReadLine()!);
                        Console.Write("ISBN: ");
                        string borrowIsbn = Console.ReadLine()!;

                        Member? borrowMember = memberManager.FindMember(borrowMemberId);
                        Book? borrowBook = bookManager.FindByISBN(borrowIsbn);

                        if (borrowMember == null || borrowBook == null)
                            Console.WriteLine("Member or Book not found.");
                        else
                            library.Borrow(borrowBook, borrowMember);
                        break;

                    case 4: // Return Book
                        Console.Write("Member ID: ");
                        int returnMemberId = int.Parse(Console.ReadLine()!);
                        Console.Write("ISBN: ");
                        string returnIsbn = Console.ReadLine()!;

                        Member? returnMember = memberManager.FindMember(returnMemberId);
                        Book? returnBook = bookManager.FindByISBN(returnIsbn);

                        if (returnMember == null || returnBook == null)
                            Console.WriteLine("Member or Book not found.");
                        else
                            library.Return(returnBook, returnMember);
                        break;

                    case 5:
                        exitFlag = 1;
                        break;

                    default:
                        Console.WriteLine("Invalid Input. Please try again.");
                        break;
                }

                if (exitFlag == 1)
                {
                    exitFlag = 0;
                    break;
                }
            }

            break;

        case 3:
            Console.WriteLine("\nThank you for using the system. Goodbye!");
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Invalid Input. Please try again.");
            break;
    }
}