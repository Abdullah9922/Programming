class Person
{
    public string name; // -> fields
    public int age;  // -> fields


    public void setValues(string n, int a) // -> mathords
    {
        this.name = n;
        this.age = a; 
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
        Person p1 = new Person();
        p1.setValues("Asif", 23);
        p1.displayInfo();

        Console.WriteLine();

        Person p2 = new Person();
        p2.name = "Arif";
        p2.age = 21;
        p2.displayInfo();


    }
}
