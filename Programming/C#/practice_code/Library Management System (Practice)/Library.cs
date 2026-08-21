using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Management_System__Practice_
{
    public class Library
    {
        private BorrowRecordManager _borrowManager;
        private MemberManager _memberManager;
        private BookManager _bookManager;

        public Library(BorrowRecordManager borrowManager , MemberManager memberManager, BookManager bookManager)
        {
            _bookManager = bookManager;
            _borrowManager = borrowManager;
            _memberManager = memberManager;
        }

        public void Borrow(int memberId, int bookId)
        {
            bool foundMember = _memberManager.FindMember( memberId);
            bool foundBook = _bookManager.FindBook(bookId);
            Book book = _bookManager.SearchBook(bookId);

            if(foundMember == null || foundBook == null)
            {
                Console.WriteLine("Book or Member Not found");
            }

            else
            {
                Book temp = new Book();
                temp.Borrow(book);

                BorrowRecord record = new BorrowRecord(memberId, bookId);
                record.MakeBorrow();
                _borrowManager.AddRecord(record);
            }
        }

        public void Return(int memberId, int bookId)
        {
            bool foundMember = _memberManager.FindMember(memberId);
            bool foundBook = _bookManager.FindBook(bookId);
            Book book = _bookManager.SearchBook(bookId);

            if (foundMember == null || foundBook == null)
            {
                Console.WriteLine("Book or Member Not found");
            }

            else
            {
                Book temp = new Book();
                temp.Borrow(book);

                BorrowRecord record = new BorrowRecord(memberId, bookId);
                record.MakeReturn();
                _borrowManager.RemoveRecord(record);
            }
        }
    }
}
