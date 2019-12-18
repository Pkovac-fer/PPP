// Decompiled with JetBrains decompiler
// Type: Snake.Program
// Assembly: Snake, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 672004E1-962C-4821-9362-3DF8F05EFDA6
// Assembly location: C:\Users\Petar\OneDrive\Desktop\C# PRIMJERI\CSharp Console Games\Snake\bin\Debug\Snake.exe

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
      byte num1 = 0;
      byte num2 = 1;
      byte num3 = 2;
      byte num4 = 3;
      int num5 = 8000;
      int num6 = 0;
      Position[] positionArray = new Position[4]
      {
        new Position(0, 1),
        new Position(0, -1),
        new Position(1, 0),
        new Position(-1, 0)
      };
      double num7 = 100.0;
      int index = (int) num1;
      Random random = new Random();
      Console.BufferHeight = Console.WindowHeight;
      int tickCount = Environment.TickCount;
      List<Position> positionList = new List<Position>()
      {
        new Position(12, 12),
        new Position(14, 20),
        new Position(7, 7),
        new Position(19, 19),
        new Position(6, 9)
      };
      foreach (Position position in positionList)
      {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.SetCursorPosition(position.col, position.row);
        Console.Write("=");
      }
      Queue<Position> source = new Queue<Position>();
      for (int col = 0; col <= 5; ++col)
        source.Enqueue(new Position(0, col));
      Position position1;
      do
      {
        position1 = new Position(random.Next(0, Console.WindowHeight), random.Next(0, Console.WindowWidth));
      }
      while (source.Contains(position1) || positionList.Contains(position1));
      Console.SetCursorPosition(position1.col, position1.row);
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.Write("@");
      foreach (Position position2 in source)
      {
        Console.SetCursorPosition(position2.col, position2.row);
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("*");
      }
      while (true)
      {
        ++num6;
        if (Console.KeyAvailable)
        {
          ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
          if (consoleKeyInfo.Key == ConsoleKey.LeftArrow && index != (int) num1)
            index = (int) num2;
          if (consoleKeyInfo.Key == ConsoleKey.RightArrow && index != (int) num2)
            index = (int) num1;
          if (consoleKeyInfo.Key == ConsoleKey.UpArrow && index != (int) num3)
            index = (int) num4;
          if (consoleKeyInfo.Key == ConsoleKey.DownArrow && index != (int) num4)
            index = (int) num3;
        }
        Position position2 = source.Last<Position>();
        Position position3 = positionArray[index];
        Position position4 = new Position(position2.row + position3.row, position2.col + position3.col);
        if (position4.col < 0)
          position4.col = Console.WindowWidth - 1;
        if (position4.row < 0)
          position4.row = Console.WindowHeight - 1;
        if (position4.row >= Console.WindowHeight)
          position4.row = 0;
        if (position4.col >= Console.WindowWidth)
          position4.col = 0;
        if (!source.Contains(position4) && !positionList.Contains(position4))
        {
          Console.SetCursorPosition(position2.col, position2.row);
          Console.ForegroundColor = ConsoleColor.DarkGray;
          Console.Write("*");
          source.Enqueue(position4);
          Console.SetCursorPosition(position4.col, position4.row);
          Console.ForegroundColor = ConsoleColor.Gray;
          if (index == (int) num1)
            Console.Write(">");
          if (index == (int) num2)
            Console.Write("<");
          if (index == (int) num4)
            Console.Write("^");
          if (index == (int) num3)
            Console.Write("v");
          if (position4.col == position1.col && position4.row == position1.row)
          {
            do
            {
              position1 = new Position(random.Next(0, Console.WindowHeight), random.Next(0, Console.WindowWidth));
            }
            while (source.Contains(position1) || positionList.Contains(position1));
            tickCount = Environment.TickCount;
            Console.SetCursorPosition(position1.col, position1.row);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("@");
            --num7;
            Position position5 = new Position();
            do
            {
              position5 = new Position(random.Next(0, Console.WindowHeight), random.Next(0, Console.WindowWidth));
            }
            while (source.Contains(position5) || positionList.Contains(position5) || position1.row != position5.row && position1.col != position5.row);
            positionList.Add(position5);
            Console.SetCursorPosition(position5.col, position5.row);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("=");
          }
          else
          {
            Position position5 = source.Dequeue();
            Console.SetCursorPosition(position5.col, position5.row);
            Console.Write(" ");
          }
          if (Environment.TickCount - tickCount >= num5)
          {
            num6 += 50;
            Console.SetCursorPosition(position1.col, position1.row);
            Console.Write(" ");
            do
            {
              position1 = new Position(random.Next(0, Console.WindowHeight), random.Next(0, Console.WindowWidth));
            }
            while (source.Contains(position1) || positionList.Contains(position1));
            tickCount = Environment.TickCount;
          }
          Console.SetCursorPosition(position1.col, position1.row);
          Console.ForegroundColor = ConsoleColor.Yellow;
          Console.Write("@");
          num7 -= 0.01;
          Thread.Sleep((int) num7);
        }
        else
          break;
      }
      Console.SetCursorPosition(0, 0);
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Game over!");
      Console.WriteLine("Your points are: {0}", (object) Math.Max((source.Count - 6) * 100 - num6, 0));
    }
  }
}
