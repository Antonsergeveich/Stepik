using System;

public class The_number_of_elements_that_are_larger_than_the_previous_one
{
	public static void Elements()
	{
		int prev = Convert.ToInt32(Console.ReadLine()), count = 0, num;
		while ((num = Convert.ToInt32(Console.ReadLine())) != 0)
		{
			if (num > prev) count++;
			prev = num;
		}
		Console.WriteLine(count);
	}
}
