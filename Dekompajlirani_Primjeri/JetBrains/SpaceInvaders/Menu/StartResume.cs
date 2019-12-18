// Decompiled with JetBrains decompiler
// Type: SpaceInvaders.StartResume
// Assembly: SpaceInvaders, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 88196E59-E302-49B4-949B-B569AF858054
// Assembly location: C:\Users\Petar\OneDrive\Desktop\C#PRIMJERI\spaceinvaders\SpaceInvaders\bin\Debug\SpaceInvaders.exe

namespace SpaceInvaders
{
  public class StartResume : MenuItem
  {
    public new static char[,] message = new char[1, 12]
    {
      {
        'S',
        'T',
        'A',
        'R',
        'T',
        '/',
        'R',
        'E',
        'S',
        'U',
        'M',
        'E'
      }
    };

    public StartResume(MatrixPosition topLeft)
      : base(topLeft, StartResume.message)
    {
    }

    public override void TakeAction(Engine engine)
    {
      engine.Run();
    }
  }
}
