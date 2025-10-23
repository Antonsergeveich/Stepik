using System;

public class YES_or_NO___that_is_the_question
{
	public static void Question()
	{
		int num = Convert.ToInt32(Console.ReadLine());

		if (num % 2 != 0) Console.WriteLine("YES");
		else if (num % 2 == 0 && num >= 2 && num <= 5) Console.WriteLine("NO");
		else if (num % 2 == 0 && num >= 6 && num <= 20) Console.WriteLine("YES");
		else if (num % 2 == 0 && num > 20) Console.WriteLine("NO");

	}
}
