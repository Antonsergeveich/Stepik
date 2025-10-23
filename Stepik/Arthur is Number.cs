using System;
using static System.Console;

public class Arthur_is_Number
{
    public static void Number()
    {
        int num = Convert.ToInt32(Console.ReadLine());
        int min, max, difference, middle;   
        int a = num % 10;
        int b = num % 100 / 10;
        int c = num / 100;
		max = a > b ? a > c ? a : c : b > c ? b : c;
        min = a < b ? a < c ? a : c : b < c ? b : c;
        difference = max - min;
        middle = a + b + c - min - max;
        WriteLine(middle == difference ? "Число интересное" : "Число неинтересное");
    }
}

