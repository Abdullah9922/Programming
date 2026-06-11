
string myName;

Console.Write("Enter Your Name: ");

myName = Console.ReadLine();

Console.WriteLine("Welcome to C# World " + myName);


int age;
Console.Write("Enter Your Age: ");
age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Age: " + age);



double cgpa;
Console.Write("Enter Your CGPA: ");
cgpa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Your cgpa is " +  cgpa);


bool isRegister;
Console.Write("Are u register the course: ");
isRegister = Convert.ToBoolean(Console.ReadLine());
Console.WriteLine("Your registration status is " +  isRegister);
