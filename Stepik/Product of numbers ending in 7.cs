using System;

public class Product_of_numbers_ending_in_7
{
	public static void Numbers()
	{
		int a = Convert.ToInt32(Console.ReadLine());
		int b = Convert.ToInt32(Console.ReadLine());

		int res = 1;
		for(int i = a; i <= b; i++)
		{
			if (i % 10 == 7 || i % 10 == -7) res *= i;
		}
		Console.WriteLine(res);
	}
}
