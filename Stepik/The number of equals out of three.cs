public class The_number_of_equals_out_of_three
{
	public static void How_many_numbers_match()
	{
		int num1 = Convert.ToInt32(Console.ReadLine());
		int num2 = Convert.ToInt32(Console.ReadLine());
		int num3 = Convert.ToInt32(Console.ReadLine());

		if (num1 == num2 && num2 == num3)
		{
			Console.WriteLine("3");
		}
		else if (num1 == num2 || num1 == num3 || num2 == num3)
		{
			Console.WriteLine("2");
		}
		else
		{
			Console.WriteLine("0");
		}
	}
}
