using System;

public class Rearrange_adjacent_elements
{
	public static void Rearrange()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		string[] arr = Console.ReadLine().Split(' ');
		int[] numbers = new int[arr.Length];
		for (int i = 0; i < n; i++)
		{
			numbers[i] = Convert.ToInt32(arr[i]);
		}

		for (int i = 0; i < n - 1; i += 2)
		{
			int buf = numbers[i];
			numbers[i] = numbers[i + 1];
			numbers[i + 1] = buf;
		}
		for(int i = 0; i < n; i++)
			Console.Write(numbers[i] + " ");
	}
}
