using System;

public class The_difference_between_the_maximum_and_minimum_indices
{
	public static void Difference()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		string[] str = Console.ReadLine().Split(' ');
		int[] num = new int[n];

		num[0] = Convert.ToInt32(str[0]);
		int min = num[0], max = num[0];
		int index_min = 0, index_max = 0;
		for(int i = 1; i < n; i++)
		{
			num[i] = Convert.ToInt32(str[i]);
			if (num[i] < min)
			{
				min = num[i];
				index_min = i;
			}
			if (num[i] > max)
			{
				max = num[i];
				index_max = i;
			}
		}
		Console.WriteLine(index_max - index_min);
	}
}
