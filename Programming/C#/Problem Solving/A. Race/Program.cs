
int tc = int.Parse(Console.ReadLine());

int a, x, y;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();
    a = int.Parse(input[0]);
    x = int.Parse(input[1]);
    y = int.Parse(input[2]);

    Console.WriteLine((a < x) == (a < y) ? "YES" : "NO");

    //int diff = Math.Abs(x - y);
    
    //if(diff == 0)
    //{
    //    if (a == x) Console.WriteLine("NO");
    //    else Console.WriteLine("YES");
    //}

    //else if(diff % 2 == 0)
    //{
    //    diff /= 2;
    //    if(Math.Min(x,y) + diff == a) Console.WriteLine("NO");
    //    else Console.WriteLine("YES");
    //}

    //else
    //{
    //    diff /= 2;
    //    if(Math.Min(x, y) + diff == a || Math.Min(x, y) + ++diff == a) Console.WriteLine("NO");
    //    else Console.WriteLine("YES");
    //}

}