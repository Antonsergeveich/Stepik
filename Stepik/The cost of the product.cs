using System;

public class The_cost_of_the_product
{
	public static void Product()
	{
		string product = Console.ReadLine();
		double price = Convert.ToDouble(Console.ReadLine());
		int count = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine($"Стоимость {product}: {price} * {count} = {price*count} руб.");
	}
}
