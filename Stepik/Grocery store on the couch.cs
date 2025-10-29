using System;

public class Grocery_store_on_the_couch
{
	public static void Grocery()
	{
		//Чтение количества заказов
		int orders = Convert.ToInt32(Console.ReadLine());

		//Создание массива для хранения заказов
		string[][] orderitems = new string[orders][];

		//Чтение и сохранение всех заказов
		for(int i = 0; i < orders; i++)
		{
			orderitems[i] = Console.ReadLine().Split(' ');
		}

		//Чтение начального количества продуктов на складе
		string[] productQuantity = Console.ReadLine().Split(' ');

		//Создание массива для остселживания остатков продуктов на складе
		int[] soldproducts = new int[5];

		//Заполнение массива начальными количествами продуктов на складе
		for(int i = 0; i < soldproducts.Length; i++)
		{
			soldproducts[i] = Convert.ToInt32(productQuantity[i]);
		}

		//Обработка каждого заказа и вычитание проданных товаров
		for(int i = 0; i < orderitems.Length; i++)
		{
			switch (orderitems[i][1])  //orderitems[i][1] - название продукта
			{
				case "Сметана":
					soldproducts[0] -= Convert.ToInt32(orderitems[i][0]);
					break;
				case "Хлеб":
					soldproducts[1] -= Convert.ToInt32(orderitems[i][0]);
					break;
				case "Макароны":
					soldproducts[2] -= Convert.ToInt32(orderitems[i][0]); 
					break;
				case "Сахар":
					soldproducts[3] -= Convert.ToInt32(orderitems[i][0]); 
					break;
				case "Сыр":
					soldproducts[4] -= Convert.ToInt32(orderitems[i][0]);
					break;
			}
		}

		Console.WriteLine($"На складе осталось {soldproducts[0]} банок сметаны, " +
			$"{soldproducts[1]} буханок хлеба, " +
			$"{soldproducts[2]} пачек макарон, " +
			$"{soldproducts[3]} пачек сахара, " +
			$"{soldproducts[4]} головок сыра");





		//int n = Convert.ToInt32(Console.ReadLine());

		//int sour = 0;
		//int bread = 0;
		//int pasta = 0;
		//int sugar = 0;
		//int cheese = 0;

		//for(int i = 0; i < n; i++)
		//{
		//	string[] order = Console.ReadLine().Split();
		//	int quantity = Convert.ToInt32(order[0]);
		//	string product = order[1];

		//	switch (product)
		//	{
		//		case "Сметана":
		//			sour += quantity;
		//			break;
		//		case "Хлеб": bread += quantity; 
		//			break;
		//		case "Макароны": pasta += quantity;
		//			break;
		//		case "Сахар": sugar += quantity;
		//			break;
		//		case "Сыр": cheese += quantity;
		//			break;
		//	}
		//}

		//string[] balances = Console.ReadLine().Split();
		//int sourBalance = Convert.ToInt32(balances[0]);
		//int breadBalance = Convert.ToInt32(balances[1]);
		//int pastaBalance = Convert.ToInt32(balances[2]);
		//int sugarBalance = Convert.ToInt32(balances[3]);
		//int cheeseBalance = Convert.ToInt32(balances[4]);

		//int sourRes = sourBalance - sour;
		//int breadRes = breadBalance - bread;
		//int pastaRes = pastaBalance - pasta;
		//int sugarRes = sugarBalance - sugar;
		//int cheeseRes = cheeseBalance - cheese;

		//Console.WriteLine($"На складе осталось {sourRes} банок сметаны, " +
		//	$"{breadRes} буханок хлеба," +
		//	$"{pastaRes} пачек макарон, " +
		//	$"{sugarRes} пачек сахара, " +
		//	$"{cheeseRes} головок сыра");


		//int n = Convert.ToInt32(Console.ReadLine());

		//string[] products = { "Сметана", "Хлеб", "Макароны", "Сахар", "Сыр" };
		//int[] ordered = new int[5];
		//int[] balances = new int[5];

		//for (int i = 0; i < n; i++)
		//{
		//	string[] order = Console.ReadLine().Split();
		//	int quantity = Convert.ToInt32(order[0]);
		//	string product = order[1];

		//	int index = Array.IndexOf(products, product);
		//	if (index >= 0) ordered[index] += quantity;
		//}

		//string[] balanceInput = Console.ReadLine().Split();
		//for (int i = 0; i < 5; i++)
		//	balances[i] = Convert.ToInt32(balanceInput[i]);

		//Console.WriteLine($"На складе осталось {balances[0] - ordered[0]} банок сметаны, " +
		//	$"{balances[1] - ordered[1]} буханок хлеба, " +
		//	$"{balances[2] - ordered[2]} пачек макарон, " +
		//	$"{balances[3] - ordered[3]} пачек сахара, " +
		//	$"{balances[4] - ordered[4]} головок сыра");
	}

}
