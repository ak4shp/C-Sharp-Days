internal class Program : ProgramBase {
    private static void Main()
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("print my name !!");
        int result = Add(10, 13);
        Console.WriteLine(Subtract(result, 5));
        Console.WriteLine("sum is " + result);
        PrintName("Akash");
    }

    static int Subtract(int a, int b)
    {
        return a - b;
    }

    public static void PrintName(string name)
    {
        Console.WriteLine($"You Name is: {name}");
        SayHello();

        void SayHello()
        {
            Console.WriteLine($"Hello {name}!");
        }
    }
}