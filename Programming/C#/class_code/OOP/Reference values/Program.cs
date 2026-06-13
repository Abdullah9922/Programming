class Person
{
    public string name;
    public int age;

    public Person()
    {
        name = "Arif";
        age = 23;
    }

    public Person(string n , int a)
    {
        name = n;
        age = a;
    }

    public void displayInfo()
    {
        Console.WriteLine($"name: {name}, Age: {age}\n");
    }
}

class Test
{
    public static void Main(string[] args)
    {
        Person p1 = new Person("Aaaa", 44);
        p1.displayInfo();

        Person p2 = p1;
        p2.displayInfo();


        p1.name = "korim";
        p1.age = 23;
        p2.displayInfo();
    }
}

