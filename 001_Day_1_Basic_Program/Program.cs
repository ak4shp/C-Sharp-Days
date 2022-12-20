using BasicMath;
using Greetings;

internal class Program
{

    private static void Main()
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Enter two numbers:");
        var numa = Console.ReadLine();
        var numb = Console.ReadLine();
        int num1 = Convert.ToInt32(numa);
        int num2 = Convert.ToInt32(numb);
        char ch = 'A';

        int result = MathsFunc.Add(num1, num2);
        Console.WriteLine("Sum is " + result);
        Console.WriteLine("Subtracting the sum by 5: " + MathsFunc.Subtract(result, 5));
        Console.WriteLine(5 + 2);
        Console.WriteLine("What is Your Name: ");
        string myName = Console.ReadLine();
        SayMeHello.PrintName(myName);
    }
}


