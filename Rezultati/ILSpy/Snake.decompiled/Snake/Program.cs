using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Snake
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			byte b = 0;
			byte b2 = 1;
			byte b3 = 2;
			byte b4 = 3;
			int num = 0;
			int num2 = 8000;
			int num3 = 0;
			Position[] array = new Position[4]
			{
				new Position(0, 1),
				new Position(0, -1),
				new Position(1, 0),
				new Position(-1, 0)
			};
			double num4 = 100.0;
			int num5 = b;
			Random random = new Random();
			Console.BufferHeight = Console.WindowHeight;
			num = Environment.TickCount;
			List<Position> list = new List<Position>
			{
				new Position(12, 12),
				new Position(14, 20),
				new Position(7, 7),
				new Position(19, 19),
				new Position(6, 9)
			};
			foreach (Position item3 in list)
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.SetCursorPosition(item3.col, item3.row);
				Console.Write("=");
			}
			Queue<Position> queue = new Queue<Position>();
			for (int i = 0; i <= 5; i++)
			{
				queue.Enqueue(new Position(0, i));
			}
			Position item;
			do
			{
				item = new Position(random.Next(0, Console.WindowHeight), random.Next(0, Console.WindowWidth));
			}
			while (queue.Contains(item) || list.Contains(item));
			Console.SetCursorPosition(item.col, item.row);
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write("@");
			foreach (Position item4 in queue)
			{
				Console.SetCursorPosition(item4.col, item4.row);
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("*");
			}
			while (true)
			{
				num3++;
				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
					if (consoleKeyInfo.Key == ConsoleKey.LeftArrow && num5 != b)
					{
						num5 = b2;
					}
					if (consoleKeyInfo.Key == ConsoleKey.RightArrow && num5 != b2)
					{
						num5 = b;
					}
					if (consoleKeyInfo.Key == ConsoleKey.UpArrow && num5 != b3)
					{
						num5 = b4;
					}
					if (consoleKeyInfo.Key == ConsoleKey.DownArrow && num5 != b4)
					{
						num5 = b3;
					}
				}
				Position position = queue.Last();
				Position position2 = array[num5];
				Position item2 = new Position(position.row + position2.row, position.col + position2.col);
				if (item2.col < 0)
				{
					item2.col = Console.WindowWidth - 1;
				}
				if (item2.row < 0)
				{
					item2.row = Console.WindowHeight - 1;
				}
				if (item2.row >= Console.WindowHeight)
				{
					item2.row = 0;
				}
				if (item2.col >= Console.WindowWidth)
				{
					item2.col = 0;
				}
				if (queue.Contains(item2) || list.Contains(item2))
				{
					break;
				}
				Console.SetCursorPosition(position.col, position.row);
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("*");
				queue.Enqueue(item2);
				Console.SetCursorPosition(item2.col, item2.row);
				Console.ForegroundColor = ConsoleColor.Gray;
				if (num5 == b)
				{
					Console.Write(">");
				}
				if (num5 == b2)
				{
					Console.Write("<");
				}
				if (num5 == b4)
				{
					Console.Write("^");
				}
				if (num5 == b3)
				{
					Console.Write("v");
				}
				if (item2.col == item.col && item2.row == item.row)
				{
					do
					{
						item = new Position(random.Next(0, Console.WindowHeight), random.Next(0, Console.WindowWidth));
					}
					while (queue.Contains(item) || list.Contains(item));
					num = Environment.TickCount;
					Console.SetCursorPosition(item.col, item.row);
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.Write("@");
					num4 -= 1.0;
					Position position3 = default(Position);
					do
					{
						position3 = new Position(random.Next(0, Console.WindowHeight), random.Next(0, Console.WindowWidth));
					}
					while (queue.Contains(position3) || list.Contains(position3) || (item.row != position3.row && item.col != position3.row));
					list.Add(position3);
					Console.SetCursorPosition(position3.col, position3.row);
					Console.ForegroundColor = ConsoleColor.Cyan;
					Console.Write("=");
				}
				else
				{
					Position position4 = queue.Dequeue();
					Console.SetCursorPosition(position4.col, position4.row);
					Console.Write(" ");
				}
				if (Environment.TickCount - num >= num2)
				{
					num3 += 50;
					Console.SetCursorPosition(item.col, item.row);
					Console.Write(" ");
					do
					{
						item = new Position(random.Next(0, Console.WindowHeight), random.Next(0, Console.WindowWidth));
					}
					while (queue.Contains(item) || list.Contains(item));
					num = Environment.TickCount;
				}
				Console.SetCursorPosition(item.col, item.row);
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.Write("@");
				num4 -= 0.01;
				Thread.Sleep((int)num4);
			}
			Console.SetCursorPosition(0, 0);
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Game over!");
			int val = (queue.Count - 6) * 100 - num3;
			val = Math.Max(val, 0);
			Console.WriteLine("Your points are: {0}", val);
		}
	}
}
