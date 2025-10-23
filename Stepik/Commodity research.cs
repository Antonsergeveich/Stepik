using System;

public class Commodity_research
{
	public static void Research()
	{
		int count = Convert.ToInt32(Console.ReadLine());
		for(int i = 0; i < count; i++)
		{
			int cod = Convert.ToInt32(Console.ReadLine());
			string country = "";
			switch (cod)
			{
				case 460:
				case 461:
				case 462:
				case 463:
				case 464:
				case 465:
				case 466:
				case 467:
				case 468:
				case 469:
					country = "Россия";break;
				case 471: country = "Тайвань";break;
				case 474: country = "Эстония";break;
				case 475: country = "Латвия";break;
				case 476: country = "Азербайджан";break;
				case 477: country = "Литва";break;
				case 478: country = "Узбекистан"; break;
				case 479: country = "Шри-Ланка"; break;
				case 480: country = "Филиппины"; break;
				case 481: country = "Беларусь"; break;
			}

			if (country != "")
			{
				Console.WriteLine($"Код страны изготовителя ({country})");
			}
			else
			{
				Console.WriteLine("Тут я тебе не помощник!");
			}
		}
	}
}
