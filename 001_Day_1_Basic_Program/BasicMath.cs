namespace BasicMath
{
    internal class MathsFunc
    {
        public static int Add(int a, int b) => a + b;

        public static int Subtract(int a, int b)
        {
            return a - b;
        }
    }

}


namespace Greetings 
{
    internal class SayMeHello
    {
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
}


