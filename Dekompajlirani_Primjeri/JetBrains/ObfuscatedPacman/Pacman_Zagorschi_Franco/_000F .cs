// Decompiled with JetBrains decompiler
// Type:  
// Assembly: Pacman_Zagorschi_Franco, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C2E3103A-7060-4739-85EE-FB357D9D720D
// Assembly location: C:\Users\Petar\OneDrive\Desktop\Originalni_Primjeri\Pacman\Pacman_Zagorschi_Franco\bin\Debug\Pacman_Zagorschi_Franco.exe

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

internal static class \u000F\u2000
{
  private static \u000F\u2000.\u0003 \u0003;
  private static byte[] \u0005;
  private static int \u000F;
  private static short \u0008;
  private static \u000F\u2000.\u0002 \u0003\u2000;
  private static int \u0002\u2000;
  private static int \u0006;
  private static byte[] \u000E;
  private static Dictionary<int, string> \u0002;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static \u000F\u2000()
  {
    int num1 = -297420002;
    int num2 = num1 ^ -905966255;
    \u000F\u2000.\u0002 = new Dictionary<int, string>(311128851 - num1 ^ num2);
    int skipFrames = 2;
    StackTrace stackTrace = new StackTrace(skipFrames, false);
    int index1 = skipFrames - 2;
    StackFrame frame = stackTrace.GetFrame(index1);
    int index2 = index1;
    if (frame == null)
    {
      stackTrace = new StackTrace();
      index2 = 1;
      frame = stackTrace.GetFrame(index2);
    }
    int num3 = ~--~~-~-~-~(num1 - 613784086 - num2) ^ -~-~-~~-~(-1220161680 - num1 ^ num2);
    MethodBase method = frame?.GetMethod();
    if (frame != null)
      num3 ^= -~~--~-~-~~((-3273393 ^ num1) - num2);
    Type type = (object) method != null ? method.DeclaringType : (Type) null;
    int num4;
    if ((object) type == (object) typeof (RuntimeMethodHandle))
    {
      \u000F\u2000.\u0003\u2000 = (\u000F\u2000.\u0002) 4 | \u000F\u2000.\u0003\u2000;
      num4 = num3 ^ (311128198 - num1 ^ num2) + index1;
    }
    else if ((object) type == null)
    {
      if (\u000F\u2000.\u0002(stackTrace, index2))
      {
        \u000F\u2000.\u0003\u2000 = (\u000F\u2000.\u0002) 16 | \u000F\u2000.\u0003\u2000;
        num4 = num3 ^ -~~--~-~~(num1 - 311152464 + num2) - index1;
      }
      else
      {
        num4 = num3 ^ -~~--~-~~(905929242 ^ num1 ^ num2);
        \u000F\u2000.\u0003\u2000 |= (\u000F\u2000.\u0002) 1;
      }
    }
    else
    {
      \u000F\u2000.\u0003\u2000 = (\u000F\u2000.\u0002) 16 | \u000F\u2000.\u0003\u2000;
      num4 = num3 ^ -~~--~~--~~(num1 - 311152465 + num2) - index1;
    }
    \u000F\u2000.\u0002\u2000 += num4;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  internal static string \u0002(int _param0)
  {
    lock (\u000F\u2000.\u0002)
    {
      string str;
      if (\u000F\u2000.\u0002.TryGetValue(_param0, out str))
        return str;
      return \u000F\u2000.\u0002(_param0, true);
    }
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static string \u0002(int _param0, bool _param1)
  {
    int num1 = 710889651;
    int num2 = -199636051 - num1;
    string str = (string) null;
    byte[] numArray1;
    int num3;
    do
    {
      int num4;
      if (\u000F\u2000.\u0003 == null)
      {
        Assembly executingAssembly = Assembly.GetExecutingAssembly();
        Assembly.GetCallingAssembly();
        \u000F\u2000.\u0006 |= (-477340209 ^ num1) - num2;
        Assembly assembly = executingAssembly;
        StringBuilder stringBuilder = new StringBuilder();
        int num5 = num1 + 737104987 + num2;
        stringBuilder.Append((char) (num5 >> 16)).Append((char) num5);
        int num6 = 336571310 - num1 ^ num2;
        stringBuilder.Append((char) (num6 >> 16)).Append((char) num6);
        int num7 = (num1 ^ -1008612432) - num2;
        stringBuilder.Append((char) (num7 >> 16)).Append((char) num7);
        int num8 = num1 + 737170524 + num2;
        stringBuilder.Append((char) (num8 >> 16)).Append((char) num8);
        int num9 = -1008399797 ^ num1 ^ num2;
        stringBuilder.Append((char) num9).Append((char) (num9 >> 16));
        int num10 = 737236062 + num1 + num2;
        stringBuilder.Append((char) (num10 >> 16)).Append((char) num10);
        int num11 = (num1 ^ -471479736) - num2;
        stringBuilder.Append((char) num11);
        string name = stringBuilder.ToString();
        Stream manifestResourceStream = assembly.GetManifestResourceStream(name);
        int skipFrames = 2;
        StackTrace stackTrace = new StackTrace(skipFrames, false);
        \u000F\u2000.\u0006 ^= -199642001 - num1 ^ num2 | skipFrames;
        int index1 = skipFrames - 2;
        StackFrame frame = stackTrace.GetFrame(index1);
        int index2 = index1;
        if (frame == null)
        {
          stackTrace = new StackTrace();
          index2 = 1;
          frame = stackTrace.GetFrame(index2);
        }
        MethodBase method = frame?.GetMethod();
        \u000F\u2000.\u0006 ^= index1 + ((num1 ^ 471520565) + num2);
        Type type = (object) method != null ? method.DeclaringType : (Type) null;
        if (frame == null)
          \u000F\u2000.\u0006 ^= num1 - 1621503594 ^ num2;
        bool flag = (object) type == (object) typeof (RuntimeMethodHandle);
        \u000F\u2000.\u0006 ^= 1621415513 - num1 + num2;
        if (!flag)
        {
          flag = (object) type == null;
          if (flag)
          {
            if (\u000F\u2000.\u0002(stackTrace, index2))
              flag = false;
            else
              \u000F\u2000.\u0006 ^= (num1 ^ -471694530) - num2;
          }
        }
        if (flag == (stackTrace != null))
          \u000F\u2000.\u0006 ^= 32;
        \u000F\u2000.\u0006 ^= 199642553 + num1 + num2 | 1 + index1;
        \u000F\u2000.\u0003 = new \u000F\u2000.\u0003(manifestResourceStream);
        short num12 = (short) ((int) \u000F\u2000.\u0003.\u0002() ^ (int) (short) ~--~~-~-~-~(-199609777 - num1 - num2));
        if (num12 == (short) 0)
          \u000F\u2000.\u0008 = (short) ((int) \u000F\u2000.\u0003.\u0002() ^ (int) (short) ~-~--~~-~((num1 ^ 471492076) + num2));
        else
          \u000F\u2000.\u0005 = \u000F\u2000.\u0003.\u0002((int) num12);
        \u000F\u2000.\u000E = \u000F\u2000.\u0002(\u000F\u2000.\u0002(executingAssembly));
        int num13 = \u000F\u2000.\u0002\u2000 ^ (-879198228 - num1 ^ num2);
        \u000F\u2000.\u0002\u2000 = 0;
        long num14 = \u0003\u2001.\u0002();
        int num15 = num13 ^ (int) (uint) num14 ^ num1 - 1313528180 - num2;
        int num16 = num15;
        int num17 = 0;
        int num18 = ((num1 ^ 1092509678 ^ num2) + num16 ^ -1408456491 - num1 + num2) * (num1 - 1621410060 - num2) % (-226719798 - num1 ^ num2);
        int num19 = num18;
        \u0003\u2000<int> enumerator = ((\u000E<int>) new \u0008.\u0002(199636049 + num1 | num2)
        {
          \u0006 = num19
        }).GetEnumerator();
        try
        {
          while (enumerator.\u000F\u2005\u2000\u0002())
          {
            int num20 = enumerator.\u000F\u2005\u2000\u0002();
            num18 ^= num20 - num17;
            num17 += num18 >> 1;
          }
        }
        finally
        {
          enumerator?.\u0002\u2000\u2005\u2000\u0002();
        }
        num4 = num18 + (num15 ^ ~-~--~~-~-~(-1246473112 - num1 + num2));
        \u000F\u2000.\u0006 = \u000F\u2000.\u0006 & (-333785797 ^ num1 ^ num2) ^ num1 - 1621408565 - num2;
        \u000F\u2000.\u000F = num4;
        if ((\u000F\u2000.\u0003\u2000 & (\u000F\u2000.\u0002) -~-~~-~-~-~((num1 ^ 471520327) + num2)) == (\u000F\u2000.\u0002) 0)
          \u000F\u2000.\u0006 = -199592089 - num1 - num2;
      }
      else
        num4 = \u000F\u2000.\u000F;
      if (\u000F\u2000.\u0006 == (471425139 ^ num1) + num2)
      {
        str = new string(new char[3]
        {
          (char) (num1 - 1621415265 - num2),
          '0',
          (char) (-471520751 ^ num1 ^ num2)
        });
        return str;
      }
      int num21 = _param0 ^ 266843397 + num1 - num2 ^ num4 ^ (-347264904 - num1 ^ num2);
      \u000F\u2000.\u0003.\u0002().Position = (long) num21;
      if (\u000F\u2000.\u0005 != null)
      {
        numArray1 = \u000F\u2000.\u0005;
      }
      else
      {
        short num5 = \u000F\u2000.\u0008 != (short) -1 ? \u000F\u2000.\u0008 : (short) ((int) \u000F\u2000.\u0003.\u0002() ^ num1 + 199628377 + num2 ^ num21);
        if (num5 == (short) 0)
        {
          numArray1 = (byte[]) null;
        }
        else
        {
          numArray1 = \u000F\u2000.\u0003.\u0002((int) num5);
          for (int index = 0; index != numArray1.Length; index = 1 + index)
            numArray1[index] ^= (byte) (\u000F\u2000.\u000F >> ((3 & index) << 3));
        }
      }
      num3 = \u000F\u2000.\u0003.\u0002() ^ num21 ^ ~-~--~~-~((940872517 ^ num1) - num2) ^ num4;
      if (num3 == (1621415351 - num1 | num2))
      {
        byte[] numArray2 = \u000F\u2000.\u0003.\u0002(4);
        _param0 = (-940872524 ^ num1) + num2 ^ num4;
        _param0 = ((int) numArray2[2] | (int) numArray2[3] << 16 | (int) numArray2[0] << 8 | (int) numArray2[1] << 24) ^ -_param0;
      }
      else
        goto label_38;
    }
    while (!\u000F\u2000.\u0002.TryGetValue(_param0, out str));
    return str;
label_38:
    bool flag1 = (uint) (num3 & 526068295 + num1 - num2) > 0U;
    bool flag2 = (uint) (num3 & (-1008391607 ^ num1 ^ num2)) > 0U;
    bool flag3 = (uint) (num3 & -1599810119 - num1 + num2) > 0U;
    int num22 = num3 & (num1 - 1679412142 ^ num2);
    byte[] numArray3 = numArray1;
    byte[] numArray4 = \u000F\u2000.\u0003.\u0002(num22);
    byte[] numArray5 = numArray3;
    byte num23 = numArray5[1];
    int length1 = numArray4.Length;
    byte num24 = (byte) (length1 + 11 ^ (int) num23 + 7);
    uint num25 = (uint) (((int) numArray5[0] | (int) numArray5[2] << 8) + ((int) num24 << 3));
    ushort num26 = 0;
    int index3 = 0;
    while (index3 < length1)
    {
      if ((1 & index3) == 0)
      {
        num25 = (uint) ((int) num25 * ((num1 ^ 471308720) + num2) + (num1 - 1618884342 - num2));
        num26 = (ushort) (num25 >> 16);
      }
      byte num4 = (byte) num26;
      num26 >>= 8;
      byte num5 = numArray4[index3];
      numArray4[index3] = (byte) ((uint) ((int) num23 ^ (int) num5 ^ 3 + (int) num24) ^ (uint) num4);
      index3 = 1 + index3;
      num24 = num5;
    }
    byte[] numArray6 = numArray4;
    if (\u000F\u2000.\u000E != null != (\u000F\u2000.\u0006 != 1623023167 - num1 + num2))
    {
      for (int index1 = 0; index1 < num22; index1 = 1 + index1)
      {
        byte num4 = \u000F\u2000.\u000E[7 & index1];
        byte num5 = (byte) ((int) num4 << 3 | (int) num4 >> 5);
        numArray6[index1] = (byte) ((uint) numArray6[index1] ^ (uint) num5);
      }
    }
    int num27 = \u000F\u2000.\u0006 - 12;
    byte[] bytes;
    int length2;
    if (!flag2)
    {
      bytes = numArray6;
      length2 = num22;
    }
    else
    {
      length2 = (int) numArray6[2] | (int) numArray6[0] << 16 | (int) numArray6[3] << 8 | (int) numArray6[1] << 24;
      bytes = new byte[length2];
      \u000F\u2000.\u0002(numArray6, 4, bytes);
    }
    if (flag1 && num27 == num1 - 1619807551 - num2)
    {
      char[] chArray = new char[length2];
      for (int index1 = 0; index1 < length2; ++index1)
        chArray[index1] = (char) bytes[index1];
      str = new string(chArray);
    }
    else
      str = Encoding.Unicode.GetString(bytes, 0, bytes.Length);
    int num28 = num27 + ((num1 ^ -471520714 ^ num2) + (3 & num27) << 5);
    if (num28 != num1 - 1619803423 - num2)
    {
      int num4 = _param0 + num22 ^ (-471113679 ^ num1 ^ num2) ^ num28 & -199634758 - num1 - num2;
      ref int local = ref num4;
      StringBuilder stringBuilder = new StringBuilder();
      int num5 = num1 ^ -471520751 ^ num2;
      stringBuilder.Append((char) (byte) num5);
      string format = stringBuilder.ToString();
      str = local.ToString(format);
    }
    if (!flag3 & _param1)
    {
      str = string.Intern(str);
      \u000F\u2000.\u0002[_param0] = str;
      if (\u000F\u2000.\u0002.Count == -199635609 - num1 - num2)
      {
        \u000F\u2000.\u0003.\u0003();
        \u000F\u2000.\u0003 = (\u000F\u2000.\u0003) null;
        \u000F\u2000.\u0005 = (byte[]) null;
        \u000F\u2000.\u000E = (byte[]) null;
      }
    }
    return str;
  }

  private static AssemblyName \u0002(Assembly _param0)
  {
    try
    {
      return _param0.GetName();
    }
    catch
    {
      return new AssemblyName(_param0.FullName);
    }
  }

  private static byte[] \u0002(AssemblyName _param0)
  {
    byte[] numArray = _param0.GetPublicKeyToken();
    if (numArray != null && numArray.Length == 0)
      numArray = (byte[]) null;
    return numArray;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static bool \u0002(StackTrace _param0, int _param1)
  {
    StackFrame frame1 = _param0.GetFrame(++_param1);
    Assembly assembly1;
    if (frame1 == null)
    {
      assembly1 = (Assembly) null;
    }
    else
    {
      MethodBase method = frame1.GetMethod();
      if ((object) method == null)
      {
        assembly1 = (Assembly) null;
      }
      else
      {
        Type declaringType = method.DeclaringType;
        assembly1 = (object) declaringType != null ? declaringType.Assembly : (Assembly) null;
      }
    }
    Assembly assembly2 = assembly1;
    if ((object) assembly2 != null)
    {
      byte[] numArray = \u000F\u2000.\u0002(\u000F\u2000.\u0002(assembly2));
      if (numArray != null && numArray.Length == 8 && (numArray[0] == (byte) 183 && numArray[7] == (byte) 137))
        return true;
    }
    Assembly assembly3;
    do
    {
      StackFrame frame2 = _param0.GetFrame(++_param1);
      if (frame2 != null)
      {
        MethodBase method = frame2.GetMethod();
        Assembly assembly4;
        if ((object) method == null)
        {
          assembly4 = (Assembly) null;
        }
        else
        {
          Type declaringType = method.DeclaringType;
          assembly4 = (object) declaringType != null ? declaringType.Assembly : (Assembly) null;
        }
        assembly3 = assembly4;
      }
      else
        goto label_14;
    }
    while ((object) assembly3 == null || (object) assembly3 != (object) typeof (\u000F\u2000).Assembly);
    return true;
label_14:
    return false;
  }

  private static void \u0002(byte[] _param0, int _param1, byte[] _param2)
  {
    int num1 = 0;
    int num2 = 0;
    int num3 = 128;
    int length = _param2.Length;
label_10:
    while (num1 < length)
    {
      if ((num3 <<= 1) == 256)
      {
        num3 = 1;
        num2 = (int) _param0[_param1++];
      }
      if ((num2 & num3) != 0)
      {
        int num4 = ((int) _param0[_param1] >> 2) + 3;
        int num5 = ((int) _param0[_param1] << 8 | (int) _param0[_param1 + 1]) & 1023;
        _param1 += 2;
        int num6 = num1 - num5;
        if (num6 < 0)
          break;
        while (true)
        {
          if (--num4 >= 0 && num1 < length)
            _param2[num1++] = _param2[num6++];
          else
            goto label_10;
        }
      }
      else
        _param2[num1++] = _param0[_param1++];
    }
  }

  private enum \u0002
  {
  }

  private sealed class \u0003
  {
    private Stream \u0002;
    private byte[] \u0003;

    public \u0003(Stream _param1)
    {
      this.\u0002 = _param1;
      this.\u0003 = new byte[4];
    }

    public Stream \u0002()
    {
      return this.\u0002;
    }

    public short \u0002()
    {
      this.\u0002(2);
      return (short) ((int) this.\u0003[0] | (int) this.\u0003[1] << 8);
    }

    public int \u0002()
    {
      this.\u0002(4);
      return (int) this.\u0003[0] | (int) this.\u0003[1] << 8 | (int) this.\u0003[2] << 16 | (int) this.\u0003[3] << 24;
    }

    private void \u0002()
    {
      throw new EndOfStreamException();
    }

    private void \u0002(int _param1)
    {
      int offset = 0;
      if (_param1 == 1)
      {
        int num = this.\u0002.ReadByte();
        if (num == -1)
          this.\u0002();
        this.\u0003[0] = (byte) num;
      }
      else
      {
        do
        {
          int num = this.\u0002.Read(this.\u0003, offset, _param1 - offset);
          if (num == 0)
            this.\u0002();
          offset += num;
        }
        while (offset < _param1);
      }
    }

    public void \u0003()
    {
      Stream stream = this.\u0002;
      this.\u0002 = (Stream) null;
      stream?.Close();
      this.\u0003 = (byte[]) null;
    }

    public byte[] \u0002(int _param1)
    {
      if (_param1 < 0)
        throw new ArgumentOutOfRangeException();
      byte[] buffer = new byte[_param1];
      int length = 0;
      do
      {
        int num = this.\u0002.Read(buffer, length, _param1);
        if (num != 0)
        {
          length += num;
          _param1 -= num;
        }
        else
          break;
      }
      while (_param1 > 0);
      if (length != buffer.Length)
      {
        byte[] numArray = new byte[length];
        Buffer.BlockCopy((Array) buffer, 0, (Array) numArray, 0, length);
        buffer = numArray;
      }
      return buffer;
    }
  }
}
