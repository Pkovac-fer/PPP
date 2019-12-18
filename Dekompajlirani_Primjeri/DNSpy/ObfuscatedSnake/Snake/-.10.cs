using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

// Token: 0x0200000E RID: 14
internal sealed class \u0008\u2000
{
	// Token: 0x06000027 RID: 39 RVA: 0x00003140 File Offset: 0x00001340
	private static void \u0002(string[] \u0002)
	{
		if (!\u0003.\u0002())
		{
			return;
		}
		byte b = 0;
		byte b2 = 1;
		byte b3 = 2;
		byte b4 = 3;
		int num = 0;
		int num2 = 8000;
		int num3 = 0;
		\u0005\u2000[] array = new \u0005\u2000[]
		{
			new \u0005\u2000(0, 1),
			new \u0005\u2000(0, -1),
			new \u0005\u2000(1, 0),
			new \u0005\u2000(-1, 0)
		};
		double num4 = 100.0;
		int num5 = (int)b;
		Random random = new Random();
		Console.BufferHeight = Console.WindowHeight;
		num = Environment.TickCount;
		List<\u0005\u2000> list = new List<\u0005\u2000>
		{
			new \u0005\u2000(12, 12),
			new \u0005\u2000(14, 20),
			new \u0005\u2000(7, 7),
			new \u0005\u2000(19, 19),
			new \u0005\u2000(6, 9)
		};
		foreach (\u0005\u2000 u0005_u in list)
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.SetCursorPosition(u0005_u.\u0003, u0005_u.\u0002);
			Console.Write(\u0006\u2000.\u0002(1257959107));
		}
		Queue<\u0005\u2000> queue = new Queue<\u0005\u2000>();
		for (int i = 0; i <= 5; i++)
		{
			queue.Enqueue(new \u0005\u2000(0, i));
		}
		\u0005\u2000 u0005_u2;
		do
		{
			u0005_u2 = new \u0005\u2000(random.Next(0, Console.WindowHeight), random.Next(0, Console.WindowWidth));
		}
		while (queue.Contains(u0005_u2) || list.Contains(u0005_u2));
		Console.SetCursorPosition(u0005_u2.\u0003, u0005_u2.\u0002);
		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.Write(\u0006\u2000.\u0002(1257959115));
		foreach (\u0005\u2000 u0005_u3 in queue)
		{
			Console.SetCursorPosition(u0005_u3.\u0003, u0005_u3.\u0002);
			Console.ForegroundColor = ConsoleColor.DarkGray;
			Console.Write(\u0006\u2000.\u0002(1257959123));
		}
		for (;;)
		{
			num3++;
			bool keyAvailable = Console.KeyAvailable;
			if (keyAvailable)
			{
				ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
				bool flag = consoleKeyInfo.Key == ConsoleKey.LeftArrow;
				if (flag)
				{
					bool flag2 = num5 != (int)b;
					if (flag2)
					{
						num5 = (int)b2;
					}
				}
				bool flag3 = consoleKeyInfo.Key == ConsoleKey.RightArrow;
				if (flag3)
				{
					bool flag4 = num5 != (int)b2;
					if (flag4)
					{
						num5 = (int)b;
					}
				}
				bool flag5 = consoleKeyInfo.Key == ConsoleKey.UpArrow;
				if (flag5)
				{
					bool flag6 = num5 != (int)b3;
					if (flag6)
					{
						num5 = (int)b4;
					}
				}
				bool flag7 = consoleKeyInfo.Key == ConsoleKey.DownArrow;
				if (flag7)
				{
					bool flag8 = num5 != (int)b4;
					if (flag8)
					{
						num5 = (int)b3;
					}
				}
			}
			\u0005\u2000 u0005_u4 = queue.Last<\u0005\u2000>();
			\u0005\u2000 u0005_u5 = array[num5];
			\u0005\u2000 u0005_u6 = new \u0005\u2000(u0005_u4.\u0002 + u0005_u5.\u0002, u0005_u4.\u0003 + u0005_u5.\u0003);
			bool flag9 = u0005_u6.\u0003 < 0;
			if (flag9)
			{
				u0005_u6.\u0003 = Console.WindowWidth - 1;
			}
			bool flag10 = u0005_u6.\u0002 < 0;
			if (flag10)
			{
				u0005_u6.\u0002 = Console.WindowHeight - 1;
			}
			bool flag11 = u0005_u6.\u0002 >= Console.WindowHeight;
			if (flag11)
			{
				u0005_u6.\u0002 = 0;
			}
			bool flag12 = u0005_u6.\u0003 >= Console.WindowWidth;
			if (flag12)
			{
				u0005_u6.\u0003 = 0;
			}
			bool flag13 = queue.Contains(u0005_u6) || list.Contains(u0005_u6);
			if (flag13)
			{
				break;
			}
			Console.SetCursorPosition(u0005_u4.\u0003, u0005_u4.\u0002);
			Console.ForegroundColor = ConsoleColor.DarkGray;
			Console.Write(\u0006\u2000.\u0002(1257959123));
			queue.Enqueue(u0005_u6);
			Console.SetCursorPosition(u0005_u6.\u0003, u0005_u6.\u0002);
			Console.ForegroundColor = ConsoleColor.Gray;
			bool flag14 = num5 == (int)b;
			if (flag14)
			{
				Console.Write(\u0006\u2000.\u0002(1257959047));
			}
			bool flag15 = num5 == (int)b2;
			if (flag15)
			{
				Console.Write(\u0006\u2000.\u0002(1257959055));
			}
			bool flag16 = num5 == (int)b4;
			if (flag16)
			{
				Console.Write(\u0006\u2000.\u0002(1257959063));
			}
			bool flag17 = num5 == (int)b3;
			if (flag17)
			{
				Console.Write(\u0006\u2000.\u0002(1257959071));
			}
			bool flag18 = u0005_u6.\u0003 == u0005_u2.\u0003 && u0005_u6.\u0002 == u0005_u2.\u0002;
			if (flag18)
			{
				do
				{
					u0005_u2 = new \u0005\u2000(random.Next(0, Console.WindowHeight), random.Next(0, Console.WindowWidth));
				}
				while (queue.Contains(u0005_u2) || list.Contains(u0005_u2));
				num = Environment.TickCount;
				Console.SetCursorPosition(u0005_u2.\u0003, u0005_u2.\u0002);
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.Write(\u0006\u2000.\u0002(1257959115));
				num4 -= 1.0;
				\u0005\u2000 u0005_u7 = default(\u0005\u2000);
				do
				{
					u0005_u7 = new \u0005\u2000(random.Next(0, Console.WindowHeight), random.Next(0, Console.WindowWidth));
				}
				while (queue.Contains(u0005_u7) || list.Contains(u0005_u7) || (u0005_u2.\u0002 != u0005_u7.\u0002 && u0005_u2.\u0003 != u0005_u7.\u0002));
				list.Add(u0005_u7);
				Console.SetCursorPosition(u0005_u7.\u0003, u0005_u7.\u0002);
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.Write(\u0006\u2000.\u0002(1257959107));
			}
			else
			{
				\u0005\u2000 u0005_u8 = queue.Dequeue();
				Console.SetCursorPosition(u0005_u8.\u0003, u0005_u8.\u0002);
				Console.Write(\u0006\u2000.\u0002(1257959079));
			}
			bool flag19 = Environment.TickCount - num >= num2;
			if (flag19)
			{
				num3 += 50;
				Console.SetCursorPosition(u0005_u2.\u0003, u0005_u2.\u0002);
				Console.Write(\u0006\u2000.\u0002(1257959079));
				do
				{
					u0005_u2 = new \u0005\u2000(random.Next(0, Console.WindowHeight), random.Next(0, Console.WindowWidth));
				}
				while (queue.Contains(u0005_u2) || list.Contains(u0005_u2));
				num = Environment.TickCount;
			}
			Console.SetCursorPosition(u0005_u2.\u0003, u0005_u2.\u0002);
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write(\u0006\u2000.\u0002(1257959115));
			num4 -= 0.01;
			Thread.Sleep((int)num4);
		}
		Console.SetCursorPosition(0, 0);
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine(\u0006\u2000.\u0002(1257959131));
		int num6 = (queue.Count - 6) * 100 - num3;
		num6 = Math.Max(num6, 0);
		Console.WriteLine(\u0006\u2000.\u0002(1257959144), num6);
	}
}
