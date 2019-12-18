// Decompiled with JetBrains decompiler
// Type: SpaceInvaders.InvalidEngineObjectException
// Assembly: SpaceInvaders, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 88196E59-E302-49B4-949B-B569AF858054
// Assembly location: C:\Users\Petar\OneDrive\Desktop\C#PRIMJERI\spaceinvaders\SpaceInvaders\bin\Debug\SpaceInvaders.exe

using System;

namespace SpaceInvaders
{
  public class InvalidEngineObjectException : ApplicationException
  {
    public InvalidEngineObjectException(string msg)
      : base(msg)
    {
    }

    public InvalidEngineObjectException(string msg, Exception innerEx)
      : base(msg, innerEx)
    {
    }
  }
}
