using System.Globalization; // will be used for ToTitleCse conversion

internal class Program
{
    private static void Main(string[] args)
    {

        string MyString = "      This is a sentence for testing various string methods    ";

        // Find Length
        Console.WriteLine("Length : " + MyString.Length);
        // Trim Methods
        TrimMethods(MyString);

        MyString = MyString.Trim();
        // Case Conversion Methods
        Conversions(MyString);

        // Searching/finding Methods in a string
        SearchString(MyString);

    }

    internal static void TrimMethods(string Sentence)
    {
        string FullTrim = Sentence.Trim();
        string LeftPartTrim = Sentence.TrimStart();
        string RightPartTrim = Sentence.TrimEnd();
        Console.WriteLine("\nFull sentence: " + Sentence);
        Console.WriteLine($"Full Trim: {FullTrim}, \nLeft part trimmed: {LeftPartTrim}, \nRight part trimmed: {RightPartTrim},");

    }

    public static void Conversions(string Sentence)
    {
        string UpperConvert = Sentence.ToUpper();
        string LowerConvert = Sentence.ToLower();
        // Non inbuilt for Title case; can make one using arrays.

        Console.WriteLine("\nFull sentence: " + Sentence);
        Console.WriteLine($"Upper: {UpperConvert}, \nLower: {LowerConvert},");
    }

    protected static void SearchString(string Sentence)
    {
        string ReplacedWord = Sentence.Replace("testing", "'the purpose of testing'");
        bool CheckContains = Sentence.Contains("methods");
        bool StartingWith = Sentence.StartsWith("This");
        bool EndingWith = Sentence.EndsWith("testing");

        Console.WriteLine("\nFull sentence: " + Sentence);
        Console.WriteLine($"Replaced: {ReplacedWord}, \nContains 'methods'? {CheckContains}, \nStart 'This'? {StartingWith}, \nending 'testing'? {EndingWith},");

    }
}