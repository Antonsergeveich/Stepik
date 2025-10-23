using System;

public class Number_of_numbers
{
	public static void Quantity()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		int quantity = 0;
		for (int i = 0; i < n; i++)
		{
			int num = Convert.ToInt32(Console.ReadLine());
			if (num % 10 == 0) quantity++;
		}
		Console.WriteLine(quantity);
	}
}
