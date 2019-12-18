// Decompiled with JetBrains decompiler
// Type: SpaceInvaders.Exit
// Assembly: SpaceInvaders, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 88196E59-E302-49B4-949B-B569AF858054
// Assembly location: C:\Users\Petar\OneDrive\Desktop\C#PRIMJERI\spaceinvaders\SpaceInvaders\bin\Debug\SpaceInvaders.exe

using System;

namespace SpaceInvaders
{
  public class Exit : MenuItem
  {
    public new static char[,] message = new char[1, 4]
    {
      {
        'E',
        'X',
        'I',
        'T'
      }
    };

    public Exit(MatrixPosition topLeft)
      : base(topLeft, Exit.message)
    {
    }

    public override void TakeAction(Engine engine)
    {
      Environment.Exit(0);
    }
  }
}
