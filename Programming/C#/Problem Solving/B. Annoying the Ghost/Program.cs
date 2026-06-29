public class Solve
{
    public static bool checkContain(List<int> l1 , List<int> l2)
    {
        List<int> temp1 = new List<int>(l1);  
        List<int> temp2 = new List<int>(l2);

        
        temp1.Sort();
        bool same = temp1.SequenceEqual(temp2);
        return same;
    }

    public static int BubbleSort(List<int> list)
    {
        int count = 0;
        for (int i = 0; i < list.Count - 1; i++)
        {
            for (int j = 0; j < list.Count - i - 1; j++)
            {
                if (list[j] > list[j + 1])
                {
                    int temp = list[j];
                    list[j] = list[j + 1];
                    list[j + 1] = temp;
                    count++;
                }
            }
        }

        return count;
    }


    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());     

        for (int i = 0; i < tc; i++)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> list1 = Console.ReadLine()
                                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToList();

            List<int> list2 = Console.ReadLine()
                                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToList();

            bool isContain = checkContain(list1, list2);

            if (isContain)
            {
                int ans = BubbleSort(list1);
                Console.WriteLine(ans);
            }

            else
            {

            }
            Console.ReadKey();

        }
    }
}
