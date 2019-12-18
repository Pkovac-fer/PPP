using System;
using System.Collections.Generic;

namespace SpaceInvaders
{
	public static class CollisionDispatcher
	{
		private static void ChangeAliensDirection(List<MovingObject> movingObjects)
		{
			foreach (MovingObject alien in movingObjects)
			{
				if (alien is AlienShip)
				{
					alien.RespondToCollision(CollisionType.Bounce);
				}
			}
		}

		private static bool CollidesWithWall(MovingObject obj, List<GameObject> staticObjects)
		{
			bool flag;
			foreach (GameObject staticObj in staticObjects)
			{
				if ((!(staticObj is Wall) ? false : obj.TopLeft.Row == staticObj.TopLeft.Row))
				{
					if (obj.TopLeft.Col - 1 == staticObj.TopLeft.Col)
					{
						flag = true;
						return flag;
					}
					else if (obj.TopLeft.Col + 1 == staticObj.TopLeft.Col)
					{
						flag = true;
						return flag;
					}
				}
			}
			flag = false;
			return flag;
		}

		public static void HandleCollisions(List<MovingObject> movingObjects, List<GameObject> staticObjects, List<MovingObject> alienShips, PlayerShip playerShip)
		{
			foreach (MovingObject obj in movingObjects)
			{
				if (obj is Projectile)
				{
					if ((obj as Projectile).Owner == ProjectileOwner.Player)
					{
						foreach (MovingObject alien in alienShips)
						{
							if ((obj.TopLeft.Row != alien.TopLeft.Row ? false : obj.TopLeft.Col == alien.TopLeft.Col))
							{
								alien.RespondToCollision(CollisionType.Destruction);
								obj.RespondToCollision(CollisionType.Destruction);
								playerShip.IncreaseScore(1);
							}
						}
						foreach (GameObject staticObj in staticObjects)
						{
							if ((obj.TopLeft.Row != staticObj.TopLeft.Row + 1 ? false : obj.TopLeft.Col == staticObj.TopLeft.Col))
							{
								obj.RespondToCollision(CollisionType.Destruction);
							}
						}
					}
					else if ((obj.TopLeft.Row != playerShip.TopLeft.Row ? false : obj.TopLeft.Col == playerShip.TopLeft.Col))
					{
						playerShip.RespondToCollision(CollisionType.Destruction);
						obj.RespondToCollision(CollisionType.Destruction);
					}
					foreach (GameObject staticObj in staticObjects)
					{
						if (!(staticObj is PlayerShip))
						{
							if ((obj.TopLeft.Row != staticObj.TopLeft.Row - 1 ? false : obj.TopLeft.Col == staticObj.TopLeft.Col))
							{
								obj.RespondToCollision(CollisionType.Destruction);
							}
						}
					}
				}
			}
			foreach (MovingObject obj in movingObjects)
			{
				if (obj is AlienShip)
				{
					if (CollisionDispatcher.CollidesWithWall(obj, staticObjects))
					{
						CollisionDispatcher.ChangeAliensDirection(movingObjects);
						break;
					}
				}
				if (obj is Gift)
				{
					if (obj is GiftPoints)
					{
						if ((obj.TopLeft.Row != playerShip.TopLeft.Row ? false : obj.TopLeft.Col == playerShip.TopLeft.Col))
						{
							playerShip.IncreaseScore(10);
							obj.RespondToCollision(CollisionType.Destruction);
						}
					}
					if (obj is GiftLife)
					{
						if ((obj.TopLeft.Row != playerShip.TopLeft.Row ? false : obj.TopLeft.Col == playerShip.TopLeft.Col))
						{
							playerShip.BonusLife();
							obj.RespondToCollision(CollisionType.Destruction);
						}
					}
				}
			}
		}
	}
}