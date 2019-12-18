using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Snake
{
	internal class Program
	{
		public Program()
		{
		}

		private static void Main(string[] args)
		{
			Position food;
			bool flag;
			bool flag1;
			bool flag2;
			bool flag3;
			byte right = 0;
			byte left = 1;
			byte down = 2;
			byte up = 3;
			int lastFoodTime = 0;
			int foodDissapearTime = 0x1f40;
			int negativePoints = 0;
			Position[] directions = new Position[] { new Position(0, 1), new Position(0, -1), new Position(1, 0), new Position(-1, 0) };
			double sleepTime = 100;
			int direction = right;
			Random randomNumbersGenerator = new Random();
			Console.BufferHeight = Console.WindowHeight;
			lastFoodTime = Environment.TickCount;
			List<Position> obstacles = new List<Position>()
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
			do
			{
				food = new Position(randomNumbersGenerator.Next(0, Console.WindowHeight), randomNumbersGenerator.Next(0, Console.WindowWidth));
				flag = (snakeElements.Contains(food) ? true : obstacles.Contains(food));
			}
			while (flag);
			Console.SetCursorPosition(food.col, food.row);
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write("@");
			foreach (Position position in snakeElements)
			{
				Console.SetCursorPosition(position.col, position.row);
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("*");
			}
			while (true)
			{
				negativePoints++;
				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo userInput = Console.ReadKey();
					if (userInput.Key == ConsoleKey.LeftArrow)
					{
						if (direction != right)
						{
							direction = left;
						}
					}
					if (userInput.Key == ConsoleKey.RightArrow)
					{
						if (direction != left)
						{
							direction = right;
						}
					}
					if (userInput.Key == ConsoleKey.UpArrow)
					{
						if (direction != down)
						{
							direction = up;
						}
					}
					if (userInput.Key == ConsoleKey.DownArrow)
					{
						if (direction != up)
						{
							direction = down;
						}
					}
				}
				Position snakeHead = snakeElements.Last<Position>();
				Position nextDirection = directions[direction];
				Position snakeNewHead = new Position(snakeHead.row + nextDirection.row, snakeHead.col + nextDirection.col);
				if (snakeNewHead.col < 0)
				{
					snakeNewHead.col = Console.WindowWidth - 1;
				}
				if (snakeNewHead.row < 0)
				{
					snakeNewHead.row = Console.WindowHeight - 1;
				}
				if (snakeNewHead.row >= Console.WindowHeight)
				{
					snakeNewHead.row = 0;
				}
				if (snakeNewHead.col >= Console.WindowWidth)
				{
					snakeNewHead.col = 0;
				}
				if ((snakeElements.Contains(snakeNewHead) ? true : obstacles.Contains(snakeNewHead)))
				{
					break;
				}
				Console.SetCursorPosition(snakeHead.col, snakeHead.row);
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("*");
				snakeElements.Enqueue(snakeNewHead);
				Console.SetCursorPosition(snakeNewHead.col, snakeNewHead.row);
				Console.ForegroundColor = ConsoleColor.Gray;
				if (direction == right)
				{
					Console.Write(">");
				}
				if (direction == left)
				{
					Console.Write("<");
				}
				if (direction == up)
				{
					Console.Write("^");
				}
				if (direction == down)
				{
					Console.Write("v");
				}
				if ((snakeNewHead.col != food.col ? true : snakeNewHead.row != food.row))
				{
					Position last = snakeElements.Dequeue();
					Console.SetCursorPosition(last.col, last.row);
					Console.Write(" ");
				}
				else
				{
					do
					{
						food = new Position(randomNumbersGenerator.Next(0, Console.WindowHeight), randomNumbersGenerator.Next(0, Console.WindowWidth));
						flag2 = (snakeElements.Contains(food) ? true : obstacles.Contains(food));
					}
					while (flag2);
					lastFoodTime = Environment.TickCount;
					Console.SetCursorPosition(food.col, food.row);
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.Write("@");
					sleepTime -= 1;
					Position obstacle = new Position();
					do
					{
						obstacle = new Position(randomNumbersGenerator.Next(0, Console.WindowHeight), randomNumbersGenerator.Next(0, Console.WindowWidth));
						if (snakeElements.Contains(obstacle) || obstacles.Contains(obstacle))
						{
							flag3 = true;
						}
						else
						{
							flag3 = (food.row == obstacle.row ? false : food.col != obstacle.row);
						}
					}
					while (flag3);
					obstacles.Add(obstacle);
					Console.SetCursorPosition(obstacle.col, obstacle.row);
					Console.ForegroundColor = ConsoleColor.Cyan;
					Console.Write("=");
				}
				if (Environment.TickCount - lastFoodTime >= foodDissapearTime)
				{
					negativePoints += 50;
					Console.SetCursorPosition(food.col, food.row);
					Console.Write(" ");
					do
					{
						food = new Position(randomNumbersGenerator.Next(0, Console.WindowHeight), randomNumbersGenerator.Next(0, Console.WindowWidth));
						flag1 = (snakeElements.Contains(food) ? true : obstacles.Contains(food));
					}
					while (flag1);
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
			Console.WriteLine("Your points are: {0}", Math.Max(userPoints, 0));
		}
	}
}