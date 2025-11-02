using System;

public class Zodiac_Signs
{
	public static void Signs()
	{
		int month, day;
		if (!int.TryParse(Console.ReadLine(), out month) || month < 1 || month > 12)
		{
			Console.WriteLine("Неверный месяц");
			return;
		}
		if (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 31)
		{
			Console.WriteLine("Неверный день");
			return;
		}

		string zodiac = "";
		switch (month)
		{
			case 1:
				zodiac = (day <= 20) ? "Козерог" : "Водолей";
				break;
			case 2:
				if (day > 29)
				{
					Console.WriteLine("Неверный день");
					return;
				}
				zodiac = (day <= 18) ? "Водолей" : "Рыбы";
				break;
			case 3:
				zodiac = (day <= 20) ? "Рыбы" : "Овен";
				break;
			case 4:
				if (day > 30)
				{
					Console.WriteLine("Неверный день");
					return;
				}
				zodiac = (day <= 20) ? "Овен" : "Телец";
				break;
			case 5:
				zodiac = (day <= 21) ? "Телец" : "Близнецы";
				break;
			case 6:
				if (day > 30)
				{
					Console.WriteLine("Неверный день");
					return;
				}
				zodiac = (day <= 21) ? "Близнецы" : "Рак";
				break;
			case 7:
				zodiac = (day <= 22) ? "Рак" : "Лев";
				break;
			case 8:
				zodiac = (day <= 23) ? "Лев" : "Дева";
				break;
			case 9:
				if (day > 30)
				{
					Console.WriteLine("Неверный день");
					return;
				}
				zodiac = (day <= 22) ? "Дева" : "Весы";
				break;
			case 10:
				zodiac = (day <= 23) ? "Весы" : "Скорпион";
				break;
			case 11:
				if (day > 30)
				{
					Console.WriteLine("Неверный день");
					return;
				}
				zodiac = (day <= 22) ? "Скорпион" : "Стрелец";
				break;
			case 12:
				zodiac = (day <= 21) ? "Стрелец" : "Козерог";
				break;
		}
		Console.WriteLine(zodiac);
	}
}
//using System;
//using static System.Console;

//public class MainClass
//{
//	public static void Main()
//	{
//		int mon = int.Parse(ReadLine());
//		int day = int.Parse(ReadLine());

//		WriteLine((100 * mon + day) switch
//		{
//			>= 121 and <= 218 => "Водолей",
//			>= 219 and <= 320 => "Рыбы",
//			>= 321 and <= 420 => "Овен",
//			>= 421 and <= 521 => "Телец",
//			>= 522 and <= 621 => "Близнецы",
//			>= 622 and <= 722 => "Рак",
//			>= 723 and <= 823 => "Лев",
//			>= 824 and <= 922 => "Дева",
//			>= 923 and <= 1023 => "Весы",
//			>= 1024 and <= 1122 => "Скорпион",
//			>= 1123 and <= 1221 => "Стрелец",
//			_ => "Козерог"
//		});
//	}
//}