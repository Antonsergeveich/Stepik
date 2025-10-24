using System;

public class Search2
{
	public static void Search()
	{
		int n = int.Parse(Console.ReadLine());
		string[] str = Console.ReadLine().Split(' ');
		for(int i = 0; i < n; i++)
		{
			int number = Convert.ToInt32(str[i]);
			if (number % 3 == 0) Console.Write(str[i] + " ");
		}
	}
}
