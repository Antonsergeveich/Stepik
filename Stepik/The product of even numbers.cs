using System;

public class The_product_of_even_numbers
{
	public static void Even()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		int product = 1;

		for(int i = 1; i <= n; i++)
		{
			if (i % 2 == 0) product *= i;
		}
		Console.WriteLine(product);

	}
}
