using System.Runtime.CompilerServices;

public class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }
}

public class Student : Person,iReport
{
    public int Id { get; set; }
    public string Department { get; set; }

    public Student (string name, int id, string dep) 
        : base(name)
    {
        Id = id;
        Department = dep;
    }

    private List<double> Marks = new List<double>();

    public void addMark(double value)
    {
        Marks.Add(value);
    }

    public double GetAverage()
    {
        double total = 0;
        foreach (var m in Marks) total += m;
        return Marks.Count == 0 ? 0 : total / Marks.Count;
    }

    public void displayInfo()
    {
        Console.WriteLine($"[Name] {Name} | [Id] {Id} | [Department] {Department}");
        
    }
}


interface iReport
{
    public void displayInfo();
    
}



public class Mainn
{
    public static void Main(string[] args)
    {
        Student s1 = new Student("Asif", 918, "CSE");
        s1.addMark(85); s1.addMark(90); s1.addMark(78);

        Student s2 = new Student("Arif", 999, "CSE");
        s2.addMark(55); s2.addMark(60); s2.addMark(50);

        Student s3 = new Student("Korim", 279, "EEE");
        s3.addMark(65); s3.addMark(70); s3.addMark(63);

        Student s4 = new Student("Nila", 223, "NFE");
        s4.addMark(75); s4.addMark(83); s4.addMark(72);


        s1.displayInfo();
        Console.WriteLine($"Average: {s1.GetAverage(): F3}");


        Console.ReadKey();
    }
}