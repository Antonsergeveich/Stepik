using System;
using static System.Console;
public class The_reverse_number
{
	public static void Reverse()
	{
		double num = Convert.ToDouble(ReadLine());
		WriteLine(num != 0 ? 1 / num : "Обратного числа не существует");
	}
}
