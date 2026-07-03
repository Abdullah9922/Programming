using System.ComponentModel;

public class Solve
{
    public static long countBit(long num)
    {
        long count = 0;

        while (num > 0)
        {
            count += num % 2;
            num /= 2;
        }

        return count;
    }


    public static void Main(string[] args)
    {
        long tc = long.Parse(Console.ReadLine());

        long n, k;
        while (tc > 0)
        {
            string[] input = Console.ReadLine().Split();

            n = long.Parse(input[0]);
            k = long.Parse(input[1]);

            long tempBits = 0, Mainbits = 0;
            for (long i = 1; i <= n; i++)
            {
                tempBits = countBit(i);
                //Console.WriteLine("Number: " + i + " -> ");
                //Console.WriteLine("Bit count: " + tempBits);

                long count = 1;
                long  num = 1;

                while (true)
                {
                    if (num <= n && count <= k) //if (num <= i && count <= k)
                    {
                        num = count * num;
                        count++;
                    }
                    else
                    {
                        count--;
                        break;
                    }
                }

                //Console.WriteLine("Mul count: " + count);
                //Console.WriteLine();


                tempBits = tempBits * count;
                if (tempBits > Mainbits)
                {
                    Mainbits = tempBits;
                }
            }

            Console.WriteLine(Mainbits);
            //Console.WriteLine();

            tc--;
        }
        Console.ReadKey();
    }
}
