using System;

using System;

public class Interesting_numbers
{
	public static void Numbers()
	{
		bool firstNumber = true; // Флаг для первого числа

		for (int i = 10; i <= 99; i++)
		{
			int a = i % 10;     // последняя цифра (единицы)
			int b = i / 10;     // первая цифра (десятки)
			int c = a * b * 2;  // удвоенное произведение цифр

			if (i == c)
			{
				// Если это не первое число, ставим запятую перед ним
				if (!firstNumber)
				{
					Console.Write(",");
				}
				Console.Write(i);
				firstNumber = false;
			}
		}
	}
}
