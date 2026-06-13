object number = "10";
string result = number switch
{
    int => "Integer",
    double => "Double",
    string => "String",
    _ => "Unknown type",
};
Console.WriteLine($"{result}");
Console.ReadKey();