using System;

public class Reverse_sequence
{
	public static void Reverse()
	{
		int a = Convert.ToInt32(Console.ReadLine());
		int b = Convert.ToInt32(Console.ReadLine());

		for(int i = b; i >= a; i--)
		{
			Console.WriteLine(i);
		}
	}
}
