using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace SpaceInvaders
{
	public class Engine
	{
		private IRenderer renderer;

		private IUserInterface userInterface;

		private List<GameObject> allObjects;

		private List<MovingObject> movingObjects;

		private List<MovingObject> alienShips;

		private List<GameObject> staticObjects;

		private List<GameObject> menuItems;

		private List<GameInformation> gameInfoFields;

		private PlayerShip playerShip;

		private Cursor cursor;

		private int sleepTime;

		public bool isPaused = true;

		private static Random randomGenerator;

		static Engine()
		{
			Engine.randomGenerator = new Random();
		}

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

		public Engine(IRenderer renderer, IUserInterface userInterface, int sleepTime) : this(renderer, userInterface)
		{
			this.sleepTime = sleepTime;
		}

		private void AddCursor(GameObject newObj)
		{
			this.allObjects.Remove(this.cursor);
			this.staticObjects.Remove(this.cursor);
			this.cursor = newObj as Cursor;
			this.AddStaticObject(newObj);
		}

		private void AddMenuItem(GameObject newObj)
		{
			this.staticObjects.Add(newObj);
			this.allObjects.Add(newObj);
			this.menuItems.Add(newObj);
		}

		private void AddMovingObject(MovingObject newObj)
		{
			this.movingObjects.Add(newObj);
			if (newObj is AlienShip)
			{
				this.alienShips.Add(newObj);
			}
			this.allObjects.Add(newObj);
		}

		public virtual void AddObject(GameObject newObj)
		{
			try
			{
				if (newObj is MovingObject)
				{
					this.AddMovingObject(newObj as MovingObject);
				}
				else if (newObj is PlayerShip)
				{
					this.AddPlayer(newObj);
				}
				else if (newObj is Cursor)
				{
					this.AddCursor(newObj);
				}
				else if (newObj is MenuItem)
				{
					this.AddMenuItem(newObj);
				}
				else if (!(newObj is GameInformation))
				{
					if (newObj is MovingObject)
					{
						throw new InvalidEngineObjectException("The object cannot be added to engine.");
					}
					this.AddStaticObject(newObj);
				}
				else
				{
					this.gameInfoFields.Add(newObj as GameInformation);
					this.allObjects.Add(newObj);
				}
			}
			catch (InvalidEngineObjectException invalidEngineObjectException)
			{
				Console.WriteLine(invalidEngineObjectException.Message);
			}
		}

		private void AddPlayer(GameObject newObj)
		{
			this.allObjects.Remove(this.playerShip);
			this.staticObjects.Remove(this.playerShip);
			this.playerShip = newObj as PlayerShip;
			this.AddStaticObject(newObj);
		}

		private void AddStaticObject(GameObject newObj)
		{
			this.staticObjects.Add(newObj);
			this.allObjects.Add(newObj);
		}

		public virtual void CursorAction()
		{
			foreach (MenuItem item in this.menuItems)
			{
				if (item.TopLeft.Row == this.cursor.TopLeft.Row)
				{
					item.TakeAction(this);
				}
			}
		}

		public void GameOver()
		{
			this.AddObject(new GameInformation(new MatrixPosition(11, 54), "Game Over!"));
		}

		public virtual void MoveCursorDown()
		{
			this.cursor.MoveDown();
		}

		public virtual void MoveCursorUp()
		{
			this.cursor.MoveUp();
		}

		public virtual void MovePlayerShipLeft()
		{
			if (this.playerShip.TopLeft.Col > 1)
			{
				this.playerShip.MoveLeft();
			}
		}

		public virtual void MovePlayerShipRight()
		{
			if (this.playerShip.TopLeft.Col < this.renderer.GetWidth() - 22)
			{
				this.playerShip.MoveRight();
			}
		}

		public virtual void Pause()
		{
			while (true)
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

		public virtual void Run()
		{
			this.isPaused = false;
			while (true)
			{
				if (this.playerShip.IsDestroyed)
				{
					break;
				}
				this.renderer.RenderAll();
				foreach (GameInformation info in this.gameInfoFields)
				{
					if (info is Score)
					{
						int score = this.playerShip.Score;
						info.RefreshMessage(string.Concat("Score: ", score.ToString()));
					}
					if (info is Lifes)
					{
						string lifes = "";
						for (int i = 0; i < this.playerShip.Life; i++)
						{
							lifes = string.Concat(lifes, "♥");
						}
						info.RefreshMessage(string.Concat("Lifes: ", lifes));
					}
				}
				Thread.Sleep(this.sleepTime);
				this.userInterface.RunProcessInput();
				this.renderer.ClearQueue();
				foreach (GameObject allObject in this.allObjects)
				{
					allObject.Update();
					this.renderer.EnqueueForRendering(allObject);
				}
				CollisionDispatcher.HandleCollisions(this.movingObjects, this.staticObjects, this.alienShips, this.playerShip);
				List<GameObject> producedObjects = new List<GameObject>();
				foreach (GameObject gameObject in this.allObjects)
				{
					producedObjects.AddRange(gameObject.ProduceObjects());
				}
				this.allObjects.RemoveAll((GameObject obj) => obj.IsDestroyed);
				this.movingObjects.RemoveAll((MovingObject obj) => obj.IsDestroyed);
				this.staticObjects.RemoveAll((GameObject obj) => obj.IsDestroyed);
				this.alienShips.RemoveAll((MovingObject obj) => obj.IsDestroyed);
				foreach (GameObject gameObject1 in producedObjects)
				{
					this.AddObject(gameObject1);
				}
			}
			this.GameOver();
		}

		public virtual void Shoot()
		{
			this.playerShip.IsShooting = true;
		}
	}
}