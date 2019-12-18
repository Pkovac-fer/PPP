// Decompiled with JetBrains decompiler
// Type: SpaceInvaders.Cursor
// Assembly: SpaceInvaders, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 88196E59-E302-49B4-949B-B569AF858054
// Assembly location: C:\Users\Petar\OneDrive\Desktop\C#PRIMJERI\spaceinvaders\SpaceInvaders\bin\Debug\SpaceInvaders.exe

namespace SpaceInvaders
{
  public class Cursor : GameObject
  {
    public bool isActive;

    public bool IsActive
    {
      get
      {
        return this.isActive;
      }
      set
      {
        this.isActive = value;
      }
    }

    public Cursor(MatrixPosition topLeft)
      : base(topLeft, new char[1, 2]{ { '>', '>' } })
    {
      this.isActive = false;
    }

    public void MoveUp()
    {
      if (this.topLeft.Row <= 3)
        return;
      this.topLeft.Row -= 2;
    }

    public void MoveDown()
    {
      this.topLeft.Row += 2;
    }
  }
}
