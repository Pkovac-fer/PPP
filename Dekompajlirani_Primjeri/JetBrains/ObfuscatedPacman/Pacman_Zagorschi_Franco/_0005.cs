// Decompiled with JetBrains decompiler
// Type: 
// Assembly: Pacman_Zagorschi_Franco, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C2E3103A-7060-4739-85EE-FB357D9D720D
// Assembly location: C:\Users\Petar\OneDrive\Desktop\Originalni_Primjeri\Pacman\Pacman_Zagorschi_Franco\bin\Debug\Pacman_Zagorschi_Franco.exe

using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

internal static class \u0005
{
  private static bool \u0002(bool _param0)
  {
    DateTime dateTime = DateTime.Parse(\u000F\u2000.\u0002(-380207014), (IFormatProvider) CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);
    DateTime utcNow = DateTime.UtcNow;
    if (utcNow > dateTime || utcNow < dateTime.AddDays(-21.0))
    {
      string message = string.Format(\u000F\u2000.\u0002(-380206977), (object) typeof (\u0005).Assembly.GetName().Name);
      if (_param0)
        throw new Exception(message);
      \u0005.\u0002();
      Application.Run((Form) new \u0003(message, \u000F\u2000.\u0002(-380205439)));
      return false;
    }
    if (!\u0002.\u0002())
      return \u0005.\u0003(_param0);
    if (\u0002.\u0005())
      return true;
    try
    {
      \u0005.\u0002();
      \u0003 obj = new \u0003(\u000F\u2000.\u0002(-380205409), \u000F\u2000.\u0002(-380206960));
      obj.BackColor = Color.White;
      int num = (int) obj.ShowDialog();
    }
    catch
    {
    }
    if (_param0)
      throw new Exception(\u000F\u2000.\u0002(-380205170));
    return false;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static bool \u0003(bool _param0)
  {
    \u0005.\u0002 obj = new \u0005.\u0002();
    obj.\u0002 = new bool?();
    try
    {
      string data = AppDomain.CurrentDomain.GetData(\u000F\u2000.\u0002(-380205217)) as string;
      if (data != null)
      {
        if (data == \u000F\u2000.\u0002(-380205190))
          obj.\u0002 = new bool?(false);
        else if (data == \u000F\u2000.\u0002(-380205950))
          obj.\u0002 = new bool?(true);
      }
    }
    catch
    {
    }
    bool hasValue = obj.\u0002.HasValue;
    if (!obj.\u0002.HasValue)
    {
      try
      {
        if (\u0002.\u0003())
          \u0005.\u0002(new ThreadStart(obj.\u0002));
        else
          \u0005.\u0002(new ThreadStart(obj.\u0003));
      }
      catch
      {
      }
    }
    if (!hasValue)
    {
      if (obj.\u0002.HasValue)
      {
        try
        {
          AppDomain.CurrentDomain.SetData(\u000F\u2000.\u0002(-380205217), obj.\u0002.Value ? (object) \u000F\u2000.\u0002(-380205950) : (object) \u000F\u2000.\u0002(-380205190));
        }
        catch
        {
        }
      }
    }
    if (obj.\u0002.GetValueOrDefault())
      return true;
    if (_param0)
      throw new Exception(\u000F\u2000.\u0002(-380205942));
    return false;
  }

  private static void \u0002(ThreadStart _param0)
  {
    \u0005.\u0003 obj = new \u0005.\u0003();
    obj.\u0002 = _param0;
    obj.\u0003 = (Exception) null;
    Thread thread = new Thread(new ThreadStart(obj.\u0002));
    thread.SetApartmentState(ApartmentState.STA);
    thread.IsBackground = true;
    thread.Start();
    thread.Join();
    if (obj.\u0003 != null)
      throw obj.\u0003;
  }

  private static void \u0002()
  {
    try
    {
      Application.EnableVisualStyles();
      Application.DoEvents();
    }
    catch
    {
    }
  }

  public static bool \u0002()
  {
    return \u0005.\u0002(false);
  }

  public static void \u0003()
  {
    \u0005.\u0002(true);
  }

  private sealed class \u0002
  {
    public bool? \u0002;

    internal void \u0002()
    {
      \u0003 obj = new \u0003(\u000F\u2000.\u0002(-380206501), \u000F\u2000.\u0002(-380206960), MessageBoxButtons.YesNo);
      obj.BackColor = Color.White;
      this.\u0002 = new bool?(obj.ShowDialog() == DialogResult.Yes);
    }

    internal void \u0003()
    {
      \u0003 obj = new \u0003(\u000F\u2000.\u0002(-380206924), \u000F\u2000.\u0002(-380206960));
      obj.BackColor = Color.White;
      this.\u0002 = new bool?(obj.ShowDialog() == DialogResult.OK);
    }
  }

  private sealed class \u0003
  {
    public ThreadStart \u0002;
    public Exception \u0003;

    internal void \u0002()
    {
      try
      {
        this.\u0002();
      }
      catch (Exception ex)
      {
        this.\u0003 = ex;
      }
    }
  }
}
