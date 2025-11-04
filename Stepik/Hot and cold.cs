using System;

public class HotAndCold
{
	public static void HC()
	{
		int x = int.Parse(Console.ReadLine());
		int y = int.Parse(Console.ReadLine());

		int playerX = int.Parse(Console.ReadLine());
		int playerY = int.Parse(Console.ReadLine());

		double startDist = Math.Sqrt(
			Math.Pow(playerX - x, 2) +
			Math.Pow(playerY - y, 2));

		string command;
		do
		{
			command = Console.ReadLine();
			if (command == "Верх" && playerX < 9) playerX++;
			else if (command == "Низ" && playerX > 0) playerX--;
			else if (command == "Право" && playerY < 9) playerY++;
			else if (command == "Лево" && playerY > 0) playerY--;
		} while (command != "Стоп");
		if (playerX == x && playerY == y) Console.WriteLine("Сокровище найдено!");
		else
		{
			double endDist = Math.Sqrt(
				Math.Pow(playerX - x, 2) +
				Math.Pow(playerY - y, 2));

			if (endDist < startDist) Console.WriteLine("Горячо");
			else if (endDist > startDist) Console.WriteLine("Холодно");
			else Console.WriteLine("Без изменений");
		}
	}
}
