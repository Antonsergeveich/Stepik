using System;

public class The_Shifter
{
	public static void Shifter()
	{
		string str = Console.ReadLine();
		for(int i = str.Length - 1; i >= 0; i--)
		{
			Console.Write(str[i]);
		}
	}
}
