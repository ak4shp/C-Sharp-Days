internal class Program : ProgramBase {
    private static void Main()
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("print my name !!");
        string numa = Console.ReadLine();
        string numb = Console.ReadLine();
        int num1 = Convert.ToInt32(numa)
        int num2 = Convert.ToInt32(numb)

        int result = Add(num1, num2);
        Console.WriteLine(Subtract(result, 5));
        Console.WriteLine("Difference is " + result);
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