

int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 } };

Console.WriteLine(matrix[0, 2]);
Console.WriteLine(matrix[1, 1]);


Console.WriteLine();
Console.WriteLine();



for(int row = 0; row <2; row++)
{
    for(int col = 0; col <3; col++)
    {
        Console.WriteLine(matrix[row, col]);
    }
    Console.WriteLine();
}
