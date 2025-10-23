using System;
using static System.Console;

public class A_symmetric_number
{
    public static void Symmetric_number()
    {
        int num = Convert.ToInt32(Console.ReadLine());
        int a = num % 10;
        int b = num % 100 / 10;
        int c = num % 1000 / 100;
        int d = num / 1000;
        WriteLine(a == d && b == c ? "YES" : "NO");
    }
}
