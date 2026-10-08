
int tc = int.Parse(Console.ReadLine());

int x, y, r;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();
    x = int.Parse(input[0]);
    y = int.Parse(input[1]);
    r = int.Parse(input[2]);

    int sum = x + y;
    Console.WriteLine(0 + " " + (sum - r >= 0 ? (sum-r) : (r-sum))  );
}