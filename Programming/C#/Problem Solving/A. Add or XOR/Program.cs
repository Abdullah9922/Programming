int tc = int.Parse(Console.ReadLine());

int a, b, x, y;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();

    a = int.Parse(input[0]);
    b = int.Parse(input[1]);
    x = int.Parse(input[2]);
    y = int.Parse(input[3]);

    if (b % 2 != 0 && b < a) Console.WriteLine(-1);

    else if (b % 2 == 0 && b + 1 < a) Console.WriteLine(-1);

    else
    {
        int cost1 = (b - a) * x;

        if(a % 2 != 0 ) Console.WriteLine(cost1);
        else
        {
            if( b + 1 == a)
            {
                Console.WriteLine(cost1 < y ? cost1 : y);
            }
            else Console.WriteLine(cost1);
        }
    }
}
