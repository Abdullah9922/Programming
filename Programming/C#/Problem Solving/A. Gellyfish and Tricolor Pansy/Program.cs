
int tc = int.Parse(Console.ReadLine());

int a, b, c, d;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();
    a = int.Parse(input[0]);
    b = int.Parse(input[1]);
    c = int.Parse(input[2]);
    d = int.Parse(input[3]);



    if (Math.Min(a, c) >= Math.Min(b, d)) Console.WriteLine("Gellyfish");
    else Console.WriteLine("Flower");



    //int k = 1;
    //while (true)
    //{
    //    if (k % 2 != 0 && c > 0)
    //    {
    //        if (b < d) b--;
    //        else d--;
    //    }

    //    else if (k % 2 == 0 && d > 0)
    //    {

    //         if (a < c) a--;
    //         else c--;

    //    }

    //    if (b == 0 || d == 0)
    //    {
    //        Console.WriteLine("Gellyfish");
    //        break;
    //    }

    //    else if (a == 0 || c == 0)
    //    {
    //        Console.WriteLine("Flower");
    //        break;
    //    }
    //    k++;

    //}
}