using System;
using System.Collections.Generic;

namespace SpaceInvaders
{
	// Token: 0x02000003 RID: 3
	public static class CollisionDispatcher
	{
		// Token: 0x06000002 RID: 2 RVA: 0x0000207C File Offset: 0x0000027C
		public static void HandleCollisions(List<MovingObject> movingObjects, List<GameObject> staticObjects, List<MovingObject> alienShips, PlayerShip playerShip)
		{
			foreach (MovingObject obj in movingObjects)
			{
				bool flag = obj is Projectile;
				if (flag)
				{
					bool flag2 = (obj as Projectile).Owner == ProjectileOwner.Player;
					if (flag2)
					{
						foreach (MovingObject alien in alienShips)
						{
							bool flag3 = obj.TopLeft.Row == alien.TopLeft.Row && obj.TopLeft.Col == alien.TopLeft.Col;
							if (flag3)
							{
								alien.RespondToCollision(CollisionType.Destruction);
								obj.RespondToCollision(CollisionType.Destruction);
								playerShip.IncreaseScore(1);
							}
						}
						foreach (GameObject staticObj in staticObjects)
						{
							bool flag4 = obj.TopLeft.Row == staticObj.TopLeft.Row + 1 && obj.TopLeft.Col == staticObj.TopLeft.Col;
							if (flag4)
							{
								obj.RespondToCollision(CollisionType.Destruction);
							}
						}
					}
					else
					{
						bool flag5 = obj.TopLeft.Row == playerShip.TopLeft.Row && obj.TopLeft.Col == playerShip.TopLeft.Col;
						if (flag5)
						{
							playerShip.RespondToCollision(CollisionType.Destruction);
							obj.RespondToCollision(CollisionType.Destruction);
						}
					}
					foreach (GameObject staticObj2 in staticObjects)
					{
						bool flag6 = !(staticObj2 is PlayerShip);
						if (flag6)
						{
							bool flag7 = obj.TopLeft.Row == staticObj2.TopLeft.Row - 1 && obj.TopLeft.Col == staticObj2.TopLeft.Col;
							if (flag7)
							{
								obj.RespondToCollision(CollisionType.Destruction);
							}
						}
					}
				}
			}
			foreach (MovingObject obj2 in movingObjects)
			{
				bool flag8 = obj2 is AlienShip;
				if (flag8)
				{
					bool flag9 = CollisionDispatcher.CollidesWithWall(obj2, staticObjects);
					if (flag9)
					{
						CollisionDispatcher.ChangeAliensDirection(movingObjects);
						break;
					}
				}
				bool flag10 = obj2 is Gift;
				if (flag10)
				{
					bool flag11 = obj2 is GiftPoints;
					if (flag11)
					{
						bool flag12 = obj2.TopLeft.Row == playerShip.TopLeft.Row && obj2.TopLeft.Col == playerShip.TopLeft.Col;
						if (flag12)
						{
							playerShip.IncreaseScore(10);
							obj2.RespondToCollision(CollisionType.Destruction);
						}
					}
					bool flag13 = obj2 is GiftLife;
					if (flag13)
					{
						bool flag14 = obj2.TopLeft.Row == playerShip.TopLeft.Row && obj2.TopLeft.Col == playerShip.TopLeft.Col;
						if (flag14)
						{
							playerShip.BonusLife();
							obj2.RespondToCollision(CollisionType.Destruction);
						}
					}
				}
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002474 File Offset: 0x00000674
		private static void ChangeAliensDirection(List<MovingObject> movingObjects)
		{
			foreach (MovingObject alien in movingObjects)
			{
				bool flag = alien is AlienShip;
				if (flag)
				{
					alien.RespondToCollision(CollisionType.Bounce);
				}
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000024D8 File Offset: 0x000006D8
		private static bool CollidesWithWall(MovingObject obj, List<GameObject> staticObjects)
		{
			foreach (GameObject staticObj in staticObjects)
			{
				bool flag = staticObj is Wall && obj.TopLeft.Row == staticObj.TopLeft.Row;
				if (flag)
				{
					bool flag2 = obj.TopLeft.Col - 1 == staticObj.TopLeft.Col;
					if (flag2)
					{
						return true;
					}
					bool flag3 = obj.TopLeft.Col + 1 == staticObj.TopLeft.Col;
					if (flag3)
					{
						return true;
					}
				}
			}
			return false;
		}
	}
}
