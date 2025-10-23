using System;
using static System.Console;

public class Desks
{
	public static void Min_desks()
	{
		int students1 = Convert.ToInt32(Console.ReadLine());
		int students2 = Convert.ToInt32(Console.ReadLine());
		int students3 = Convert.ToInt32(Console.ReadLine());

		int desks1 = (int)Math.Ceiling((double)students1 / 2);
		int desks2 = (int)Math.Ceiling((double)students2 / 2);
		int desks3 = (int)Math.Ceiling((double)students3 / 2);

		WriteLine(desks1 + desks2 + desks3);
	}
}
	