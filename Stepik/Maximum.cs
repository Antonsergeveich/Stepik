using System;

public class Maximum
{
	public static void Max()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		int x = Convert.ToInt32(Console.ReadLine());
		int max = x;
		for(int i = 0; i < n - 1; i++)
		{
			x = Convert.ToInt32(Console.ReadLine());
			if(x > max)max = x;
		}
		Console.WriteLine(max);
	}
}
