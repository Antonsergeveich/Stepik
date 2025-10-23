using System;

public class The_amount_with_the_condition
{
	public static void Condition()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		int sum = 0;
		for (int i = 0; i < n; i++)
		{
			int num = Convert.ToInt32(Console.ReadLine());
			if (num % 2 == 0 && num % 3 != 0)
				sum += num;
		}
		Console.WriteLine(sum);
	}
}
