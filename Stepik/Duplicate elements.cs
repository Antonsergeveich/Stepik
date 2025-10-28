using System;

public class Duplicate_elements
{
	public static void Dublicate()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		string[] str = Console.ReadLine().Split();
		int[] num = new int[n];
		for (int i = 0; i < n; i++)
		{
			num[i] = Convert.ToInt32(str[i]);
		}
		bool find = false;
		for (int i = 0; i < n; i++)
		{
			for (int j = i + 1; j < n; j++)
			{
				if (num[i] == num[j])
				{
					find = true;
					break;
				}
			}
		}
		Console.WriteLine(find ? "YES" : "NO");
	}
}
