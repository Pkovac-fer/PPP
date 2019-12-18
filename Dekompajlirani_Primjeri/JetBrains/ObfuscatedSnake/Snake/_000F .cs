// Decompiled with JetBrains decompiler
// Type:  
// Assembly: Snake, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 38C15F98-FF89-4351-86D4-377BA31BC5C9
// Assembly location: C:\Users\Petar\OneDrive\Desktop\C#PRIMJERI\CSharpConsoleGames\Snake.exe

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

internal static class \u000F\u2000
{
  private static \u000F\u2000.\u0002 \u0002 = new \u000F\u2000.\u0002();

  [MethodImpl(MethodImplOptions.NoInlining)]
  internal static long \u0002()
  {
    if ((object) Assembly.GetCallingAssembly() != (object) typeof (\u000F\u2000).Assembly || !\u000F\u2000.\u0002())
      return 0;
    lock (\u000F\u2000.\u0002)
    {
      long num1 = \u000F\u2000.\u0002.\u0002();
      if (num1 == 0L)
      {
        Assembly executingAssembly = Assembly.GetExecutingAssembly();
        List<byte> byteList = new List<byte>();
        AssemblyName assemblyName;
        try
        {
          assemblyName = executingAssembly.GetName();
        }
        catch
        {
          assemblyName = new AssemblyName(executingAssembly.FullName);
        }
        byte[] numArray = assemblyName.GetPublicKeyToken();
        if (numArray != null && numArray.Length == 0)
          numArray = (byte[]) null;
        if (numArray != null)
          byteList.AddRange((IEnumerable<byte>) numArray);
        byteList.AddRange((IEnumerable<byte>) Encoding.Unicode.GetBytes(assemblyName.Name));
        int num2 = \u000F\u2000.\u0002(typeof (\u000F\u2000));
        int num3 = \u000F\u2000.\u0005.\u0002();
        byteList.Add((byte) (num2 >> 24));
        byteList.Add((byte) (num3 >> 16));
        byteList.Add((byte) (num2 >> 8));
        byteList.Add((byte) num3);
        byteList.Add((byte) (num2 >> 16));
        byteList.Add((byte) (num3 >> 8));
        byteList.Add((byte) num2);
        byteList.Add((byte) (num3 >> 24));
        int count = byteList.Count;
        ulong num4 = 0;
        for (int index = 0; index != count; ++index)
        {
          ulong num5 = num4 + (ulong) byteList[index];
          ulong num6 = num5 + (num5 << 20);
          num4 = num6 ^ num6 >> 12;
          byteList[index] = (byte) 0;
        }
        ulong num7 = num4 + (num4 << 6);
        ulong num8 = num7 ^ num7 >> 22;
        num1 = (long) (num8 + (num8 << 30)) ^ -2321961055637633712L;
        \u000F\u2000.\u0002.\u0002(num1);
      }
      return num1;
    }
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static bool \u0002()
  {
    return \u000F\u2000.\u0003();
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static bool \u0003()
  {
    StackFrame frame = new StackTrace().GetFrame(3);
    MethodBase methodBase = frame == null ? (MethodBase) null : frame.GetMethod();
    Type type = (object) methodBase == null ? (Type) null : methodBase.DeclaringType;
    return (object) type != (object) typeof (RuntimeMethodHandle) && (object) type != null && (object) type.Assembly == (object) typeof (\u000F\u2000).Assembly;
  }

  private static int \u0002(Type _param0)
  {
    return _param0.MetadataToken;
  }

  private sealed class \u0002
  {
    private int \u0002;
    private int \u0003;

    internal \u0002()
    {
      this.\u0002(0L);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal long \u0002()
    {
      if ((object) Assembly.GetCallingAssembly() != (object) typeof (\u000F\u2000.\u0002).Assembly || !\u000F\u2000.\u0002())
        return 2918384;
      int[] numArray = new int[4]
      {
        0,
        0,
        0,
        ~-~--~~-~549419311
      };
      numArray[1] = -~-~-~~-~-~642810094;
      numArray[2] = -~-~~-~-~-~-1579114406;
      numArray[0] = -~~-~-~-~-1431756118;
      int num1 = this.\u0002;
      int num2 = this.\u0003;
      int num3 = ~-~--~~-~1640531524;
      int num4 = ~--~~-~--~~957401310;
      for (int index = 0; index != 32; ++index)
      {
        num2 -= (num1 << 4 ^ num1 >> 5) + num1 ^ num4 + numArray[num4 >> 11 & 3];
        num4 -= num3;
        num1 -= (num2 << 4 ^ num2 >> 5) + num2 ^ num4 + numArray[num4 & 3];
      }
      for (int index = 0; index != 4; ++index)
        numArray[index] = 0;
      return (long) ((ulong) num2 << 32 | (ulong) (uint) num1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void \u0002(long _param1)
    {
      if ((object) Assembly.GetCallingAssembly() != (object) typeof (\u000F\u2000.\u0002).Assembly || !\u000F\u2000.\u0002())
        return;
      int[] numArray = new int[4]
      {
        0,
        -~~-~--~-~~642810094,
        0,
        0
      };
      numArray[0] = -~-~~--~~-~-1431756115;
      numArray[2] = ~-~--~~-~-1579114407;
      numArray[3] = -~~-~--~~-~549419312;
      int num1 = -~~-~--~~-~1640531525;
      int num2 = (int) _param1;
      int num3 = (int) (_param1 >> 32);
      int num4 = 0;
      for (int index = 0; index != 32; ++index)
      {
        num2 += (num3 << 4 ^ num3 >> 5) + num3 ^ num4 + numArray[num4 & 3];
        num4 += num1;
        num3 += (num2 << 4 ^ num2 >> 5) + num2 ^ num4 + numArray[num4 >> 11 & 3];
      }
      for (int index = 0; index != 4; ++index)
        numArray[index] = 0;
      this.\u0002 = num2;
      this.\u0003 = num3;
    }
  }

  private sealed class \u0002\u2000
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int \u0002()
    {
      return \u000F\u2000.\u0003.\u0002(\u000F\u2000.\u0002(typeof (\u000F\u2000.\u0002\u2000)), \u000F\u2000.\u0003.\u0005(\u000F\u2000.\u0003.\u0003(\u000F\u2000.\u0002(typeof (\u000F\u2000.\u000F)), \u000F\u2000.\u0002(typeof (\u000F\u2000.\u0005))), \u000F\u2000.\u0003.\u0005(\u000F\u2000.\u0002(typeof (\u000F\u2000.\u0008)) ^ ~-~--~~-~1140344186, \u000F\u2000.\u000F.\u0002())));
    }
  }

  private static class \u0003
  {
    internal static int \u0002(int _param0, int _param1)
    {
      return _param0 ^ _param1 - ~--~~-~--~~-2022811286;
    }

    internal static int \u0003(int _param0, int _param1)
    {
      return _param0 - -~-~-~~-~1689796184 ^ _param1 + -~-~-~~-~-1823220423;
    }

    internal static int \u0005(int _param0, int _param1)
    {
      return _param0 ^ (_param1 - ~--~~-~--~~-269855288 ^ _param0 - _param1);
    }
  }

  private sealed class \u0005
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int \u0002()
    {
      return \u000F\u2000.\u0003.\u0005(\u000F\u2000.\u0003.\u0003(\u000F\u2000.\u0002(typeof (\u000F\u2000.\u0006)), \u000F\u2000.\u0003.\u0005(\u000F\u2000.\u0002(typeof (\u000F\u2000.\u0005)), \u000F\u2000.\u0002(typeof (\u000F\u2000.\u000F)))), \u000F\u2000.\u0002\u2000.\u0002());
    }
  }

  private sealed class \u0006
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int \u0002()
    {
      return \u000F\u2000.\u0003.\u0002(\u000F\u2000.\u0002(typeof (\u000F\u2000.\u0008)), \u000F\u2000.\u0002(typeof (\u000F\u2000.\u000E)) ^ \u000F\u2000.\u0003.\u0003(\u000F\u2000.\u0002(typeof (\u000F\u2000.\u0006)), \u000F\u2000.\u0003.\u0005(\u000F\u2000.\u0002(typeof (\u000F\u2000.\u0002\u2000)), \u000F\u2000.\u000E.\u0002())));
    }
  }

  private sealed class \u0008
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int \u0002()
    {
      return \u000F\u2000.\u0003.\u0005(\u000F\u2000.\u0003.\u0002(\u000F\u2000.\u0006.\u0002() ^ -~-~~--~~-527758445, \u000F\u2000.\u0002(typeof (\u000F\u2000.\u000E))), \u000F\u2000.\u0003.\u0003(\u000F\u2000.\u0002(typeof (\u000F\u2000.\u0005)) ^ \u000F\u2000.\u0002(typeof (\u000F\u2000.\u0002\u2000)), -~~-~-~-~396877143));
    }
  }

  private sealed class \u000E
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int \u0002()
    {
      return \u000F\u2000.\u0003.\u0005(\u000F\u2000.\u0002(typeof (\u000F\u2000.\u000E)), \u000F\u2000.\u0003.\u0002(\u000F\u2000.\u0002(typeof (\u000F\u2000.\u0005)), \u000F\u2000.\u0003.\u0003(\u000F\u2000.\u0002(typeof (\u000F\u2000.\u0006)), \u000F\u2000.\u0003.\u0005(\u000F\u2000.\u0002(typeof (\u000F\u2000.\u0008)), \u000F\u2000.\u0003.\u0002(\u000F\u2000.\u0002(typeof (\u000F\u2000.\u000F)), \u000F\u2000.\u0002(typeof (\u000F\u2000.\u0002\u2000)))))));
    }
  }

  private sealed class \u000F
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int \u0002()
    {
      return \u000F\u2000.\u0003.\u0003(\u000F\u2000.\u0003.\u0003(\u000F\u2000.\u0008.\u0002(), \u000F\u2000.\u0003.\u0002(\u000F\u2000.\u0002(typeof (\u000F\u2000.\u000F)), \u000F\u2000.\u0006.\u0002())), \u000F\u2000.\u0002(typeof (\u000F\u2000.\u0002\u2000)));
    }
  }
}
