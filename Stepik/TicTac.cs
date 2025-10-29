using System;

public class TicTac
{
	public static void Go()
	{
		string[][] str = new string[3][];
		for(int i = 0; i < 3; i++)
			str[i] = Console.ReadLine().Split();

		for(int i = 0;i < 3; i++)
		{
			if (str[i][0] == str[i][1] && str[i][1] == str[i][2])
			{
				Console.WriteLine(str[i][0] == "X" ? "Победили крестики" : "Победили нолики");
				return;
			}
			if (str[0][i] == str[1][i] && str[1][i] == str[2][i])
			{
				Console.WriteLine(str[0][i] == "X" ? "Победили крестики" : "Победили нолики");
				return;
			}
		}

		if (str[0][0] == str[1][1] && str[1][1] == str[2][2] || str[0][2] == str[1][1] && str[1][1] == str[2][0])
		{
			Console.WriteLine(str[1][1] == "X" ? "Победили крестики" : "Победили нолики");
			return;
		}
		Console.WriteLine("Ничья");
	}
}
