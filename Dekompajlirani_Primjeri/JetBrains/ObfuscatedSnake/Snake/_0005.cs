// Decompiled with JetBrains decompiler
// Type: 
// Assembly: Snake, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 38C15F98-FF89-4351-86D4-377BA31BC5C9
// Assembly location: C:\Users\Petar\OneDrive\Desktop\C#PRIMJERI\CSharpConsoleGames\Snake.exe

using System;
using System.Diagnostics;
using System.Threading;

internal static class \u0005
{
  internal sealed class \u0002 : \u0006<int>, \u0008, \u0002\u2000<int>, \u000F, \u000E
  {
    private int \u0002;
    private int \u0003;
    private int \u0005;
    private int \u0008;
    public int \u0006;

    [DebuggerHidden]
    public \u0002(int _param1)
    {
      this.\u0002 = _param1;
      this.\u0005 = Thread.CurrentThread.ManagedThreadId;
    }

    [DebuggerHidden]
    void \u000F.\u0002\u2005\u2006\u0002()
    {
    }

    bool \u000E.\u000E\u2005\u2006\u0002()
    {
      switch (this.\u0002)
      {
        case 0:
          this.\u0002 = -1;
          this.\u0003 = 250489705;
          this.\u0002 = 1;
          return true;
        case 1:
          this.\u0002 = -1;
          this.\u0003 = this.\u0008 ^ -2566833;
          this.\u0002 = 2;
          return true;
        case 2:
          this.\u0002 = -1;
          this.\u0003 = -633790635;
          this.\u0002 = 3;
          return true;
        case 3:
          this.\u0002 = -1;
          this.\u0003 = this.\u0008 ^ -2566833;
          this.\u0002 = 4;
          return true;
        case 4:
          this.\u0002 = -1;
          this.\u0003 = 1511105469;
          this.\u0002 = 5;
          return true;
        case 5:
          this.\u0002 = -1;
          this.\u0003 = this.\u0008 ^ 872045545;
          this.\u0002 = 6;
          return true;
        case 6:
          this.\u0002 = -1;
          this.\u0003 = -708120235;
          this.\u0002 = 7;
          return true;
        case 7:
          this.\u0002 = -1;
          this.\u0003 = 2037083242;
          this.\u0002 = 8;
          return true;
        case 8:
          this.\u0002 = -1;
          return false;
        default:
          return false;
      }
    }

    [DebuggerHidden]
    int \u0002\u2000<int>.\u0002\u2005\u2006\u0002()
    {
      return this.\u0003;
    }

    [DebuggerHidden]
    void \u000E.\u0002\u2005\u2006\u0003()
    {
      throw new NotSupportedException();
    }

    [DebuggerHidden]
    object \u000E.\u0002\u2005\u2006\u0002()
    {
      return (object) this.\u0003;
    }

    [DebuggerHidden]
    \u0002\u2000<int> \u0006<int>.\u0002\u2005\u2006\u0002()
    {
      \u0005.\u0002 obj;
      if (this.\u0002 == -2 && this.\u0005 == Thread.CurrentThread.ManagedThreadId)
      {
        this.\u0002 = 0;
        obj = this;
      }
      else
        obj = new \u0005.\u0002(0);
      obj.\u0008 = this.\u0006;
      return (\u0002\u2000<int>) obj;
    }

    [DebuggerHidden]
    \u000E \u0008.\u0002\u2005\u2006\u0002()
    {
      return (\u000E) this.\u0002\u2005\u2006\u0002();
    }
  }
}
