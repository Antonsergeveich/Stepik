using System;

public class A_multiple_but_not_quite
{
	public static void Multiple()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		int c = Convert.ToInt32(Console.ReadLine());
		int d = Convert.ToInt32(Console.ReadLine());

		for(int i = 1; i <= n; i++)
		{
			if(i % c == 0 && i % d != 0)
			{
				Console.WriteLine(i);
				break;
			}
		}
	}
}
