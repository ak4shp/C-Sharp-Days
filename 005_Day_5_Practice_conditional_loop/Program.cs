using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Day_4_Conditionals_Loops_practice
{
    class Program
    {
        public static void Main()
        {
            CheckAge("hey");
            CheckAge("good bye");
        }


        public static void CheckAge(string args)
        {
            Console.WriteLine(args);
            Console.Write("What is your age? ");
            string age = Console.ReadLine();
            int ageLimit = 18;
            if (Int32.TryParse(age, out int ageInput))
            {
                //IF the input is greater than the limit, Write "Welcome"
                if (ageInput >= ageLimit)
                {
                    Console.WriteLine("Welcome");
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    int underAge = ageLimit - ageInput;
                    Console.WriteLine("Come back in " + underAge + " years, kid.");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
            }
        }


    }
}
