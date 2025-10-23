using System;

public class How_many_times_is_it_divided
{
	public static void Many()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		int count = 0;
		while(n % 3 == 0)
		{
			n/= 3;
			count++;
		}
		Console.WriteLine(count);
	}
}
