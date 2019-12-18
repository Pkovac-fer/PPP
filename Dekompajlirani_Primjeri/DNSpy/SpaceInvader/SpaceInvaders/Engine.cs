using System;
using System.Collections.Generic;
using System.Threading;

namespace SpaceInvaders
{
	// Token: 0x02000008 RID: 8
	public class Engine
	{
		// Token: 0x06000010 RID: 16 RVA: 0x00002898 File Offset: 0x00000A98
		public Engine(IRenderer renderer, IUserInterface userInterface)
		{
			this.renderer = renderer;
			this.userInterface = userInterface;
			this.allObjects = new List<GameObject>();
			this.movingObjects = new List<MovingObject>();
			this.alienShips = new List<MovingObject>();
			this.staticObjects = new List<GameObject>();
			this.menuItems = new List<GameObject>();
			this.gameInfoFields = new List<GameInformation>();
			this.sleepTime = 100;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000290C File Offset: 0x00000B0C
		public Engine(IRenderer renderer, IUserInterface userInterface, int sleepTime) : this(renderer, userInterface)
		{
			this.sleepTime = sleepTime;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002920 File Offset: 0x00000B20
		public virtual void AddObject(GameObject newObj)
		{
			try
			{
				bool flag = newObj is MovingObject;
				if (flag)
				{
					this.AddMovingObject(newObj as MovingObject);
				}
				else
				{
					bool flag2 = newObj is PlayerShip;
					if (flag2)
					{
						this.AddPlayer(newObj);
					}
					else
					{
						bool flag3 = newObj is Cursor;
						if (flag3)
						{
							this.AddCursor(newObj);
						}
						else
						{
							bool flag4 = newObj is MenuItem;
							if (flag4)
							{
								this.AddMenuItem(newObj);
							}
							else
							{
								bool flag5 = newObj is GameInformation;
								if (flag5)
								{
									this.gameInfoFields.Add(newObj as GameInformation);
									this.allObjects.Add(newObj);
								}
								else
								{
									bool flag6 = !(newObj is MovingObject);
									if (!flag6)
									{
										throw new InvalidEngineObjectException("The object cannot be added to engine.");
									}
									this.AddStaticObject(newObj);
								}
							}
						}
					}
				}
			}
			catch (InvalidEngineObjectException ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002A20 File Offset: 0x00000C20
		private void AddMenuItem(GameObject newObj)
		{
			this.staticObjects.Add(newObj);
			this.allObjects.Add(newObj);
			this.menuItems.Add(newObj);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002A4A File Offset: 0x00000C4A
		private void AddCursor(GameObject newObj)
		{
			this.allObjects.Remove(this.cursor);
			this.staticObjects.Remove(this.cursor);
			this.cursor = (newObj as Cursor);
			this.AddStaticObject(newObj);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002A85 File Offset: 0x00000C85
		private void AddPlayer(GameObject newObj)
		{
			this.allObjects.Remove(this.playerShip);
			this.staticObjects.Remove(this.playerShip);
			this.playerShip = (newObj as PlayerShip);
			this.AddStaticObject(newObj);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002AC0 File Offset: 0x00000CC0
		private void AddStaticObject(GameObject newObj)
		{
			this.staticObjects.Add(newObj);
			this.allObjects.Add(newObj);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002AE0 File Offset: 0x00000CE0
		private void AddMovingObject(MovingObject newObj)
		{
			this.movingObjects.Add(newObj);
			bool flag = newObj is AlienShip;
			if (flag)
			{
				this.alienShips.Add(newObj);
			}
			this.allObjects.Add(newObj);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002B24 File Offset: 0x00000D24
		public virtual void MoveCursorUp()
		{
			this.cursor.MoveUp();
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002B33 File Offset: 0x00000D33
		public virtual void MoveCursorDown()
		{
			this.cursor.MoveDown();
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002B44 File Offset: 0x00000D44
		public virtual void CursorAction()
		{
			foreach (GameObject gameObject in this.menuItems)
			{
				MenuItem item = (MenuItem)gameObject;
				bool flag = item.TopLeft.Row == this.cursor.TopLeft.Row;
				if (flag)
				{
					item.TakeAction(this);
				}
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002BC8 File Offset: 0x00000DC8
		public virtual void MovePlayerShipLeft()
		{
			bool flag = this.playerShip.TopLeft.Col > 1;
			if (flag)
			{
				this.playerShip.MoveLeft();
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002BFC File Offset: 0x00000DFC
		public virtual void MovePlayerShipRight()
		{
			bool flag = this.playerShip.TopLeft.Col < this.renderer.GetWidth() - 22;
			if (flag)
			{
				this.playerShip.MoveRight();
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002C3C File Offset: 0x00000E3C
		public virtual void Shoot()
		{
			this.playerShip.IsShooting = true;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002C4C File Offset: 0x00000E4C
		public void GameOver()
		{
			GameInformation gameOver = new GameInformation(new MatrixPosition(11, 54), "Game Over!");
			this.AddObject(gameOver);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002C78 File Offset: 0x00000E78
		public virtual void Pause()
		{
			for (;;)
			{
				this.renderer.RenderAll();
				Thread.Sleep(this.sleepTime);
				this.userInterface.PauseProcessInput();
				this.renderer.ClearQueue();
				foreach (GameObject obj in this.allObjects)
				{
					this.renderer.EnqueueForRendering(obj);
				}
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002D10 File Offset: 0x00000F10
		public virtual void Run()
		{
			this.isPaused = false;
			for (;;)
			{
				bool isDestroyed = this.playerShip.IsDestroyed;
				if (isDestroyed)
				{
					break;
				}
				this.renderer.RenderAll();
				foreach (GameInformation info in this.gameInfoFields)
				{
					bool flag = info is Score;
					if (flag)
					{
						info.RefreshMessage("Score: " + this.playerShip.Score.ToString());
					}
					bool flag2 = info is Lifes;
					if (flag2)
					{
						string lifes = "";
						for (int i = 0; i < this.playerShip.Life; i++)
						{
							lifes += "♥";
						}
						info.RefreshMessage("Lifes: " + lifes);
					}
				}
				Thread.Sleep(this.sleepTime);
				int count = 0;
				count++;
				this.userInterface.RunProcessInput();
				this.renderer.ClearQueue();
				foreach (GameObject obj4 in this.allObjects)
				{
					obj4.Update();
					this.renderer.EnqueueForRendering(obj4);
				}
				CollisionDispatcher.HandleCollisions(this.movingObjects, this.staticObjects, this.alienShips, this.playerShip);
				List<GameObject> producedObjects = new List<GameObject>();
				foreach (GameObject obj2 in this.allObjects)
				{
					producedObjects.AddRange(obj2.ProduceObjects());
				}
				this.allObjects.RemoveAll((GameObject obj) => obj.IsDestroyed);
				this.movingObjects.RemoveAll((MovingObject obj) => obj.IsDestroyed);
				this.staticObjects.RemoveAll((GameObject obj) => obj.IsDestroyed);
				this.alienShips.RemoveAll((MovingObject obj) => obj.IsDestroyed);
				foreach (GameObject obj3 in producedObjects)
				{
					this.AddObject(obj3);
				}
			}
			this.GameOver();
		}

		// Token: 0x04000008 RID: 8
		private IRenderer renderer;

		// Token: 0x04000009 RID: 9
		private IUserInterface userInterface;

		// Token: 0x0400000A RID: 10
		private List<GameObject> allObjects;

		// Token: 0x0400000B RID: 11
		private List<MovingObject> movingObjects;

		// Token: 0x0400000C RID: 12
		private List<MovingObject> alienShips;

		// Token: 0x0400000D RID: 13
		private List<GameObject> staticObjects;

		// Token: 0x0400000E RID: 14
		private List<GameObject> menuItems;

		// Token: 0x0400000F RID: 15
		private List<GameInformation> gameInfoFields;

		// Token: 0x04000010 RID: 16
		private PlayerShip playerShip;

		// Token: 0x04000011 RID: 17
		private Cursor cursor;

		// Token: 0x04000012 RID: 18
		private int sleepTime;

		// Token: 0x04000013 RID: 19
		public bool isPaused = true;

		// Token: 0x04000014 RID: 20
		private static Random randomGenerator = new Random();
	}
}
