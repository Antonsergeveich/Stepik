using System;

public class Program_analysis_2
{
	public static void Analysis()
	{
		int i = 0;
		int s = 0;
		while (i + 1 < 10)
		{
			i = i + 2;
			s = s + i;
			if (s > 16)
			{
				break;
			}
		}
		Console.WriteLine(i = i + 1);
	}
}
