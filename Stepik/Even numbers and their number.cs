using System;

public class Even_numbers_and_their_number
{
	public static void Even()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		string[] arr = Console.ReadLine().Split();
		int[] num = new int[n];
		int count = 0;
		for (int i = 0; i < n; i++)
		{
			num[i] = Convert.ToInt32(arr[i]);
			if (num[i] % 2 == 0)
			{
				Console.Write(num[i] + " ");
				count++;
			}
		}
		Console.WriteLine();
		Console.WriteLine(count);
	}
}
