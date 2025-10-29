using System;

public class The_intruder
{
	public static void Intruder()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		int ip = Convert.ToInt32(Console.ReadLine());

		string[][] str = new string[n][];
		bool res = false;
		for(int i = 0; i < n; i++)
		{
			str[i] = Console.ReadLine().Split();
			int num = Convert.ToInt32(str[i][1].Split('.')[0]);
			if(num != ip)
			{
				res = true;
				Console.WriteLine($"{str[i][0]} нарушитель, писал(а) тест с телефона.");
			}
		}
		if (!res) Console.WriteLine("Никто не нарушил, все молодцы");

	}
}
