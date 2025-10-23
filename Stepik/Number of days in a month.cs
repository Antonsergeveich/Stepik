using System;

public class Number_of_days_in_a_month
{
	public static void Days()
	{
		int num = Convert.ToInt32(Console.ReadLine());

		switch(num)
		{
			case 1: Console.WriteLine(31);break;
			case 2: Console.WriteLine(29);break;
			case 3: Console.WriteLine(31);break;
			case 4: Console.WriteLine(30);break;
			case 5: Console.WriteLine(31);break;
			case 6: Console.WriteLine(30);break;
			case 7: Console.WriteLine(31);break;
			case 8: Console.WriteLine(31);break;
			case 9: Console.WriteLine(30);break;
			case 10: Console.WriteLine(31);break;
			case 11: Console.WriteLine(30);break;
			case 12: Console.WriteLine(31);break;
		}
	}
}
