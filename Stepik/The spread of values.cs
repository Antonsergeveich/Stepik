using System;

public class The_spread_of_values
{
	public static void Value()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		int min = Convert.ToInt32(Console.ReadLine());
		int max = min;	
		for(int i = 0; i < n - 1; i++)
		{
			int digit = Convert.ToInt32(Console.ReadLine());
			if(digit > max)max = digit;
			if(digit < min)min = digit;
		}
		Console.WriteLine(max - min);
	}
}
