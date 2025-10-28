using System;

public class Less_than_the_following
{
	public static void Less()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		string[] str = Console.ReadLine().Split();
		int[] num = new int[n];
		for(int i = 0; i < n; i++)
		{
			num[i] = Convert.ToInt32(str[i]);
		}
		int count = 0;
		for(int i = 0;i < n - 1; i++)
		{
			if (num[i] < num[i + 1]) count++;
		}
		Console.WriteLine(count);
	}
}
