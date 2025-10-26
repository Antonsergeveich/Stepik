using System;

public class Reduce_all_array_elements_to_the_minimum_element
{
	public static void ReduceElement()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		string[] str = Console.ReadLine().Split(' ');
		int[] num = new int[n];
		int min = num[0] = Convert.ToInt32(str[0]);
		for (int i = 1; i < n; i++)
		{
			num[i] = Convert.ToInt32(str[i]);
			if (num[i] < min)min = num[i];
		}
		for(int i = 0;i < n; i++)
		{
			Console.Write(num[i] - min + " ");
		}
	}
}
