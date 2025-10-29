using System;

public class Flower_garden
{
	public static void Garden()
	{
		string[,] flowers = new string[3, 5];
		for (int i = 0; i < 3; i++)
		{
			string[] rose = Console.ReadLine().Split();
 			for (int j = 0; j < 5; j++)
			{
				flowers[i, j] = rose[j];
			}
		}
		string[] price = Console.ReadLine().Split();
		int priceRed = int.Parse(price[0]);
		int priceWhite = int.Parse(price[1]);
		int pricePink = int.Parse(price[2]);

		int countRed = 0;
		int countWhite = 0;
		int countPink = 0;

		for (int i = 0; i < 3; i++)
		{
			for (int j = 0; j < 5; j++)
			{
				switch (flowers[i, j])
				{
					case "к": countRed++; break;
					case "б": countWhite++; break;
					case "р": countPink++; break;
				}
			}
		}
		Console.WriteLine(countRed * 100 * priceRed + 
			countWhite * 100 * priceWhite + 
			countPink * 100 * pricePink);
	}
}
