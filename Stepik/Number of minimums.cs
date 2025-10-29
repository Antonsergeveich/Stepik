using System;

public class Number_of_minimums
{
	public static void Minimums()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		int[] num = new int[n];

		for (int i = 0; i < n; i++)
			num[i] = Convert.ToInt32(Console.ReadLine());

		int min = num[0];
		int count = 0;

		for (int i = 1; i < n; i++)
			if (num[i] < min) min = num[i];
		for(int i = 0;i < n; i++)
			if (num[i] == min)count++;
		
		Console.WriteLine(count);
	}
}
