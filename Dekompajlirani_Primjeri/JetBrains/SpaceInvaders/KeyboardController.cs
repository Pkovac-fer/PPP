// Decompiled with JetBrains decompiler
// Type: SpaceInvaders.KeyboardController
// Assembly: SpaceInvaders, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 88196E59-E302-49B4-949B-B569AF858054
// Assembly location: C:\Users\Petar\OneDrive\Desktop\C#PRIMJERI\spaceinvaders\SpaceInvaders\bin\Debug\SpaceInvaders.exe

using System;

namespace SpaceInvaders
{
  public class KeyboardController : IUserInterface
  {
    public event EventHandler OnLeftPressed;

    public event EventHandler OnRightPressed;

    public event EventHandler OnActionPressed;

    public event EventHandler OnEscapePressed;

    public event EventHandler OnUpPressed;

    public event EventHandler OnDownPressed;

    public event EventHandler OnEnterPressed;

    public void PauseProcessInput()
    {
      if (!Console.KeyAvailable)
        return;
      ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
      while (Console.KeyAvailable)
        Console.ReadKey();
      if (consoleKeyInfo.Key.Equals((object) ConsoleKey.Escape) && this.OnEscapePressed != null)
        this.OnEscapePressed((object) this, new EventArgs());
      if (consoleKeyInfo.Key.Equals((object) ConsoleKey.UpArrow) && this.OnUpPressed != null)
        this.OnUpPressed((object) this, new EventArgs());
      if (consoleKeyInfo.Key.Equals((object) ConsoleKey.DownArrow) && this.OnDownPressed != null)
        this.OnDownPressed((object) this, new EventArgs());
      if (consoleKeyInfo.Key.Equals((object) ConsoleKey.Enter) && this.OnEnterPressed != null)
        this.OnEnterPressed((object) this, new EventArgs());
    }

    public void RunProcessInput()
    {
      if (!Console.KeyAvailable)
        return;
      ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
      while (Console.KeyAvailable)
        Console.ReadKey();
      if (consoleKeyInfo.Key.Equals((object) ConsoleKey.LeftArrow) && this.OnLeftPressed != null)
        this.OnLeftPressed((object) this, new EventArgs());
      if (consoleKeyInfo.Key.Equals((object) ConsoleKey.RightArrow) && this.OnRightPressed != null)
        this.OnRightPressed((object) this, new EventArgs());
      if (consoleKeyInfo.Key.Equals((object) ConsoleKey.Spacebar) && this.OnActionPressed != null)
        this.OnActionPressed((object) this, new EventArgs());
      if (consoleKeyInfo.Key.Equals((object) ConsoleKey.Escape) && this.OnEscapePressed != null)
        this.OnEscapePressed((object) this, new EventArgs());
    }
  }
}
