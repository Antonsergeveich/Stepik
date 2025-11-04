using System;

public class TicTacToe
{
	public static void Toe()
	{
		bool exitProgram = false;
		while (!exitProgram)
		{
			Console.WriteLine("=== Крестики Нолики ===");
			Console.WriteLine("1 - Новая Игра");
			Console.WriteLine("2 - Выход");
			Console.WriteLine("Введите 1 или 2 для выбора:");

			string? menuChoice = Console.ReadLine();
			if (menuChoice == "1")
			{
				string[,] map = new string[3, 3]
				{
					{"1", "2", "3"},
					{"4", "5", "6"},
					{"7", "8", "9"}
				};
				bool isZeroNow = false;
				for (int i = 0; i < 9; i++)
				{
					if (isZeroNow) Console.WriteLine("Ходят нолики");
					else Console.WriteLine("Ходят крестики");
					PrintMap(map);
					Console.WriteLine("Введите цифру вашего хода:");
					string cellNumber = GetPlayerCellNumber(map);
					MakeMove(map, cellNumber, isZeroNow);
					if (HasWinner(map))
					{
						PrintMap(map);
						if (isZeroNow) Console.WriteLine("Нолики победили!");
						else Console.WriteLine("Крестики победили!");
						Console.WriteLine("Нажмите любую клавишу чтобы продолжить...");
						Console.ReadKey();
						break;
					}
					isZeroNow = !isZeroNow;
				}
				if (!HasWinner(map))
				{
					PrintMap(map);
					Console.WriteLine("Ничья!");
					Console.WriteLine("Нажмите любую клавишу чтобы продолжить...");
					Console.ReadKey();
				}
			}
			else if (menuChoice == "2") exitProgram = true;
			else Console.WriteLine("Неверный выбор!");
			Console.Clear();
		}
	}

	static void PrintMap(string[,] map)
	{
		int rows = map.GetLength(0);
		int cols = map.GetLength(1);
		Console.WriteLine("-------------");
		for (int i = 0; i < rows; i++)
		{
			Console.Write("| ");
			for (int j = 0; j < cols; j++)
			{
				string symbol = map[i, j];
				if (symbol == "X") Console.ForegroundColor = ConsoleColor.Red;
				else if (symbol == "O") Console.ForegroundColor = ConsoleColor.Blue;
				Console.Write(symbol);
				Console.ResetColor();
				Console.Write(" | ");
			}
			Console.WriteLine();
			Console.WriteLine("-------------");
		}
	}

	static bool IsMoveCorrect(string[,] map, string cellNumber)
	{
		int num = int.Parse(cellNumber) - 1;
		return map[num / 3, num % 3] == cellNumber;
	}

	static string[,] MakeMove(string[,] map, string cellNumber, bool isZeroNow = true)
	{
		int num = int.Parse(cellNumber) - 1;
		map[num / 3, num % 3] = isZeroNow ? "O" : "X";
		return map;
	}

	static string GetPlayerCellNumber(string[,] map)
	{
		while (true)
		{
			string? symbol = Console.ReadLine();
			if (symbol is null)
			{
				Console.WriteLine("Неверный ввод. Пожалуйста, введите цифру от 1 до 9.");
				continue;
			}
			int number;
			if (!int.TryParse(symbol, out number) || number < 1 || number > 9)
			{
				Console.WriteLine("Неверный ввод. Пожалуйста, введите цифру от 1 до 9.");
				continue;
			}
			if (!IsMoveCorrect(map, symbol))
			{
				Console.WriteLine("Неверный ввод. Пожалуйста, введите цифру пустой ячейки.");
				continue;
			}
			return symbol;
		}
	}
	static bool HasWinner(string[,] map)
	{
		for (int i = 0; i < 3; i++)
		{
			if (map[i, 0] == map[i, 1] && map[i, 1] == map[i, 2] && map[i, 0] != "") return true;
			if (map[0, i] == map[1, i] && map[1, i] == map[2, i] && map[0, i] != "") return true;
		}
		if (map[0, 0] == map[1, 1] && map[1, 1] == map[2, 2] && map[0, 0] != "") return true;
		if (map[0, 2] == map[1, 1] && map[1, 1] == map[2, 0] && map[0, 2] != "") return true;
		return false;
	}
}
