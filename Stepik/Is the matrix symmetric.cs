using System;

public class Is_the_matrix_symmetric
{
	public static void Marix()
	{
		int n = Convert.ToInt32(Console.ReadLine());

		int[,] matrix = new int[n, n];
		for (int i = 0; i < n; i++)
		{
			string[] row = Console.ReadLine().Split();
			for (int j = 0; j < n; j++)
			{
				matrix[i, j] = Convert.ToInt32(row[j]);
			}
		}
		bool equal = true;
		for (int i = 0; i < n && equal; i++)
		{
			for (int j = i + 1; j < n && equal; j++)
			{
				if (matrix[i, j] != matrix[j, i])
				{
					equal = false;
				}
			}
		}
		Console.WriteLine(equal ? "YES" : "NO");
	}
}
