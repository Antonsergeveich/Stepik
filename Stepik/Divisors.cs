using System;

public class Divisors
{
	public static void Divisor()
	{
		int x = Convert.ToInt32(Console.ReadLine());
		int counte = 0;
		for (int i = 1; i <= x; i++)
		{
			if(x % i == 0) counte++;
		}
		Console.WriteLine(counte);
	}
}
