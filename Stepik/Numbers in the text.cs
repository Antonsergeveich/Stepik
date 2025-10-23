using System;

public class Numbers_in_the_text
{
	public static void Numbers()
	{
		string str = Console.ReadLine();
		for (int i = 0; i <= str.Length - 1; i++)
		{
			if (str[i] >= '0' && str[i] <= '9')
			{
				Console.Write(str[i]);
				if (str[i] != str[str.Length - 1]) 
					Console.Write(" ");
			}
		}
	}
}
