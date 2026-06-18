public class Test
{

    public static void Main(string[] args)
    {

        string input = "Hello 123 World!";
        int countVowel = input.Count(c => "aeiouAEIOU".Contains(c));
        int countCons = input.Count(c => !"aeiouAEIOU".Contains(c));

        Console.WriteLine("Vowel        : " + countVowel);
        Console.WriteLine("Consonant    : " + countCons);

        int countNum = input.Count(c => "0123456789".Contains(c));
        Console.WriteLine("Number       : " + countNum);


        int countSpChar = input.Count(c => "!@#$%^&".Contains(c));
        Console.WriteLine("Specila Char : " + countSpChar);

        int countWhiteSpace = input.Count(c => " ".Contains(c));
        Console.WriteLine("White Space  : " + countWhiteSpace);
    }
}