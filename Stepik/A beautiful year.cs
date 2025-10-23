using System;

public class A_beautiful_year
{
	public static void Year()
	{
		int year = Convert.ToInt32(Console.ReadLine());
		while (true)
		{
			year++;
			int a = year / 1000;
			int b = (year / 100) % 10;
			int c = (year / 10) % 10;
			int d = year % 10;

			if(a != b && a != c && a != d && b != c && b != d && c != d)
			{
				Console.WriteLine(year);
				return;
			}
		}
	}
}
