using System;

public class Doctor_is_waiting_list
{
	public static void Doctor()
	{
		string surname = Console.ReadLine();
		string names = Console.ReadLine();
		string patronymic = Console.ReadLine();
		string name = ChangeName(surname,names,patronymic);
		Console.WriteLine(name);
	}
	static string ChangeName(string surname, string name, string patronymic) 
	{
		return $"{surname} {name[0]}. {patronymic[0]}.";
	}
}
