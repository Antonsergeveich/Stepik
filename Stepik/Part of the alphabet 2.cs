using System;

public class Part_of_the_alphabet_2
{
	public static void Alphabet()
	{
		char c = Convert.ToChar(Console.ReadLine());
		for (char i = c; i <= 'z'; i++)
		{
			Console.Write(i + " ");
		}
	}
}
