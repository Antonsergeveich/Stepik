using System;

public class Minimum
{
	public static void Min()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		int x = Convert.ToInt32(Console.ReadLine());
		int min = x;
		for(int i = 0; i < n - 1; i++)
		{
			x = Convert.ToInt32(Console.ReadLine());
			if(x < min) min = x;	
		}
		Console.WriteLine(min);
	}
}
