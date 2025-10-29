using System;

public class Orientation_on_the_terrain
{
	public static void Orientation()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		int northSouth = 0;
		int eastWest = 0;

		for (int i = 0; i < n; i++)
		{
			string[] input = Console.ReadLine().Split();
			int direction = int.Parse(input[0]);
			int steps = int.Parse(input[1]);

			switch (direction)
			{
				case 1:
					northSouth += steps;
					break;
				case 2:
					eastWest += steps;
					break;
				case 3:
					northSouth -= steps;
					break;
				case 4:
					eastWest -= steps;
					break;
			}
		}

		int horizontal = eastWest;
		int vertical = northSouth;
		string horizontalDirection = "";
		string verticalDirection = "";

		if (horizontal > 0) horizontalDirection = "Восток";
		else if (horizontal < 0)
		{
			horizontalDirection = "Запад";
			horizontal = -horizontal;
		}
		if (vertical > 0) verticalDirection = "Север";
		else if (vertical < 0)
		{
			verticalDirection = "Юг";
			vertical = -vertical;
		}
		if (horizontal == 0 && vertical == 0)
			Console.WriteLine("Поздравляю с лёгкой победой! Идти никуда не надо!");
		else if (horizontal == 0)
			Console.WriteLine($"Сделайте {vertical} шага(шагов) на {verticalDirection}");
		else if (vertical == 0)
			Console.WriteLine($"Сделайте {horizontal} шага(шагов) на {horizontalDirection}");
		else
			Console.WriteLine($"Сделайте {horizontal} шага(шагов) на {horizontalDirection} и {vertical} шага(шагов) на {verticalDirection}");
	}
}
