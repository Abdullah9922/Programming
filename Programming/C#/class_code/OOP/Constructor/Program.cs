class Person
{
    public string name; // -> fields
    public int age;  // -> fields


    public Person()
    {
        Console.WriteLine("This is a default constructor.");
        name = "Anisul Islam";
        age = 1;
    }

    public Person(string n, int a)
    {
        Console.WriteLine("This is a default perameterise constructor.");
        name = n;
        age = a;
    }

    public void displayInfo()  // -> mathords
    {
        Console.WriteLine("Person :");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}


class Test
{
    public static void Main(string[] args)
    {
        Person p1 = new Person("Asif", 23);
        p1.displayInfo();

        Console.WriteLine();

        Person p2 = new Person();
        p2.displayInfo();


    }
}
