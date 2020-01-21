using System;
using System.Collections.Generic;
using System.Threading;

internal class Program
{
	private static void PrintOnPosition(int x, int y, char c, ConsoleColor color = ConsoleColor.Gray)
	{
		Console.SetCursorPosition(x, y);
		Console.ForegroundColor = color;
		Console.Write(c);
	}

	private static void PrintStringOnPosition(int x, int y, string str, ConsoleColor color = ConsoleColor.Gray)
	{
		Console.SetCursorPosition(x, y);
		Console.ForegroundColor = color;
		Console.Write(str);
	}

	private static void Main()
	{
		double num = 100.0;
		double num2 = 0.5;
		int num3 = 5;
		int num4 = 5;
		Console.BufferHeight = (Console.WindowHeight = 20);
		Console.BufferWidth = (Console.WindowWidth = 30);
		Object @object = default(Object);
		@object.x = 2;
		@object.y = Console.WindowHeight - 1;
		@object.c = '@';
		@object.color = ConsoleColor.Yellow;
		Random random = new Random();
		List<Object> list = new List<Object>();
		while (true)
		{
			num += num2;
			if (num > 400.0)
			{
				num = 400.0;
			}
			bool flag = false;
			int num7 = random.Next(0, 100);
			if (num7 < 10)
			{
				Object item = default(Object);
				item.color = ConsoleColor.Cyan;
				item.c = '-';
				item.x = random.Next(0, num3);
				item.y = 0;
				list.Add(item);
			}
			else if (num7 < 20)
			{
				Object item2 = default(Object);
				item2.color = ConsoleColor.Cyan;
				item2.c = '*';
				item2.x = random.Next(0, num3);
				item2.y = 0;
				list.Add(item2);
			}
			else
			{
				Object item3 = default(Object);
				item3.color = ConsoleColor.Green;
				item3.x = random.Next(0, num3);
				item3.y = 0;
				item3.c = '#';
				list.Add(item3);
			}
			while (Console.KeyAvailable)
			{
				ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(intercept: true);
				if (consoleKeyInfo.Key == ConsoleKey.LeftArrow)
				{
					if (@object.x - 1 >= 0)
					{
						@object.x--;
					}
				}
				else if (consoleKeyInfo.Key == ConsoleKey.RightArrow && @object.x + 1 < num3)
				{
					@object.x++;
				}
			}
			List<Object> list2 = new List<Object>();
			for (int i = 0; i < list.Count; i++)
			{
				Object object2 = list[i];
				Object item4 = default(Object);
				item4.x = object2.x;
				item4.y = object2.y + 1;
				item4.c = object2.c;
				item4.color = object2.color;
				if (item4.c == '*' && item4.y == @object.y && item4.x == @object.x)
				{
					num -= 20.0;
				}
				if (item4.c == '-' && item4.y == @object.y && item4.x == @object.x)
				{
					num4++;
				}
				if (item4.c == '#' && item4.y == @object.y && item4.x == @object.x)
				{
					num4--;
					flag = true;
					num += 50.0;
					if (num > 400.0)
					{
						num = 400.0;
					}
					if (num4 <= 0)
					{
						PrintStringOnPosition(8, 10, "GAME OVER!!!", ConsoleColor.Red);
						PrintStringOnPosition(8, 12, "Press [enter] to exit", ConsoleColor.Red);
						Console.ReadLine();
						Environment.Exit(0);
					}
				}
				if (item4.y < Console.WindowHeight)
				{
					list2.Add(item4);
				}
			}
			list = list2;
			Console.Clear();
			if (flag)
			{
				list.Clear();
				PrintOnPosition(@object.x, @object.y, 'X', ConsoleColor.Red);
			}
			else
			{
				PrintOnPosition(@object.x, @object.y, @object.c, @object.color);
			}
			foreach (Object item5 in list)
			{
				PrintOnPosition(item5.x, item5.y, item5.c, item5.color);
			}
			PrintStringOnPosition(8, 4, "Lives: " + num4.ToString(), ConsoleColor.White);
			PrintStringOnPosition(8, 5, "Speed: " + num.ToString(), ConsoleColor.White);
			PrintStringOnPosition(8, 6, "Acceleration: " + num2.ToString(), ConsoleColor.White);
			Thread.Sleep((int)(600.0 - num));
		}
	}
}
