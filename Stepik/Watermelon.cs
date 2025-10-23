using System;
using static System.Console;

public class Watermelon
{
	public static void Melon()
	{
		int weight = Convert.ToInt32(Console.ReadLine());

		if (weight > 2 && weight % 2 == 0) WriteLine("YES");
		else WriteLine("NO");

	}
}
