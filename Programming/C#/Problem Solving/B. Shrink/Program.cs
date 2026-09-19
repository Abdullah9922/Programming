
int tc = int.Parse(Console.ReadLine());

int n;
while (tc-- > 0)
{
    n = int.Parse(Console.ReadLine());
    int[] arr = new int[n];

    for(int i=0; i<n; i++)
    {
        arr[i] = i+1;
    }

    int temp = arr[arr.Length-1];
    arr[arr.Length-1] = arr[1];
    arr[1] = temp;

    for (int i = 0; i < n; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}
