using System;

public class Happy_tickets
{
	public static void Happy()
	{
		int num1 = Convert.ToInt32(Console.ReadLine());
		int num2 = Convert.ToInt32(Console.ReadLine());
		int res = TicketHappy(num1, num2);
		Console.WriteLine(res);
	}
	static int TicketHappy(int n1, int n2)
	{
		int sum1First = 0, sum1Last = 0;
		int sum2First = 0, sum2Last = 0;
		for (int i = 0; i < 3; i++)
		{
			sum1First += n1 % 10;
			n1 /= 10;
		}
		for (int i = 0; i < 3; i++)
		{
			sum1Last += n1 % 10;
			n1 /= 10;
		}
		for (int i = 0; i < 3; i++)
		{
			sum2First += n2 % 10;
			n2 /= 10;
		}
		for (int i = 0; i < 3; i++)
		{
			sum2Last += n2 % 10;
			n2 /= 10;
		}
		return (sum1First == sum1Last && sum2First == sum2Last) ? 1 : -1;
	}


	//public class MainClass
	//{
	//	public static bool isLucky(string num)
	//	{
	//		return num[0] + num[1] + num[2] == num[3] + num[4] + num[5];
	//	}

	//	public static void Main()
	//	{
	//		int res = -1;
	//		if (isLucky(Console.ReadLine()) && isLucky(Console.ReadLine()))
	//		{
	//			res = 1;
	//		}

	//		Console.WriteLine(res);
	//	}
	//}
}
