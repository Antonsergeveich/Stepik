using System;

public class TimurZaborAndHisTeam
{
	public static void Team()
	{
		string[] str = Console.ReadLine().Split();
		int friends = Convert.ToInt32(str[0]);
		int fence_height = Convert.ToInt32(str[1]);
		string[] growth = Console.ReadLine().Split();
		int[] num = new int[friends];
		for(int i = 0; i < friends; i++)
		{
			num[i] = Convert.ToInt32(growth[i]);
		}
		int road_width = 0;
		for(int i = 0; i < friends; i++)
		{
			if (num[i] <= fence_height) road_width++;
			else if (num[i] > fence_height) road_width += 2;
		}
		Console.WriteLine(road_width);
	}
}
