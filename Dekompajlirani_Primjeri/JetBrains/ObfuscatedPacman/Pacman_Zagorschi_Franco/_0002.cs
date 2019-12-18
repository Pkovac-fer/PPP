// Decompiled with JetBrains decompiler
// Type: 
// Assembly: Pacman_Zagorschi_Franco, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C2E3103A-7060-4739-85EE-FB357D9D720D
// Assembly location: C:\Users\Petar\OneDrive\Desktop\Originalni_Primjeri\Pacman\Pacman_Zagorschi_Franco\bin\Debug\Pacman_Zagorschi_Franco.exe

using Microsoft.Win32;
using System;

internal static class \u0002
{
  public static string \u0002()
  {
    return \u000F\u2000.\u0002(-380206457);
  }

  public static bool \u0002()
  {
    try
    {
      OperatingSystem osVersion = Environment.OSVersion;
      if (osVersion.Platform == PlatformID.Win32NT)
        return osVersion.Version >= new Version(6, 0);
      return false;
    }
    catch
    {
      return false;
    }
  }

  public static bool \u0003()
  {
    try
    {
      return (uint) Environment.OSVersion.Platform <= 2U;
    }
    catch
    {
      return false;
    }
  }

  public static bool \u0005()
  {
    return \u0002.\u0003() != null;
  }

  private static string \u0003()
  {
    try
    {
      RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(\u0002.\u0005()) ?? Registry.LocalMachine.OpenSubKey(\u0002.\u0008());
      if (registryKey == null)
        return (string) null;
      string str = (string) registryKey.GetValue(\u000F\u2000.\u0002(-380206439), (object) null);
      registryKey.Close();
      return str;
    }
    catch
    {
      return (string) null;
    }
  }

  private static string \u0005()
  {
    return \u000F\u2000.\u0002(-380206424) + \u0002.\u0002();
  }

  private static string \u0008()
  {
    return \u000F\u2000.\u0002(-380206396) + \u0002.\u0002();
  }
}
