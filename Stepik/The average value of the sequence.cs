using System;

public class The_average_value_of_the_sequence
{
	public static void Sequence()
	{
		int num = Convert.ToInt32(Console.ReadLine());
		int sum = 0;
		int count = 0;
		while (num != 0)
		{
			sum += num;
			count++;
			num = Convert.ToInt32(Console.ReadLine());
		}
		Console.WriteLine((double)sum/count);
	}
}
