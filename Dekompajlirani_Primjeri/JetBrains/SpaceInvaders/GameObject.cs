// Decompiled with JetBrains decompiler
// Type: SpaceInvaders.GameObject
// Assembly: SpaceInvaders, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 88196E59-E302-49B4-949B-B569AF858054
// Assembly location: C:\Users\Petar\OneDrive\Desktop\C#PRIMJERI\spaceinvaders\SpaceInvaders\bin\Debug\SpaceInvaders.exe

using System.Collections.Generic;

namespace SpaceInvaders
{
  public abstract class GameObject : IRenderable
  {
    public int life = 1;
    protected char[,] image;
    protected MatrixPosition topLeft;

    public MatrixPosition TopLeft
    {
      get
      {
        return new MatrixPosition(this.topLeft.Row, this.topLeft.Col);
      }
      protected set
      {
        this.topLeft = new MatrixPosition(value.Row, value.Col);
      }
    }

    public bool IsDestroyed { get; protected set; }

    protected GameObject(MatrixPosition topLeft, char[,] image)
    {
      this.TopLeft = topLeft;
      image.GetLength(0);
      image.GetLength(1);
      this.image = this.CopyImageMatrix(image);
      this.IsDestroyed = false;
    }

    private char[,] CopyImageMatrix(char[,] matrixToCopy)
    {
      int length1 = matrixToCopy.GetLength(0);
      int length2 = matrixToCopy.GetLength(1);
      char[,] chArray = new char[length1, length2];
      for (int index1 = 0; index1 < length1; ++index1)
      {
        for (int index2 = 0; index2 < length2; ++index2)
          chArray[index1, index2] = matrixToCopy[index1, index2];
      }
      return chArray;
    }

    public virtual MatrixPosition GetPosition()
    {
      return this.TopLeft;
    }

    public virtual char[,] GetImage()
    {
      return this.CopyImageMatrix(this.image);
    }

    public virtual IEnumerable<GameObject> ProduceObjects()
    {
      return (IEnumerable<GameObject>) new List<GameObject>();
    }

    public virtual void Update()
    {
    }

    public virtual void RespondToCollision(CollisionType collisionType)
    {
    }

    public int Life
    {
      get
      {
        return this.life;
      }
      private set
      {
        this.life = value;
      }
    }

    protected void Destroy()
    {
      --this.life;
      if (this.life != 0)
        return;
      this.IsDestroyed = true;
    }
  }
}
