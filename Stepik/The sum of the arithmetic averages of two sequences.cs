using System;

public class The_sum_of_the_arithmetic_averages_of_two_sequences
{
	public static void Sequences()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		int m = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(SumArg(n, m));
		Console.WriteLine(Average(n)+Average(m));
	}
	static double SumArg(int n, int m)
	{
		int sum1 = 0;
		int sum2 = 0;
		for(int i = 1; i <= n; i++)
		{
			sum1 += i;
		}
		for(int i = 1; i <= m; i++)
		{
			sum2 += i;
		}
		return ((double)sum1/n) + ((double)sum2/m);
	}
	static double Average(double n)
	{
		return (1 + n) / 2.0;
	}
}
