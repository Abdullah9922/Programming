
int tc = int.Parse(Console.ReadLine());

string s;
while (tc-- > 0)
{
    s = Console.ReadLine();
    int[] arr = new int[s.Length];

    for(int i=0; i<arr.Length; i++)
    {
        arr[i] = s[i];
    }

    Array.Sort(arr);
    Array.Reverse(arr);

    int temp = 9;
    int index = 0;
    for(int i=0; i < arr.Length; i++)
    {
        temp -= i;
        index = i;

        while (temp >= arr[index] && index < arr.Length) index++;

        index--;
        if(index >= 0) (arr[i], arr[index]) = (arr[index], arr[i]);
        temp = 9;
    }

    Console.WriteLine(string.Join("", arr));
}
