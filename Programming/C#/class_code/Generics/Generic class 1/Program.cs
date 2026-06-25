public class Student <T>
{
    private T name { get; set; }
    private T id { get; set; }

    private T age { get; set; }

    public Student(T name, T id, T age  )
    {
        this.name = name;
        this.id = id;
        this.age = age;
    }


    public T Display()
    {
        Console.WriteLine($"Name => {name} | Age => {age}");
        return id;
    }
}



public class Mainn
{
    public static void Main(string[] args)
    {
        Student<int> s = new Student<int>(1, 2, 3);
        int ss = s.Display();
        Console.WriteLine(ss);

        Student<string> s2 = new Student<string>("1", "2", "3");
        string ss2 = s2.Display();
        Console.WriteLine(ss2);

        Console.ReadKey();
    }
}
