public class Student
{
    private string? _name;
    private DateTime _dateOfBirth;
    private string? _rollNumber;

    public Student(string name, DateTime dateOfBirth, string rollNumber)
    {
        _name = name;
        _dateOfBirth = dateOfBirth;
        _rollNumber = rollNumber;
    }

   public string? Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public DateTime DateOfBirth
    {
        get { return _dateOfBirth; }
        set
        {
            if (value > DateTime.Now)
            {
                throw new ArgumentException("Date of birth can not be in future.");
            }
        }
    }

    public string? RollNumber
    {
        get { return _rollNumber; }
        set { _rollNumber = value; }
    }
}


public class Test
{
    public static void Main(string[] args)
    {
        try
        {
            Student student1 = new Student("Arif", new DateTime(2002, 3, 5), "CSE101");
            Student student2 = new Student("Arif", new DateTime(2003, 7, 1), "CSE102");


            // Display student details
            Console.WriteLine($"Student Details: ");
            Console.WriteLine($"—————————————————————————————————");
            Console.WriteLine($"Name: {student1.Name}, Date of Birth: {student1.DateOfBirth.ToShortDateString()}, RollNumber: {student1.RollNumber}");

            Console.WriteLine($"Name: {student2.Name}, Date of Birth: {student2.DateOfBirth.ToShortDateString()}, RollNumber: {student2.RollNumber}");
        }

        catch(Exception ex)
        {
            Console.WriteLine($"Error : {ex.Message}");
        }
    }
}
