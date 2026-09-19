
int tc = int.Parse(Console.ReadLine());

int k, a, b, x, y;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();
    k = int.Parse(input[0]);
    a = int.Parse(input[1]);
    b = int.Parse(input[2]);
    x = int.Parse(input[3]);
    y = int.Parse(input[4]);

    int cooked = 0;
    int min = Math.Min(x, y);

    bool flagA = false;
    bool flagB = false;
    int remaining = (x < y ? a : b);
    while (true) 
    {
        if (k < a && k < b) break;

        if (x < y && a < k)
        {
            cooked++;
            k -= x;
            flagA = true;
        }
        else if (y < x && b < k)
        {
            cooked++;
            k -= y;
            flagB = true;
        }

        if(k <= remaining)
        {
            if(flagA)
            {
                cooked++;
                k -= y;
            }
            else if(flagB)
            {
                cooked++;
                k -= x;
            }
        }
        
    } 

    Console.WriteLine(cooked);
}