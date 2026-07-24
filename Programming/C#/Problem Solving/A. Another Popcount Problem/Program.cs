public class Solve
{
    /*public static long countBit(long num)
    {
        long count = 0;

        while (num > 0)
        {
            count += num % 2;
            num /= 2;
        }

        return count;
    }*/


    public static void Main(string[] args)
    {
        long tc = long.Parse(Console.ReadLine());

        long n, k;
        while (tc-- > 0)
        {
            string[] input = Console.ReadLine().Split();

            n = long.Parse(input[0]);
            k = long.Parse(input[1]);

            long ans = 0;

            for (int i = 0; i < 30; i++)
            {
                long power = 1L << i;   // 2^i

                long num = Math.Min(n / power, k);

                ans += num;
                n -= num * power;
            }

            Console.WriteLine(ans);
        }
    }
}





// 2nd try 
/*long tempBitCount = 0;
long mainBitCount = 0;

if (k >= n)
{
    Console.WriteLine(n);
    continue;
}

else
{

    for (int i = 1; i <= n; i++)
    {
        tempBitCount = 0;
        if (i * k <= n)
        {
            tempBitCount = Solve.countBit(i);
            tempBitCount *= k;

            if(tempBitCount > mainBitCount)
            {
                mainBitCount = tempBitCount;
            }
        }

        else break;
    }

}


double temp = 0;
int power = 0;
long tempBitCount2 = 0;
long mainBitCount2 = 0;

while (true)
{ 
    temp = Math.Pow(2, power);

    if(temp > n)
    {
        break;
    }

    temp -= 1;
    tempBitCount2 = Solve.countBit((long)temp);

    if (temp * k > n) tempBitCount2 *= (long)(n / temp);
    else tempBitCount2 *= k;

    if (tempBitCount2 > mainBitCount2)
    {
        mainBitCount2 = tempBitCount2;
    }

    power++;
    tempBitCount2 = 0;
}

Console.WriteLine("1st -> " + mainBitCount + "   2nd -> " + mainBitCount2);

Console.WriteLine(mainBitCount > mainBitCount2 ? mainBitCount: mainBitCount2);*/







// first try
/*long tempBits = 0, Mainbits = 0;
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

tc--;*/
