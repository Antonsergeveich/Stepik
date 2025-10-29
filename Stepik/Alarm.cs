using System;

public class Alarm
{
	public static void DzinDzin()
	{
		string[] sleepTime = Console.ReadLine().Split(':');
		string[] alarmTime = Console.ReadLine().Split(':');

		int sleepHours = int.Parse(sleepTime[0]);
		int sleepMinutes = int.Parse(sleepTime[1]);
		int alarmHours = int.Parse(alarmTime[0]);
		int alarmMinutes = int.Parse(alarmTime[1]);

		int totalSleepMinutes = sleepHours * 60 + sleepMinutes;
		int totalAlarmMinutes = alarmHours * 60 + alarmMinutes;

		int totalMinutesDifference;

		if(totalAlarmMinutes >= totalSleepMinutes)
			totalMinutesDifference = totalAlarmMinutes - totalSleepMinutes;
		else totalMinutesDifference = (24 * 60 - totalSleepMinutes) + totalAlarmMinutes;

		int hours = totalMinutesDifference / 60;
		int minutes = totalMinutesDifference % 60;

		string result;
		if(minutes == 0)
		{
			result = $"Будильник зазвонит через {hours} час(часов).";
		}
		else if(hours == 0)
		{
			result = $"Будильник зазвонит через {minutes} минут.";
		}
		else
		{
			result = $"Будильник зазвонит через {hours} час(часов) и {minutes} минут.";
		}
		Console.WriteLine(result);
	}
}
