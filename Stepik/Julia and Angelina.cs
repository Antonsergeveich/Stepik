using System;

public class Julia_and_Angelina
{
	public static void And()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		string[] ch = new string[n];
		for (int i = 0; i < n; i++)
		{
			ch[i] = Console.ReadLine();
		}
		for (int i = 0; i < n; i++)
		{
			Console.Write((char)Convert.ToInt32(ch[i]));
		}
	}
}
