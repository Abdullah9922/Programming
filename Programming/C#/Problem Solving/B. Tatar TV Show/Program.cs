public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        for(int t = 0; t < tc; t++)
        {
            

            string[] input = Console.ReadLine().Split();

            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);

            string str = Console.ReadLine();
            char[] arr = str.ToCharArray();

            //int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i + k < arr.Length)

                // 3 1 101 -> YES
                // 2 1 10 -> NO

                {
                    if (arr[i] == '1' && arr[i + k] == '1' || arr[i] == '1' && arr[i + k] == '0' || arr[i] == '0' && arr[i + k] == '1') 
                    {
                        arr[i] = '0';
                        arr[i + k] = '0';
                    }
                    
                    
                }
                else break;
            }

            //Console.WriteLine(arr);

            bool allZero = true;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != '0')
                {
                    allZero = false;
                    break;
                }
            }

            if (allZero)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
