using System;

namespace DailyTask_Enum_Flags
{
	class Program
	{
		static void Main(string[] args)
		{
			var day = (DAY.SATURDAY | DAY.FRIDAY);
			if(day.HasFlag(DAY.WEEKEND))
			{
				Console.WriteLine("enjoy your weekend!");
			}
			Console.ReadKey();
		}
	}

	[Flags]
	enum DAY
	{
		NONE		= 0b0000_0000,
		FRIDAY		= 0b0000_0001,
		SATURDAY	= 0b0000_0010,
		SUNDAY		= 0b0000_0100,
		MONDAY		= 0b0000_1000,
		TUESDAY		= 0b0001_0000,
		WEDENSDAY	= 0b0010_0000,
		THURSDAY	= 0b0100_0000,
		WEEKEND     = FRIDAY | SATURDAY,
		BUSSINESS	= SUNDAY | MONDAY | THURSDAY | WEDENSDAY | THURSDAY
	}
}
