using System;

public class Part_of_the_alphabet
{
	public static void Alphabet()
	{
		char c = Convert.ToChar(Console.ReadLine());
		for(int i = 'a'; i <= c; i++)
		{
			Console.Write((char)i + " ");
		}
	}
}
