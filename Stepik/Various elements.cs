using System;

public class Various_elements
{
	public static void Various()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		string[] str = Console.ReadLine().Split();
		int[] arr = new int[n];
		int count = 1;
		arr[0] = Convert.ToInt32(str[0]);
		for (int i = 1; i < n; i++)
		{
			arr[i] = Convert.ToInt32(str[i]);
			if (arr[i] > arr[i - 1])count++;
		}
		Console.WriteLine(count);
	}
}
