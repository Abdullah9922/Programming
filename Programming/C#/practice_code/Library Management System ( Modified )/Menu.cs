using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Management_System___Modified__
{
    public class Menu
    {
        public void ShowMainMenu()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("     LIBRARY MANAGEMENT SYSTEM");
            Console.WriteLine("=================================");
            Console.WriteLine("1. Librarian");
            Console.WriteLine("2. Member");
            Console.WriteLine("3. Exit");
        }

        public void ShowLibrarianMenu()
        {
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Delete Book");
            Console.WriteLine("3. Register Member");
            Console.WriteLine("4. Calculate Fine");
            Console.WriteLine("5. Show Available Books");
            Console.WriteLine("6. Show Borrowed Books");
            Console.WriteLine("7. Exit");
        }

        public void ShowMemberMenu()
        {
            Console.WriteLine("1. Show All Books");
            Console.WriteLine("2. Search Book");
            Console.WriteLine("3. Borrow Book");
            Console.WriteLine("4. Return Book");
            Console.WriteLine("5. Exit");
        }
    }
}
