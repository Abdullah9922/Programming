public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        int n , k;
        while (tc-- > 0)
        {
            string[] input = Console.ReadLine().Split();

            n = int.Parse(input[0]);
            k = int.Parse(input[1]);

            string s = Console.ReadLine();

            if(k*2 > n)
            {
                Console.WriteLine("-1");
                continue;
            }

            int count = 0;
            int Findx = 0;
            int Lindx = n - 1;
            bool Fflag = true;
            bool Lflag = true;

            while (k-- > 0)
            {
                Fflag = true;
                Lflag = true;
                if (s[Findx] == 'L')
                {
                    count++;
                    Findx++;
                    Fflag = false;
                    //Console.WriteLine("F index: " + Findx);
                }

                if (s[Lindx] == 'R')
                {
                    count++;
                    Lindx--;
                    Lflag = false;
                    //Console.WriteLine("L index: " + Lindx);
                }

                if (Fflag)
                {
                    Findx++;
                }

                if (Lflag)
                {
                    Lindx--;
                }
                
                //Console.WriteLine("Kola");
            }

            Console.WriteLine(count);
            
        }
    }
}