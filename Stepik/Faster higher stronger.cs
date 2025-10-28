using System;

public class Faster_higher_stronger
{
	public static void Faster()
	{
		string[] num = Console.ReadLine().Split();
		int n = Convert.ToInt32(num[0]);
		int m = Convert.ToInt32(num[1]);
		int[,] stronger = new int[n, m];
		for (int i = 0; i < n; i++)
		{
			string[] str = Console.ReadLine().Split();
			for (int j = 0; j < m; j++)
			{
				stronger[i, j] = Convert.ToInt32(str[j]);
			}
		}
		int max = 0;
		int index = 0;
		for (int i = 0; i < n; i++)
		{
			int sum = 0;
			for (int j = 0; j < m; j++)
			{
				sum += stronger[i, j];
				if (sum > max)
				{
					max = sum;
					index = i;
				}
			}
		}
		Console.WriteLine(max);
		Console.WriteLine(index);
	}
}
