using System;

public class Unipolar_neighbors
{
	public static void Unipolar()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		string[] str = Console.ReadLine().Split(' ');
		int[] num = new int[str.Length];

		for(int i = 0; i < n; i++)
		{
			num[i] = Convert.ToInt32(str[i]);
		}

		for (int i = 1; i < n; i++)
		{
			if ((num[i - 1] < 0 && num[i] < 0) || (num[i - 1] > 0 && num[i] > 0))
			{
				Console.WriteLine("YES"); return;
			}
		}
		Console.WriteLine("NO");
	}
}
