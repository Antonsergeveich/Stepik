using System;

public class A_unique_symbol
{
	public static void Symbol()
	{
		string input = Console.ReadLine();
		char symbol = Console.ReadLine()[0];
		bool result = IsCharacterUnique(input, symbol);
		Console.WriteLine(result);
	}
	static bool IsCharacterUnique(string input, char symbol)
	{
		bool result;
		int count = 0;
		for(int i = 0; i <= input.Length - 1; i++)
		{
			if (input[i] == symbol)count++;
		}
		result = count != 1 ? false : true;
		return result;
	}
}
