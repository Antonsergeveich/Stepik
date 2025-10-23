using System;

public class Programmer_is_level
{
	public static void Level()
	{
		int num = Convert.ToInt32(Console.ReadLine());
		if (num <= 3) Console.WriteLine("начинающий");
		else if (num >= 4 && num <= 7) Console.WriteLine("младший разработчик");
		else if (num >= 8 && num <= 15) Console.WriteLine("средний разработчик");
		else Console.WriteLine("старший разработчик");
	}
}
