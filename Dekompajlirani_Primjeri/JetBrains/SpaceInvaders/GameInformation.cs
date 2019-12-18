// Decompiled with JetBrains decompiler
// Type: SpaceInvaders.GameInformation
// Assembly: SpaceInvaders, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 88196E59-E302-49B4-949B-B569AF858054
// Assembly location: C:\Users\Petar\OneDrive\Desktop\C#PRIMJERI\spaceinvaders\SpaceInvaders\bin\Debug\SpaceInvaders.exe

namespace SpaceInvaders
{
  public class GameInformation : GameObject
  {
    public GameInformation(MatrixPosition topLeft, string msg)
      : base(topLeft, new char[1, 1]{ { 'a' } })
    {
      char[] charArray = msg.ToCharArray();
      this.image = new char[1, charArray.Length];
      for (int index = 0; index < charArray.Length; ++index)
        this.image[0, index] = charArray[index];
      this.topLeft = topLeft;
    }

    public virtual void RefreshMessage(string msg)
    {
      char[] charArray = msg.ToCharArray();
      this.image = new char[1, charArray.Length];
      for (int index = 0; index < charArray.Length; ++index)
        this.image[0, index] = charArray[index];
    }
  }
}
