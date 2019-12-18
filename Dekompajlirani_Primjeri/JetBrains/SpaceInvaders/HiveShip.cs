// Decompiled with JetBrains decompiler
// Type: SpaceInvaders.HiveShip
// Assembly: SpaceInvaders, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 88196E59-E302-49B4-949B-B569AF858054
// Assembly location: C:\Users\Petar\OneDrive\Desktop\C#PRIMJERI\spaceinvaders\SpaceInvaders\bin\Debug\SpaceInvaders.exe

namespace SpaceInvaders
{
  public class HiveShip : AlienShip
  {
    public HiveShip(MatrixPosition topLeft, MatrixPosition speed)
      : base(topLeft, speed)
    {
      this.image = new char[1, 1]{ { '&' } };
      this.life = 5;
    }
  }
}
