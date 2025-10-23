using System;

public class Bulls_and_cows
{
	public static void Cows()
	{
		string pc = Console.ReadLine();
		string player = Console.ReadLine();
		int bulls = 0;
		int cows = 0;

		for (int i = 0; i <= pc.Length - 1; i++)
		{
			if (pc[i] == player[i]) bulls++;
			for (int j = 0; j <= player.Length - 1; j++)
			{
				if (pc[i] == player[j] && pc[i] != player[i]) cows++;
			}
		}
		if (bulls == 4) Console.WriteLine("Четыре быка! Ты выиграл!");
		else if (cows == 4) Console.WriteLine("Четыре коровы. Правильно расставьте цифры");
		else Console.WriteLine($"Быки-{bulls}, коровы-{cows}");
	}
}
