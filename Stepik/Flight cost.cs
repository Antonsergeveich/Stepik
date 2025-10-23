using System;
public class Flight_cost
{
	public static void Flight()
	{
		int ticket_price = Convert.ToInt32(Console.ReadLine());
		int window_seat = Convert.ToInt32(Console.ReadLine());
		int board_food = Convert.ToInt32(Console.ReadLine());
		int weight = Convert.ToInt32(Console.ReadLine());
		int price_weight = weight <= 3 ? 0 : 200 * (weight - 3); 
		Console.WriteLine("Полёт обойдётся в " + (ticket_price + window_seat + board_food + price_weight) + " рублей");
	}
}
