// Decompiled with JetBrains decompiler
// Type: 
// Assembly: Pacman_Zagorschi_Franco, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C2E3103A-7060-4739-85EE-FB357D9D720D
// Assembly location: C:\Users\Petar\OneDrive\Desktop\Originalni_Primjeri\Pacman\Pacman_Zagorschi_Franco\bin\Debug\Pacman_Zagorschi_Franco.exe

using System;
using System.Diagnostics;
using System.Threading;

internal static class \u0008
{
  internal sealed class \u0002 : \u000E<int>, \u0006, \u0003\u2000<int>, \u0002\u2000, \u000F
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
    void \u0002\u2000.\u0002\u2005\u2000\u0002()
    {
    }

    bool \u000F.\u000F\u2005\u2000\u0002()
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
    int \u0003\u2000<int>.\u0002\u2005\u2000\u0002()
    {
      return this.\u0003;
    }

    [DebuggerHidden]
    void \u000F.\u0002\u2005\u2000\u0003()
    {
      throw new NotSupportedException();
    }

    [DebuggerHidden]
    object \u000F.\u0002\u2005\u2000\u0002()
    {
      return (object) this.\u0003;
    }

    [DebuggerHidden]
    \u0003\u2000<int> \u000E<int>.\u0002\u2005\u2000\u0002()
    {
      \u0008.\u0002 obj;
      if (this.\u0002 == -2 && this.\u0005 == Thread.CurrentThread.ManagedThreadId)
      {
        this.\u0002 = 0;
        obj = this;
      }
      else
        obj = new \u0008.\u0002(0);
      obj.\u0008 = this.\u0006;
      return (\u0003\u2000<int>) obj;
    }

    [DebuggerHidden]
    \u000F \u0006.\u0002\u2005\u2000\u0002()
    {
      return (\u000F) this.\u0002\u2005\u2000\u0002();
    }
  }
}
