using System;

public class Storage
{
	public static void Warehouse()
	{
		string product = Console.ReadLine();
		int rows = Convert.ToInt32(Console.ReadLine());
		int cols = Convert.ToInt32(Console.ReadLine());
		int count = 0;
		for(int i = 0; i < rows; i++)
		{
			string[] str = Console.ReadLine().Split();
			for(int j = 0; j < cols; j++)
			{
				if (str[j] == product)count++;
			}
		}
		Console.WriteLine($"{product} = {count}");
	}
}
