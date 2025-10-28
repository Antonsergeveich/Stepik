using System;

public class Side_diagonal
{
	public static void Diagonal()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		for(int i = 0; i < n; i++)
		{
			for(int j = n - 1; j >= 0; j--)
			{
				if (i == j) Console.Write(1 + " ");
				else if (i > j) Console.Write(2 + " ");
				else if (i < j) Console.Write(0 + " ");
			}
			Console.WriteLine();
		}
	}
}
