using System;

public class Which_symbol_occurs_earlier
{
	public static void Symbol()
	{
		string str = Console.ReadLine();
		for(int i = 0; i <= str.Length - 1; i++)
		{
			if (str[i] == 'x')
			{
				Console.WriteLine('x'); return;
			}
			else if (str[i] == 'w')
			{
				Console.WriteLine('w'); return;
			}
		}
		Console.WriteLine(-1);
	}
}
