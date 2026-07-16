using System.Xml.Serialization;

public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        long n, c;
        while (tc-- > 0)
        {
            var input = Console.ReadLine()
                        .Split()
                        .Select(long.Parse)
                        .ToArray();

            n = input[0];
            c = input[1]; 


            List<long> arr = Console.ReadLine()
                            .Split()
                            .Select(long.Parse)
                            .ToList();

            if (c == 0)
            {
                Console.WriteLine(arr.Sum());
                continue;
            }

            long score = 0, maxValue = 0, index = 0, first = 0, last = 0;
            while (arr.Any())
            {
                first = 0; last = 0;
                
                maxValue = arr.Max();
                index = arr.IndexOf(maxValue);

                // confusion ase ae khane
                if(maxValue >= c)
                {
                    score += (maxValue - c);
                    arr.Remove(maxValue);
                    continue;
                }

                // diffrance with next value 
                if (index + 1 < arr.Count)
                {
                    last = arr[(int)index] - arr[(int)index + 1];
                }

                // diffrance with previous value 
                if (index - 1 >= 0)
                {
                    first = arr[(int)index] - arr[(int)index - 1];
                }

                if (arr.Count == 1)
                {
                    score += arr[0];
                    score -= c;
                    break;
                }


                if (first > last)
                {
                    score += arr[(int)index];
                    score -= c;
                    arr.RemoveAt((int)index);
                    arr.RemoveAt((int)index - 1);

                }

                // jamela hote pare
                else if (last >= first)
                {
                    score += arr[(int)index];
                    score -= c;
                    arr.RemoveAt((int)index + 1);
                    arr.RemoveAt((int)index);

                }
            }

            Console.WriteLine(score);

        }
    }
}