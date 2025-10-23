using System;

public class Multiplicity_condition
{
	public static void Condition()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		int c = Convert.ToInt32(Console.ReadLine());
		int d = Convert.ToInt32(Console.ReadLine());

		for (int i = 1; i <= n; i++)
		{
			if (i % c == 0 && i % d != 0)
			{
				Console.WriteLine(i);
			}
		}
	}
}
