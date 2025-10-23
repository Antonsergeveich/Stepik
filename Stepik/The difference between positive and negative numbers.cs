using System;

public class The_difference_between_positive_and_negative_numbers
{
	public static void Difference()
	{
		int plus = 0;
		int minus = 0;
		int num = Convert.ToInt32(Console.ReadLine());
		while (num != 0)
		{
			if (num > 0) plus++;
			else minus++;
			num = Convert.ToInt32(Console.ReadLine());
		}
		Console.WriteLine(plus - minus);
	}
}
