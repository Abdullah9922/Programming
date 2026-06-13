int day = 3;

string dayName = day switch
{
    1 => "Saturday",
    2 => "Sunday",
    3 => "Monday",
    4 => "Tuesday",
    5 => "Wednesday",
    6 => "Thursday",
    7 => "Friday",
    _ => "Invalid day"
};

Console.WriteLine($"Day is: {dayName}"); //Console.WriteLine(dayName) -> same kaj kora