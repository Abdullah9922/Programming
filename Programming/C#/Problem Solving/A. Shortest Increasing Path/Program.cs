int tc = int.Parse(Console.ReadLine());

int x, y;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();

    x = int.Parse(input[0]);
    y = int.Parse(input[1]);

    if (x < y) Console.WriteLine(2);
    else
    {
        x -= 1;
        if(x > y) // 4 1
        {
           if(x % 2 == 0)
            {
                Console.WriteLine(-1);
                continue;
            }
            else
            {
                Console.WriteLine(3);
                continue;
            }
        }

        if( x < y)
        {
            Console.WriteLine(-1);
            continue;
        }

        if(x == y)
        {
            Console.WriteLine(-1);//01518389160
            continue;
        }
    }
}