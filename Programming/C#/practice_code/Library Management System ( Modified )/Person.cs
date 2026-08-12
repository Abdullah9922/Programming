using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Management_System___Modified__
{
    public abstract class Person
    {
        private int _id;
        private string _name;
        private string _phone;
        private string _email;

        public int Id
        {
            get { return _id; }
            protected set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            protected set { _name = value; }
        }

        public string Phone
        {
            get { return _phone; }
            protected set { _phone = value; }
        }

        public string Email
        {
            get { return _email; }
            protected set { _email = value; }
        }

        protected Person(int id, string name, string phone, string email)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Email = email;
        }

        public abstract void DisplayInfo();
    }
}
