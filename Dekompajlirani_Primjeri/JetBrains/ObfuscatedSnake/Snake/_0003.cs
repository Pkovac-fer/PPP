// Decompiled with JetBrains decompiler
// Type: 
// Assembly: Snake, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 38C15F98-FF89-4351-86D4-377BA31BC5C9
// Assembly location: C:\Users\Petar\OneDrive\Desktop\C#PRIMJERI\CSharpConsoleGames\Snake.exe

using System;
using System.Globalization;

internal static class \u0003
{
  private static bool \u0002(bool _param0)
  {
    DateTime dateTime = DateTime.Parse(\u0006\u2000.\u0002(1257959213), (IFormatProvider) CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);
    DateTime utcNow = DateTime.UtcNow;
    if (utcNow > dateTime || utcNow < dateTime.AddDays(-21.0))
    {
      string message = string.Format(\u0006\u2000.\u0002(1257959376), new object[1]
      {
        (object) \u0006\u2000.\u0002(1257959352)
      });
      if (_param0)
        throw new Exception(message);
      Console.WriteLine(message);
      return false;
    }
    if (!\u0002.\u0005())
    {
      try
      {
        Console.WriteLine(\u0006\u2000.\u0002(1257958984));
      }
      catch
      {
      }
    }
    return true;
  }

  public static bool \u0002()
  {
    return \u0003.\u0002(true);
  }

  public static void \u0002()
  {
    \u0003.\u0002(true);
  }
}
