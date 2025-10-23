using System;

public class On_an_electric_scooter_with_a_breeze
{
	public static void Breeze()
	{
		int rent = Convert.ToInt32(Console.ReadLine());
		int free_minutes = Convert.ToInt32(Console.ReadLine());
		int duration_of_the_trip = Convert.ToInt32(Console.ReadLine());
		int minute_limit = Convert.ToInt32(Console.ReadLine());

		int over = duration_of_the_trip - free_minutes;
		if (over <= 0)
		{
			Console.WriteLine(rent);
		}
		else
		{
			int res = (over * minute_limit) + rent;
			Console.WriteLine(res);
		}
	}
}
