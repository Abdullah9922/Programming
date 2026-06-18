public class Test
{
    public static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1,2,3,4,5,6,7,8};

        var enenNumber = numbers.Where(num => num % 2 == 0);

        if (enenNumber.Any())
        {
            Console.WriteLine("Count of ever number: " + enenNumber.Count());
            Console.Write("Enver numbers are: ");
            foreach (var item in enenNumber)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        else
        {
            Console.WriteLine("There is  no ever number.");
        }

        List<string> words = new List<string>() { "apple", "orange", "kiwi", "banana"};
        var longWord = words.Where(word => word.Length > 4);

        if (longWord.Any())
        {
            Console.WriteLine("Count of Long words: " + longWord.Count());
            Console.Write("Long words are: ");
            foreach (var item in longWord)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        else
        {
            Console.WriteLine("There is no long words.");
        }


        List<Student> students = new List<Student>()
        {
            new Student{ Name = "Arif", Score = 75},
            new Student{ Name = "Asif", Score = 95},
            new Student{ Name = "korim", Score = 80},
            new Student{ Name = "Arik", Score = 90},
            new Student{ Name = "Ajij", Score = 65},
        };
        var higerScorer = students.Where(s => s.Score > 80);

        if (higerScorer.Any())
        {
            Console.WriteLine("Count of students: " + higerScorer.Count());
            Console.Write("students are: ");
            foreach (var item in higerScorer)
            {
                Console.Write(item.Name + " ");
            }
            Console.WriteLine();
        }

        else
        {
            Console.WriteLine("There is no students.");
        }
    }
}