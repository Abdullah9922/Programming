

int[][] jaggedArray = new int[4][];

jaggedArray[0] = new int[] { 1, 2 };
jaggedArray[1] = new int[] { 3, 4, 5 };
jaggedArray[2] = new int[] { 6 };
jaggedArray[3] = new int[] { 7, 8, 9, 10 };


/*
 int[][] jaggedArray =
{
    new int[] { 1, 2, 3 },
    new int[] { 4, 5 },
    new int[] { 6, 7, 8, 9 }
};
 */

Console.WriteLine(jaggedArray[1][1]);
Console.WriteLine();
Console.WriteLine();


for (int row = 0; row < jaggedArray.Length; row++)
{
    for(int col = 0; col < jaggedArray[row].Length; col++)
    {
        Console.WriteLine(jaggedArray[row][col]);
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


foreach( var row in jaggedArray)
{
    foreach( var item in row)
    {
        Console.WriteLine(item + " ");

    }
    Console.WriteLine();
}

