namespace Library_Management_System__Practice_
{
    public class FineCalculator : IFineCalculator
    {
        public int CalculateFine(DateTime borrowDate, DateTime returnDate)
        {
            int day = (returnDate - borrowDate).Days;

            if (day > 7) return (day - 7) * 10;
            else return 0;
        }
    }
}
