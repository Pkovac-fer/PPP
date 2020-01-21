using System;
using System.Collections.Generic;
using System.Threading;

internal class Program
{
	public Program()
	{
	}

	private static void Main()
	{
		double speed = 100;
		double acceleration = 0.5;
		int playfieldWidth = 5;
		int livesCount = 5;
		int num = 20;
		Console.WindowHeight = num;
		Console.BufferHeight = num;
		int num1 = 30;
		Console.WindowWidth = num1;
		Console.BufferWidth = num1;
		Object userCar = new Object()
		{
			x = 2,
			y = Console.WindowHeight - 1,
			c = '@',
			color = ConsoleColor.Yellow
		};
		Random randomGenerator = new Random();
		List<Object> objects = new List<Object>();
		while (true)
		{
			speed += acceleration;
			if (speed > 400)
			{
				speed = 400;
			}
			bool hitted = false;
			int chance = randomGenerator.Next(0, 100);
			if (chance < 10)
			{
				Object newObject = new Object()
				{
					color = ConsoleColor.Cyan,
					c = '-',
					x = randomGenerator.Next(0, playfieldWidth),
					y = 0
				};
				objects.Add(newObject);
			}
			else if (chance >= 20)
			{
				Object newCar = new Object()
				{
					color = ConsoleColor.Green,
					x = randomGenerator.Next(0, playfieldWidth),
					y = 0,
					c = '#'
				};
				objects.Add(newCar);
			}
			else
			{
				Object newObject = new Object()
				{
					color = ConsoleColor.Cyan,
					c = '*',
					x = randomGenerator.Next(0, playfieldWidth),
					y = 0
				};
				objects.Add(newObject);
			}
			while (Console.KeyAvailable)
			{
				ConsoleKeyInfo pressedKey = Console.ReadKey(true);
				if (pressedKey.Key == ConsoleKey.LeftArrow)
				{
					if (userCar.x - 1 >= 0)
					{
						userCar.x--;
					}
				}
				else if (pressedKey.Key == ConsoleKey.RightArrow)
				{
					if (userCar.x + 1 < playfieldWidth)
					{
						userCar.x++;
					}
				}
			}
			List<Object> newList = new List<Object>();
			for (int i = 0; i < objects.Count; i++)
			{
				Object oldCar = objects[i];
				Object newObject = new Object()
				{
					x = oldCar.x,
					y = oldCar.y + 1,
					c = oldCar.c,
					color = oldCar.color
				};
				if ((newObject.c != '*' || newObject.y != userCar.y ? false : newObject.x == userCar.x))
				{
					speed -= 20;
				}
				if ((newObject.c != '-' || newObject.y != userCar.y ? false : newObject.x == userCar.x))
				{
					livesCount++;
				}
				if ((newObject.c != '#' || newObject.y != userCar.y ? false : newObject.x == userCar.x))
				{
					livesCount--;
					hitted = true;
					speed += 50;
					if (speed > 400)
					{
						speed = 400;
					}
					if (livesCount <= 0)
					{
						Program.PrintStringOnPosition(8, 10, "GAME OVER!!!", ConsoleColor.Red);
						Program.PrintStringOnPosition(8, 12, "Press [enter] to exit", ConsoleColor.Red);
						Console.ReadLine();
						Environment.Exit(0);
					}
				}
				if (newObject.y < Console.WindowHeight)
				{
					newList.Add(newObject);
				}
			}
			objects = newList;
			Console.Clear();
			if (!hitted)
			{
				Program.PrintOnPosition(userCar.x, userCar.y, userCar.c, userCar.color);
			}
			else
			{
				objects.Clear();
				Program.PrintOnPosition(userCar.x, userCar.y, 'X', ConsoleColor.Red);
			}
			foreach (Object car in objects)
			{
				Program.PrintOnPosition(car.x, car.y, car.c, car.color);
			}
			Program.PrintStringOnPosition(8, 4, string.Concat("Lives: ", livesCount.ToString()), ConsoleColor.White);
			Program.PrintStringOnPosition(8, 5, string.Concat("Speed: ", speed.ToString()), ConsoleColor.White);
			Program.PrintStringOnPosition(8, 6, string.Concat("Acceleration: ", acceleration.ToString()), ConsoleColor.White);
			Thread.Sleep((int)(600 - speed));
		}
	}

	private static void PrintOnPosition(int x, int y, char c, ConsoleColor color = 7)
	{
		Console.SetCursorPosition(x, y);
		Console.ForegroundColor = color;
		Console.Write(c);
	}

	private static void PrintStringOnPosition(int x, int y, string str, ConsoleColor color = 7)
	{
		Console.SetCursorPosition(x, y);
		Console.ForegroundColor = color;
		Console.Write(str);
	}
}