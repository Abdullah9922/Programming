using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Management_System__Practice_
{
    public class BorrowRecord
    {
        public int MemberId { get; private set; }
        public int BookId { get; private set; }
        public DateTime BorrowDate { get; private set; }
        public DateTime RetuenDate { get; private set; }

        public BorrowRecord(int memberId ,int bookId)
        {
            MemberId = memberId;
            BookId = bookId;
        }

        public void MakeBorrow()
        {
            BorrowDate = DateTime.Now;
        }

        public void MakeReturn()
        {
            RetuenDate = DateTime.Now;
        }
    }
}
