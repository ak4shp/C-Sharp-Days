using System;
using BasicMath;
using Greetings;

internal class Program {
    private static void Main() {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Enter two numbers:");
        var numa = Console.ReadLine();
        var numb = Console.ReadLine();
        int num1 = Convert.ToInt32(numa);
        int num2 = Convert.ToInt32(numb);
        char ch = 'A';
        float cgpa = 9.28f;
        Console.WriteLine("{0} : {1}", ch, cgpa);

        int result = MathsFunc.Add(num1, num2);
        Console.WriteLine("Sum is " + result);
        Console.WriteLine("Subtracting the sum by 5: " + MathsFunc.Subtract(result, 5));

        // Numbers in String Concatination 
        Console.WriteLine("5 + 2 = " + (5 + 2)); // () treats as mathematical expression
        Console.WriteLine("5 + 2 = " + 5 + 2); // 5 + 2 is 52

        Console.WriteLine("What is Your Name: ");
        string myName = Console.ReadLine();
        Console.WriteLine(myName);
        SayMeHello.PrintName("name " + myName); 
        ushort x = 0;
        Console.WriteLine("short" + x);

        x = (ushort)Math.Abs(-1);
        Console.WriteLine("int short " + x);
        Console.ReadLine();
    }
}


