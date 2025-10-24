using System;

public class The_sum_of_the_numbers_on_the_segments
{
	public static void Sum()
	{
		int num1 = Convert.ToInt32(Console.ReadLine());
		int num2 = Convert.ToInt32(Console.ReadLine());
		int num3 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(SumRange(num1,num2)+SumRange(num2,num3));
	}
	static int SumRange(int x, int y)
	{
		int sum = 0;
		if (x > y) return 0;
		for(int i = x; i <= y; i++) sum += i;
		return sum;
	}
}
