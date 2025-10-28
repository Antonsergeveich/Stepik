using System;

public class The_number_of_elements_according_to_the_condition
{
	public static void According()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		string[] str = Console.ReadLine().Split();
		int[] arr = new int[n];
		int count = 0;
		for(int i = 0; i < n; i++)
		{
			arr[i] = Convert.ToInt32(str[i]);
			if (arr[i] % 3 == 0 && arr[i] % 10 == 7)count++;
		}
		for(int i = 0;i < n; i++)
		{
			if (arr[i] % 3 == 0 && arr[i] % 10 == 7) arr[i] = count;
			Console.Write(arr[i]);
			if (i <  n - 1) Console.Write(" ");
		}
	}
}
