using System;
using static System.Console;

public class Registration_mark
{
	public static void Registration()
	{
		int num = Convert.ToInt32(Console.ReadLine());
		int cod = num % 10;

		switch (cod)
		{
			case 1: Console.WriteLine("Брестская область"); break;
			case 2: Console.WriteLine("Витебская область"); break;
			case 3: Console.WriteLine("Гомельская область"); break;
			case 4: Console.WriteLine("Гродненская область"); break;
			case 5: Console.WriteLine("Минская область"); break;
			case 6: Console.WriteLine("Могилевская область"); break;
			case 7: Console.WriteLine("г. Минск"); break;
			default: Console.WriteLine("Что-то не так разглядела"); break;
		}
	}
}

//using System;
//using static System.Console;

//public class MainClass
//{
//	public static void Main()
//	{
//		int n = int.Parse(ReadLine());
//		WriteLine((n % 10) switch
//		{
//			1 => "Брестская область",
//			2 => "Витебская область",
//			3 => "Гомельская область",
//			4 => "Гродненская область",
//			5 => "Минская область",
//			6 => "Могилевская область",
//			7 => "г. Минск",
//			_ => "Что-то не так разглядела"
//		});
//	}
//}
