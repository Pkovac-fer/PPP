// Decompiled with JetBrains decompiler
// Type:  
// Assembly: Snake, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 38C15F98-FF89-4351-86D4-377BA31BC5C9
// Assembly location: C:\Users\Petar\OneDrive\Desktop\C#PRIMJERI\CSharpConsoleGames\Snake.exe

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

internal sealed class \u0008\u2000
{
  private static void \u0002(string[] _param0)
  {
    if (!\u0003.\u0002())
      return;
    byte num1 = 0;
    byte num2 = 1;
    byte num3 = 2;
    byte num4 = 3;
    int num5 = 8000;
    int num6 = 0;
    \u0005\u2000[] objArray = new \u0005\u2000[4]
    {
      new \u0005\u2000(0, 1),
      new \u0005\u2000(0, -1),
      new \u0005\u2000(1, 0),
      new \u0005\u2000(-1, 0)
    };
    double num7 = 100.0;
    int index1 = (int) num1;
    Random random = new Random();
    Console.BufferHeight = Console.WindowHeight;
    int tickCount = Environment.TickCount;
    List<\u0005\u2000> objList = new List<\u0005\u2000>()
    {
      new \u0005\u2000(12, 12),
      new \u0005\u2000(14, 20),
      new \u0005\u2000(7, 7),
      new \u0005\u2000(19, 19),
      new \u0005\u2000(6, 9)
    };
    foreach (\u0005\u2000 obj in objList)
    {
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.SetCursorPosition(obj.\u0003, obj.\u0002);
      Console.Write(\u0006\u2000.\u0002(1257959107));
    }
    Queue<\u0005\u2000> source = new Queue<\u0005\u2000>();
    for (int index2 = 0; index2 <= 5; ++index2)
      source.Enqueue(new \u0005\u2000(0, index2));
    \u0005\u2000 obj1;
    do
    {
      obj1 = new \u0005\u2000(random.Next(0, Console.WindowHeight), random.Next(0, Console.WindowWidth));
    }
    while (source.Contains(obj1) || objList.Contains(obj1));
    Console.SetCursorPosition(obj1.\u0003, obj1.\u0002);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(\u0006\u2000.\u0002(1257959115));
    foreach (\u0005\u2000 obj2 in source)
    {
      Console.SetCursorPosition(obj2.\u0003, obj2.\u0002);
      Console.ForegroundColor = ConsoleColor.DarkGray;
      Console.Write(\u0006\u2000.\u0002(1257959123));
    }
    while (true)
    {
      ++num6;
      if (Console.KeyAvailable)
      {
        ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
        if (consoleKeyInfo.Key == ConsoleKey.LeftArrow && index1 != (int) num1)
          index1 = (int) num2;
        if (consoleKeyInfo.Key == ConsoleKey.RightArrow && index1 != (int) num2)
          index1 = (int) num1;
        if (consoleKeyInfo.Key == ConsoleKey.UpArrow && index1 != (int) num3)
          index1 = (int) num4;
        if (consoleKeyInfo.Key == ConsoleKey.DownArrow && index1 != (int) num4)
          index1 = (int) num3;
      }
      \u0005\u2000 obj2 = source.Last<\u0005\u2000>();
      \u0005\u2000 obj3 = objArray[index1];
      \u0005\u2000 obj4 = new \u0005\u2000(obj2.\u0002 + obj3.\u0002, obj2.\u0003 + obj3.\u0003);
      if (obj4.\u0003 < 0)
        obj4.\u0003 = Console.WindowWidth - 1;
      if (obj4.\u0002 < 0)
        obj4.\u0002 = Console.WindowHeight - 1;
      if (obj4.\u0002 >= Console.WindowHeight)
        obj4.\u0002 = 0;
      if (obj4.\u0003 >= Console.WindowWidth)
        obj4.\u0003 = 0;
      if (!source.Contains(obj4) && !objList.Contains(obj4))
      {
        Console.SetCursorPosition(obj2.\u0003, obj2.\u0002);
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write(\u0006\u2000.\u0002(1257959123));
        source.Enqueue(obj4);
        Console.SetCursorPosition(obj4.\u0003, obj4.\u0002);
        Console.ForegroundColor = ConsoleColor.Gray;
        if (index1 == (int) num1)
          Console.Write(\u0006\u2000.\u0002(1257959047));
        if (index1 == (int) num2)
          Console.Write(\u0006\u2000.\u0002(1257959055));
        if (index1 == (int) num4)
          Console.Write(\u0006\u2000.\u0002(1257959063));
        if (index1 == (int) num3)
          Console.Write(\u0006\u2000.\u0002(1257959071));
        if (obj4.\u0003 == obj1.\u0003 && obj4.\u0002 == obj1.\u0002)
        {
          do
          {
            obj1 = new \u0005\u2000(random.Next(0, Console.WindowHeight), random.Next(0, Console.WindowWidth));
          }
          while (source.Contains(obj1) || objList.Contains(obj1));
          tickCount = Environment.TickCount;
          Console.SetCursorPosition(obj1.\u0003, obj1.\u0002);
          Console.ForegroundColor = ConsoleColor.Yellow;
          Console.Write(\u0006\u2000.\u0002(1257959115));
          --num7;
          \u0005\u2000 obj5 = new \u0005\u2000();
          do
          {
            obj5 = new \u0005\u2000(random.Next(0, Console.WindowHeight), random.Next(0, Console.WindowWidth));
          }
          while (source.Contains(obj5) || objList.Contains(obj5) || obj1.\u0002 != obj5.\u0002 && obj1.\u0003 != obj5.\u0002);
          objList.Add(obj5);
          Console.SetCursorPosition(obj5.\u0003, obj5.\u0002);
          Console.ForegroundColor = ConsoleColor.Cyan;
          Console.Write(\u0006\u2000.\u0002(1257959107));
        }
        else
        {
          \u0005\u2000 obj5 = source.Dequeue();
          Console.SetCursorPosition(obj5.\u0003, obj5.\u0002);
          Console.Write(\u0006\u2000.\u0002(1257959079));
        }
        if (Environment.TickCount - tickCount >= num5)
        {
          num6 += 50;
          Console.SetCursorPosition(obj1.\u0003, obj1.\u0002);
          Console.Write(\u0006\u2000.\u0002(1257959079));
          do
          {
            obj1 = new \u0005\u2000(random.Next(0, Console.WindowHeight), random.Next(0, Console.WindowWidth));
          }
          while (source.Contains(obj1) || objList.Contains(obj1));
          tickCount = Environment.TickCount;
        }
        Console.SetCursorPosition(obj1.\u0003, obj1.\u0002);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(\u0006\u2000.\u0002(1257959115));
        num7 -= 0.01;
        Thread.Sleep((int) num7);
      }
      else
        break;
    }
    Console.SetCursorPosition(0, 0);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(\u0006\u2000.\u0002(1257959131));
    Console.WriteLine(\u0006\u2000.\u0002(1257959144), (object) Math.Max((source.Count - 6) * 100 - num6, 0));
  }
}
