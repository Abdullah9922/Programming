using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Management_System__Practice_
{
    public class BorrowRecordManager
    {
        private List<BorrowRecord> _records = new();

        public void AddRecord (BorrowRecord record)
        {
            _records.Add(record);
        }

        public void RemoveRecord(BorrowRecord record)
        {
            _records.Remove(record);
        }

        public bool FineRecord(int memberId)
        {
            return _records.Any( r => r.MemberId  == memberId);
        }

        public DateTime? FindBorrowDate(int memberId)
        {
            bool findMember = _records.Any(r => r.MemberId == memberId);

            if (findMember)
            {
                return _records.FirstOrDefault(r => r.MemberId == memberId).BorrowDate;
            }
            else return null;
        }

        public DateTime? FindReturnDate(int memberId)
        {
            bool findMember = _records.Any(r => r.MemberId == memberId);

            if (findMember)
            {
                return _records.FirstOrDefault(r => r.MemberId == memberId).RetuenDate;
            }
            else return null;
        }
    }
}
