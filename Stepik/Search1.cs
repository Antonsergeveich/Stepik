using System;

public class Search1
{
	public static void Search()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		string[] num = Console.ReadLine().Split(' ');
		for(int i = 0; i < n; i += 3)
		{
			Console.Write(num[i] + " ");
		}
	}
}
