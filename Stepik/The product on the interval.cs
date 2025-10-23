using System;

public class The_product_on_the_interval
{
	public static void Interval()
	{
		int a = Convert.ToInt32(Console.ReadLine());
		int b = Convert.ToInt32(Console.ReadLine());
		int product = 1;
		for (int i = a; i <= b; i++)
		{
			product *= i;	
		}
		Console.WriteLine(product);
	}
}
