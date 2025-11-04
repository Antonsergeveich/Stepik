using System;

public class ElectronicQueue
{
	public static void Elec()
	{
		int queue = 0;
		string status = "Ожидание";

		string cmd;
		while ((cmd = Console.ReadLine()) != "Конец рабочего дня")
		{
			if (cmd == "Новый клиент") queue++;
			else if (cmd == "Начало обслуживания")
			{
				if (status == "Обслуживание") Console.WriteLine("Обслуживание не начато, не завершено обслуживание предыдущего клиента");
				else if (queue == 0) Console.WriteLine("Обслуживание не начато, в очереди никого нет");
				else
				{
					queue--;
					status = "Обслуживание";
				}
			}
			else if (cmd == "Завершение обслуживания") status = "Ожидание";
			else if (cmd == "Длина очереди") Console.WriteLine($"Длина очереди: {queue}");
			else if (cmd == "Текущий статус") Console.WriteLine($"Текущий статус: {status}");
			else Console.WriteLine("Неизвестная команда");
		}
	}
}
