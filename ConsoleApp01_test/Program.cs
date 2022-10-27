using System;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// string k;
/* k = Console.ReadLine();

int m = int.Parse(k);
int n = Convert.ToInt32(k);
Console.WriteLine(m);
Console.WriteLine(n);

string s = Console.ReadLine();
Console.WriteLine(s);*/

void Main()
{
    
    Double d = -2.345;
    int i = (int)d;

    string k = Convert.ToString(d);
    Console.WriteLine(k);

    Console.WriteLine("The double value {0} when converted to an int becomes {1}", d, i);

    string s = "12/12/98";
    DateTime dt = (DateTime)Convert.ChangeType(s, typeof(DateTime));

    Console.WriteLine("The string value {0} when converted to a Date becomes {1}", s, dt);

    Console.ReadLine();

}
Main();