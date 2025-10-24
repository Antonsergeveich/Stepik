using System;

public class Clothing_size
{
	public static void Size()
	{
		int size = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(GetClothingDescription(size));
	}

	static string GetClothingDescription(int size)
	{
		if (size <= 0)
			return "Ошибка: Размер одежды должен быть положительным числом.";
		else if (size <= 42)
			return "Это маленький размер одежды.";
		else if (size <= 50)
			return "Это средний размер одежды.";
		else
			return "Это большой размер одежды.";
	}
}
