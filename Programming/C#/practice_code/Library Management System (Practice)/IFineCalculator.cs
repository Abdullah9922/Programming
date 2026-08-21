using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Library_Management_System__Practice_
{
    public interface IFineCalculator
    {
        int CalculateFine(DateTime borrowDate, DateTime returnDate);
    }
}
