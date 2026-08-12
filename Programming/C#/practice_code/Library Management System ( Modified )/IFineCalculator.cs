using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Management_System___Modified__
{
    public interface IFineCalculator
    {
        decimal CalculateFine(DateTime borrowDate, DateTime returnDate);
    }
}
