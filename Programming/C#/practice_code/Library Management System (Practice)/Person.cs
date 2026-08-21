using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Management_System__Practice_
{
    public abstract class Person
    {
        private int _id;
        private string _name;
        private string _email;

        public int Id { get { return _id; } protected set { if(value > 0) _id = value; } }
        public string Name { get { return _name; } protected set { if (value != null) _name = value; } }
        public string Email { get { return _name; } protected set { if (value != null) _email = value; } }

        public Person() : this(0) { }
        public Person(int id): this(id, "unknown") { }
        public Person(int id, string name) : this(id, name, "unknown@example.com") { }
        public Person(int id, string name,string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        public abstract void DisplayInfo();

    }
}
