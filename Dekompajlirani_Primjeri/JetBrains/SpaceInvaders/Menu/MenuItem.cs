// Decompiled with JetBrains decompiler
// Type: SpaceInvaders.MenuItem
// Assembly: SpaceInvaders, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 88196E59-E302-49B4-949B-B569AF858054
// Assembly location: C:\Users\Petar\OneDrive\Desktop\C#PRIMJERI\spaceinvaders\SpaceInvaders\bin\Debug\SpaceInvaders.exe

namespace SpaceInvaders
{
  public abstract class MenuItem : GameObject
  {
    protected char[,] message;

    protected MenuItem(MatrixPosition topLeft, char[,] message)
      : base(topLeft, message)
    {
    }

    public abstract void TakeAction(Engine engine);
  }
}
