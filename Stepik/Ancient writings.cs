using System;

public class Ancient_writings
{
	public static void Ancient()
	{
		int num = Convert.ToInt32(Console.ReadLine());
		for (int i = 0; i < num; i++)
		{
			string str = Console.ReadLine();
			int res = 0;
			for (int j = 0; j < str.Length; j++)
			{
				char symbol = str[j];

				switch (symbol)
				{
					case '/': res += 10000; break;
					case '$': res += 1000; break;
					case '?': res += 100; break;
					case 'л': res += 10; break;
					case '|': res += 1; break;
				}
			}
			Console.WriteLine(res);
		}
	}
}
