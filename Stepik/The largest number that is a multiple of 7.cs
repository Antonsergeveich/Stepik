using System;

public class The_largest_number_that_is_a_multiple_of_7
{
	public static void Largest()
	{
		int a = Convert.ToInt32(Console.ReadLine());
		int b = Convert.ToInt32(Console.ReadLine());

		for(int i = b; i >= a; i--)
		{
			if (i % 7 == 0)
			{
				Console.WriteLine(i);
				return;
			}
		}
		Console.WriteLine("NO");
	}
}
