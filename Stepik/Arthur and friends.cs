using System;

public class Arthur_and_friends
{
	public static void Friends()
	{
		int number = Convert.ToInt32(Console.ReadLine()); 
		bool seven = false;
		bool zero = false;
		while (number != 0)
		{
			if(number % 10 == 7)  
			{
				seven = true; 
			}
			else if (number % 10 == 0)
		    {
				zero = true;
			}
			number /= 10;
		}
		Console.WriteLine(seven == true && zero == false ? "YES" : "NO");
	}
}
