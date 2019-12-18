// Decompiled with JetBrains decompiler
// Type: Pacman_Zagorschi_Franco.Program
// Assembly: Pacman_Zagorschi_Franco, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E1912E80-659D-41AE-B9F0-CD405BA0A8F1
// Assembly location: C:\Users\Petar\OneDrive\Desktop\C#PRIMJERI\Pacman game in c#\Pacman_Zagorschi_Franco\bin\Debug\Pacman_Zagorschi_Franco.exe

using System;
using System.Windows.Forms;

namespace Pacman_Zagorschi_Franco
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new Form1());
    }
  }
}
