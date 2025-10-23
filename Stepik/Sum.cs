using System;

public class Sum
{
	public static void Summator()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		int sum = 0;
		for(int i = 0; i < n; i++)
		{
			sum += Convert.ToInt32(Console.ReadLine());
		}
		Console.WriteLine(sum);
	}
}
