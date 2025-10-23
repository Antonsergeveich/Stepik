public class Weighing_ceremony
{
	public static void ProcessWeight()
	{
		int weight = Convert.ToInt32(Console.ReadLine());

		if (weight < 60)
		{
			Console.WriteLine("Легкий вес");
		}
		else
		{
			if (weight >= 60 && weight < 64)
			{
				Console.WriteLine("Первый полусредний вес");
			}
			else if (weight >= 64 && weight < 69)
			{
				Console.WriteLine("Полусредний вес");
			}
		}
	}
}
