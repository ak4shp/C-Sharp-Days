internal class Program
{
    private static void Main(string[] args) {

        // Conditionals
        Conditionals();
        
        // Loops 
        WhileLoop();
        DoWhileLoop();
        ForLoop();
    
    }
    // Conditionals implementation
    public static void Conditionals() {
        int a = 5;
        int b = 9;
        int c = 10;
        if (a + b > 20)
        {
            if (a == 15)
                Console.WriteLine("The answer is greater than 10.");
            else
                Console.WriteLine("a is not 15");
        }

        else if (((a + b + c > 10) || (a == b)))
            Console.WriteLine("b is 10");

        else
            Console.WriteLine("The answer is less than 20");
    }

    // loops -->>
    // while loop
    public static void WhileLoop() {
        Console.WriteLine("\nInside While Loop -------------");
        int counter = 0;
        while (counter < 10)
        {
            Console.WriteLine($"Hello World! The counter is {counter}");
            counter++;
        }
    }
    
    // Do while loop
    public static void DoWhileLoop() {
        Console.WriteLine("\nInside do While Loop -------------");

        int counter = 0;
        do {
            Console.WriteLine($"Hello World! The counter is {counter}");
            counter++;
        } while (counter < 10);
    }

    // for and nested for loops
    public static void ForLoop() {
        Console.WriteLine("\nInside for Loop -------------");

        for (int counter = 0; counter < 10; counter++) {
            Console.WriteLine($"Hello World! The counter is {counter}");
        }

        Console.WriteLine("\nInside nested for Loop -------------");
        for (int row = 1; row < 6; row++) {
            for (char column = 'a'; column < 'e'; column++) {
                Console.WriteLine($"The cell is ({row}, {column})");
            }
        }
    }


}