
int tc = int.Parse(Console.ReadLine());

int n, k;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();
    n = int.Parse(input[0]);
    k = int.Parse(input[1]);

    var arrA = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    var arrB = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    bool flag = true;
    for(int i=0; i<arrB.Length; i++)
    {
        if (arrB[i] == 0 || arrB[i] < k && arrB[i] % 2 != 0)
        {
            Console.WriteLine("NO");
            flag = false;
            break;
        }
    }
    if(flag) Console.WriteLine("YES");
}