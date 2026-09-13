
int tc = int.Parse(Console.ReadLine());

int l1, b1, l2, b2, l3, b3;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();
    l1 = int.Parse(input[0]);
    b1 = int.Parse(input[1]);
    l2 = int.Parse(input[2]);
    b2 = int.Parse(input[3]);
    l3 = int.Parse(input[4]);
    b3 = int.Parse(input[5]);

    if (l1 + l2 + l3 == b1 && b1 == b2 && b2 == b3) Console.WriteLine("YES");
    else if (l2 + l3 == l1 && b2 == b3 && b1 + b2 == l1) Console.WriteLine("YES");
    else if (b1 + b2 + b3 == l1 && l1 == l2 && l2 == l3) Console.WriteLine("YES");
    else if (b2 + b3 == b1 && l2 == l3 && l1 + l2 == b1) Console.WriteLine("YES");
    else Console.WriteLine("NO");

    
}
