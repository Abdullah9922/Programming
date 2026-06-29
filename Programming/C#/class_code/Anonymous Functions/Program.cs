public delegate void MyDelegates(int num);

class Program
{
    public static void MyMethord(MyDelegates del,int a)
    {
        a += 10; // 15
        del.Invoke(a);
    }

    public static void Main(string[] args)
    {
        //MyDelegates obj = new MyDelegates(Program.MyMethord);

        //obj.Invoke(5); // obj(5); -> same 


        Program.MyMethord(delegate (int b) { b += 10; Console.WriteLine(b); }, 5);



        //MyDelegates obj = delegate (int a)
        //{
        //    a += 10;
        //    Console.WriteLine(a);
        //};

        obj.Invoke(5);
        Console.ReadKey();
    }
}
