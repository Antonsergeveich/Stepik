using System;

public class Swap_the_first_minimum_and_the_last_maximum
{
	public static void Swap()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		string[] input = Console.ReadLine().Split();
		int[] arr = new int[n];

		for (int i = 0; i < n; i++)
		{
			arr[i] = Convert.ToInt32(input[i]);
		}

		int minIndex = 0;
		int minValue = arr[0];

		for (int i = 1; i < n; i++)
		{
			if (arr[i] < minValue)
			{
				minValue = arr[i];
				minIndex = i;
			}
		}

		int maxIndex = 0;
		int maxValue = arr[0];

		for (int i = 1; i < n; i++)
		{
			if (arr[i] >= maxValue)
			{
				maxValue = arr[i];
				maxIndex = i;
			}
		}

		int buf = arr[minIndex];
		arr[minIndex] = arr[maxIndex];
		arr[maxIndex] = buf;

		for (int i = 0; i < n; i++)
		{
			Console.Write(arr[i]);
			if (i < n - 1)
				Console.Write(" ");
		}

	}
}