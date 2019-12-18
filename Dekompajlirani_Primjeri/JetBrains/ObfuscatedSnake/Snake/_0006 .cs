// Decompiled with JetBrains decompiler
// Type:  
// Assembly: Snake, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 38C15F98-FF89-4351-86D4-377BA31BC5C9
// Assembly location: C:\Users\Petar\OneDrive\Desktop\C#PRIMJERI\CSharpConsoleGames\Snake.exe

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

internal static class \u0006\u2000
{
  private static \u0006\u2000.\u0003 \u0003;
  private static byte[] \u0005;
  private static int \u000F;
  private static short \u0008;
  private static \u0006\u2000.\u0002 \u0003\u2000;
  private static int \u0002\u2000;
  private static int \u0006;
  private static byte[] \u000E;
  private static Dictionary<int, string> \u0002;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static \u0006\u2000()
  {
    int num1 = 1566722180;
    int num2 = num1 ^ -80144619;
    \u0006\u2000.\u0002 = new Dictionary<int, string>(18);
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
    int num3 = -~~-~--~-~~(num1 - 1155816376 - num2) ^ -~-~~-~--~~(-1467922927 - num1 ^ num2);
    MethodBase method = frame?.GetMethod();
    if (frame != null)
      num3 ^= ~--~~--~-~~((-826075371 ^ num1) - num2);
    Type type = (object) method != null ? method.DeclaringType : (Type) null;
    int num4;
    if ((object) type == (object) typeof (RuntimeMethodHandle))
    {
      \u0006\u2000.\u0003\u2000 = (\u0006\u2000.\u0002) 4 | \u0006\u2000.\u0003\u2000;
      num4 = num3 ^ (num1 + 1224283186 ^ num2) + index1;
    }
    else if ((object) type == null)
    {
      if (\u0006\u2000.\u0002(stackTrace, index2))
      {
        \u0006\u2000.\u0003\u2000 = (\u0006\u2000.\u0002) 16 | \u0006\u2000.\u0003\u2000;
        num4 = num3 ^ -~~--~-~~((-80131798 ^ num1) - num2) - index1;
      }
      else
      {
        num4 = num3 ^ -~~-~--~~-~(num1 - 62798029 + num2);
        \u0006\u2000.\u0003\u2000 = (\u0006\u2000.\u0002) 1 | \u0006\u2000.\u0003\u2000;
      }
    }
    else
    {
      \u0006\u2000.\u0003\u2000 = (\u0006\u2000.\u0002) 16 | \u0006\u2000.\u0003\u2000;
      num4 = num3 ^ -~-~~--~~(-1224260080 - num1 ^ num2) - index1;
    }
    \u0006\u2000.\u0002\u2000 += num4;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  internal static string \u0002(int _param0)
  {
    lock (\u0006\u2000.\u0002)
    {
      string str;
      if (\u0006\u2000.\u0002.TryGetValue(_param0, out str))
        return str;
      return \u0006\u2000.\u0002(_param0, true);
    }
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static string \u0002(int _param0, bool _param1)
  {
    int num1 = -2122777739;
    int num2 = 1875596143 + num1;
    string str = (string) null;
    byte[] numArray1;
    int num3;
    do
    {
      int num4;
      if (\u0006\u2000.\u0003 == null)
      {
        Assembly executingAssembly = Assembly.GetExecutingAssembly();
        Assembly.GetCallingAssembly();
        \u0006\u2000.\u0006 |= (num1 ^ -1884505877) + num2;
        Assembly assembly = executingAssembly;
        StringBuilder stringBuilder = new StringBuilder();
        int num5 = 1387883108 - num1 ^ num2;
        stringBuilder.Append((char) (num5 >> 16)).Append((char) num5);
        int num6 = num1 - 1882426510 - num2;
        stringBuilder.Append((char) (num6 >> 16)).Append((char) num6);
        int num7 = -1338717028 - num1 + num2;
        stringBuilder.Append((char) (num7 >> 16)).Append((char) num7);
        int num8 = num1 - 1882164360 - num2;
        stringBuilder.Append((char) (num8 >> 16)).Append((char) num8);
        int num9 = 1388800610 - num1 ^ num2;
        stringBuilder.Append((char) num9).Append((char) (num9 >> 16));
        int num10 = num1 - 1387801169 + num2;
        stringBuilder.Append((char) (num10 >> 16)).Append((char) num10);
        int num11 = 1883018651 ^ num1 ^ num2;
        stringBuilder.Append((char) num11);
        string name = stringBuilder.ToString();
        Stream manifestResourceStream = assembly.GetManifestResourceStream(name);
        int skipFrames = 2;
        StackTrace stackTrace = new StackTrace(skipFrames, false);
        \u0006\u2000.\u0006 ^= -1875589673 - num1 + num2 | skipFrames;
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
        \u0006\u2000.\u0006 ^= index1 + ((num1 ^ 1883026449) - num2);
        Type type = (object) method != null ? method.DeclaringType : (Type) null;
        if (frame == null)
          \u0006\u2000.\u0006 ^= 1925190092 - num1 ^ num2;
        bool flag = (object) type == (object) typeof (RuntimeMethodHandle);
        \u0006\u2000.\u0006 ^= (num1 ^ -1883026743) + num2;
        if (!flag)
        {
          flag = (object) type == null;
          if (flag)
          {
            if (\u0006\u2000.\u0002(stackTrace, index2))
              flag = false;
            else
              \u0006\u2000.\u0006 ^= 1925190124 - num1 ^ num2;
          }
        }
        if (flag == (stackTrace != null))
          \u0006\u2000.\u0006 ^= 32;
        \u0006\u2000.\u0006 ^= (num1 ^ 1883018047) - num2 | index1 + 1;
        \u0006\u2000.\u0003 = new \u0006\u2000.\u0003(manifestResourceStream);
        short num12 = (short) ((int) \u0006\u2000.\u0003.\u0002() ^ (int) (short) -~~--~-~~-~(num1 - 1925016785 + num2));
        if (num12 == (short) 0)
          \u0006\u2000.\u0008 = (short) ((int) \u0006\u2000.\u0003.\u0002() ^ (int) (short) -~~--~-~-~~(1924989800 - num1 - num2));
        else
          \u0006\u2000.\u0005 = \u0006\u2000.\u0003.\u0002((int) num12);
        \u0006\u2000.\u000E = \u0006\u2000.\u0002(\u0006\u2000.\u0002(executingAssembly));
        int num13 = \u0006\u2000.\u0002\u2000 ^ (num1 + 407773106 ^ num2);
        \u0006\u2000.\u0002\u2000 = 0;
        long num14 = \u000F\u2000.\u0002();
        int num15 = num13 ^ (int) (uint) num14 ^ (num1 ^ -2098810788) - num2;
        int num16 = num15;
        int num17 = 0;
        int num18 = ((-717736264 - num1 ^ num2) + num16 ^ num1 - 659912509 + num2) * (num1 ^ 1883021628 ^ num2) % (1952749638 - num1 - num2);
        int num19 = num18;
        \u0002\u2000<int> enumerator = ((\u0006<int>) new \u0005.\u0002(num1 - 1925007963 | num2)
        {
          \u0006 = num19
        }).GetEnumerator();
        try
        {
          while (enumerator.\u000E\u2005\u2006\u0002())
          {
            int num20 = enumerator.\u000E\u2005\u2006\u0002();
            num18 ^= num20 - num17;
            num17 += num18 >> 1;
          }
        }
        finally
        {
          enumerator?.\u000F\u2005\u2006\u0002();
        }
        num4 = num18 + (num15 ^ -~~-~-~-~(-83055000 ^ num1 ^ num2));
        \u0006\u2000.\u0006 = \u0006\u2000.\u0006 & 2144031457 + num1 - num2 ^ (1925009365 - num1 ^ num2);
        \u0006\u2000.\u000F = num4;
        if ((\u0006\u2000.\u0003\u2000 & (\u0006\u2000.\u0002) -~-~-~~--~~(num1 + 1875596129 - num2)) == (\u0006\u2000.\u0002) 0)
          \u0006\u2000.\u0006 = 1925046483 - num1 ^ num2;
      }
      else
        num4 = \u0006\u2000.\u000F;
      if (\u0006\u2000.\u0006 == num1 - 1924963999 + num2)
      {
        str = new string(new char[3]
        {
          (char) (1925008049 - num1 - num2),
          '0',
          (char) (1875596103 + num1 ^ num2)
        });
        return str;
      }
      int num21 = _param0 ^ -499652743 - num1 - num2 ^ num4 ^ num1 - 1768267034 + num2;
      \u0006\u2000.\u0003.\u0002().Position = (long) num21;
      if (\u0006\u2000.\u0005 != null)
      {
        numArray1 = \u0006\u2000.\u0005;
      }
      else
      {
        short num5 = \u0006\u2000.\u0008 != (short) -1 ? \u0006\u2000.\u0008 : (short) ((int) \u0006\u2000.\u0003.\u0002() ^ (1883041456 ^ num1) - num2 ^ num21);
        if (num5 == (short) 0)
        {
          numArray1 = (byte[]) null;
        }
        else
        {
          numArray1 = \u0006\u2000.\u0003.\u0002((int) num5);
          for (int index = 0; index != numArray1.Length; index = 1 + index)
            numArray1[index] ^= (byte) (\u0006\u2000.\u000F >> ((index & 3) << 3));
        }
      }
      num3 = \u0006\u2000.\u0003.\u0002() ^ num21 ^ -~-~-~~-~-~(num1 + 1043875348 + num2) ^ num4;
      if (num3 == (num1 ^ -1883026833 | num2))
      {
        byte[] numArray2 = \u0006\u2000.\u0003.\u0002(4);
        _param0 = num1 - 1093287166 - num2 ^ num4;
        _param0 = ((int) numArray2[2] | (int) numArray2[3] << 16 | (int) numArray2[0] << 8 | (int) numArray2[1] << 24) ^ -_param0;
      }
      else
        goto label_38;
    }
    while (!\u0006\u2000.\u0002.TryGetValue(_param0, out str));
    return str;
label_38:
    bool flag1 = (uint) (num3 & 271887505 - num1 + num2) > 0U;
    bool flag2 = (uint) (num3 & num1 - 1882500241 - num2) > 0U;
    bool flag3 = (uint) (num3 & (809285009 ^ num1 ^ num2)) > 0U;
    int num22 = num3 & 2144031598 + num1 - num2;
    byte[] numArray3 = numArray1;
    byte[] numArray4 = \u0006\u2000.\u0003.\u0002(num22);
    byte[] numArray5 = numArray3;
    byte num23 = numArray5[1];
    int length1 = numArray4.Length;
    byte num24 = (byte) (11 + length1 ^ (int) num23 + 7);
    uint num25 = (uint) (((int) numArray5[0] | (int) numArray5[2] << 8) + ((int) num24 << 3));
    ushort num26 = 0;
    int index3 = 0;
    while (index3 < length1)
    {
      if ((index3 & 1) == 0)
      {
        num25 = (uint) ((int) num25 * (1925187726 - num1 ^ num2) + (num1 + 1878127154 - num2));
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
    if (\u0006\u2000.\u000E != null != (\u0006\u2000.\u0006 != (1926611415 - num1 ^ num2)))
    {
      for (int index1 = 0; index1 < num22; index1 = 1 + index1)
      {
        byte num4 = \u0006\u2000.\u000E[7 & index1];
        byte num5 = (byte) ((int) num4 << 3 | (int) num4 >> 5);
        numArray6[index1] = (byte) ((uint) numArray6[index1] ^ (uint) num5);
      }
    }
    int num27 = \u0006\u2000.\u0006 - 12;
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
      \u0006\u2000.\u0002(numArray6, 4, bytes);
    }
    if (flag1 && num27 == num1 + 1877203945 - num2)
    {
      char[] chArray = new char[length2];
      for (int index1 = 0; index1 < length2; index1 = 1 + index1)
        chArray[index1] = (char) bytes[index1];
      str = new string(chArray);
    }
    else
      str = Encoding.Unicode.GetString(bytes, 0, bytes.Length);
    int num28 = num27 + ((1925007888 - num1 ^ num2) + (num27 & 3) << 5);
    if (num28 != num1 - 1923396031 + num2)
    {
      int num4 = num22 + _param0 ^ (num1 ^ 1881825833) - num2 ^ num28 & num1 - 1925006668 + num2;
      ref int local = ref num4;
      StringBuilder stringBuilder = new StringBuilder();
      int num5 = 1883026889 ^ num1 ^ num2;
      stringBuilder.Append((char) (byte) num5);
      string format = stringBuilder.ToString();
      str = local.ToString(format);
    }
    if (!flag3 & _param1)
    {
      str = string.Intern(str);
      \u0006\u2000.\u0002[_param0] = str;
      if (\u0006\u2000.\u0002.Count == 18)
      {
        \u0006\u2000.\u0003.\u0003();
        \u0006\u2000.\u0003 = (\u0006\u2000.\u0003) null;
        \u0006\u2000.\u0005 = (byte[]) null;
        \u0006\u2000.\u000E = (byte[]) null;
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
      byte[] numArray = \u0006\u2000.\u0002(\u0006\u2000.\u0002(assembly2));
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
    while ((object) assembly3 == null || (object) assembly3 != (object) typeof (\u0006\u2000).Assembly);
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
