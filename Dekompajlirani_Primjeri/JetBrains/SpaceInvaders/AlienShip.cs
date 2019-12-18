// Decompiled with JetBrains decompiler
// Type: SpaceInvaders.AlienShip
// Assembly: SpaceInvaders, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 88196E59-E302-49B4-949B-B569AF858054
// Assembly location: C:\Users\Petar\OneDrive\Desktop\C#PRIMJERI\spaceinvaders\SpaceInvaders\bin\Debug\SpaceInvaders.exe

using System.Collections.Generic;

namespace SpaceInvaders
{
  public class AlienShip : MovingObject
  {
    public bool IsShooting { get; set; }

    public AlienShip(MatrixPosition topLeft, MatrixPosition speed)
      : base(topLeft, new char[1, 1]{ { '@' } }, speed)
    {
      this.framesPerMove = 5;
    }

    private void ChangeSymbol()
    {
      switch (this.life)
      {
        case 1:
          this.image[0, 0] = '@';
          break;
        case 2:
          this.image[0, 0] = '?';
          break;
        case 3:
          this.image[0, 0] = '~';
          break;
      }
    }

    public override void RespondToCollision(CollisionType collisionType)
    {
      if (collisionType == CollisionType.Bounce && this.currentFrame == 0)
      {
        this.Speed.Col *= -1;
        ++this.topLeft.Row;
      }
      if (collisionType != CollisionType.Destruction)
        return;
      this.Destroy();
      this.ChangeSymbol();
    }

    public override IEnumerable<GameObject> ProduceObjects()
    {
      List<GameObject> gameObjectList = new List<GameObject>();
      if (this.IsShooting)
      {
        gameObjectList.Add((GameObject) new Projectile(this.topLeft, new MatrixPosition(1, 0))
        {
          Owner = ProjectileOwner.Alien
        });
        this.IsShooting = false;
      }
      Gift gift1 = new Gift(new MatrixPosition(0, 0), new MatrixPosition(0, 0));
      if (this.IsDestroyed)
      {
        Gift gift2 = GameData.GetGift();
        if (gift2 is GiftLife)
        {
          gift2 = (Gift) new GiftLife(new MatrixPosition(this.TopLeft.Row + 1, this.TopLeft.Col), new MatrixPosition(1, 0));
          gameObjectList.Add((GameObject) gift2);
        }
        if (gift2 is GiftPoints)
        {
          Gift gift3 = (Gift) new GiftPoints(new MatrixPosition(this.TopLeft.Row + 1, this.TopLeft.Col), new MatrixPosition(1, 0));
          gameObjectList.Add((GameObject) gift3);
        }
      }
      return (IEnumerable<GameObject>) gameObjectList;
    }

    public override void Update()
    {
      if (GameData.ShootingProbability())
        this.IsShooting = true;
      this.UpdatePosition();
    }
  }
}
