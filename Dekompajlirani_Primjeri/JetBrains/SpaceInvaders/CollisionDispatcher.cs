// Decompiled with JetBrains decompiler
// Type: SpaceInvaders.CollisionDispatcher
// Assembly: SpaceInvaders, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 88196E59-E302-49B4-949B-B569AF858054
// Assembly location: C:\Users\Petar\OneDrive\Desktop\C#PRIMJERI\spaceinvaders\SpaceInvaders\bin\Debug\SpaceInvaders.exe

using System.Collections.Generic;

namespace SpaceInvaders
{
  public static class CollisionDispatcher
  {
    public static void HandleCollisions(
      List<MovingObject> movingObjects,
      List<GameObject> staticObjects,
      List<MovingObject> alienShips,
      PlayerShip playerShip)
    {
      foreach (MovingObject movingObject in movingObjects)
      {
        if (movingObject is Projectile)
        {
          if ((movingObject as Projectile).Owner == ProjectileOwner.Player)
          {
            foreach (MovingObject alienShip in alienShips)
            {
              if (movingObject.TopLeft.Row == alienShip.TopLeft.Row && movingObject.TopLeft.Col == alienShip.TopLeft.Col)
              {
                alienShip.RespondToCollision(CollisionType.Destruction);
                movingObject.RespondToCollision(CollisionType.Destruction);
                playerShip.IncreaseScore(1);
              }
            }
            foreach (GameObject staticObject in staticObjects)
            {
              if (movingObject.TopLeft.Row == staticObject.TopLeft.Row + 1 && movingObject.TopLeft.Col == staticObject.TopLeft.Col)
                movingObject.RespondToCollision(CollisionType.Destruction);
            }
          }
          else if (movingObject.TopLeft.Row == playerShip.TopLeft.Row && movingObject.TopLeft.Col == playerShip.TopLeft.Col)
          {
            playerShip.RespondToCollision(CollisionType.Destruction);
            movingObject.RespondToCollision(CollisionType.Destruction);
          }
          foreach (GameObject staticObject in staticObjects)
          {
            if (!(staticObject is PlayerShip) && (movingObject.TopLeft.Row == staticObject.TopLeft.Row - 1 && movingObject.TopLeft.Col == staticObject.TopLeft.Col))
              movingObject.RespondToCollision(CollisionType.Destruction);
          }
        }
      }
      foreach (MovingObject movingObject in movingObjects)
      {
        if (movingObject is AlienShip && CollisionDispatcher.CollidesWithWall(movingObject, staticObjects))
        {
          CollisionDispatcher.ChangeAliensDirection(movingObjects);
          break;
        }
        if (movingObject is Gift)
        {
          if (movingObject is GiftPoints && (movingObject.TopLeft.Row == playerShip.TopLeft.Row && movingObject.TopLeft.Col == playerShip.TopLeft.Col))
          {
            playerShip.IncreaseScore(10);
            movingObject.RespondToCollision(CollisionType.Destruction);
          }
          if (movingObject is GiftLife && (movingObject.TopLeft.Row == playerShip.TopLeft.Row && movingObject.TopLeft.Col == playerShip.TopLeft.Col))
          {
            playerShip.BonusLife();
            movingObject.RespondToCollision(CollisionType.Destruction);
          }
        }
      }
    }

    private static void ChangeAliensDirection(List<MovingObject> movingObjects)
    {
      foreach (MovingObject movingObject in movingObjects)
      {
        if (movingObject is AlienShip)
          movingObject.RespondToCollision(CollisionType.Bounce);
      }
    }

    private static bool CollidesWithWall(MovingObject obj, List<GameObject> staticObjects)
    {
      foreach (GameObject staticObject in staticObjects)
      {
        if (staticObject is Wall && obj.TopLeft.Row == staticObject.TopLeft.Row && (obj.TopLeft.Col - 1 == staticObject.TopLeft.Col || obj.TopLeft.Col + 1 == staticObject.TopLeft.Col))
          return true;
      }
      return false;
    }
  }
}
