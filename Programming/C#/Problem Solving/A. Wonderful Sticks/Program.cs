
int tc = int.Parse(Console.ReadLine());

int n;
while (tc-- > 0)
{
    n = int.Parse(Console.ReadLine());
    string s = Console.ReadLine();

    int[] arr = new int[n];
    for(int i=0; i<arr.Length; i++)
    {
        arr[i] = i + 1;
    }

    for(int i=0; i<arr.Length-1; i++)
    {
        if (s[i] == '<' && arr[i] < arr[i + 1])
            (arr[i], arr[i + 1]) = (arr[i+1], arr[i]);
        else if(s[i] == '>'&& arr[i] > arr[i + 1])
            (arr[i], arr[i + 1]) = (arr[i + 1], arr[i]);
    }

    for(int i=0; i<arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}