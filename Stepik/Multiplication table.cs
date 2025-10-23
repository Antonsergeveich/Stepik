using System;

public class Multiplication_table
{
	public static void Table()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		for(int i = 1; i <= 10; i++)
		{
			Console.WriteLine($"{n} * {i} = {n * i}");
		}
	}
}
