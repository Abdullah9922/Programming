
try
{
    Console.Write($"Enter num1 = ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write($"Enter num2 = ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    if(num2 > 1000)
    {
        throw new ArgumentException("Num2 is not valid input.\n");
    }

    int result = num1 / num2;
    Console.WriteLine($"Result: {result}");
}
catch (OverflowException)
{
    Console.WriteLine($"Number was too big or small for Int32");
}
catch (Exception e)
{
    Console.WriteLine($"An error occured: {e.Message}");
}

finally
{
    Console.WriteLine("Good Bye");
}