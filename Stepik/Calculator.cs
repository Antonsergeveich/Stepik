using System;

public class Calculator
{
	public static void Counting_the_number()
	{
		int num1 = Convert.ToInt32(Console.ReadLine());
		int num2 = Convert.ToInt32(Console.ReadLine());
		string symbol = Console.ReadLine();

		if(symbol != "+" && symbol != "-" && symbol != "*" && symbol != "/")
		{
			Console.WriteLine("Неверная операция");
		}
		else
		{
			if(symbol == "+")
			{
				Console.WriteLine(num1 + num2);
			}
			else if (symbol == "-")
			{
				Console.WriteLine(num1 - num2);
			}
			else if (symbol == "*")
			{
				Console.WriteLine(num1 * num2);
			}
			else
			{
				if (num2 == 0)
				{
					Console.WriteLine("На ноль делить нельзя!");
				}
				else
				{
					Console.WriteLine((double)num1 / num2);
				}
			}
		}
	}
}
