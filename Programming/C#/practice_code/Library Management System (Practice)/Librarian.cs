using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Library_Management_System__Practice_
{
    public class Librarian : Person
    {
        public Librarian() : this(0) { }
        public Librarian(int id) : this(id, "unknown") { }
        public Librarian(int id, string name) : this(id, name, "unknown@example.com") { }
        public Librarian (string name): this(0, name, "unknown@example.com") { }
        public Librarian(int id, string name, string email) : base(id, name, email) { }
        public override void DisplayInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Librarian ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine();
        }
    }
}
