using System;

public class Part_of_the_alphabet2
{
	public static void Part()
	{
		char a = Convert.ToChar(Console.ReadLine());
		char b = Convert.ToChar(Console.ReadLine());

		char max, min;
		if (a > b)
		{
			max = a;
			min = b;
		}
		else
		{
			max = b;
			min = a;
		}
		for(char i = min; i <= max; i++)
		{
			Console.Write(i + " ");
		}
	}
}
