int index = 0;
Book[] array_book = new Book[10];

public class Book
{
    public int id;
    public string name;
    public string author;
    public bool abailability;

    public Book(int id, string name, string author)
    {
        this.id = id;
        this.name = name;
        this.author = author;
        this.abailability = true;
    }

    public void display_books()
    {
        Console.WriteLine($"Book id {id}.");
        Console.WriteLine($"Book name is {name}.");
        Console.WriteLine($"Book's author name is {author}");
        Console.WriteLine($"Book's availability is {abailability}");
    }
}

class Test
{
    public static void add_book()
    {
        int book_id = 0;
        Console.Write("Enter book id: ");
        book_id = Convert.ToInt16(Console.ReadLine());

        string book_name;
        Console.Write("Enter book name: ");
        book_name = Console.ReadLine();

        string author_name;
        Console.Write("Enter book author name: ");
        author_name = Console.ReadLine();

        Book b = new Book(book_id, book_name, author_name);
        array_book[index++] = b;
    }

    public static void show_books()
    {
        for (int i = 0; i < index; i++)
        {
            Book b = array_book[i];
            b.display_books();
            Console.WriteLine("\n\n");
        }
    }

    public static void search_book()
    {
        int flag = 0;
        int b_id = 0;
        Console.Write("Enter Book ID: ");
        b_id = Convert.ToInt16(Console.ReadLine());

        for (int i = 0; i < index; i++)
        {
            Book b = array_book[i];
            if (b_id == b.id)
            {
                b.display_books();
                Console.WriteLine("\n\n");
                flag++;
                break;
            }
        }

        if (flag == 0)
        {
            Console.WriteLine("Books not found\n\n");
        }
    }

    public static void boorrow_book()
    {
        int flag = 0;
        int b_id = 0;
        Console.Write("Enter Book ID: ");
        b_id = Convert.ToInt16(Console.ReadLine());

        for (int i = 0; i < index; i++)
        {
            Book b = array_book[i];
            if (b_id == b.id && b.abailability == true)
            {
                Console.WriteLine($"{b.name} is borrowed successfully.");
                b.abailability = false;
                Console.WriteLine("\n\n");
                flag++;
                break;
            }
        }

        if (flag == 0)
        {
            Console.WriteLine("Books not found\n\n");
        }
    }

    public static void return_book()
    {
        int flag = 0;
        int b_id = 0;
        Console.Write("Enter Book ID: ");
        b_id = Convert.ToInt16(Console.ReadLine());

        for (int i = 0; i < index; i++)
        {
            Book b = array_book[i];
            if (b_id == b.id && b.abailability == false)
            {
                Console.WriteLine($"{b.name} is returned successfully.");
                b.abailability = true;
                Console.WriteLine("\n\n");
                flag++;
                break;
            }
        }

        if (flag == 0)
        {
            Console.WriteLine("Book not found\n\n");
        }
    }

    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter your choice: ");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Show Books");
            Console.WriteLine("3. Search Book");
            Console.WriteLine("4. Borrow Book");
            Console.WriteLine("5. Return Book");
            Console.WriteLine("6. Exit");

            Console.Write("Enter Your Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    if (index < 10) { add_book(); }
                    else { Console.WriteLine("Storage is Full.\n\n"); }
                    break;
                case 2:
                    if (index == 0) { Console.WriteLine("Storage is Empty.\n\n"); }
                    else { show_books(); }
                    break;
                case 3:
                    if (index == 0) { Console.WriteLine("Storage is Empty.\n\n"); }
                    else { search_book(); }
                    break;
                case 4:
                    if (index == 0) { Console.WriteLine("Storage is Empty.\n\n"); }
                    else { boorrow_book(); }
                    break;
                case 5:
                    if (index == 0) { Console.WriteLine("Storage is Empty.\n\n"); }
                    else { return_book(); }
                    break;
                case 6:
                    Console.WriteLine("\n\n***Good-Bye***\n\n");
                    return;
                default:
                    Console.WriteLine("Wrong Choice. Please Try again.\n\n");
                    break;
            }
        }
    }
}