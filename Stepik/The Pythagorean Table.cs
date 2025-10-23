using System;

public class The_Pythagorean_Table
{
	public static void Table()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		if(n == 0)
		{
			Console.WriteLine("Таблица пустая");
			return;
		}
		for(int i = 1; i <= n; i++)
		{
			for(int j = 1; j <= n; j++)
			{
				Console.Write(i * j + " ");
			}
			Console.WriteLine();
		}
	}
}
