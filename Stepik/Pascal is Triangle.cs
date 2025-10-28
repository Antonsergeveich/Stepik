using System;

public class Pascal_is_Triangle
{
	public static void Triangle()
	{
		string[] str = Console.ReadLine().Split();
		int n = Convert.ToInt32(str[0]);
		int m = Convert.ToInt32(str[1]);
		int[,] num = new int[n, m];
		for (int i = 0; i < n; i++)
		{
			for (int j = 0; j < m; j++)
			{
				if (i == 0 || j == 0) num[i, j] = 1;
				else num[i, j] = num[i, j - 1] + num[i - 1, j];
			}
		}
		for (int i = 0; i < n; i++)
		{
			for (int j = 0; j < m; j++)
			{
				Console.Write(num[i, j]);
				if (j < m - 1) Console.Write(" ");
			}
			Console.WriteLine();
		}
	}
}
