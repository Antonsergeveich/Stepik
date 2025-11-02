using System;

public class Frost_and_wind
{
	public static void Wind()
	{
		int temperature = int.Parse(Console.ReadLine());
		int windSpeed = int.Parse(Console.ReadLine());
		int maxClass = 0;

		if(temperature <= -31 || (temperature >= -31 && temperature <= -28 && windSpeed >= 5))
		{
			maxClass = 11;
		}
		else if (temperature <= -28 || (temperature >= -28 && temperature <= -25 && windSpeed >= 5))
		{
			maxClass = 8;
		}
		else if (temperature <= -25)
		{
			maxClass = 4;
		}
		if (maxClass > 0)
		{
			Console.WriteLine($"Занятия отменяются в классах с 1 по {maxClass}");
		}
		else
		{
			Console.WriteLine("Оснований для отмены школьных занятий нет");
		}
	}
}

//using System;

//public class MainClass
//{
//	public static void Main()
//	{
//		int tempetature = int.Parse(Console.ReadLine());
//		int woosh = int.Parse(Console.ReadLine());
//		string word = "Занятия отменяются в классах с ";
//		switch (tempetature)
//		{
//			case < -30: word += "1 по 11"; break;
//			case <= -28: word += woosh >= 5 ? "1 по 11" : "1 по 8"; break;
//			case <= -25: word += woosh >= 5 ? "1 по 8" : "1 по 4"; break;
//			default: word = "Оснований для отмены школьных занятий нет"; break;
//		}
//		Console.WriteLine(word);
//	}
//}
