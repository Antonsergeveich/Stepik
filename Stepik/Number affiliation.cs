using System;

public class Number_affiliation
{
	public static void Affiliation()
	{
		int num = Convert.ToInt32(Console.ReadLine());

		if (num > -30 && num <= -2 || num > 7 && num <= 25)
		{
			Console.WriteLine("Принадлежит");
		}
		else
		{
			Console.WriteLine("Не принадлежит");
		}
	}
}
