using System;

public class Andrey_goes_the_distance
{
	public static void Distance()
	{
		int num = Convert.ToInt32(Console.ReadLine());
		int days = 0;
		double km = 1;
		while (km < num)
		{
			km += km * 0.2;
			days++;
		}
		Console.WriteLine(days);
	}
}
