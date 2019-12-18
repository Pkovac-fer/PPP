// Decompiled with JetBrains decompiler
// Type: SpaceInvaders.MovingObject
// Assembly: SpaceInvaders, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 88196E59-E302-49B4-949B-B569AF858054
// Assembly location: C:\Users\Petar\OneDrive\Desktop\C#PRIMJERI\spaceinvaders\SpaceInvaders\bin\Debug\SpaceInvaders.exe

namespace SpaceInvaders
{
  public class MovingObject : GameObject
  {
    protected int framesPerMove;
    protected int currentFrame;

    public MatrixPosition Speed { get; protected set; }

    public MovingObject(MatrixPosition topLeft, char[,] image, MatrixPosition speed)
      : base(topLeft, image)
    {
      this.currentFrame = 0;
      this.framesPerMove = 1;
      this.Speed = speed;
    }

    protected virtual void UpdatePosition()
    {
      ++this.currentFrame;
      if (this.currentFrame != this.framesPerMove)
        return;
      this.TopLeft = this.TopLeft + this.Speed;
      this.currentFrame = 0;
    }

    public override void Update()
    {
      this.UpdatePosition();
    }
  }
}
