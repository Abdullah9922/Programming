using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Management_System___Modified__
{
    public class Library : IBorrowable
    {
        private readonly BookManager _bookManager;
        private readonly MemberManager _memberManager;
        private readonly IFineCalculator _fineCalculator;

        private readonly List<BorrowRecord> _borrowRecords = new();

        public Library(
            BookManager bookManager,
            MemberManager memberManager,
            IFineCalculator fineCalculator)
        {
            _bookManager = bookManager;
            _memberManager = memberManager;
            _fineCalculator = fineCalculator;
        }

        public void Borrow(Book book, Member member)
        {
            if (!book.IsAvailable)
            {
                Console.WriteLine("Book is already borrowed.");
                return;
            }

            book.Borrow();

            _borrowRecords.Add(
                new BorrowRecord(member.Id, book.ISBN)
            );

            Console.WriteLine("Book borrowed successfully.");
        }

        public void Return(Book book, Member member)
        {
            BorrowRecord? record = _borrowRecords
                .FirstOrDefault(r =>
                    r.MemberId == member.Id &&
                    r.ISBN == book.ISBN &&
                    r.ReturnDate == null);

            if (record == null)
            {
                Console.WriteLine("Borrow record not found.");
                return;
            }

            book.Return();
            record.MarkReturned();

            decimal fine = _fineCalculator.CalculateFine(
                record.BorrowDate,
                record.ReturnDate!.Value
            );

            Console.WriteLine($"Fine: {fine}");
        }
    }
}
