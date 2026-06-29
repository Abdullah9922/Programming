public delegate void Mydelegate(int num);
public delegate int Mydelegate2(int num, int num2);

class Program
{
    static void Main(string[] args)
    {
        Mydelegate obj = (a) => // anonimous function ke simplify kora dae lambda expressison
        {
            a += 5;
            Console.WriteLine(a);
        };

        obj.Invoke(5);


        Mydelegate2 obj2 = (a, b) => (a + b);
        Console.WriteLine(obj2(10,20));
        Console.ReadKey();
    }
}