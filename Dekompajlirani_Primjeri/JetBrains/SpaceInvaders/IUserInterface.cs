// Decompiled with JetBrains decompiler
// Type: SpaceInvaders.IUserInterface
// Assembly: SpaceInvaders, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 88196E59-E302-49B4-949B-B569AF858054
// Assembly location: C:\Users\Petar\OneDrive\Desktop\C#PRIMJERI\spaceinvaders\SpaceInvaders\bin\Debug\SpaceInvaders.exe

using System;

namespace SpaceInvaders
{
  public interface IUserInterface
  {
    event EventHandler OnLeftPressed;

    event EventHandler OnRightPressed;

    event EventHandler OnActionPressed;

    event EventHandler OnEscapePressed;

    event EventHandler OnUpPressed;

    event EventHandler OnDownPressed;

    event EventHandler OnEnterPressed;

    void PauseProcessInput();

    void RunProcessInput();
  }
}
