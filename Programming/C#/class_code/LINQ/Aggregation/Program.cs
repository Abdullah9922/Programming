public class Myclass
{

    // aggregation - sum, count, average, Min, Max
    // single value output hisabe dibe.
    public static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6 };
        int sum = numbers.Sum();
        int max = numbers.Max(); 
        int min = numbers.Min();
        int count = numbers.Count();
        double avg = numbers.Average();

        Console.WriteLine("Sum: " + sum + "\nMax: " + max + "\nMin: " + min + "\nCount: " + count + "\nAvg: " + avg);

    }
}
