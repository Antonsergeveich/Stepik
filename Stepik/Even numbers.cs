using System;

public class Even_numbers
{
	public static void Even()
	{
		int i = Convert.ToInt32(Console.ReadLine());
		int n = Convert.ToInt32(Console.ReadLine());
		for(int j = i; j <= n; j++)
		{
			if(j % 2 == 0)Console.WriteLine(j);
		}
	}
}
