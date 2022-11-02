internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // List<T> type collection 
        AllAboutLists();
    }

    private static void AllAboutLists()
    {
        // New list of string names with Add and Remove.
        List<string> names = new List<string> { "<start_names>", "Ana", "remove_me", "Felipe", "Garbage" };e
        names.Remove("Garbag");
        names.Add("Ria");
        names.Add("Praful");
        names.Add("Jaya");
        names.Add("Aakash");
        names.Remove("remove_me");
        names.Add("<end_names>");

        // New List denoting corresponding ages
        // Implicit conversion while creating list: 
        // int -> Int32 can be done but Int64(long) to Int32(or int) or vice versa can not be done.
        List<Int32> ages = new List<int> { 0, 21, 32, 24, 23, 27, 22, 1 };

        // Accessing each name from the list and printing in uppercase.
        Console.WriteLine("____@____Welcome All____@____");
        foreach (var name in names)
        {
            Console.WriteLine($"Hello {name.ToUpper()} !");
        }

        // Finding index 
        Console.WriteLine("Index of 'Ana' " + names.IndexOf("Ana"));
        Console.WriteLine("Indes of 'Abhi' " + names.IndexOf("Abhi") + " Not in List"); // returns -1 if not found.

        // List can be reversed.
        names.Reverse();
        ages.Reverse();

        // Use of both the Lists 'names' and 'ages'in a single for loop.
        Console.WriteLine("\n-----Name   Age----------");
        for (int i = 0; i < ages.Count; i++)
        {
            Console.WriteLine($"I am {names[i]}, {ages[i]} years old.");
        }

        // Replace a name by finding its index. Reducing its age by 5
        int AnaIndex = names.IndexOf("Ana");
        names[AnaIndex] = "Ana's sister";
        ages[AnaIndex] -= 5;

        // Two lists for even and odd ages. NOTE: var keyword can also be used.
        var EvenAgeNames = new List<string> { };
        var OddAgeNames = new List<string> { };

        // Separating Persons with even and odd ages.
        for (int i = 0; i < ages.Count; i++)
        {
            if (ages[i] % 2 == 0)
            {
                // append the age of that person in its name string and then add to the list
                EvenAgeNames.Add(names[i] + " " + ages[i]);
            }
            else
            {
                OddAgeNames.Add(names[i] + " " + ages[i]);
            }
        }

        // Print Even age person's names in accending order
        Console.WriteLine("\n-------even age asc-------");
        EvenAgeNames.Sort();
        foreach (var name in EvenAgeNames)
        {
            Console.WriteLine(name);
        }

        // Print odd age person's names in descending order
        Console.WriteLine("-------odd age desc-------");
        OddAgeNames.Sort();
        OddAgeNames.Reverse();
        foreach (var name in OddAgeNames)
        {
            Console.WriteLine(name);
        }

    }
}