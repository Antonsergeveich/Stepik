using System;

public class Rubles_and_kopecks
{
	public static void RB()
	{
		int rubles = int.Parse(Console.ReadLine());
		int kopecks = int.Parse(Console.ReadLine());

		string rubleWord = GetRubles(rubles);
		string kopekWord = GetKopecks(kopecks);

		Console.WriteLine($"{rubles} {rubleWord} {kopecks} {kopekWord}");
	}

	public static string GetRubles(int rubles)
	{
		int lastTwoDigits = rubles % 100;
		if (lastTwoDigits >= 11 && lastTwoDigits <= 19) return "рублей";
		int lastDigit = rubles % 10;
		switch (lastDigit)
		{
			case 1:
				return "рубль";
			case 2:
			case 3:
			case 4:
				return "рубля";
			default:
				return "рублей";
		}
	}

	public static string GetKopecks(int kopecks)
	{
		int lastTwoDigits = kopecks % 100;
		if (lastTwoDigits >= 11 && lastTwoDigits <= 19) return "копеек";
		int lastDigit = kopecks % 10;
		switch (lastDigit)
		{
			case 1: return "копейка";
			case 2:
			case 3:
			case 4:
				return "копейки";
			default:
				return "копеек";

		}
	}
}

//using System;

//public class MainClass
//{
//	public static void Main()
//	{
//		int rubles = int.Parse(Console.ReadLine());
//		int kopecks = int.Parse(Console.ReadLine());

//		string rubleWord = GetWordForm(rubles, "рубль", "рубля", "рублей");
//		string kopeckWord = GetWordForm(kopecks, "копейка", "копейки", "копеек");

//		Console.WriteLine($"{rubles} {rubleWord} {kopecks} {kopeckWord}");
//	}

//	static string GetWordForm(int number, string form1, string form2, string form5)
//	{
//		int lastTwoDigits = number % 100;
//		int lastDigit = number % 10;

//		if (lastTwoDigits >= 11 && lastTwoDigits <= 14)
//			return form5;

//		switch (lastDigit)
//		{
//			case 1:
//				return form1;
//			case 2:
//			case 3:
//			case 4:
//				return form2;
//			default:
//				return form5;
//		}
//	}
//}
