
int tc = int.Parse(Console.ReadLine());

int a, b, c;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();
    a = int.Parse(input[0]);
    b = int.Parse(input[1]);
    c = int.Parse(input[2]);

   
        Console.WriteLine((b == a + 1 && c == b + 1 ? "YES" : "NO"));

}