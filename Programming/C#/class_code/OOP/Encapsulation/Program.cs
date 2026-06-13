class Person
{
    public string name; // READABLE AND WRITEABLE
    private int age; // NOT READABLE AND NOT WRITABLE

    public void SetAge(int a) // writteable korlam
    {
        age = a;
    }

    public int GetAge()  // readable korlam
    {
        return age;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}, Age: {age}\n");
    }
}


class Test
{
    public static void Main(string[] args)
    {
        Person p1 = new Person();
        p1.name = "Anisul Islam";
        p1.SetAge(33);
        Console.WriteLine($"name = {p1.name}, age= {p1.GetAge()}");
    }
}