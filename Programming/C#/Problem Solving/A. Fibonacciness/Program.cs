
int tc = int.Parse(Console.ReadLine());

int a1, a2, a4, a5;
while(tc-- > 0)
{
    string[] input = Console.ReadLine().Split();
    a1 = int.Parse(input[0]);
    a2 = int.Parse(input[1]);
    a4 = int.Parse(input[2]);
    a5 = int.Parse(input[3]);

    int temp1 = a1 + a2;
    int temp2 = a4 - a2;
    int temp3 = a5 - a4;

    if (temp1 == temp2 && temp2 == temp3) Console.WriteLine(3);
    else if (temp1 == temp2 || temp2 == temp3 || temp1 == temp3) Console.WriteLine(2);
    else Console.WriteLine(1);
}