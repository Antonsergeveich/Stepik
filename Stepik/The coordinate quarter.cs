using System;

public class The_coordinate_quarter
{
	public static void in_which_coordinate_quarter_is_the_point_located()
	{
		double x = Convert.ToDouble(Console.ReadLine());
		double y = Convert.ToDouble(Console.ReadLine());

		if (x > 0 && y > 0)
		{
			Console.WriteLine("1");
		}
		else if (x < 0 && y > 0)
		{
			Console.WriteLine("2");
		}
		else if (x < 0 && y < 0)
		{
			Console.WriteLine("3");
		}
		else
		{
			Console.WriteLine("4");
		}
	}
}
