using System;

public class Deleting_a_character_from_a_string
{
	public static void Deleting()
	{
		string str = Console.ReadLine();
		int num = Convert.ToInt32(Console.ReadLine());
		for (int i = 0; i <= str.Length - 1; i++)
		{
			if (i != num - 1) Console.Write(str[i]);
		}
	}
}
