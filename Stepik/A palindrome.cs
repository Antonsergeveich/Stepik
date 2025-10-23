using System;

public class A_palindrome
{
	public static void Palindrom()
	{
		string s = Console.ReadLine();
		bool palindrome = true;
		
		for(int i = 0; i < s.Length / 2; i++)
		{
			if (s[i] != s[s.Length - 1 - i])
			{
				palindrome = false;
				break;
			}
		}
		Console.WriteLine(palindrome ? "YES" : "NO");
	}
}
