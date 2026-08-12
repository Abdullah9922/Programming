using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Management_System___Modified__
{
    public class FineCalculator : IFineCalculator
    {
        public decimal CalculateFine(DateTime borrowDate, DateTime returnDate)
        {
            int days = (returnDate - borrowDate).Days;

            if (days <= 7)
                return 0;

            return (days - 7) * 10;
        }
    }
}
