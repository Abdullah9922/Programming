class Test
{
    public static double addition(double x, double y)
    {
        return x + y;
    }
    public static double subtraction(double x, double y)
    {
        return x - y;
    }

    public static double multiplication(double x, double y)
    {
        return x * y;
    }

    public static double divition(double x, double y)
    {
        return (x / y);
    }


    public static void Main(string[] args)
    {
        Console.WriteLine("Simple Calculator: ");

        while (true)
        {
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Exit");

            Console.Write("Enter Your Choice: ");
            int  choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Console.WriteLine("Enter two number:");

                    Console.Write("1st number: ");
                    double x = Convert.ToDouble(Console.ReadLine());

                    Console.Write("2st number: ");
                    double y = Convert.ToDouble(Console.ReadLine());

                    double ans = addition(x, y);
                    Console.WriteLine($"Answer is: {ans}");
                    break;


                case 2:
                    Console.WriteLine("Enter two number:");

                    Console.Write("1st number: ");
                    double x2 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("2st number: ");
                    double y2 = Convert.ToDouble(Console.ReadLine());

                    double ans2 = subtraction(x2, y2);
                    Console.WriteLine($"Answer is: {ans2}");
                    break;


                case 3:
                    Console.WriteLine("Enter two number:");

                    Console.Write("1st number: ");
                    double x3 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("2st number: ");
                    double y3 = Convert.ToDouble(Console.ReadLine());

                    double ans3 = multiplication(x3, y3);
                    Console.WriteLine($"Answer is {ans3}");
                    break;


                case 4:
                    Console.WriteLine("Enter two number:");

                    Console.Write("1st number: ");
                    double x4 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("2st number: ");
                    double y4 = Convert.ToDouble(Console.ReadLine());

                    if(y4 == 0)
                    {
                        Console.WriteLine("Divide not possible.");
                    }
                    else
                    {
                        double ans4 = divition(x4, y4);
                        Console.WriteLine($"Answer is {ans4}");
                    }
                    break;



                case 5:
                    Console.WriteLine("Thank you for using our calculator.");
                    return;
            }
        }


    }
}
