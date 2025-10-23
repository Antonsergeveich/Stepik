using System;

public class We_play_football
{
	public static void Play()
	{
		int age = Convert.ToInt32(Console.ReadLine());
		string gender = Console.ReadLine();
		Console.WriteLine(age >= 12 && age <=18 && gender == "m" ? "YES" : "NO");
	}
}
