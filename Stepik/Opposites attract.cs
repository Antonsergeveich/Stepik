using System;

public class Opposites_attract
{
	public static void Attract()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		string[] str = Console.ReadLine().Split();
		int[] num = new int[n];
		for(int i = 0; i < n; i++)
		{
			num[i] = Convert.ToInt32(str[i]);
		}
		for (int i = 0; i < n - 1; i++)
		{
			for(int j = i + 1; j < n; j++)
			{
				if (num[i] + num[j] == 0)
				{
					Console.WriteLine(i < j ? i + " " + j : j + " " + i);
					return;
				} 
			}
		}
	}
}
