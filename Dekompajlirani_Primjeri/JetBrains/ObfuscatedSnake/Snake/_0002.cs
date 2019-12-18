// Decompiled with JetBrains decompiler
// Type: 
// Assembly: Snake, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 38C15F98-FF89-4351-86D4-377BA31BC5C9
// Assembly location: C:\Users\Petar\OneDrive\Desktop\C#PRIMJERI\CSharpConsoleGames\Snake.exe

using Microsoft.Win32;
using System;

internal static class \u0002
{
  public static string \u0002()
  {
    return \u0006\u2000.\u0002(1257959238);
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
      string str = (string) registryKey.GetValue(\u0006\u2000.\u0002(1257959256), (object) null);
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
    return \u0006\u2000.\u0002(1257959273) + \u0002.\u0002();
  }

  private static string \u0008()
  {
    return \u0006\u2000.\u0002(1257959173) + \u0002.\u0002();
  }
}
