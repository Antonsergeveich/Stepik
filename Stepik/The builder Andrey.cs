using System;

public class The_builder_Andrey
{
	public static void Builder()
	{
		int house = Convert.ToInt32(Console.ReadLine());
		string[] number_floors = Console.ReadLine().Split();
		int sum_hours = 0;
		for (int i = 0; i < house; i++)
		{
			sum_hours += Convert.ToInt32(number_floors[i]);
		}
		int days = (sum_hours + 11) / 12;
		Console.WriteLine(days);
	}
}
