using System;

public class The_index_of_the_minimum_element
{
	public static void Index()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		string[] str = Console.ReadLine().Split(' ');
		int[] num = new int[n];
		for(int i = 0; i < n; i++)
		{
			num[i] = Convert.ToInt32(str[i]);
		}
		int index = 0;
		for(int i = 1; i < n; i++)
		{
			if (num[i] < num[index]) index = i;
		}
		Console.WriteLine(index);
	}
}
