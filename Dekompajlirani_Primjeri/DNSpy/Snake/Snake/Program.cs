using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Snake
{
	// Token: 0x02000003 RID: 3
	internal class Program
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002064 File Offset: 0x00000264
		private static void Main(string[] args)
		{
			byte right = 0;
			byte left = 1;
			byte down = 2;
			byte up = 3;
			int lastFoodTime = 0;
			int foodDissapearTime = 8000;
			int negativePoints = 0;
			Position[] directions = new Position[]
			{
				new Position(0, 1),
				new Position(0, -1),
				new Position(1, 0),
				new Position(-1, 0)
			};
			double sleepTime = 100.0;
			int direction = (int)right;
			Random randomNumbersGenerator = new Random();
			Console.BufferHeight = Console.WindowHeight;
			lastFoodTime = Environment.TickCount;
			List<Position> obstacles = new List<Position>
			{
				new Position(12, 12),
				new Position(14, 20),
				new Position(7, 7),
				new Position(19, 19),
				new Position(6, 9)
			};
			foreach (Position obstacle in obstacles)
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.SetCursorPosition(obstacle.col, obstacle.row);
				Console.Write("=");
			}
			Queue<Position> snakeElements = new Queue<Position>();
			for (int i = 0; i <= 5; i++)
			{
				snakeElements.Enqueue(new Position(0, i));
			}
			Position food;
			do
			{
				food = new Position(randomNumbersGenerator.Next(0, Console.WindowHeight), randomNumbersGenerator.Next(0, Console.WindowWidth));
			}
			while (snakeElements.Contains(food) || obstacles.Contains(food));
			Console.SetCursorPosition(food.col, food.row);
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write("@");
			foreach (Position position in snakeElements)
			{
				Console.SetCursorPosition(position.col, position.row);
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("*");
			}
			for (;;)
			{
				negativePoints++;
				bool keyAvailable = Console.KeyAvailable;
				if (keyAvailable)
				{
					ConsoleKeyInfo userInput = Console.ReadKey();
					bool flag = userInput.Key == ConsoleKey.LeftArrow;
					if (flag)
					{
						bool flag2 = direction != (int)right;
						if (flag2)
						{
							direction = (int)left;
						}
					}
					bool flag3 = userInput.Key == ConsoleKey.RightArrow;
					if (flag3)
					{
						bool flag4 = direction != (int)left;
						if (flag4)
						{
							direction = (int)right;
						}
					}
					bool flag5 = userInput.Key == ConsoleKey.UpArrow;
					if (flag5)
					{
						bool flag6 = direction != (int)down;
						if (flag6)
						{
							direction = (int)up;
						}
					}
					bool flag7 = userInput.Key == ConsoleKey.DownArrow;
					if (flag7)
					{
						bool flag8 = direction != (int)up;
						if (flag8)
						{
							direction = (int)down;
						}
					}
				}
				Position snakeHead = snakeElements.Last<Position>();
				Position nextDirection = directions[direction];
				Position snakeNewHead = new Position(snakeHead.row + nextDirection.row, snakeHead.col + nextDirection.col);
				bool flag9 = snakeNewHead.col < 0;
				if (flag9)
				{
					snakeNewHead.col = Console.WindowWidth - 1;
				}
				bool flag10 = snakeNewHead.row < 0;
				if (flag10)
				{
					snakeNewHead.row = Console.WindowHeight - 1;
				}
				bool flag11 = snakeNewHead.row >= Console.WindowHeight;
				if (flag11)
				{
					snakeNewHead.row = 0;
				}
				bool flag12 = snakeNewHead.col >= Console.WindowWidth;
				if (flag12)
				{
					snakeNewHead.col = 0;
				}
				bool flag13 = snakeElements.Contains(snakeNewHead) || obstacles.Contains(snakeNewHead);
				if (flag13)
				{
					break;
				}
				Console.SetCursorPosition(snakeHead.col, snakeHead.row);
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("*");
				snakeElements.Enqueue(snakeNewHead);
				Console.SetCursorPosition(snakeNewHead.col, snakeNewHead.row);
				Console.ForegroundColor = ConsoleColor.Gray;
				bool flag14 = direction == (int)right;
				if (flag14)
				{
					Console.Write(">");
				}
				bool flag15 = direction == (int)left;
				if (flag15)
				{
					Console.Write("<");
				}
				bool flag16 = direction == (int)up;
				if (flag16)
				{
					Console.Write("^");
				}
				bool flag17 = direction == (int)down;
				if (flag17)
				{
					Console.Write("v");
				}
				bool flag18 = snakeNewHead.col == food.col && snakeNewHead.row == food.row;
				if (flag18)
				{
					do
					{
						food = new Position(randomNumbersGenerator.Next(0, Console.WindowHeight), randomNumbersGenerator.Next(0, Console.WindowWidth));
					}
					while (snakeElements.Contains(food) || obstacles.Contains(food));
					lastFoodTime = Environment.TickCount;
					Console.SetCursorPosition(food.col, food.row);
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.Write("@");
					sleepTime -= 1.0;
					Position obstacle2 = default(Position);
					do
					{
						obstacle2 = new Position(randomNumbersGenerator.Next(0, Console.WindowHeight), randomNumbersGenerator.Next(0, Console.WindowWidth));
					}
					while (snakeElements.Contains(obstacle2) || obstacles.Contains(obstacle2) || (food.row != obstacle2.row && food.col != obstacle2.row));
					obstacles.Add(obstacle2);
					Console.SetCursorPosition(obstacle2.col, obstacle2.row);
					Console.ForegroundColor = ConsoleColor.Cyan;
					Console.Write("=");
				}
				else
				{
					Position last = snakeElements.Dequeue();
					Console.SetCursorPosition(last.col, last.row);
					Console.Write(" ");
				}
				bool flag19 = Environment.TickCount - lastFoodTime >= foodDissapearTime;
				if (flag19)
				{
					negativePoints += 50;
					Console.SetCursorPosition(food.col, food.row);
					Console.Write(" ");
					do
					{
						food = new Position(randomNumbersGenerator.Next(0, Console.WindowHeight), randomNumbersGenerator.Next(0, Console.WindowWidth));
					}
					while (snakeElements.Contains(food) || obstacles.Contains(food));
					lastFoodTime = Environment.TickCount;
				}
				Console.SetCursorPosition(food.col, food.row);
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.Write("@");
				sleepTime -= 0.01;
				Thread.Sleep((int)sleepTime);
			}
			Console.SetCursorPosition(0, 0);
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Game over!");
			int userPoints = (snakeElements.Count - 6) * 100 - negativePoints;
			userPoints = Math.Max(userPoints, 0);
			Console.WriteLine("Your points are: {0}", userPoints);
		}
	}
}
