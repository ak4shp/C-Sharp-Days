// Take input from user in console, first line name, second age, third city.
// print name + age + city for a perticular city given by  user

/* 
 ------- Input -------
Enter name saperate by space
Akash Rani Gopal Vaishnavi Anshul Karnika Divya Animesh
Enter their ages saperate by space
21 21 22 22 26 23 23 24
Enter their cities saperate by space
Bang Pune Jab Mum Bang Jab Mum  Pune
Which City to query for ?
Bang

------- Output -------
Akash 21 Bang
Anshul 26 Bang
 */
internal class Program
{
    private static void Main(string[] args)
    {
        // var Student = new List<string> { };
        // var Age = new List<int> { };
        // var City = new List<string> { };

        Console.WriteLine("------- Input -------");
        Console.WriteLine("Enter name saperate by space");
        string St = Console.ReadLine();
        var Student = new List<string> (St.Split(' '));

        Console.WriteLine("Enter their ages saperate by space");
        string Ag = Console.ReadLine();
        var Age = new List<string>(Ag.Split(' '));

        Console.WriteLine("Enter their cities saperate by space");
        string Ct = Console.ReadLine();
        var City = new List<string>(Ct.Split(' '));

        Console.WriteLine("Which City to query for ?");
        string QueryCity = Console.ReadLine();

        var Answer = new List<string> (FindNameForCity(Student, Age,  City, QueryCity));

        Console.WriteLine("\n------- Output -------");

        foreach (string Ans in Answer)
        {
            Console.WriteLine(Ans);
        }



        //Console.WriteLine($"Your desired redult is {Answer}.");

        /*
        foreach (string sd in Student)
        {
            Console.WriteLine(sd);
        }

        foreach (string sd in Age)
        {
            Console.WriteLine(sd);
        }

        foreach (string sd in City)
        {
            Console.WriteLine(sd);
        }*/
    }

    public static List<string> FindNameForCity(List<string> Student, List<string> Age, List<string> City, string QueryCity)
    {
        var NameAgeCity = new List<string> ();
        string CurrentNameAgeCity = "";
        for(int i =0; i<Student.Count; i++)
        {
            if (City[i] == QueryCity)
            {
                CurrentNameAgeCity = $"{Student[i]} {Age[i]} {City[i]}";
                NameAgeCity.Add(CurrentNameAgeCity);
            }
        }

        return NameAgeCity;

    }


    public static List<int> Fibonacci(int N)
    {   
        // if N = 20, The last element = 6765
        var Fibo = new List<int> {1, 1};

        for (int i = 0; i < N; i ++){
            var previous = Fibo[Fibo.Count - 1];
            var previous2 = Fibo[Fibo.Count - 2];
            Fibo.Add(previous + previous2);
        }

        return Fibo;
    }
    
}