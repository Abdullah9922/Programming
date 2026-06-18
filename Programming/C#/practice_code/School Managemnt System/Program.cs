using System;
using System.Collections.Generic;

// ─────────────────────────────────────────────
// Abstraction - Abstract base class
// ─────────────────────────────────────────────
abstract class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    private string Email { get; set; } // Encapsulation - private field

    public Person(string name, int age, string email)
    {
        Name = name;
        Age = age;
        Email = email;
    }

    public abstract string GetRole();   // Abstract method - subclass must override
    public abstract void ShowDetails(); // Abstract method - subclass must override

    public void Introduce()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Role: {GetRole()}");
    }

    public void UpdateEmail(string newEmail) // Encapsulation - controlled access
    {
        if (newEmail.Contains("@"))
            Email = newEmail;
        else
            Console.WriteLine("Invalid email!");
    }
}

// ─────────────────────────────────────────────
// Inheritance - Student inherits from Person
// ─────────────────────────────────────────────
class Student : Person
{
    public string StudentID { get; set; }
    public string ClassName { get; set; }
    private List<double> Marks = new List<double>();

    public Student(string name, int age, string email, string studentID, string className)
        : base(name, age, email)
    {
        StudentID = studentID;
        ClassName = className;
    }

    public void AddMark(double mark)
    {
        Marks.Add(mark);
    }

    public double GetAverage()
    {
        double total = 0;
        foreach (var m in Marks) total += m;
        return Marks.Count == 0 ? 0 : total / Marks.Count;
    }

    public string GetGrade()
    {
        double avg = GetAverage();
        if (avg >= 80) return "A+";
        if (avg >= 70) return "A";
        if (avg >= 60) return "B";
        return "F";
    }

    // Polymorphism - override abstract methods
    public override string GetRole() => "Student";

    public override void ShowDetails()
    {
        Console.WriteLine($"[Student] {Name} | ID: {StudentID} | Class: {ClassName} | Avg: {GetAverage():F1} | Grade: {GetGrade()}");
    }
}

// ─────────────────────────────────────────────
// Inheritance - Teacher inherits from Person
// ─────────────────────────────────────────────
class Teacher : Person
{
    public string TeacherID { get; set; }
    public string Subject { get; set; }
    public double Salary { get; private set; } // Encapsulation - private set

    public Teacher(string name, int age, string email, string teacherID, string subject, double salary)
        : base(name, age, email)
    {
        TeacherID = teacherID;
        Subject = subject;
        Salary = salary;
    }

    public void IncreaseSalary(double amount) => Salary += amount;

    // Polymorphism - override abstract methods
    public override string GetRole() => "Teacher";

    public override void ShowDetails()
    {
        Console.WriteLine($"[Teacher] {Name} | ID: {TeacherID} | Subject: {Subject} | Salary: {Salary}");
    }
}

// ─────────────────────────────────────────────
// Multi-level Inheritance - Principal inherits from Teacher
// ─────────────────────────────────────────────
class Principal : Teacher
{
    public string SchoolName { get; set; }

    public Principal(string name, int age, string email, string id, string schoolName)
        : base(name, age, email, id, "Administration", 80000)
    {
        SchoolName = schoolName;
    }

    public override string GetRole() => "Principal";

    public override void ShowDetails()
    {
        Console.WriteLine($"[Principal] {Name} | School: {SchoolName} | Salary: {Salary}");
    }
}

// ─────────────────────────────────────────────
// Abstraction - Interface
// ─────────────────────────────────────────────
interface IExaminable
{
    void TakeExam();
    void PublishResult();
}

class ExamController : IExaminable
{
    private string ExamName;
    private List<Student> Students = new List<Student>();

    public ExamController(string examName) => ExamName = examName;

    public void AddStudent(Student s) => Students.Add(s);

    public void TakeExam()
    {
        Console.WriteLine($"\n[Exam] {ExamName} started.");
    }

    public void PublishResult()
    {
        Console.WriteLine($"[Result] {ExamName}:");
        foreach (var s in Students)
            Console.WriteLine($"  {s.Name} -> Grade: {s.GetGrade()}");
    }
}

// ─────────────────────────────────────────────
// Polymorphism - Method Overloading
// ─────────────────────────────────────────────
class Calculator
{
    public int Add(int a, int b) => a + b;
    public double Add(double a, double b) => a + b;
    public int Add(int a, int b, int c) => a + b + c;
}

// ─────────────────────────────────────────────
// Main Program
// ─────────────────────────────────────────────
class Program
{
    static void Main()
    {
        // Student objects
        Student s1 = new Student("Alice", 15, "alice@mail.com", "S-001", "Class 9");
        s1.AddMark(85); s1.AddMark(90); s1.AddMark(78);

        Student s2 = new Student("Bob", 16, "bob@mail.com", "S-002", "Class 10");
        s2.AddMark(55); s2.AddMark(60); s2.AddMark(50);

        // Teacher object
        Teacher t1 = new Teacher("Mr. Karim", 40, "karim@mail.com", "T-001", "Math", 45000);
        t1.IncreaseSalary(5000);

        // Principal object
        Principal p1 = new Principal("Dr. Rahim", 55, "rahim@mail.com", "P-001", "Dhaka Model School");

        // Polymorphism - সবাইকে Person হিসেবে treat করা হচ্ছে
        Console.WriteLine("=== Polymorphism Demo ===");
        List<Person> persons = new List<Person> { p1, t1, s1, s2 };
        foreach (Person p in persons)
            p.ShowDetails(); // Runtime এ decide হয় কোন ShowDetails() call হবে

        // Exam
        ExamController exam = new ExamController("Annual Exam 2024");
        exam.AddStudent(s1);
        exam.AddStudent(s2);
        exam.TakeExam();
        exam.PublishResult();

        // Method Overloading
        Calculator calc = new Calculator();
        Console.WriteLine($"\n[Calculator] 10+20 = {calc.Add(10, 20)}");
        Console.WriteLine($"[Calculator] 1.5+2.5 = {calc.Add(1.5, 2.5)}");
        Console.WriteLine($"[Calculator] 10+20+30 = {calc.Add(10, 20, 30)}");

        Console.ReadKey();
    }
}
