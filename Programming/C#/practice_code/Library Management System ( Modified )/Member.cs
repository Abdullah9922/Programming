using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Library_Management_System___Modified__
{
    public class Member: Person
    {
        public Member(int id, string name, string phone, string email)
        : base(id, name, phone, email)
        {
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Member ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Phone: {Phone}");
            Console.WriteLine($"Email: {Email}");
        }
    }
}
