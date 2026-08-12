using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Management_System___Modified__
{
    public interface IBorrowable
    {
        void Borrow(Book book, Member member);
        void Return(Book book, Member member);
    }
}
