﻿// Decompiled with JetBrains decompiler
// Type: SpaceInvaders.IRenderer
// Assembly: SpaceInvaders, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 88196E59-E302-49B4-949B-B569AF858054
// Assembly location: C:\Users\Petar\OneDrive\Desktop\C#PRIMJERI\spaceinvaders\SpaceInvaders\bin\Debug\SpaceInvaders.exe

namespace SpaceInvaders
{
  public interface IRenderer
  {
    void EnqueueForRendering(IRenderable obj);

    void RenderAll();

    void ClearQueue();

    int GetWidth();
  }
}
