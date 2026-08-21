using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Management_System__Practice_
{
    public class Member : Person
    {
        public Member() : this(0) { }
        public Member(int id) : this(id, "unknown") { }
        public Member(int id, string name) : this(id, name, "unknown@example.com") { }
        public Member(string name) : this(0, name, "unknown@example.com") { }
        public Member(int id, string name, string email): base(id, name, email) { }
        public override void DisplayInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Member ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine();
        }
    }
}
