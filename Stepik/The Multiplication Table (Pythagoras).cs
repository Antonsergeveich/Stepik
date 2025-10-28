using System;

public class The_Multiplication_Table_Pythagoras
{
	public static void Pythagoras()
	{
		string[] input = Console.ReadLine().Split();
		int n = Convert.ToInt32(input[0]);
		int m = Convert.ToInt32(input[1]);

		int[,] table = new int[n,m];

		for (int i = 0; i < n; i++)
		{
			for(int j = 0; j < m; j++)
			{
				table[i, j] = (i + 1) * (j + 1);
				Console.Write((table[i,j]) + " ");
			}
			Console.WriteLine();
		}
	}
}
