using System;

public class Arthur_and_the_mysterious_thermometer
{
	public static void Thermometer()
	{
		double min = double.MaxValue;
		double max = double.MinValue;
		double sum = 0;
		int count = 0;
		int total = 0;
		while (true)
		{
			string input = Console.ReadLine();
			if (input == "кажется, я сломался") break;
			double temp = Convert.ToDouble(input);
			total++;

			if (temp < min) min = temp;
			if (temp > max) max = temp;
			if (temp >= -50 && temp <= 100)
			{
				sum += temp;
				count++;
			}

		}

		double avg = count > 0 ? sum / count : 0;

		Console.WriteLine($"Средняя температура: {avg}");
		Console.WriteLine($"Самая низкая температура: {min}");
		Console.WriteLine($"Самая высокая температура: {max}");

		if (total - count > total * 0.5)
			Console.WriteLine("Совет: Артур, термометр явно с другой планеты! Выбрось его!");
		else
			Console.WriteLine("Совет: Термометр иногда врет, но жить можно. Держи его подальше от микроволновки!");
	}
}
