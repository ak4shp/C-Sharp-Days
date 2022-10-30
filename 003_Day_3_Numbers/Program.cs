/*
The chart below details most of the comon variable types, as well as thier size and possible values.
 
C# 	   .Net Framework  Signed?	Bytes 	Possible Values
Type    (System) type          Occupied
--------------------------------------------------------------------------------------
sbyte	System.Sbyte	Yes    	1	    -128 to 127
short	System.Int16	Yes 	2	    -32768 to 32767
int	    System.Int32	Yes	    4	    -2147483648 to 2147483647
long	System.Int64	Yes 	8	    -9223372036854775808 to 9223372036854775807
byte	System.Byte 	No  	1	    0 to 255
ushort	System.Uint16	No  	2	    0 to 65535
uint	System.UInt32	No  	4	    0 to 4294967295
ulong	System.Uint64	No	    8	    0 to 18446744073709551615
float	System.Single	Yes 	4	    Approximately ±1.5 x 10-45 to ±3.4 x 1038 with 7 significant figures
double	System.Double	Yes 	8	    Approximately ±5.0 x 10-324 to ±1.7 x 10308 with 15 or 16 significant figures
decimal	System.Decimal	Yes	    12	    Approximately ±1.0 x 10-28 to ±7.9 x 1028 with 28 or 29 significant figures
char	System.Char 	N/A	    2	    Any Unicode character (16 bit)
bool    System.Boolean  N/A     1 / 2	true or false
*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World! Lets learn Numbers in C#  ... ");
        float a = 1112234.01234567890123456789012345678912F;
        double b = 1112234.01234567890123456789012345678912;
        decimal c = 12111230.01234567890123456789012345611912M;
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);

        // All int
        int aa = 7;
        int bb = 4;
        int cc = 3;
        int dd = (aa + bb) / cc;
        int ee = (aa + bb) % cc;
        Console.WriteLine($"quotient: {dd}");
        Console.WriteLine($"remainder: {ee}");

        int max = int.MaxValue;
        int min = int.MinValue;
        Console.WriteLine($"\nThe range of integers is {min} to {max}");

        // Double
        double adb = 5;
        double bdb = 4;
        double cdb = 2;
        double ddb = (adb + bdb) / cdb;
        Console.WriteLine(ddb);

        double maxd = double.MaxValue;
        double mind = double.MinValue;
        Console.WriteLine($"\nThe range of double is {mind} to {maxd}");

        //Decimal
        decimal mindec = decimal.MinValue;
        decimal maxdec = decimal.MaxValue;
        Console.WriteLine($"\nThe range of the decimal type is {mindec} to {maxdec}\n");

        double adec = 1.0;
        double bdec = 3.0;
        Console.WriteLine(adec / bdec);

        decimal cdec = 1.0M;
        decimal ddec = 3.0M;
        Console.WriteLine(cdec / ddec);
    }
}