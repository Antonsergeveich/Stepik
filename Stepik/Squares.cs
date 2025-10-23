using System;

public class Squares
{
	public static void Square()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		for(int i = 1; i <= n; i++)
		{
			Console.WriteLine(i*i);
		}
	}
}
