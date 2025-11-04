using System;

public class TicTacToe
{
	public static void Toe()
	{
		string[,] map = new string[3, 3]
		{
			{"1", "2", "O"},
			{"4", "5", "6"},
			{"X", "8", "9"}
		};
		PrintMap(map);

	}

	static void PrintMap(string[,] map)
	{
		int rows = map.GetLength(0);
		int cols = map.GetLength(1);

		for (int i = 0; i < rows; i++)
		{
			for (int j = 0; j < cols; j++)
			{
				string symbol = map[i, j];
				if (symbol == "X") Console.ForegroundColor = ConsoleColor.Red;
				else if (symbol == "O") Console.ForegroundColor = ConsoleColor.Blue;
				Console.Write(symbol + " ");
				Console.ResetColor();
			}
			Console.WriteLine();
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
}
