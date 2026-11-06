
int tc = int.Parse(Console.ReadLine());

int a, b;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();
    a = int.Parse(input[0]);
    b = int.Parse(input[1]);

    if (b-a > 1) Console.WriteLine(-1);
    else
    {
        if (a == b) Console.WriteLine(a);
        else if (b > a) Console.WriteLine(b);
        else
        {
            int temp = a - b;
            if (temp % 2 == 0) Console.WriteLine(a);
            else Console.WriteLine(a + 1);
        }
    }
}