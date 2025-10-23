using System;

public class Divisors_on_a_segment
{
	public static void Divisor()
	{
		int a = Convert.ToInt32(Console.ReadLine());
		int b = Convert.ToInt32(Console.ReadLine());
		int k = Convert.ToInt32(Console.ReadLine());

		for(int j = a; j <= b; j++)
		{
			int x = j;
			int divisorCount = 0;
			for(int i = 1; i <= x; i++)
			{
				if(x % i == 0)divisorCount++;
			}
			if (divisorCount <= k) Console.Write(x + " ");
		}
	}
}
