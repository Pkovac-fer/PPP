// Decompiled with JetBrains decompiler
// Type: SpaceInvaders.Gift
// Assembly: SpaceInvaders, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 88196E59-E302-49B4-949B-B569AF858054
// Assembly location: C:\Users\Petar\OneDrive\Desktop\C#PRIMJERI\spaceinvaders\SpaceInvaders\bin\Debug\SpaceInvaders.exe

namespace SpaceInvaders
{
  public class Gift : MovingObject
  {
    public Gift(MatrixPosition topLeft, MatrixPosition speed)
      : base(topLeft, new char[1, 1]{ { 'G' } }, speed)
    {
      this.framesPerMove = 5;
    }

    public Gift(MatrixPosition topLeft, char[,] image, MatrixPosition speed)
      : base(topLeft, image, speed)
    {
      this.framesPerMove = 5;
    }

    public override void RespondToCollision(CollisionType collisionType)
    {
      if (collisionType != CollisionType.Destruction)
        return;
      this.Destroy();
    }
  }
}
