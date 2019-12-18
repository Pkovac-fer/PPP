// Decompiled with JetBrains decompiler
// Type: SpaceInvaders.PlayerShip
// Assembly: SpaceInvaders, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 88196E59-E302-49B4-949B-B569AF858054
// Assembly location: C:\Users\Petar\OneDrive\Desktop\C#PRIMJERI\spaceinvaders\SpaceInvaders\bin\Debug\SpaceInvaders.exe

using System.Collections.Generic;

namespace SpaceInvaders
{
  public class PlayerShip : GameObject
  {
    private static PlayerShip instance;
    private bool isShooting;

    public int Score { get; protected set; }

    protected PlayerShip(MatrixPosition topLeft)
      : base(topLeft, new char[1, 1]{ { '^' } })
    {
      this.isShooting = false;
      this.life = 3;
      this.Score = 0;
    }

    public static PlayerShip Instance(MatrixPosition position)
    {
      if (PlayerShip.instance == null)
        PlayerShip.instance = new PlayerShip(position);
      return PlayerShip.instance;
    }

    public void IncreaseScore(int bonus)
    {
      this.Score += bonus;
    }

    public void BonusLife()
    {
      ++this.life;
    }

    public bool IsShooting
    {
      get
      {
        return this.isShooting;
      }
      set
      {
        this.isShooting = value;
      }
    }

    public void MoveLeft()
    {
      --this.topLeft.Col;
    }

    public void MoveRight()
    {
      ++this.topLeft.Col;
    }

    public override IEnumerable<GameObject> ProduceObjects()
    {
      List<GameObject> gameObjectList = new List<GameObject>();
      if (this.isShooting)
      {
        gameObjectList.Add((GameObject) new Projectile(new MatrixPosition(this.topLeft.Row, this.topLeft.Col), new MatrixPosition(-1, 0))
        {
          Owner = ProjectileOwner.Player
        });
        this.isShooting = false;
      }
      return (IEnumerable<GameObject>) gameObjectList;
    }

    public override void RespondToCollision(CollisionType collisionType)
    {
      this.Destroy();
    }
  }
}
