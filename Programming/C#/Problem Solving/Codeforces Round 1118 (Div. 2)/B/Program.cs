
using System.Security.Cryptography;

int tc = int.Parse(Console.ReadLine());

int n, i;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();

    n = int.Parse(input[0]);
    i = int.Parse(input[1]);

    var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    Dictionary<int, int> freq = new Dictionary<int, int>();

    int temp = 0;
    int max = 0;

    for(int m=i; m >= 0; m--)
    {
        foreach (int x in arr)
        {
            if(m > x)
            {
                if (freq.ContainsKey(x))
                    freq[x]++;
                else
                    freq[x] = 1;
            }
            else if( x == m)
            {
                if (freq.ContainsKey(x))
                {
                    freq[x]++;
                    freq[x]++;
                }

                else
                {
                    freq[x] = 1;
                    freq[x]++;
                }
                    
            }

            else
            {
                int l = x - m;
                if (freq.ContainsKey(m))
                    freq[m]++;
                else
                    freq[m] = 1;

                if (freq.ContainsKey(l))
                    freq[l]++;
                else
                    freq[l] = 1;
            }
            
        }

        temp = freq.Values.Max();
        if( temp > max)
        {
            max = temp; 
        }
        freq.Clear();
    }

    Console.WriteLine("----> " + max);
}