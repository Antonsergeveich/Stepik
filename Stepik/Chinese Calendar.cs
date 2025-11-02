using System;

public class Chinese_Calendar
{
	public static void Chinese()
	{
		int year = Convert.ToInt32(Console.ReadLine());
		int month = Convert.ToInt32(Console.ReadLine());
		int day = Convert.ToInt32(Console.ReadLine());

		if (IsDateInRange(year, month, day))
		{
			string animal = GetChineseAnimal(year, month, day);
			Console.WriteLine(animal);
		}
		else Console.WriteLine("Дата вне диапазона");
	}

	private static bool IsDateInRange(int year, int month, int day)
	{
		DateTime inputDate = new DateTime(year, month, day);
		DateTime startDate = new DateTime(2020, 1, 25);
		DateTime endDate = new DateTime(2026, 2, 16);

		return inputDate >= startDate && inputDate <= endDate;
	}

	private static string GetChineseAnimal(int year, int month, int day)
	{
		DateTime inputDate = new DateTime(year, month, day);

		if (inputDate >= new DateTime(2020, 1, 25) && inputDate <= new DateTime(2021, 2, 11))
			return "Крыса";
		else if (inputDate >= new DateTime(2021, 2, 12) && inputDate <= new DateTime(2022, 1, 31))
			return "Бык";
		else if (inputDate >= new DateTime(2022, 2, 1) && inputDate <= new DateTime(2023, 1, 21))
			return "Тигр";
		else if (inputDate >= new DateTime(2023, 1, 22) && inputDate <= new DateTime(2024, 2, 9))
			return "Кролик";
		else if (inputDate >= new DateTime(2024, 2, 10) && inputDate <= new DateTime(2025, 1, 28))
			return "Дракон";
		else if (inputDate >= new DateTime(2025, 1, 29) && inputDate <= new DateTime(2026, 2, 16))
			return "Змея";
		else
			return "Дата вне диапазона";
	}
}
//using System;

//public class MainClass
//{
//	public static void Main()
//	{
//		int year = int.Parse(Console.ReadLine());
//		int month = int.Parse(Console.ReadLine());
//		int day = int.Parse(Console.ReadLine());

//		// Преобразуем дату в число для удобного сравнения
//		int date = year * 10000 + month * 100 + day;

//		if (date >= 20200125 && date <= 20210211)
//			Console.WriteLine("Крыса");
//		else if (date >= 20210212 && date <= 20220131)
//			Console.WriteLine("Бык");
//		else if (date >= 20220201 && date <= 20230121)
//			Console.WriteLine("Тигр");
//		else if (date >= 20230122 && date <= 20240209)
//			Console.WriteLine("Кролик");
//		else if (date >= 20240210 && date <= 20250128)
//			Console.WriteLine("Дракон");
//		else if (date >= 20250129 && date <= 20260216)
//			Console.WriteLine("Змея");
//		else
//			Console.WriteLine("Дата вне диапазона");
//	}
//}