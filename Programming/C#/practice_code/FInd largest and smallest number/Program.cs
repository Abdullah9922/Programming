
int largest = 0;
int smallest = int.MaxValue;


for(int i = 0; i < 5; i++)
{
    int n = Convert.ToInt32(Console.ReadLine());

    if(n > largest)  largest = n; 

    if(n < smallest) smallest = n;
}

Console.WriteLine($"Largest number is {largest}");
Console.WriteLine($"Smallest number is {smallest}");

