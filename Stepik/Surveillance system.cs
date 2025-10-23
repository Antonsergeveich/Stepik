using System;

public class Surveillance_system
{
	public static void System()
	{
		int num = Convert.ToInt32(Console.ReadLine());

		if (num % 10 == 1 && num % 100 != 11) Console.WriteLine($"{num} Гимназист");
		else if ((num % 10 == 2 ||  num % 10 == 3 || num % 10 == 4) && num % 100 != 12 && num % 100 != 13 && num % 100 != 14)
		{
			Console.WriteLine($"{num} Гимназиста");
		}
        else
        {
			Console.WriteLine($"{num} Гимназистов");
        }
    }
}
