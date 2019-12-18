// Decompiled with JetBrains decompiler
// Type: SpaceInvaders.Engine
// Assembly: SpaceInvaders, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 88196E59-E302-49B4-949B-B569AF858054
// Assembly location: C:\Users\Petar\OneDrive\Desktop\C#PRIMJERI\spaceinvaders\SpaceInvaders\bin\Debug\SpaceInvaders.exe

using System;
using System.Collections.Generic;
using System.Threading;

namespace SpaceInvaders
{
  public class Engine
  {
    private static Random randomGenerator = new Random();
    public bool isPaused = true;
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

    public Engine(IRenderer renderer, IUserInterface userInterface, int sleepTime)
      : this(renderer, userInterface)
    {
      this.sleepTime = sleepTime;
    }

    public virtual void AddObject(GameObject newObj)
    {
      try
      {
        if (newObj is MovingObject)
          this.AddMovingObject(newObj as MovingObject);
        else if (newObj is PlayerShip)
          this.AddPlayer(newObj);
        else if (newObj is Cursor)
          this.AddCursor(newObj);
        else if (newObj is MenuItem)
          this.AddMenuItem(newObj);
        else if (newObj is GameInformation)
        {
          this.gameInfoFields.Add(newObj as GameInformation);
          this.allObjects.Add(newObj);
        }
        else
        {
          if (newObj is MovingObject)
            throw new InvalidEngineObjectException("The object cannot be added to engine.");
          this.AddStaticObject(newObj);
        }
      }
      catch (InvalidEngineObjectException ex)
      {
        Console.WriteLine(ex.Message);
      }
    }

    private void AddMenuItem(GameObject newObj)
    {
      this.staticObjects.Add(newObj);
      this.allObjects.Add(newObj);
      this.menuItems.Add(newObj);
    }

    private void AddCursor(GameObject newObj)
    {
      this.allObjects.Remove((GameObject) this.cursor);
      this.staticObjects.Remove((GameObject) this.cursor);
      this.cursor = newObj as Cursor;
      this.AddStaticObject(newObj);
    }

    private void AddPlayer(GameObject newObj)
    {
      this.allObjects.Remove((GameObject) this.playerShip);
      this.staticObjects.Remove((GameObject) this.playerShip);
      this.playerShip = newObj as PlayerShip;
      this.AddStaticObject(newObj);
    }

    private void AddStaticObject(GameObject newObj)
    {
      this.staticObjects.Add(newObj);
      this.allObjects.Add(newObj);
    }

    private void AddMovingObject(MovingObject newObj)
    {
      this.movingObjects.Add(newObj);
      if (newObj is AlienShip)
        this.alienShips.Add(newObj);
      this.allObjects.Add((GameObject) newObj);
    }

    public virtual void MoveCursorUp()
    {
      this.cursor.MoveUp();
    }

    public virtual void MoveCursorDown()
    {
      this.cursor.MoveDown();
    }

    public virtual void CursorAction()
    {
      foreach (MenuItem menuItem in this.menuItems)
      {
        if (menuItem.TopLeft.Row == this.cursor.TopLeft.Row)
          menuItem.TakeAction(this);
      }
    }

    public virtual void MovePlayerShipLeft()
    {
      if (this.playerShip.TopLeft.Col <= 1)
        return;
      this.playerShip.MoveLeft();
    }

    public virtual void MovePlayerShipRight()
    {
      if (this.playerShip.TopLeft.Col >= this.renderer.GetWidth() - 22)
        return;
      this.playerShip.MoveRight();
    }

    public virtual void Shoot()
    {
      this.playerShip.IsShooting = true;
    }

    public void GameOver()
    {
      this.AddObject((GameObject) new GameInformation(new MatrixPosition(11, 54), "Game Over!"));
    }

    public virtual void Pause()
    {
label_5:
      this.renderer.RenderAll();
      Thread.Sleep(this.sleepTime);
      this.userInterface.PauseProcessInput();
      this.renderer.ClearQueue();
      using (List<GameObject>.Enumerator enumerator = this.allObjects.GetEnumerator())
      {
        while (enumerator.MoveNext())
          this.renderer.EnqueueForRendering((IRenderable) enumerator.Current);
        goto label_5;
      }
    }

    public virtual void Run()
    {
      this.isPaused = false;
label_29:
      if (this.playerShip.IsDestroyed)
      {
        this.GameOver();
      }
      else
      {
        this.renderer.RenderAll();
        foreach (GameInformation gameInfoField in this.gameInfoFields)
        {
          if (gameInfoField is Score)
            gameInfoField.RefreshMessage("Score: " + this.playerShip.Score.ToString());
          if (gameInfoField is Lifes)
          {
            string str = "";
            for (int index = 0; index < this.playerShip.Life; ++index)
              str += "♥";
            gameInfoField.RefreshMessage("Lifes: " + str);
          }
        }
        Thread.Sleep(this.sleepTime);
        int num = 0 + 1;
        this.userInterface.RunProcessInput();
        this.renderer.ClearQueue();
        foreach (GameObject allObject in this.allObjects)
        {
          allObject.Update();
          this.renderer.EnqueueForRendering((IRenderable) allObject);
        }
        CollisionDispatcher.HandleCollisions(this.movingObjects, this.staticObjects, this.alienShips, this.playerShip);
        List<GameObject> gameObjectList = new List<GameObject>();
        foreach (GameObject allObject in this.allObjects)
          gameObjectList.AddRange(allObject.ProduceObjects());
        this.allObjects.RemoveAll((Predicate<GameObject>) (obj => obj.IsDestroyed));
        this.movingObjects.RemoveAll((Predicate<MovingObject>) (obj => obj.IsDestroyed));
        this.staticObjects.RemoveAll((Predicate<GameObject>) (obj => obj.IsDestroyed));
        this.alienShips.RemoveAll((Predicate<MovingObject>) (obj => obj.IsDestroyed));
        using (List<GameObject>.Enumerator enumerator = gameObjectList.GetEnumerator())
        {
          while (enumerator.MoveNext())
            this.AddObject(enumerator.Current);
          goto label_29;
        }
      }
    }
  }
}
