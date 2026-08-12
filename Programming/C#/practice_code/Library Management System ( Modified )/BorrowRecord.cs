using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Management_System___Modified__
{
    public class BorrowRecord
    {
        public int MemberId { get; private set; }
        public string ISBN { get; private set; }
        public DateTime BorrowDate { get; private set; }
        public DateTime? ReturnDate { get; private set; }

        public BorrowRecord(int memberId, string isbn)
        {
            MemberId = memberId;
            ISBN = isbn;
            BorrowDate = DateTime.Now;
        }

        public void MarkReturned()
        {
            ReturnDate = DateTime.Now;
        }
    }
}
