using System;

public class Numbers_from_10_to_100
{

	public static void Numbers()
	{
		while (true)
		{
			int n = Convert.ToInt32(Console.ReadLine());

			if (n < 10)
			{
				continue;
			}

			if (n > 100)
			{
				break;
			}

			Console.WriteLine(n);
		}

		//int x = Convert.ToInt32(Console.ReadLine());
		//while (x <= 100)
		//{
		//	if (x >= 10 && x <= 100) Console.WriteLine(x);
		//	x = Convert.ToInt32(Console.ReadLine());
		//}
	}
}
