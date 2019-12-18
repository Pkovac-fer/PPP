// Decompiled with JetBrains decompiler
// Type:  
// Assembly: Pacman_Zagorschi_Franco, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C2E3103A-7060-4739-85EE-FB357D9D720D
// Assembly location: C:\Users\Petar\OneDrive\Desktop\Originalni_Primjeri\Pacman\Pacman_Zagorschi_Franco\bin\Debug\Pacman_Zagorschi_Franco.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public sealed class \u0008\u2000 : Form
{
  public int \u000E\u2000 = 1;
  public bool \u000F\u2004 = true;
  public int \u0006\u2005 = 3;
  public int \u000F\u2006 = 1;
  public int \u0002\u2007 = 2;
  public int \u0003\u2007 = 2;
  public int \u0005\u2007 = 2;
  public int \u0008\u2007 = 2;
  public Random \u0006\u2007 = new Random();
  public List<object> \u000E\u2007 = new List<object>();
  private IContainer \u000F\u2007 = (IContainer) null;
  public int \u0002;
  public int \u0003;
  public int \u0005;
  public int \u0008;
  public int \u0006;
  public int \u000E;
  public int \u000F;
  public int \u0002\u2000;
  public int \u0003\u2000;
  public int \u0005\u2000;
  public int \u0008\u2000;
  public int \u0006\u2000;
  public bool \u000F\u2000;
  public bool \u0002\u2001;
  public bool \u0003\u2001;
  public bool \u0005\u2001;
  public bool \u0008\u2001;
  public bool \u0006\u2001;
  public bool \u000E\u2001;
  public bool \u000F\u2001;
  public bool \u0002\u2002;
  public bool \u0003\u2002;
  public bool \u0005\u2002;
  public bool \u0008\u2002;
  public bool \u0006\u2002;
  public bool \u000E\u2002;
  public bool \u000F\u2002;
  public bool \u0002\u2003;
  public bool \u0003\u2003;
  public bool \u0005\u2003;
  public bool \u0008\u2003;
  public bool \u0006\u2003;
  public bool \u000E\u2003;
  public bool \u000F\u2003;
  public bool \u0002\u2004;
  public bool \u0003\u2004;
  public bool \u0005\u2004;
  public bool \u0008\u2004;
  public bool \u0006\u2004;
  public bool \u000E\u2004;
  public int \u0002\u2005;
  public int \u0003\u2005;
  public int \u0005\u2005;
  public int \u0008\u2005;
  public int \u000E\u2005;
  public int \u000F\u2005;
  public int \u0002\u2006;
  public int \u0003\u2006;
  public int \u0005\u2006;
  public int \u0008\u2006;
  public int \u0006\u2006;
  public int \u000E\u2006;
  private Timer \u0002\u2008;
  private Label \u0003\u2008;
  private Label \u0005\u2008;
  private Label \u0008\u2008;
  private Label \u0006\u2008;
  private Label \u000E\u2008;
  private Label \u000F\u2008;
  private PictureBox \u0002\u2009;
  private PictureBox \u0003\u2009;
  private Label \u0005\u2009;
  private Timer \u0008\u2009;
  private Timer \u0006\u2009;
  private Timer \u000E\u2009;
  private Timer \u000F\u2009;
  private Timer \u0002\u200A;
  private Label \u0003\u200A;
  private Label \u0005\u200A;
  private Label \u0008\u200A;
  private Label \u0006\u200A;
  private Label \u000E\u200A;
  private Label \u000F\u200A;
  private Label \u0002​;
  private Label \u0003​;
  private Label \u0005​;
  private Label \u0008​;
  private Label \u0006​;
  private Label \u000E​;
  private Label \u000F​;
  private Label \u0002\u2000\u2000;
  private Label \u0003\u2000\u2000;
  private Label \u0005\u2000\u2000;
  private Label \u0008\u2000\u2000;
  private Label \u0006\u2000\u2000;
  private Label \u000E\u2000\u2000;
  private Label \u000F\u2000\u2000;
  private Label \u0002\u2001\u2000;
  private Label \u0003\u2001\u2000;
  private Label \u0005\u2001\u2000;
  private Label \u0008\u2001\u2000;
  private Label \u0006\u2001\u2000;
  private Label \u000E\u2001\u2000;
  private Label \u000F\u2001\u2000;
  private Label \u0002\u2002\u2000;
  private Label \u0003\u2002\u2000;
  private Label \u0005\u2002\u2000;
  private Label \u0008\u2002\u2000;
  private Label \u0006\u2002\u2000;
  private Label \u000E\u2002\u2000;
  private Label \u000F\u2002\u2000;
  private Label \u0002\u2003\u2000;
  private Label \u0003\u2003\u2000;
  private Label \u0005\u2003\u2000;
  private Label \u0008\u2003\u2000;
  private Label \u0006\u2003\u2000;
  private Label \u000E\u2003\u2000;
  private Label \u000F\u2003\u2000;
  private Label \u0002\u2004\u2000;
  private Label \u0003\u2004\u2000;
  private Label \u0005\u2004\u2000;
  private Label \u0008\u2004\u2000;
  private Label \u0006\u2004\u2000;
  private Label \u000E\u2004\u2000;
  private Label \u000F\u2004\u2000;
  private Label \u0002\u2006\u2000;
  private Label \u0003\u2006\u2000;
  private Label \u0005\u2006\u2000;
  private Label \u0008\u2006\u2000;
  private Label \u0006\u2006\u2000;
  private Label \u000E\u2006\u2000;
  private Label \u000F\u2006\u2000;
  private Label \u0002\u2007\u2000;
  private Label \u0003\u2007\u2000;
  private Label \u0005\u2007\u2000;
  private Label \u0008\u2007\u2000;
  private Label \u0006\u2007\u2000;
  private Label \u000E\u2007\u2000;
  private Label \u000F\u2007\u2000;
  private Label \u0002\u2008\u2000;
  private Label \u0003\u2008\u2000;
  private Label \u0005\u2008\u2000;
  private Label \u0008\u2008\u2000;
  private Label \u0006\u2008\u2000;
  private Label \u000E\u2008\u2000;
  private Label \u000F\u2008\u2000;
  private Label \u0002\u2009\u2000;
  private Label \u0003\u2009\u2000;
  private Label \u0005\u2009\u2000;
  private Label \u0008\u2009\u2000;
  private Label \u0006\u2009\u2000;
  private Label \u000E\u2009\u2000;
  private Label \u000F\u2009\u2000;
  private Label \u0002\u200A\u2000;
  private Label \u0003\u200A\u2000;
  private Label \u0005\u200A\u2000;
  private Label \u0008\u200A\u2000;
  private Label \u0006\u200A\u2000;
  private Label \u000E\u200A\u2000;
  private Label \u000F\u200A\u2000;
  private Label \u0002​\u2000;
  private Label \u0003​\u2000;
  private Label \u0005​\u2000;
  private Label \u0008​\u2000;
  private Label \u0006​\u2000;
  private Label \u000E​\u2000;
  private Label \u000F​\u2000;
  private Label \u0002\u2000\u2001;
  private Label \u0003\u2000\u2001;
  private Label \u0005\u2000\u2001;
  private Label \u0008\u2000\u2001;
  private Label \u0006\u2000\u2001;
  private Label \u000E\u2000\u2001;
  private Label \u000F\u2000\u2001;
  private Label \u0002\u2001\u2001;
  private Label \u0003\u2001\u2001;
  private Label \u0005\u2001\u2001;
  private Label \u0008\u2001\u2001;
  private Label \u0006\u2001\u2001;
  private Label \u000E\u2001\u2001;
  private Label \u000F\u2001\u2001;
  private Label \u0002\u2002\u2001;
  private Label \u0003\u2002\u2001;
  private Label \u0005\u2002\u2001;
  private Label \u0008\u2002\u2001;
  private Label \u0006\u2002\u2001;
  private Label \u000E\u2002\u2001;
  private Label \u000F\u2002\u2001;
  private Label \u0002\u2003\u2001;
  private Label \u0003\u2003\u2001;
  private Label \u0005\u2003\u2001;
  private Label \u0008\u2003\u2001;
  private Label \u0006\u2003\u2001;
  private Label \u000E\u2003\u2001;
  private Label \u000F\u2003\u2001;
  private Label \u0002\u2004\u2001;
  private Label \u0003\u2004\u2001;
  private Label \u0005\u2004\u2001;
  private Label \u0008\u2004\u2001;
  private Label \u0006\u2004\u2001;
  private Label \u000E\u2004\u2001;
  private Label \u000F\u2004\u2001;
  private Label \u0002\u2005\u2001;
  private Label \u0003\u2005\u2001;
  private Label \u0005\u2005\u2001;
  private Label \u0008\u2005\u2001;
  private Label \u0006\u2005\u2001;
  private Label \u000E\u2005\u2001;
  private Label \u000F\u2005\u2001;
  private Label \u0002\u2006\u2001;
  private Label \u0003\u2006\u2001;
  private Label \u0005\u2006\u2001;
  private Label \u0008\u2006\u2001;
  private Label \u0006\u2006\u2001;
  private Label \u000E\u2006\u2001;
  private Label \u000F\u2006\u2001;
  private Label \u0002\u2007\u2001;
  private Label \u0003\u2007\u2001;
  private Label \u0005\u2007\u2001;
  private Label \u0008\u2007\u2001;
  private Label \u0006\u2007\u2001;
  private Label \u000E\u2007\u2001;
  private Label \u000F\u2007\u2001;
  private Label \u0002\u2008\u2001;
  private Label \u0003\u2008\u2001;
  private Label \u0005\u2008\u2001;
  private Label \u0008\u2008\u2001;
  private Label \u0006\u2008\u2001;
  private Label \u000E\u2008\u2001;
  private Label \u000F\u2008\u2001;
  private Label \u0002\u2009\u2001;
  private Label \u0003\u2009\u2001;
  private Label \u0005\u2009\u2001;
  private Label \u0008\u2009\u2001;
  private Label \u0006\u2009\u2001;
  private Label \u000E\u2009\u2001;
  private Label \u000F\u2009\u2001;
  private Label \u0002\u200A\u2001;
  private Label \u0003\u200A\u2001;
  private Label \u0005\u200A\u2001;
  private Label \u0008\u200A\u2001;
  private Label \u0006\u200A\u2001;
  private Label \u000E\u200A\u2001;
  private Label \u000F\u200A\u2001;
  private Label \u0002​\u2001;
  private Label \u0003​\u2001;
  private Label \u0005​\u2001;
  private Label \u0008​\u2001;
  private Label \u0006​\u2001;
  private Label \u000E​\u2001;
  private Label \u000F​\u2001;
  private Label \u0002\u2000\u2002;
  private Label \u0003\u2000\u2002;
  private Label \u0005\u2000\u2002;
  private Label \u0008\u2000\u2002;
  private Label \u0006\u2000\u2002;
  private Label \u000E\u2000\u2002;
  private Label \u000F\u2000\u2002;
  private Label \u0002\u2001\u2002;
  private Label \u0003\u2001\u2002;
  private Label \u0005\u2001\u2002;
  private Label \u0008\u2001\u2002;
  private Label \u0006\u2001\u2002;
  private Label \u000E\u2001\u2002;
  private Label \u000F\u2001\u2002;
  private Label \u0002\u2002\u2002;
  private Label \u0003\u2002\u2002;
  private Label \u0005\u2002\u2002;
  private Label \u0008\u2002\u2002;
  private Label \u0006\u2002\u2002;
  private Label \u000E\u2002\u2002;
  private Label \u000F\u2002\u2002;
  private Label \u0002\u2003\u2002;
  private Label \u0003\u2003\u2002;
  private Label \u0005\u2003\u2002;
  private Label \u0008\u2003\u2002;
  private Label \u0006\u2003\u2002;
  private Label \u000E\u2003\u2002;
  private Label \u000F\u2003\u2002;
  private Label \u0002\u2004\u2002;
  private Label \u0003\u2004\u2002;
  private Label \u0005\u2004\u2002;
  private Label \u0008\u2004\u2002;
  private Label \u0006\u2004\u2002;
  private Label \u000E\u2004\u2002;
  private Label \u000F\u2004\u2002;
  private Label \u0002\u2005\u2002;
  private Label \u0003\u2005\u2002;
  private Label \u0005\u2005\u2002;
  private Label \u0008\u2005\u2002;
  private Label \u0006\u2005\u2002;
  private Label \u000E\u2005\u2002;
  private Label \u000F\u2005\u2002;
  private Label \u0002\u2006\u2002;
  private Label \u0003\u2006\u2002;
  private Label \u0005\u2006\u2002;
  private Label \u0008\u2006\u2002;
  private Label \u0006\u2006\u2002;
  private Label \u000E\u2006\u2002;
  private Label \u000F\u2006\u2002;
  private Label \u0002\u2007\u2002;
  private Label \u0003\u2007\u2002;
  private Label \u0005\u2007\u2002;
  private Label \u0008\u2007\u2002;
  private Label \u0006\u2007\u2002;
  private Label \u000E\u2007\u2002;
  private Label \u000F\u2007\u2002;
  private Label \u0002\u2008\u2002;
  private Label \u0003\u2008\u2002;
  private Label \u0005\u2008\u2002;
  private Label \u0008\u2008\u2002;
  private Label \u0006\u2008\u2002;
  private Label \u000E\u2008\u2002;
  private Label \u000F\u2008\u2002;
  private Label \u0002\u2009\u2002;
  private Label \u0003\u2009\u2002;
  private Label \u0005\u2009\u2002;
  private Label \u0008\u2009\u2002;
  private Label \u0006\u2009\u2002;
  private Label \u000E\u2009\u2002;
  private Label \u000F\u2009\u2002;
  private Label \u0002\u200A\u2002;
  private Label \u0003\u200A\u2002;
  private Label \u0005\u200A\u2002;
  private Label \u0008\u200A\u2002;
  private Label \u0006\u200A\u2002;
  private Label \u000E\u200A\u2002;
  private Label \u000F\u200A\u2002;
  private Label \u0002​\u2002;
  private Label \u0003​\u2002;
  private Label \u0005​\u2002;
  private Label \u0008​\u2002;
  private Label \u0006​\u2002;
  private Label \u000E​\u2002;
  private Label \u000F​\u2002;
  private Label \u0002\u2000\u2003;
  private Label \u0003\u2000\u2003;
  private Label \u0005\u2000\u2003;
  private Label \u0008\u2000\u2003;
  private Label \u0006\u2000\u2003;
  private Label \u000E\u2000\u2003;
  private Label \u000F\u2000\u2003;
  private Label \u0002\u2001\u2003;
  private Label \u0003\u2001\u2003;
  private Label \u0005\u2001\u2003;
  private Label \u0008\u2001\u2003;
  private Label \u0006\u2001\u2003;
  private Label \u000E\u2001\u2003;
  private Label \u000F\u2001\u2003;
  private Label \u0002\u2002\u2003;
  private Label \u0003\u2002\u2003;
  private Label \u0005\u2002\u2003;
  private Label \u0008\u2002\u2003;
  private Label \u0006\u2002\u2003;
  private Label \u000E\u2002\u2003;
  private Label \u000F\u2002\u2003;
  private Label \u0002\u2003\u2003;
  private Label \u0003\u2003\u2003;
  private Label \u0005\u2003\u2003;
  private Label \u0008\u2003\u2003;
  private Label \u0006\u2003\u2003;
  private Label \u000E\u2003\u2003;
  private Label \u000F\u2003\u2003;
  private Label \u0002\u2004\u2003;
  private Label \u0003\u2004\u2003;
  private Label \u0005\u2004\u2003;
  private Label \u0008\u2004\u2003;
  private Label \u0006\u2004\u2003;
  private Label \u000E\u2004\u2003;
  private Label \u000F\u2004\u2003;
  private Label \u0002\u2005\u2003;
  private Label \u0003\u2005\u2003;
  private Label \u0005\u2005\u2003;
  private Label \u0008\u2005\u2003;
  private Label \u0006\u2005\u2003;
  private Label \u000E\u2005\u2003;
  private Label \u000F\u2005\u2003;
  private Label \u0002\u2006\u2003;
  private Label \u0003\u2006\u2003;
  private Label \u0005\u2006\u2003;
  private Label \u0008\u2006\u2003;
  private Label \u0006\u2006\u2003;
  private Label \u000E\u2006\u2003;
  private Label \u000F\u2006\u2003;
  private Label \u0002\u2007\u2003;
  private Label \u0003\u2007\u2003;
  private Label \u0005\u2007\u2003;
  private Label \u0008\u2007\u2003;
  private Label \u0006\u2007\u2003;
  private Label \u000E\u2007\u2003;
  private Label \u000F\u2007\u2003;
  private Label \u0002\u2008\u2003;
  private Label \u0003\u2008\u2003;
  private Label \u0005\u2008\u2003;
  private Label \u0008\u2008\u2003;
  private Label \u0006\u2008\u2003;
  private Label \u000E\u2008\u2003;
  private Label \u000F\u2008\u2003;
  private Label \u0002\u2009\u2003;
  private Label \u0003\u2009\u2003;
  private Label \u0005\u2009\u2003;
  private Label \u0008\u2009\u2003;
  private Label \u0006\u2009\u2003;
  private Label \u000E\u2009\u2003;
  private Label \u000F\u2009\u2003;
  private Label \u0002\u200A\u2003;
  private Label \u0003\u200A\u2003;
  private Label \u0005\u200A\u2003;
  private Label \u0008\u200A\u2003;
  private Label \u0006\u200A\u2003;
  private Timer \u000E\u200A\u2003;
  private Panel \u000F\u200A\u2003;
  private Button \u0002​\u2003;
  private PictureBox \u0003​\u2003;
  private PictureBox \u0005​\u2003;
  private Timer \u0008​\u2003;
  private Timer \u0006​\u2003;
  private Timer \u000E​\u2003;
  private Timer \u000F​\u2003;
  private Label \u0002\u2000\u2004;
  private Label \u0003\u2000\u2004;
  private Timer \u0005\u2000\u2004;
  private Timer \u0008\u2000\u2004;
  private PictureBox \u0006\u2000\u2004;
  private PictureBox \u000E\u2000\u2004;
  private Label \u000F\u2000\u2004;
  private Label \u0002\u2001\u2004;
  private Label \u0003\u2001\u2004;
  private Label \u0005\u2001\u2004;

  public \u0008\u2000()
  {
    this.\u000E\u2000();
    this.\u000E\u2007.Add((object) this.\u0003\u200A);
    this.\u000E\u2007.Add((object) this.\u0005\u200A);
    this.\u000E\u2007.Add((object) this.\u0008\u200A);
    this.\u000E\u2007.Add((object) this.\u0006\u200A);
    this.\u000E\u2007.Add((object) this.\u000E\u200A);
    this.\u000E\u2007.Add((object) this.\u000F\u200A);
    this.\u000E\u2007.Add((object) this.\u0002​);
    this.\u000E\u2007.Add((object) this.\u0003​);
    this.\u000E\u2007.Add((object) this.\u0005​);
    this.\u000E\u2007.Add((object) this.\u0008​);
    this.\u000E\u2007.Add((object) this.\u0006​);
    this.\u000E\u2007.Add((object) this.\u000E​);
    this.\u000E\u2007.Add((object) this.\u000F​);
    this.\u000E\u2007.Add((object) this.\u0002\u2000\u2000);
    this.\u000E\u2007.Add((object) this.\u0003\u2000\u2000);
    this.\u000E\u2007.Add((object) this.\u0005\u2000\u2000);
    this.\u000E\u2007.Add((object) this.\u0008\u2000\u2000);
    this.\u000E\u2007.Add((object) this.\u0006\u2000\u2000);
    this.\u000E\u2007.Add((object) this.\u000E\u2000\u2000);
    this.\u000E\u2007.Add((object) this.\u000F\u2000\u2000);
    this.\u000E\u2007.Add((object) this.\u0002\u2001\u2000);
    this.\u000E\u2007.Add((object) this.\u0003\u2001\u2000);
    this.\u000E\u2007.Add((object) this.\u0005\u2001\u2000);
    this.\u000E\u2007.Add((object) this.\u0008\u2001\u2000);
    this.\u000E\u2007.Add((object) this.\u0006\u2001\u2000);
    this.\u000E\u2007.Add((object) this.\u000E\u2001\u2000);
    this.\u000E\u2007.Add((object) this.\u000F\u2001\u2000);
    this.\u000E\u2007.Add((object) this.\u0002\u2002\u2000);
    this.\u000E\u2007.Add((object) this.\u0006\u2002\u2000);
    this.\u000E\u2007.Add((object) this.\u0008\u2003\u2000);
    this.\u000E\u2007.Add((object) this.\u0006\u2003\u2000);
    this.\u000E\u2007.Add((object) this.\u000E\u2003\u2000);
    this.\u000E\u2007.Add((object) this.\u000F\u2003\u2000);
    this.\u000E\u2007.Add((object) this.\u0002\u2004\u2000);
    this.\u000E\u2007.Add((object) this.\u0003\u2004\u2000);
    this.\u000E\u2007.Add((object) this.\u0005\u2004\u2000);
    this.\u000E\u2007.Add((object) this.\u0008\u2004\u2000);
    this.\u000E\u2007.Add((object) this.\u0006\u2004\u2000);
    this.\u000E\u2007.Add((object) this.\u000E\u2004\u2000);
    this.\u000E\u2007.Add((object) this.\u0005\u2002\u2000);
    this.\u000E\u2007.Add((object) this.\u0008\u2002\u2000);
    this.\u000E\u2007.Add((object) this.\u000E\u2002\u2000);
    this.\u000E\u2007.Add((object) this.\u000F\u2002\u2000);
    this.\u000E\u2007.Add((object) this.\u0002\u2003\u2000);
    this.\u000E\u2007.Add((object) this.\u000F\u2004\u2000);
    this.\u000E\u2007.Add((object) this.\u0003\u2003\u2000);
    this.\u000E\u2007.Add((object) this.\u0005\u2003\u2000);
    this.\u000E\u2007.Add((object) this.\u0002\u2006\u2000);
    this.\u000E\u2007.Add((object) this.\u0003\u2006\u2000);
    this.\u000E\u2007.Add((object) this.\u0005\u2006\u2000);
    this.\u000E\u2007.Add((object) this.\u0008\u2006\u2000);
    this.\u000E\u2007.Add((object) this.\u0006\u2006\u2000);
    this.\u000E\u2007.Add((object) this.\u000E\u2006\u2000);
    this.\u000E\u2007.Add((object) this.\u000F\u2006\u2000);
    this.\u000E\u2007.Add((object) this.\u0002\u2007\u2000);
    this.\u000E\u2007.Add((object) this.\u0003\u2007\u2000);
    this.\u000E\u2007.Add((object) this.\u0005\u2007\u2000);
    this.\u000E\u2007.Add((object) this.\u0008\u2007\u2000);
    this.\u000E\u2007.Add((object) this.\u0006\u2007\u2000);
    this.\u000E\u2007.Add((object) this.\u000E\u2007\u2000);
    this.\u000E\u2007.Add((object) this.\u000F\u2007\u2000);
    this.\u000E\u2007.Add((object) this.\u0002\u2008\u2000);
    this.\u000E\u2007.Add((object) this.\u0003\u2008\u2000);
    this.\u000E\u2007.Add((object) this.\u0005\u2008\u2000);
    this.\u000E\u2007.Add((object) this.\u0008\u2008\u2000);
    this.\u000E\u2007.Add((object) this.\u0006\u2008\u2000);
    this.\u000E\u2007.Add((object) this.\u000E\u2008\u2000);
    this.\u000E\u2007.Add((object) this.\u000F\u2008\u2000);
    this.\u000E\u2007.Add((object) this.\u0002\u2009\u2000);
    this.\u000E\u2007.Add((object) this.\u0003\u2009\u2000);
    this.\u000E\u2007.Add((object) this.\u0005\u2009\u2000);
    this.\u000E\u2007.Add((object) this.\u0006\u200A\u2000);
    this.\u000E\u2007.Add((object) this.\u0008\u2009\u2000);
    this.\u000E\u2007.Add((object) this.\u0006\u2009\u2000);
    this.\u000E\u2007.Add((object) this.\u000E\u2009\u2000);
    this.\u000E\u2007.Add((object) this.\u000F\u2009\u2000);
    this.\u000E\u2007.Add((object) this.\u0002\u200A\u2000);
    this.\u000E\u2007.Add((object) this.\u0003\u200A\u2000);
    this.\u000E\u2007.Add((object) this.\u0005\u200A\u2000);
    this.\u000E\u2007.Add((object) this.\u0008\u200A\u2000);
    this.\u000E\u2007.Add((object) this.\u000E\u200A\u2000);
    this.\u000E\u2007.Add((object) this.\u000F\u200A\u2000);
    this.\u000E\u2007.Add((object) this.\u0002​\u2000);
    this.\u000E\u2007.Add((object) this.\u0003​\u2000);
    this.\u000E\u2007.Add((object) this.\u0005​\u2000);
    this.\u000E\u2007.Add((object) this.\u0008​\u2000);
    this.\u000E\u2007.Add((object) this.\u0006​\u2000);
    this.\u000E\u2007.Add((object) this.\u000E​\u2000);
    this.\u000E\u2007.Add((object) this.\u000F​\u2000);
    this.\u000E\u2007.Add((object) this.\u0003\u2000\u2001);
    this.\u000E\u2007.Add((object) this.\u0002\u2000\u2001);
    this.\u000E\u2007.Add((object) this.\u0005\u2000\u2001);
    this.\u000E\u2007.Add((object) this.\u0008\u2000\u2001);
    this.\u000E\u2007.Add((object) this.\u000E\u2000\u2001);
    this.\u000E\u2007.Add((object) this.\u0006\u2000\u2001);
    this.\u000E\u2007.Add((object) this.\u000F\u2000\u2001);
    this.\u000E\u2007.Add((object) this.\u0002\u2001\u2001);
    this.\u000E\u2007.Add((object) this.\u0003\u2001\u2001);
    this.\u000E\u2007.Add((object) this.\u0005\u2001\u2001);
    this.\u000E\u2007.Add((object) this.\u0008\u2001\u2001);
    this.\u000E\u2007.Add((object) this.\u0006\u2001\u2001);
    this.\u000E\u2007.Add((object) this.\u000E\u2001\u2001);
    this.\u000E\u2007.Add((object) this.\u000F\u2001\u2001);
    this.\u000E\u2007.Add((object) this.\u0002\u2002\u2001);
    this.\u000E\u2007.Add((object) this.\u0003\u2002\u2001);
    this.\u000E\u2007.Add((object) this.\u0005\u2002\u2001);
    this.\u000E\u2007.Add((object) this.\u0008\u2002\u2001);
    this.\u000E\u2007.Add((object) this.\u0006\u2002\u2001);
    this.\u000E\u2007.Add((object) this.\u000E\u2002\u2001);
    this.\u000E\u2007.Add((object) this.\u000F\u2002\u2001);
    this.\u000E\u2007.Add((object) this.\u0002\u2003\u2001);
    this.\u000E\u2007.Add((object) this.\u0003\u2003\u2001);
    this.\u000E\u2007.Add((object) this.\u0005\u2003\u2001);
    this.\u000E\u2007.Add((object) this.\u0008\u2003\u2001);
    this.\u000E\u2007.Add((object) this.\u0006\u2003\u2001);
    this.\u000E\u2007.Add((object) this.\u000E\u2003\u2001);
    this.\u000E\u2007.Add((object) this.\u000F\u2003\u2001);
    this.\u000E\u2007.Add((object) this.\u0002\u2004\u2001);
    this.\u000E\u2007.Add((object) this.\u0003\u2004\u2001);
    this.\u000E\u2007.Add((object) this.\u0005\u2004\u2001);
    this.\u000E\u2007.Add((object) this.\u0008\u2004\u2001);
    this.\u000E\u2007.Add((object) this.\u0006\u2004\u2001);
    this.\u000E\u2007.Add((object) this.\u000E\u2004\u2001);
    this.\u000E\u2007.Add((object) this.\u000F\u2004\u2001);
    this.\u000E\u2007.Add((object) this.\u0002\u2005\u2001);
    this.\u000E\u2007.Add((object) this.\u0003\u2005\u2001);
    this.\u000E\u2007.Add((object) this.\u0005\u2005\u2001);
    this.\u000E\u2007.Add((object) this.\u0008\u2005\u2001);
    this.\u000E\u2007.Add((object) this.\u0006\u2005\u2001);
    this.\u000E\u2007.Add((object) this.\u000E\u2005\u2001);
    this.\u000E\u2007.Add((object) this.\u000F\u2005\u2001);
    this.\u000E\u2007.Add((object) this.\u0002\u2006\u2001);
    this.\u000E\u2007.Add((object) this.\u0003\u2006\u2001);
    this.\u000E\u2007.Add((object) this.\u0005\u2006\u2001);
    this.\u000E\u2007.Add((object) this.\u0008\u2006\u2001);
    this.\u000E\u2007.Add((object) this.\u0006\u2006\u2001);
    this.\u000E\u2007.Add((object) this.\u000E\u2006\u2001);
    this.\u000E\u2007.Add((object) this.\u000F\u2006\u2001);
    this.\u000E\u2007.Add((object) this.\u0002\u2007\u2001);
    this.\u000E\u2007.Add((object) this.\u0003\u2007\u2001);
    this.\u000E\u2007.Add((object) this.\u0005\u2007\u2001);
    this.\u000E\u2007.Add((object) this.\u0008\u2007\u2001);
    this.\u000E\u2007.Add((object) this.\u0006\u2007\u2001);
    this.\u000E\u2007.Add((object) this.\u000E\u2007\u2001);
    this.\u000E\u2007.Add((object) this.\u000F\u2007\u2001);
    this.\u000E\u2007.Add((object) this.\u0002\u2008\u2001);
    this.\u000E\u2007.Add((object) this.\u0003\u2008\u2001);
    this.\u000E\u2007.Add((object) this.\u0005\u2008\u2001);
    this.\u000E\u2007.Add((object) this.\u0008\u2008\u2001);
    this.\u000E\u2007.Add((object) this.\u0006\u2008\u2001);
    this.\u000E\u2007.Add((object) this.\u000E\u2008\u2001);
    this.\u000E\u2007.Add((object) this.\u000F\u2008\u2001);
    this.\u000E\u2007.Add((object) this.\u0002\u2009\u2001);
    this.\u000E\u2007.Add((object) this.\u0003\u2009\u2001);
    this.\u000E\u2007.Add((object) this.\u0005\u2009\u2001);
    this.\u000E\u2007.Add((object) this.\u0008\u2009\u2001);
    this.\u000E\u2007.Add((object) this.\u0006\u2009\u2001);
    this.\u000E\u2007.Add((object) this.\u000E\u2009\u2001);
    this.\u000E\u2007.Add((object) this.\u000F\u2009\u2001);
    this.\u000E\u2007.Add((object) this.\u0002\u200A\u2001);
    this.\u000E\u2007.Add((object) this.\u0003\u200A\u2001);
    this.\u000E\u2007.Add((object) this.\u0005\u200A\u2001);
    this.\u000E\u2007.Add((object) this.\u0008\u200A\u2001);
    this.\u000E\u2007.Add((object) this.\u0006\u200A\u2001);
    this.\u000E\u2007.Add((object) this.\u000E\u200A\u2001);
    this.\u000E\u2007.Add((object) this.\u000F\u200A\u2001);
    this.\u000E\u2007.Add((object) this.\u0002​\u2001);
    this.\u000E\u2007.Add((object) this.\u0003​\u2001);
    this.\u000E\u2007.Add((object) this.\u0005​\u2001);
    this.\u000E\u2007.Add((object) this.\u0008​\u2001);
    this.\u000E\u2007.Add((object) this.\u0006​\u2001);
    this.\u000E\u2007.Add((object) this.\u000E​\u2001);
    this.\u000E\u2007.Add((object) this.\u000F​\u2001);
    this.\u000E\u2007.Add((object) this.\u0002\u2000\u2002);
    this.\u000E\u2007.Add((object) this.\u0003\u2000\u2002);
    this.\u000E\u2007.Add((object) this.\u0005\u2000\u2002);
    this.\u000E\u2007.Add((object) this.\u0008\u2000\u2002);
    this.\u000E\u2007.Add((object) this.\u0006\u2000\u2002);
    this.\u000E\u2007.Add((object) this.\u000E\u2000\u2002);
    this.\u000E\u2007.Add((object) this.\u000F\u2000\u2002);
    this.\u000E\u2007.Add((object) this.\u0002\u2001\u2002);
    this.\u000E\u2007.Add((object) this.\u0003\u2001\u2002);
    this.\u000E\u2007.Add((object) this.\u0005\u2001\u2002);
    this.\u000E\u2007.Add((object) this.\u0008\u2001\u2002);
    this.\u000E\u2007.Add((object) this.\u0006\u2001\u2002);
    this.\u000E\u2007.Add((object) this.\u000E\u2001\u2002);
    this.\u000E\u2007.Add((object) this.\u000F\u2001\u2002);
    this.\u000E\u2007.Add((object) this.\u0002\u2002\u2002);
    this.\u000E\u2007.Add((object) this.\u0003\u2002\u2002);
    this.\u000E\u2007.Add((object) this.\u0005\u2002\u2002);
    this.\u000E\u2007.Add((object) this.\u000F\u2004\u2002);
    this.\u000E\u2007.Add((object) this.\u0006\u2002\u2002);
    this.\u000E\u2007.Add((object) this.\u0008\u2002\u2002);
    this.\u000E\u2007.Add((object) this.\u000E\u2002\u2002);
    this.\u000E\u2007.Add((object) this.\u000F\u2002\u2002);
    this.\u000E\u2007.Add((object) this.\u0002\u2003\u2002);
    this.\u000E\u2007.Add((object) this.\u0003\u2003\u2002);
    this.\u000E\u2007.Add((object) this.\u0005\u2003\u2002);
    this.\u000E\u2007.Add((object) this.\u0008\u2003\u2002);
    this.\u000E\u2007.Add((object) this.\u0006\u2003\u2002);
    this.\u000E\u2007.Add((object) this.\u000E\u2003\u2002);
    this.\u000E\u2007.Add((object) this.\u000F\u2003\u2002);
    this.\u000E\u2007.Add((object) this.\u0002\u2004\u2002);
    this.\u000E\u2007.Add((object) this.\u0003\u2004\u2002);
    this.\u000E\u2007.Add((object) this.\u0005\u2004\u2002);
    this.\u000E\u2007.Add((object) this.\u0008\u2004\u2002);
    this.\u000E\u2007.Add((object) this.\u0006\u2004\u2002);
    this.\u000E\u2007.Add((object) this.\u000E\u2004\u2002);
    this.\u000E\u2007.Add((object) this.\u0002\u2005\u2002);
    this.\u000E\u2007.Add((object) this.\u0003\u2005\u2002);
    this.\u000E\u2007.Add((object) this.\u0005\u2005\u2002);
    this.\u000E\u2007.Add((object) this.\u0008\u2005\u2002);
    this.\u000E\u2007.Add((object) this.\u0006\u2005\u2002);
    this.\u000E\u2007.Add((object) this.\u000E\u2005\u2002);
    this.\u000E\u2007.Add((object) this.\u000F\u2005\u2002);
    this.\u000E\u2007.Add((object) this.\u0002\u2006\u2002);
    this.\u000E\u2007.Add((object) this.\u0003\u2006\u2002);
    this.\u000E\u2007.Add((object) this.\u0005\u2006\u2002);
    this.\u000E\u2007.Add((object) this.\u0008\u2006\u2002);
    this.\u000E\u2007.Add((object) this.\u0006\u2006\u2002);
    this.\u000E\u2007.Add((object) this.\u000E\u2006\u2002);
    this.\u000E\u2007.Add((object) this.\u000F\u2006\u2002);
    this.\u000E\u2007.Add((object) this.\u0002\u2007\u2002);
    this.\u000E\u2007.Add((object) this.\u0003\u2007\u2002);
    this.\u000E\u2007.Add((object) this.\u0005\u2007\u2002);
    this.\u000E\u2007.Add((object) this.\u0008\u2007\u2002);
    this.\u000E\u2007.Add((object) this.\u0006\u2007\u2002);
    this.\u000E\u2007.Add((object) this.\u000E\u2007\u2002);
    this.\u000E\u2007.Add((object) this.\u000F\u2007\u2002);
    this.\u000E\u2007.Add((object) this.\u0002\u2008\u2002);
    this.\u000E\u2007.Add((object) this.\u0003\u2008\u2002);
    this.\u000E\u2007.Add((object) this.\u0005\u2008\u2002);
    this.\u000E\u2007.Add((object) this.\u0008\u2008\u2002);
    this.\u000E\u2007.Add((object) this.\u0006\u2008\u2002);
    this.\u000E\u2007.Add((object) this.\u000E\u2008\u2002);
    this.\u000E\u2007.Add((object) this.\u000F\u2008\u2002);
    this.\u000E\u2007.Add((object) this.\u0002\u2009\u2002);
    this.\u000E\u2007.Add((object) this.\u0003\u2009\u2002);
    this.\u000E\u2007.Add((object) this.\u0005\u2009\u2002);
    this.\u000E\u2007.Add((object) this.\u0008\u2009\u2002);
    this.\u000E\u2007.Add((object) this.\u0006\u2009\u2002);
    this.\u000E\u2007.Add((object) this.\u000E\u2009\u2002);
    this.\u000E\u2007.Add((object) this.\u000F\u2009\u2002);
    this.\u000E\u2007.Add((object) this.\u0002\u200A\u2002);
    this.\u000E\u2007.Add((object) this.\u0003\u200A\u2002);
    this.\u000E\u2007.Add((object) this.\u0005\u200A\u2002);
    this.\u000E\u2007.Add((object) this.\u0008\u200A\u2002);
    this.\u000E\u2007.Add((object) this.\u0006\u200A\u2002);
    this.\u000E\u2007.Add((object) this.\u000E\u200A\u2002);
    this.\u000E\u2007.Add((object) this.\u000F\u200A\u2002);
    this.\u000E\u2007.Add((object) this.\u0002​\u2002);
    this.\u000E\u2007.Add((object) this.\u0003​\u2002);
    this.\u000E\u2007.Add((object) this.\u0005​\u2002);
    this.\u000E\u2007.Add((object) this.\u0008​\u2002);
    this.\u000E\u2007.Add((object) this.\u0006​\u2002);
    this.\u000E\u2007.Add((object) this.\u000E​\u2002);
    this.\u000E\u2007.Add((object) this.\u0002\u2001\u2003);
    this.\u000E\u2007.Add((object) this.\u0003\u2001\u2003);
    this.\u000E\u2007.Add((object) this.\u0005\u2001\u2003);
    this.\u000E\u2007.Add((object) this.\u0008\u2001\u2003);
    this.\u000E\u2007.Add((object) this.\u0006\u2001\u2003);
    this.\u000E\u2007.Add((object) this.\u000E\u2001\u2003);
    this.\u000E\u2007.Add((object) this.\u000F​\u2002);
    this.\u000E\u2007.Add((object) this.\u0002\u2000\u2003);
    this.\u000E\u2007.Add((object) this.\u0003\u2000\u2003);
    this.\u000E\u2007.Add((object) this.\u000F\u2001\u2003);
    this.\u000E\u2007.Add((object) this.\u0002\u2002\u2003);
    this.\u000E\u2007.Add((object) this.\u0003\u2002\u2003);
    this.\u000E\u2007.Add((object) this.\u0005\u2002\u2003);
    this.\u000E\u2007.Add((object) this.\u0008\u2002\u2003);
    this.\u000E\u2007.Add((object) this.\u0005\u2000\u2003);
    this.\u000E\u2007.Add((object) this.\u0008\u2000\u2003);
    this.\u000E\u2007.Add((object) this.\u0006\u2000\u2003);
    this.\u000E\u2007.Add((object) this.\u000E\u2000\u2003);
    this.\u000E\u2007.Add((object) this.\u000F\u2000\u2003);
    this.\u000E\u2007.Add((object) this.\u0006\u2002\u2003);
    this.\u000E\u2007.Add((object) this.\u000E\u2002\u2003);
    this.\u000E\u2007.Add((object) this.\u000F\u2002\u2003);
    this.\u000E\u2007.Add((object) this.\u0002\u2003\u2003);
    this.\u000E\u2007.Add((object) this.\u0003\u2003\u2003);
    this.\u000E\u2007.Add((object) this.\u0005\u2003\u2003);
    this.\u000E\u2007.Add((object) this.\u000F\u2004\u2003);
    this.\u000E\u2007.Add((object) this.\u0002\u2005\u2003);
    this.\u000E\u2007.Add((object) this.\u0008\u2003\u2003);
    this.\u000E\u2007.Add((object) this.\u0006\u2003\u2003);
    this.\u000E\u2007.Add((object) this.\u000E\u2003\u2003);
    this.\u000E\u2007.Add((object) this.\u000F\u2003\u2003);
    this.\u000E\u2007.Add((object) this.\u0002\u2004\u2003);
    this.\u000E\u2007.Add((object) this.\u0003\u2004\u2003);
    this.\u000E\u2007.Add((object) this.\u0005\u2004\u2003);
    this.\u000E\u2007.Add((object) this.\u0008\u2004\u2003);
    this.\u000E\u2007.Add((object) this.\u0006\u2004\u2003);
    this.\u000E\u2007.Add((object) this.\u000E\u2004\u2003);
    this.\u000E\u2007.Add((object) this.\u0003\u2005\u2003);
    this.\u000E\u2007.Add((object) this.\u0005\u2005\u2003);
    this.\u000E\u2007.Add((object) this.\u0008\u2005\u2003);
    this.\u000E\u2007.Add((object) this.\u0006\u2005\u2003);
    this.\u000E\u2007.Add((object) this.\u000E\u2005\u2003);
    this.\u000E\u2007.Add((object) this.\u000F\u2005\u2003);
    this.\u000E\u2007.Add((object) this.\u0002\u2006\u2003);
    this.\u000E\u2007.Add((object) this.\u0003\u2006\u2003);
    this.\u000E\u2007.Add((object) this.\u0005\u2006\u2003);
    this.\u000E\u2007.Add((object) this.\u0008\u2006\u2003);
    this.\u000E\u2007.Add((object) this.\u0006\u2006\u2003);
    this.\u000E\u2007.Add((object) this.\u000E\u2006\u2003);
    this.\u000E\u2007.Add((object) this.\u000F\u2006\u2003);
    this.\u000E\u2007.Add((object) this.\u0002\u2007\u2003);
    this.\u000E\u2007.Add((object) this.\u0003\u2007\u2003);
    this.\u000E\u2007.Add((object) this.\u0005\u2007\u2003);
    this.\u000E\u2007.Add((object) this.\u0008\u2007\u2003);
    this.\u000E\u2007.Add((object) this.\u0006\u2007\u2003);
    this.\u000E\u2007.Add((object) this.\u000E\u2007\u2003);
    this.\u000E\u2007.Add((object) this.\u000F\u2007\u2003);
    this.\u000E\u2007.Add((object) this.\u0002\u2008\u2003);
    this.\u000E\u2007.Add((object) this.\u0003\u2008\u2003);
    this.\u000E\u2007.Add((object) this.\u0005\u2008\u2003);
    this.\u000E\u2007.Add((object) this.\u0006\u2008\u2003);
    this.\u000E\u2007.Add((object) this.\u0008\u2008\u2003);
    this.\u000E\u2007.Add((object) this.\u000E\u2008\u2003);
    this.\u000E\u2007.Add((object) this.\u000F\u2008\u2003);
    this.\u000E\u2007.Add((object) this.\u0002\u2009\u2003);
    this.\u000E\u2007.Add((object) this.\u0003\u2009\u2003);
    this.\u000E\u2007.Add((object) this.\u0005\u2009\u2003);
    this.\u000E\u2007.Add((object) this.\u0008\u2009\u2003);
    this.\u000E\u2007.Add((object) this.\u0006\u2009\u2003);
    this.\u000E\u2007.Add((object) this.\u000E\u2009\u2003);
    this.\u000E\u2007.Add((object) this.\u000F\u2009\u2003);
    this.\u000E\u2007.Add((object) this.\u0002\u200A\u2003);
    this.\u000E\u2007.Add((object) this.\u0003\u200A\u2003);
    this.\u000E\u2007.Add((object) this.\u0005\u200A\u2003);
    this.\u000E\u2007.Add((object) this.\u0008\u200A\u2003);
    this.\u000E\u2007.Add((object) this.\u0006\u200A\u2003);
  }

  private void \u0002(object _param1, EventArgs _param2)
  {
  }

  private void \u0003(object _param1, EventArgs _param2)
  {
  }

  private void \u0005(object _param1, EventArgs _param2)
  {
  }

  private void \u0008(object _param1, EventArgs _param2)
  {
  }

  private void \u0002(object _param1, PaintEventArgs _param2)
  {
  }

  private void \u0006(object _param1, EventArgs _param2)
  {
  }

  private void \u000E(object _param1, EventArgs _param2)
  {
    this.Close();
  }

  private void \u000F(object _param1, EventArgs _param2)
  {
  }

  private void \u0002\u2000(object _param1, EventArgs _param2)
  {
    this.\u0006\u2001 = true;
    this.\u0005();
    this.\u0002\u2000();
    this.\u000F\u200A\u2003.Visible = false;
    this.\u0002();
  }

  private void \u0002(object _param1, KeyEventArgs _param2)
  {
    if (_param2.KeyCode == Keys.Left)
      this.\u0008\u2000 = 1;
    if (_param2.KeyCode == Keys.Right)
      this.\u0008\u2000 = 2;
    if (_param2.KeyCode == Keys.Up)
      this.\u0008\u2000 = 3;
    if (_param2.KeyCode == Keys.Down)
      this.\u0008\u2000 = 4;
    if (_param2.KeyCode == Keys.Escape)
      this.Close();
    this.\u000E\u2000 = this.\u0008\u2000;
  }

  private void \u0003\u2000(object _param1, EventArgs _param2)
  {
    this.\u0002​\u2003.Image = (Image) \u000E\u2000.\u0005\u2004();
  }

  private void \u0005\u2000(object _param1, EventArgs _param2)
  {
    this.\u0002​\u2003.Image = (Image) \u000E\u2000.\u0008\u2004();
  }

  private void \u0008\u2000(object _param1, EventArgs _param2)
  {
    if (this.\u0005​\u2003.Enabled)
    {
      this.\u0008\u2000();
      this.\u0005\u2000();
    }
    if (this.\u0003\u2008.Enabled || this.\u0005\u2008.Enabled || this.\u0006\u2008.Enabled || this.\u0008\u2008.Enabled)
      this.\u0006\u2000();
    if (this.\u0008\u2003)
      this.\u0003();
    this.\u0008();
    this.\u0002\u2000();
    this.\u000E();
  }

  private void \u0006\u2000(object _param1, EventArgs _param2)
  {
    this.\u0005\u2009.Visible = false;
    this.\u0002\u2008.Enabled = true;
    this.\u0008\u2009.Enabled = false;
    this.\u0008\u2003 = true;
  }

  private void \u000E\u2000(object _param1, EventArgs _param2)
  {
    if (this.\u0005\u2008.Top == 180)
      this.\u000F\u2006 = 2;
    if (this.\u0005\u2008.Top == 192)
      this.\u000F\u2006 = 1;
    if (this.\u000F\u2006 == 1)
    {
      --this.\u0005\u2008.Top;
      --this.\u0008\u2008.Top;
    }
    if (this.\u000F\u2006 != 2)
      return;
    ++this.\u0005\u2008.Top;
    ++this.\u0008\u2008.Top;
  }

  private void \u000F\u2000(object _param1, EventArgs _param2)
  {
    ++this.\u000E\u2005;
    if (this.\u0006\u2008.Top > 150 && this.\u000E\u2005 > 100)
    {
      this.\u0005\u2006 = 3;
      --this.\u0006\u2008.Top;
    }
    if (this.\u0006\u2008.Top != 150)
      return;
    this.\u000E\u2009.Enabled = false;
  }

  private void \u0002\u2001(object _param1, EventArgs _param2)
  {
    ++this.\u000F\u2005;
    if (this.\u0005\u2008.Left > 153 && this.\u0005\u2008.Left < 176 && this.\u000F\u2005 > 300)
      ++this.\u0005\u2008.Left;
    if (this.\u0005\u2008.Top > 150 && this.\u0005\u2008.Left == 176)
      --this.\u0005\u2008.Top;
    if (this.\u0005\u2008.Top != 150)
      return;
    this.\u0002\u200A.Enabled = true;
    this.\u000F\u2009.Enabled = false;
  }

  private void \u0003\u2001(object _param1, EventArgs _param2)
  {
    ++this.\u0002\u2006;
    if (this.\u0008\u2008.Left > 176 && this.\u0008\u2008.Left < 200 && this.\u0002\u2006 > 100)
      --this.\u0008\u2008.Left;
    if (this.\u0008\u2008.Top > 150 && this.\u0008\u2008.Left == 176)
      --this.\u0008\u2008.Top;
    if (this.\u0008\u2008.Top != 150)
      return;
    this.\u0002\u200A.Enabled = false;
  }

  private void \u0005\u2001(object _param1, EventArgs _param2)
  {
    this.\u000F\u2004 = false;
    if (!this.\u0005\u2002)
    {
      this.\u0005\u2004 = false;
      this.\u000E\u2001 = true;
      this.\u000E\u2003 = false;
      this.\u0002\u2007 = 2;
    }
    if (!this.\u0008\u2002)
    {
      this.\u0008\u2004 = false;
      this.\u000F\u2001 = true;
      this.\u000F\u2003 = false;
      this.\u0003\u2007 = 2;
    }
    if (!this.\u0006\u2002)
    {
      this.\u0006\u2004 = false;
      this.\u0002\u2002 = true;
      this.\u0002\u2004 = false;
      this.\u0005\u2007 = 2;
    }
    if (!this.\u000E\u2002)
    {
      this.\u000E\u2004 = false;
      this.\u0003\u2002 = true;
      this.\u0003\u2004 = false;
      this.\u0008\u2007 = 2;
    }
    this.\u0006\u2003 = false;
    this.\u0008​\u2003.Enabled = false;
    this.\u0005\u2000\u2004.Enabled = false;
    if (this.\u0005\u2006 == 1 && !this.\u0005\u2002)
    {
      if ((this.\u0003\u2008.Left & 1) == 0)
        this.\u0002 = this.\u0002\u2007;
      this.\u0003\u2008.Image = (Image) \u000E\u2000.\u000E\u2004();
    }
    if (this.\u0005\u2006 == 2 && !this.\u0005\u2002)
    {
      if ((this.\u0003\u2008.Left & 1) == 0)
        this.\u0002 = -this.\u0002\u2007;
      this.\u0003\u2008.Image = (Image) \u000E\u2000.\u0002\u2005();
    }
    if (this.\u0005\u2006 == 3 && !this.\u0005\u2002)
    {
      if ((this.\u0003\u2008.Top & 1) == 0)
        this.\u000E = -this.\u0002\u2007;
      this.\u0003\u2008.Image = (Image) \u000E\u2000.\u0003\u2005();
    }
    if (this.\u0005\u2006 == 4 && !this.\u0005\u2002)
    {
      if ((this.\u0003\u2008.Top & 1) == 0)
        this.\u000E = this.\u0002\u2007;
      this.\u0003\u2008.Image = (Image) \u000E\u2000.\u0006\u2004();
    }
    if (this.\u0008\u2006 == 1 && !this.\u0008\u2002)
    {
      if ((this.\u0005\u2008.Left & 1) == 0)
        this.\u0003 = this.\u0003\u2007;
      this.\u0005\u2008.Image = (Image) \u000E\u2000.\u000E();
    }
    if (this.\u0008\u2006 == 2 && !this.\u0008\u2002)
    {
      if ((this.\u0005\u2008.Left & 1) == 0)
        this.\u0003 = -this.\u0003\u2007;
      this.\u0005\u2008.Image = (Image) \u000E\u2000.\u000F();
    }
    if (this.\u0008\u2006 == 3 && !this.\u0008\u2002)
    {
      if ((this.\u0005\u2008.Top & 1) == 0)
        this.\u000F = -this.\u0003\u2007;
      this.\u0005\u2008.Image = (Image) \u000E\u2000.\u0002\u2000();
    }
    if (this.\u0008\u2006 == 4 && !this.\u0008\u2002)
    {
      if ((this.\u0005\u2008.Top & 1) == 0)
        this.\u000F = this.\u0003\u2007;
      this.\u0005\u2008.Image = (Image) \u000E\u2000.\u0006();
    }
    if (this.\u0006\u2006 == 1 && !this.\u0006\u2002)
    {
      if ((this.\u0006\u2008.Left & 1) == 0)
        this.\u0005 = this.\u0005\u2007;
      this.\u0006\u2008.Image = (Image) \u000E\u2000.\u000E\u2005();
    }
    if (this.\u0006\u2006 == 2 && !this.\u0006\u2002)
    {
      if ((this.\u0006\u2008.Left & 1) == 0)
        this.\u0005 = -this.\u0005\u2007;
      this.\u0006\u2008.Image = (Image) \u000E\u2000.\u0002\u2006();
    }
    if (this.\u0006\u2006 == 3 && !this.\u0006\u2002)
    {
      if ((this.\u0006\u2008.Top & 1) == 0)
        this.\u0002\u2000 = -this.\u0005\u2007;
      this.\u0006\u2008.Image = (Image) \u000E\u2000.\u0003\u2006();
    }
    if (this.\u0006\u2006 == 4 && !this.\u0006\u2002)
    {
      if ((this.\u0006\u2008.Top & 1) == 0)
        this.\u0002\u2000 = this.\u0005\u2007;
      this.\u0006\u2008.Image = (Image) \u000E\u2000.\u0006\u2005();
    }
    if (this.\u000E\u2006 == 1 && !this.\u000E\u2002)
    {
      if ((this.\u0008\u2008.Left & 1) == 0)
        this.\u0008 = this.\u0008\u2007;
      this.\u0008\u2008.Image = (Image) \u000E\u2000.\u0005\u2001();
    }
    if (this.\u000E\u2006 == 2 && !this.\u000E\u2002)
    {
      if ((this.\u0008\u2008.Left & 1) == 0)
        this.\u0008 = -this.\u0008\u2007;
      this.\u0008\u2008.Image = (Image) \u000E\u2000.\u0006\u2001();
    }
    if (this.\u000E\u2006 == 3 && !this.\u000E\u2002)
    {
      if ((this.\u0008\u2008.Top & 1) == 0)
        this.\u0003\u2000 = -this.\u0008\u2007;
      this.\u0008\u2008.Image = (Image) \u000E\u2000.\u000E\u2001();
    }
    if (this.\u000E\u2006 != 4 || this.\u000E\u2002)
      return;
    if ((this.\u0008\u2008.Top & 1) == 0)
      this.\u0003\u2000 = this.\u0008\u2007;
    this.\u0003\u2008.Image = (Image) \u000E\u2000.\u0003\u2001();
  }

  private void \u0008\u2001(object _param1, EventArgs _param2)
  {
    this.\u0005​\u2003.SetBounds(this.\u0005​\u2003.Left, this.\u0005​\u2003.Top, 0, 0);
    this.\u0005\u2002 = false;
    this.\u0008\u2002 = false;
    this.\u0006\u2002 = false;
    this.\u000E\u2002 = false;
    this.\u0005\u2004 = false;
    this.\u0008\u2004 = false;
    this.\u0006\u2004 = false;
    this.\u000E\u2004 = false;
    this.\u000E\u2001 = true;
    this.\u000F\u2001 = true;
    this.\u0002\u2002 = true;
    this.\u0003\u2002 = true;
    this.\u0003\u2008.Visible = false;
    this.\u0005\u2008.Visible = false;
    this.\u0006\u2008.Visible = false;
    this.\u0008\u2008.Visible = false;
    this.\u0005​\u2003.Visible = false;
    this.\u000E\u2005 = 0;
    this.\u000F\u2005 = 0;
    this.\u0002\u2006 = 0;
    this.\u0006\u2003 = false;
    this.\u000E\u2003 = false;
    this.\u000F\u2003 = false;
    this.\u0002\u2004 = false;
    this.\u0003\u2004 = false;
    this.\u0002\u2007 = 2;
    this.\u0003\u2007 = 2;
    this.\u0005\u2007 = 2;
    this.\u0008\u2007 = 2;
    --this.\u0006\u2005;
    this.\u0005();
    this.\u0005\u2006 = 0;
    this.\u0008\u2006 = 0;
    this.\u0006\u2006 = 0;
    this.\u000E\u2006 = 0;
    this.\u000F\u2006 = 1;
    this.\u000F\u2002 = false;
    this.\u0002\u2003 = false;
    this.\u0003\u2003 = false;
    this.\u0005\u2003 = false;
    this.\u0008\u2003 = false;
    this.\u0008\u2000 = 0;
    this.\u000E\u2000 = 1;
    this.\u0006\u2000 = 0;
    this.\u0005​\u2003.Left = 24;
    this.\u0005​\u2003.Top = 364;
    this.\u0003\u2008.Left = 176;
    this.\u0003\u2008.Top = 150;
    this.\u0005\u2008.Left = 154;
    this.\u0005\u2008.Top = 185;
    this.\u0006\u2008.Left = 176;
    this.\u0006\u2008.Top = 185;
    this.\u0008\u2008.Left = 199;
    this.\u0008\u2008.Top = 185;
    this.\u0002 = 0;
    this.\u0003 = 0;
    this.\u0005 = 0;
    this.\u0008 = 0;
    this.\u000E = 0;
    this.\u000F = 0;
    this.\u0002\u2000 = 0;
    this.\u0003\u2000 = 0;
    this.\u0006 = 0;
    this.\u0005\u2000 = 0;
    this.\u000E\u200A\u2003.Enabled = false;
    this.\u0005​\u2003.Image = (Image) \u000E\u2000.\u0003();
    this.\u0003\u2008.Image = (Image) \u000E\u2000.\u0003\u2005();
    this.\u0005\u2008.Image = (Image) \u000E\u2000.\u0002\u2000();
    this.\u0006\u2008.Image = (Image) \u000E\u2000.\u0003\u2006();
    this.\u0008\u2008.Image = (Image) \u000E\u2000.\u000E\u2001();
    this.\u0003\u2008.Visible = true;
    this.\u0005\u2008.Visible = true;
    this.\u0006\u2008.Visible = true;
    this.\u0008\u2008.Visible = true;
    this.\u0005​\u2003.SetBounds(this.\u0005​\u2003.Left, this.\u0005​\u2003.Top, 22, 22);
    this.\u0005​\u2003.Visible = true;
    this.\u0008\u2009.Enabled = true;
    this.\u0006\u2009.Enabled = true;
    this.\u000E\u200A\u2003.Interval = 1900;
  }

  private void \u0006\u2001(object _param1, EventArgs _param2)
  {
    this.\u0003​\u2003.Visible = true;
    this.\u0002​\u2003.Visible = true;
    this.\u000E​\u2003.Enabled = false;
  }

  private void \u0002()
  {
    this.\u0005\u2002 = false;
    this.\u0008\u2002 = false;
    this.\u0006\u2002 = false;
    this.\u000E\u2002 = false;
    this.\u0005\u2004 = false;
    this.\u0008\u2004 = false;
    this.\u0006\u2004 = false;
    this.\u000E\u2004 = false;
    this.\u000E\u2001 = true;
    this.\u000F\u2001 = true;
    this.\u0002\u2002 = true;
    this.\u0003\u2002 = true;
    this.\u0002\u2000\u2004.Visible = false;
    this.\u0003\u2000\u2004.Visible = false;
    this.\u0005​\u2003.SetBounds(this.\u0005​\u2003.Left, this.\u0005​\u2003.Top, 22, 22);
    this.\u000E\u2005 = 0;
    this.\u000F\u2005 = 0;
    this.\u0002\u2006 = 0;
    this.\u0006\u2003 = false;
    this.\u000E\u2003 = false;
    this.\u000F\u2003 = false;
    this.\u0002\u2004 = false;
    this.\u0003\u2004 = false;
    this.\u0002\u2007 = 2;
    this.\u0003\u2007 = 2;
    this.\u0005\u2007 = 2;
    this.\u0008\u2007 = 2;
    this.\u0005();
    this.\u0005\u2006 = 0;
    this.\u0008\u2006 = 0;
    this.\u0006\u2006 = 0;
    this.\u000E\u2006 = 0;
    this.\u000F\u2006 = 1;
    this.\u000F\u2002 = false;
    this.\u0002\u2003 = false;
    this.\u0003\u2003 = false;
    this.\u0005\u2003 = false;
    this.\u0008\u2003 = false;
    this.\u0008\u2000 = 0;
    this.\u000E\u2000 = 1;
    this.\u0006\u2000 = 0;
    this.\u0005​\u2003.Left = 24;
    this.\u0005​\u2003.Top = 364;
    this.\u0003\u2008.Left = 176;
    this.\u0003\u2008.Top = 150;
    this.\u0005\u2008.Left = 154;
    this.\u0005\u2008.Top = 185;
    this.\u0006\u2008.Left = 176;
    this.\u0006\u2008.Top = 185;
    this.\u0008\u2008.Left = 199;
    this.\u0008\u2008.Top = 185;
    this.\u0002 = 0;
    this.\u0003 = 0;
    this.\u0005 = 0;
    this.\u0008 = 0;
    this.\u000E = 0;
    this.\u000F = 0;
    this.\u0002\u2000 = 0;
    this.\u0003\u2000 = 0;
    this.\u0006 = 0;
    this.\u0005\u2000 = 0;
    this.\u0005​\u2003.Image = (Image) \u000E\u2000.\u0003();
    this.\u0003\u2008.Image = (Image) \u000E\u2000.\u0003\u2005();
    this.\u0005\u2008.Image = (Image) \u000E\u2000.\u0002\u2000();
    this.\u0006\u2008.Image = (Image) \u000E\u2000.\u0003\u2006();
    this.\u0008\u2008.Image = (Image) \u000E\u2000.\u000E\u2001();
    this.\u0002\u2008.Enabled = false;
    this.\u000E\u2009.Enabled = false;
    this.\u000F\u2009.Enabled = false;
    this.\u0002\u200A.Enabled = false;
    this.\u0006​\u2003.Enabled = false;
    this.\u000E\u200A\u2003.Enabled = false;
    this.\u0008​\u2003.Enabled = false;
    this.\u0005\u2000\u2004.Enabled = false;
    if (this.\u0006\u2001)
    {
      this.\u0008\u2009.Enabled = true;
      this.\u0006\u2009.Enabled = true;
    }
    this.\u0006\u2001 = false;
    for (int index = 0; index < 332; ++index)
      ((Control) this.\u000E\u2007[index]).Visible = true;
  }

  private void \u000E\u2001(object _param1, EventArgs _param2)
  {
    this.\u0006​\u2003.Enabled = false;
    this.\u000F\u200A\u2003.Visible = true;
    this.\u0008\u2000\u2004.Enabled = true;
  }

  private void \u000F\u2001(object _param1, EventArgs _param2)
  {
    this.\u0002();
    this.\u0008\u2000\u2004.Enabled = false;
  }

  private void \u0003()
  {
    if (this.\u0005\u2008.Top != 185)
      return;
    this.\u0006\u2009.Enabled = false;
    this.\u000E\u2009.Enabled = true;
    this.\u0008\u2003 = false;
    this.\u000F\u2009.Enabled = true;
  }

  private void \u0005()
  {
    if (this.\u0006\u2005 == 3)
    {
      this.\u0002\u2009.Visible = true;
      this.\u0003\u2009.Visible = true;
    }
    if (this.\u0006\u2005 == 2)
    {
      this.\u0002\u2009.Visible = true;
      this.\u0003\u2009.Visible = false;
    }
    if (this.\u0006\u2005 != 1)
      return;
    this.\u0002\u2009.Visible = false;
    this.\u0003\u2009.Visible = false;
  }

  private void \u0008()
  {
    if (this.\u0005​\u2003.Bounds.IntersectsWith(this.\u0002​\u2001.Bounds) && this.\u0002​\u2001.Visible)
      this.\u0006();
    if (this.\u0005​\u2003.Bounds.IntersectsWith(this.\u000E\u2005\u2003.Bounds) && this.\u000E\u2005\u2003.Visible)
      this.\u0006();
    if (this.\u0005​\u2003.Bounds.IntersectsWith(this.\u000E\u2005\u2002.Bounds) && this.\u000E\u2005\u2002.Visible)
      this.\u0006();
    if (!this.\u0005​\u2003.Bounds.IntersectsWith(this.\u000F\u2008\u2000.Bounds) || !this.\u000F\u2008\u2000.Visible)
      return;
    this.\u0006();
  }

  private void \u0006()
  {
    if (!this.\u0005\u2002)
    {
      this.\u0005\u2004 = false;
      this.\u0002\u2007 = 2;
      this.\u000E\u2003 = true;
      this.\u0003\u2008.Image = (Image) \u000E\u2000.\u0008\u2000();
      this.\u000E\u2001 = true;
    }
    if (!this.\u0008\u2002)
    {
      this.\u0008\u2004 = false;
      this.\u0003\u2007 = 2;
      this.\u000F\u2003 = true;
      this.\u0005\u2008.Image = (Image) \u000E\u2000.\u0008\u2000();
      this.\u000F\u2001 = true;
    }
    if (!this.\u0006\u2002)
    {
      this.\u0006\u2004 = false;
      this.\u0005\u2007 = 2;
      this.\u0002\u2004 = true;
      this.\u0006\u2008.Image = (Image) \u000E\u2000.\u0008\u2000();
      this.\u0002\u2002 = true;
    }
    if (!this.\u000E\u2002)
    {
      this.\u000E\u2004 = false;
      this.\u0008\u2007 = 2;
      this.\u0003\u2004 = true;
      this.\u0008\u2008.Image = (Image) \u000E\u2000.\u0008\u2000();
      this.\u0003\u2002 = true;
    }
    this.\u0008​\u2003.Enabled = false;
    this.\u0005\u2000\u2004.Enabled = false;
    this.\u0005\u2000\u2004.Enabled = true;
    this.\u000F\u2004 = false;
    this.\u0008​\u2003.Enabled = true;
    this.\u0006\u2003 = true;
  }

  private void \u0002\u2002(object _param1, EventArgs _param2)
  {
    this.\u000F\u2004 = true;
    this.\u0005\u2000\u2004.Enabled = false;
  }

  private void \u000E()
  {
    if (!this.\u0005​\u2003.Bounds.IntersectsWith(this.\u0003\u2008.Bounds) && !this.\u0005​\u2003.Bounds.IntersectsWith(this.\u0005\u2008.Bounds) && !this.\u0005​\u2003.Bounds.IntersectsWith(this.\u0006\u2008.Bounds) && !this.\u0005​\u2003.Bounds.IntersectsWith(this.\u0008\u2008.Bounds))
      return;
    if (this.\u0005​\u2003.Bounds.IntersectsWith(this.\u0003\u2008.Bounds) && !this.\u000E\u2003)
      this.\u000F();
    if (this.\u0005​\u2003.Bounds.IntersectsWith(this.\u0005\u2008.Bounds) && !this.\u000F\u2003)
      this.\u000F();
    if (this.\u0005​\u2003.Bounds.IntersectsWith(this.\u0006\u2008.Bounds) && !this.\u0002\u2004)
      this.\u000F();
    if (this.\u0005​\u2003.Bounds.IntersectsWith(this.\u0008\u2008.Bounds) && !this.\u0003\u2004)
      this.\u000F();
    if (this.\u0006\u2003)
    {
      if (this.\u0005​\u2003.Bounds.IntersectsWith(this.\u0003\u2008.Bounds) && !this.\u000E\u2003)
        this.\u000F();
      if (this.\u0005​\u2003.Bounds.IntersectsWith(this.\u0005\u2008.Bounds) && !this.\u000F\u2003)
        this.\u000F();
      if (this.\u0005​\u2003.Bounds.IntersectsWith(this.\u0006\u2008.Bounds) && !this.\u0002\u2004)
        this.\u000F();
      if (this.\u0005​\u2003.Bounds.IntersectsWith(this.\u0008\u2008.Bounds) && !this.\u0003\u2004)
        this.\u000F();
    }
    if (this.\u0005​\u2003.Bounds.IntersectsWith(this.\u0003\u2008.Bounds) && this.\u000E\u2001 && this.\u000E\u2003)
    {
      this.\u0005\u2002 = true;
      this.\u0005\u2004 = true;
      this.\u000E\u2001 = false;
      this.\u0002\u2008.Enabled = false;
      this.\u000F​\u2003.Enabled = true;
      this.\u0002\u2007 = 4;
    }
    if (this.\u0005​\u2003.Bounds.IntersectsWith(this.\u0005\u2008.Bounds) && this.\u000F\u2001 && this.\u000F\u2003)
    {
      this.\u0008\u2002 = true;
      this.\u0008\u2004 = true;
      this.\u000F\u2001 = false;
      this.\u0002\u2008.Enabled = false;
      this.\u000F​\u2003.Enabled = true;
      this.\u0003\u2007 = 4;
    }
    if (this.\u0005​\u2003.Bounds.IntersectsWith(this.\u0006\u2008.Bounds) && this.\u0002\u2002 && this.\u0002\u2004)
    {
      this.\u0006\u2002 = true;
      this.\u0006\u2004 = true;
      this.\u0002\u2002 = false;
      this.\u0002\u2008.Enabled = false;
      this.\u000F​\u2003.Enabled = true;
      this.\u0005\u2007 = 4;
    }
    if (!this.\u0005​\u2003.Bounds.IntersectsWith(this.\u0008\u2008.Bounds) || !this.\u0003\u2002 || !this.\u0003\u2004)
      return;
    this.\u000E\u2002 = true;
    this.\u000E\u2004 = true;
    this.\u0003\u2002 = false;
    this.\u0002\u2008.Enabled = false;
    this.\u000F​\u2003.Enabled = true;
    this.\u0008\u2007 = 4;
  }

  private void \u0003\u2002(object _param1, EventArgs _param2)
  {
    this.\u0002\u2008.Enabled = true;
    this.\u000F​\u2003.Enabled = false;
  }

  private void \u000F()
  {
    this.\u0005​\u2003.Image = (Image) \u000E\u2000.\u000E\u2003();
    if (this.\u0006\u2005 - 1 <= 0)
    {
      this.\u0002\u2000\u2004.Visible = true;
      this.\u0003\u2000();
    }
    else
    {
      this.\u0005\u2000 = 0;
      this.\u0006 = 0;
      this.\u000E = 0;
      this.\u000F = 0;
      this.\u0002\u2000 = 0;
      this.\u0003\u2000 = 0;
      this.\u0002 = 0;
      this.\u0003 = 0;
      this.\u0005 = 0;
      this.\u0008 = 0;
      this.\u0002\u2008.Enabled = false;
      this.\u000E\u2009.Enabled = false;
      this.\u000F\u2009.Enabled = false;
      this.\u0002\u200A.Enabled = false;
      this.\u000F\u2000 = false;
      this.\u0002\u2001 = false;
      this.\u0003\u2001 = false;
      this.\u0005\u2001 = false;
      this.\u0008\u2001 = false;
      this.\u000E\u200A\u2003.Enabled = true;
    }
  }

  private void \u0002\u2000()
  {
    for (int index = 0; index < 332; ++index)
    {
      if (((Control) this.\u000E\u2007[index]).Visible && this.\u0005​\u2003.Bounds.IntersectsWith(((Control) this.\u000E\u2007[index]).Bounds))
      {
        ++this.\u0003\u2006;
        ((Control) this.\u000E\u2007[index]).Visible = false;
      }
    }
    this.\u0003\u2002\u2000.Text = this.\u0003\u2006.ToString();
    if (this.\u0003\u2006 < 332)
      return;
    this.\u0003\u2000();
    this.\u0003\u2000\u2004.Visible = true;
  }

  private void \u0003\u2000()
  {
    this.\u0003\u2006 = 0;
    this.\u0006\u2005 = 3;
    this.\u0002\u2008.Enabled = false;
    this.\u0008\u2009.Enabled = false;
    this.\u0006\u2009.Enabled = false;
    this.\u000E\u2009.Enabled = false;
    this.\u000F\u2009.Enabled = false;
    this.\u0002\u200A.Enabled = false;
    this.\u0005\u2000\u2004.Enabled = false;
    this.\u0008​\u2003.Enabled = false;
    this.\u0006​\u2003.Enabled = true;
  }

  private void \u0005\u2000()
  {
    switch (this.\u0006\u2000)
    {
      case 1:
        if (this.\u0008\u2000 != 2)
          break;
        this.\u0006 = 2;
        this.\u0005​\u2003.Image = (Image) \u000E\u2000.\u0008\u2003();
        this.\u0006\u2000 = this.\u0008\u2000;
        this.\u000E\u2000 = this.\u0008\u2000;
        break;
      case 2:
        if (this.\u0008\u2000 != 1)
          break;
        this.\u0006 = -2;
        this.\u0005​\u2003.Image = (Image) \u000E\u2000.\u000F\u2003();
        this.\u0006\u2000 = this.\u0008\u2000;
        this.\u000E\u2000 = this.\u0008\u2000;
        break;
      case 3:
        if (this.\u0008\u2000 != 4)
          break;
        this.\u0005\u2000 = 2;
        this.\u0005​\u2003.Image = (Image) \u000E\u2000.\u0005\u2003();
        this.\u0006\u2000 = this.\u0008\u2000;
        this.\u000E\u2000 = this.\u0008\u2000;
        break;
      case 4:
        if (this.\u0008\u2000 != 3)
          break;
        this.\u0005\u2000 = -2;
        this.\u0005​\u2003.Image = (Image) \u000E\u2000.\u0002\u2004();
        this.\u0006\u2000 = this.\u0008\u2000;
        this.\u000E\u2000 = this.\u0008\u2000;
        break;
    }
  }

  private void \u0002(int _param1, int _param2, int _param3, int _param4)
  {
    if (this.\u0002\u2001)
    {
      if (this.\u000E\u2003 && !this.\u000E\u2001)
      {
        if (this.\u0003\u2008.Left < 180 && this.\u0003\u2008.Top == 150 || this.\u0003\u2008.Left > 170 && this.\u0003\u2008.Top == 150)
        {
          this.\u0002\u2007 = 2;
          this.\u000E\u2003 = false;
          this.\u0005\u2004 = false;
          this.\u000E\u2001 = true;
          this.\u0005\u2002 = false;
        }
        else
        {
          if (this.\u0003\u2008.Top < 150 && (_param3 == 1 && _param4 == 1))
            _param3 = 0;
          if (this.\u0003\u2008.Top > 150 && (_param3 == 1 && _param4 == 1))
            _param4 = 0;
          if (this.\u0003\u2008.Left < 176 && (_param1 == 1 && _param2 == 1))
            _param1 = 0;
          if (this.\u0003\u2008.Left > 176 && (_param1 == 1 && _param2 == 1))
            _param2 = 0;
        }
      }
      this.\u000E = 0;
      this.\u0002 = 0;
      while (!this.\u000F\u2002)
      {
        this.\u0002\u2005 = this.\u0006\u2007.Next(1, 5);
        if (this.\u0002\u2005 == 1 && !this.\u000F\u2002 && this.\u0002\u2005 != this.\u0005\u2006 && _param1 == 1)
        {
          this.\u0002 = -this.\u0002\u2007;
          this.\u000F\u2002 = true;
          if (!this.\u000E\u2003 && this.\u000E\u2001)
            this.\u0003\u2008.Image = (Image) \u000E\u2000.\u0002\u2005();
          else if (!this.\u000F\u2004 || this.\u0005\u2002)
          {
            if (!this.\u000F\u2004)
              this.\u0003\u2008.Image = (Image) \u000E\u2000.\u0008\u2000();
            if (this.\u0005\u2002)
              this.\u0003\u2008.Image = (Image) \u000E\u2000.\u000F\u2002();
          }
          else
            this.\u0003\u2008.Image = (Image) \u000E\u2000.\u0008\u2005();
        }
        if (this.\u0002\u2005 == 2 && !this.\u000F\u2002 && this.\u0002\u2005 != this.\u0005\u2006 && _param2 == 1)
        {
          this.\u0002 = this.\u0002\u2007;
          this.\u000F\u2002 = true;
          if (!this.\u000E\u2003 && this.\u000E\u2001)
            this.\u0003\u2008.Image = (Image) \u000E\u2000.\u000E\u2004();
          else if (!this.\u000F\u2004 || this.\u0005\u2002)
          {
            if (!this.\u000F\u2004)
              this.\u0003\u2008.Image = (Image) \u000E\u2000.\u0008\u2000();
            if (this.\u0005\u2002)
              this.\u0003\u2008.Image = (Image) \u000E\u2000.\u000E\u2002();
          }
          else
            this.\u0003\u2008.Image = (Image) \u000E\u2000.\u0008\u2005();
        }
        if (this.\u0002\u2005 == 3 && !this.\u000F\u2002 && this.\u0002\u2005 != this.\u0005\u2006 && _param4 == 1)
        {
          this.\u000E = this.\u0002\u2007;
          this.\u000F\u2002 = true;
          if (!this.\u000E\u2003 && this.\u000E\u2001)
            this.\u0003\u2008.Image = (Image) \u000E\u2000.\u0006\u2004();
          else if (!this.\u000F\u2004 || this.\u0005\u2002)
          {
            if (!this.\u000F\u2004)
              this.\u0003\u2008.Image = (Image) \u000E\u2000.\u0008\u2000();
            if (this.\u0005\u2002)
              this.\u0003\u2008.Image = (Image) \u000E\u2000.\u0006\u2002();
          }
          else
            this.\u0003\u2008.Image = (Image) \u000E\u2000.\u0008\u2005();
        }
        if (this.\u0002\u2005 == 4 && !this.\u000F\u2002 && this.\u0002\u2005 != this.\u0005\u2006 && _param3 == 1)
        {
          this.\u000E = -this.\u0002\u2007;
          this.\u000F\u2002 = true;
          if (!this.\u000E\u2003 && this.\u000E\u2001)
            this.\u0003\u2008.Image = (Image) \u000E\u2000.\u0003\u2005();
          else if (!this.\u000F\u2004 || this.\u0005\u2002)
          {
            if (!this.\u000F\u2004)
              this.\u0003\u2008.Image = (Image) \u000E\u2000.\u0008\u2000();
            if (this.\u0005\u2002)
              this.\u0003\u2008.Image = (Image) \u000E\u2000.\u0003\u2003();
          }
          else
            this.\u0003\u2008.Image = (Image) \u000E\u2000.\u0008\u2005();
        }
      }
      if (this.\u0002\u2005 == 1)
        this.\u0005\u2006 = 2;
      if (this.\u0002\u2005 == 2)
        this.\u0005\u2006 = 1;
      if (this.\u0002\u2005 == 3)
        this.\u0005\u2006 = 4;
      if (this.\u0002\u2005 == 4)
        this.\u0005\u2006 = 3;
      this.\u000F\u2002 = false;
    }
    if (this.\u0003\u2001)
    {
      if (this.\u000F\u2003 && !this.\u000F\u2001)
      {
        if (this.\u0005\u2008.Left < 180 && this.\u0005\u2008.Top == 150 || this.\u0005\u2008.Left > 170 && this.\u0005\u2008.Top == 150)
        {
          this.\u0003\u2007 = 2;
          this.\u000F\u2003 = false;
          this.\u0008\u2004 = false;
          this.\u000F\u2001 = true;
          this.\u0008\u2002 = false;
        }
        else
        {
          if (this.\u0005\u2008.Top < 150 && (_param3 == 1 && _param4 == 1))
            _param3 = 0;
          if (this.\u0005\u2008.Top > 150 && (_param3 == 1 && _param4 == 1))
            _param4 = 0;
          if (this.\u0005\u2008.Left < 176 && (_param1 == 1 && _param2 == 1))
            _param1 = 0;
          if (this.\u0005\u2008.Left > 176 && (_param1 == 1 && _param2 == 1))
            _param2 = 0;
        }
      }
      this.\u000F = 0;
      this.\u0003 = 0;
      while (!this.\u0002\u2003)
      {
        this.\u0003\u2005 = this.\u0006\u2007.Next(1, 5);
        if (this.\u0003\u2005 == 1 && !this.\u0002\u2003 && this.\u0003\u2005 != this.\u0008\u2006 && _param1 == 1)
        {
          this.\u0003 = -this.\u0003\u2007;
          this.\u0002\u2003 = true;
          if (!this.\u000F\u2003 && this.\u000F\u2001)
            this.\u0005\u2008.Image = (Image) \u000E\u2000.\u000F();
          else if (!this.\u000F\u2004 || this.\u0008\u2002)
          {
            if (!this.\u000F\u2004)
              this.\u0005\u2008.Image = (Image) \u000E\u2000.\u0008\u2000();
            if (this.\u0008\u2002)
              this.\u0005\u2008.Image = (Image) \u000E\u2000.\u000F\u2002();
          }
          else
            this.\u0005\u2008.Image = (Image) \u000E\u2000.\u0008\u2005();
        }
        if (this.\u0003\u2005 == 2 && !this.\u0002\u2003 && this.\u0003\u2005 != this.\u0008\u2006 && _param2 == 1)
        {
          this.\u0003 = this.\u0003\u2007;
          this.\u0002\u2003 = true;
          if (!this.\u000F\u2003 && this.\u000F\u2001)
            this.\u0005\u2008.Image = (Image) \u000E\u2000.\u000E();
          else if (!this.\u000F\u2004 || this.\u0008\u2002)
          {
            if (!this.\u000F\u2004)
              this.\u0005\u2008.Image = (Image) \u000E\u2000.\u0008\u2000();
            if (this.\u0008\u2002)
              this.\u0005\u2008.Image = (Image) \u000E\u2000.\u000E\u2002();
          }
          else
            this.\u0005\u2008.Image = (Image) \u000E\u2000.\u0008\u2005();
        }
        if (this.\u0003\u2005 == 3 && !this.\u0002\u2003 && this.\u0003\u2005 != this.\u0008\u2006 && _param4 == 1)
        {
          this.\u000F = this.\u0003\u2007;
          this.\u0002\u2003 = true;
          if (!this.\u000F\u2003 && this.\u000F\u2001)
            this.\u0005\u2008.Image = (Image) \u000E\u2000.\u0006();
          else if (!this.\u000F\u2004 || this.\u0008\u2002)
          {
            if (!this.\u000F\u2004)
              this.\u0005\u2008.Image = (Image) \u000E\u2000.\u0008\u2000();
            if (this.\u0008\u2002)
              this.\u0005\u2008.Image = (Image) \u000E\u2000.\u0006\u2002();
          }
          else
            this.\u0005\u2008.Image = (Image) \u000E\u2000.\u0008\u2005();
        }
        if (this.\u0003\u2005 == 4 && !this.\u0002\u2003 && this.\u0003\u2005 != this.\u0008\u2006 && _param3 == 1)
        {
          this.\u000F = -this.\u0003\u2007;
          this.\u0002\u2003 = true;
          if (!this.\u000F\u2003 && this.\u000F\u2001)
            this.\u0005\u2008.Image = (Image) \u000E\u2000.\u0002\u2000();
          else if (!this.\u000F\u2004 || this.\u0008\u2002)
          {
            if (!this.\u000F\u2004)
              this.\u0005\u2008.Image = (Image) \u000E\u2000.\u0008\u2000();
            if (this.\u0008\u2002)
              this.\u0005\u2008.Image = (Image) \u000E\u2000.\u0003\u2003();
          }
          else
            this.\u0005\u2008.Image = (Image) \u000E\u2000.\u0008\u2005();
        }
      }
      if (this.\u0003\u2005 == 1)
        this.\u0008\u2006 = 2;
      if (this.\u0003\u2005 == 2)
        this.\u0008\u2006 = 1;
      if (this.\u0003\u2005 == 3)
        this.\u0008\u2006 = 4;
      if (this.\u0003\u2005 == 4)
        this.\u0008\u2006 = 3;
      this.\u0002\u2003 = false;
    }
    if (this.\u0005\u2001)
    {
      if (this.\u0002\u2004 && !this.\u0002\u2002)
      {
        if (this.\u0006\u2008.Left < 180 && this.\u0006\u2008.Top == 150 || this.\u0006\u2008.Left > 170 && this.\u0006\u2008.Top == 150)
        {
          this.\u0005\u2007 = 2;
          this.\u0002\u2004 = false;
          this.\u0006\u2004 = false;
          this.\u0002\u2002 = true;
          this.\u0006\u2002 = false;
        }
        else
        {
          if (this.\u0006\u2008.Top > 150 && (_param3 == 1 && _param4 == 1))
            _param4 = 0;
          if (this.\u0006\u2008.Top < 150 && (_param3 == 1 && _param4 == 1))
            _param3 = 0;
          if (this.\u0006\u2008.Left < 176 && (_param1 == 1 && _param2 == 1))
            _param1 = 0;
          if (this.\u0006\u2008.Left > 176 && (_param1 == 1 && _param2 == 1))
            _param2 = 0;
        }
      }
      this.\u0002\u2000 = 0;
      this.\u0005 = 0;
      while (!this.\u0003\u2003)
      {
        this.\u0005\u2005 = this.\u0006\u2007.Next(1, 5);
        if (this.\u0005\u2005 == 1 && !this.\u0003\u2003 && this.\u0005\u2005 != this.\u0006\u2006 && _param1 == 1)
        {
          this.\u0005 = -this.\u0005\u2007;
          this.\u0003\u2003 = true;
          if (!this.\u0002\u2004 && this.\u0002\u2002)
            this.\u0006\u2008.Image = (Image) \u000E\u2000.\u0002\u2006();
          else if (!this.\u000F\u2004 || this.\u0006\u2002)
          {
            if (!this.\u000F\u2004)
              this.\u0006\u2008.Image = (Image) \u000E\u2000.\u0008\u2000();
            if (this.\u0006\u2002)
              this.\u0006\u2008.Image = (Image) \u000E\u2000.\u000F\u2002();
          }
          else
            this.\u0006\u2008.Image = (Image) \u000E\u2000.\u0008\u2005();
        }
        if (this.\u0005\u2005 == 2 && !this.\u0003\u2003 && this.\u0005\u2005 != this.\u0006\u2006 && _param2 == 1)
        {
          this.\u0005 = this.\u0005\u2007;
          this.\u0003\u2003 = true;
          if (!this.\u0002\u2004 && this.\u0002\u2002)
            this.\u0006\u2008.Image = (Image) \u000E\u2000.\u000E\u2005();
          else if (!this.\u000F\u2004 || this.\u0006\u2002)
          {
            if (!this.\u000F\u2004)
              this.\u0006\u2008.Image = (Image) \u000E\u2000.\u0008\u2000();
            if (this.\u0006\u2002)
              this.\u0006\u2008.Image = (Image) \u000E\u2000.\u000E\u2002();
          }
          else
            this.\u0006\u2008.Image = (Image) \u000E\u2000.\u0008\u2005();
        }
        if (this.\u0005\u2005 == 3 && !this.\u0003\u2003 && this.\u0005\u2005 != this.\u0006\u2006 && _param4 == 1)
        {
          this.\u0002\u2000 = this.\u0005\u2007;
          this.\u0003\u2003 = true;
          if (!this.\u0002\u2004 && this.\u0002\u2002)
            this.\u0006\u2008.Image = (Image) \u000E\u2000.\u0006\u2005();
          else if (!this.\u000F\u2004 || this.\u0006\u2002)
          {
            if (!this.\u000F\u2004)
              this.\u0006\u2008.Image = (Image) \u000E\u2000.\u0008\u2000();
            if (this.\u0006\u2002)
              this.\u0006\u2008.Image = (Image) \u000E\u2000.\u0006\u2002();
          }
          else
            this.\u0006\u2008.Image = (Image) \u000E\u2000.\u0008\u2005();
        }
        if (this.\u0005\u2005 == 4 && !this.\u0003\u2003 && this.\u0005\u2005 != this.\u0006\u2006 && _param3 == 1)
        {
          this.\u0002\u2000 = -this.\u0005\u2007;
          this.\u0003\u2003 = true;
          if (!this.\u0002\u2004 && this.\u0002\u2002)
            this.\u0006\u2008.Image = (Image) \u000E\u2000.\u0003\u2006();
          else if (!this.\u000F\u2004 || this.\u0006\u2002)
          {
            if (!this.\u000F\u2004)
              this.\u0006\u2008.Image = (Image) \u000E\u2000.\u0008\u2000();
            if (this.\u0006\u2002)
              this.\u0006\u2008.Image = (Image) \u000E\u2000.\u0003\u2003();
          }
          else
            this.\u0006\u2008.Image = (Image) \u000E\u2000.\u0008\u2005();
        }
      }
      if (this.\u0005\u2005 == 1)
        this.\u0006\u2006 = 2;
      if (this.\u0005\u2005 == 2)
        this.\u0006\u2006 = 1;
      if (this.\u0005\u2005 == 3)
        this.\u0006\u2006 = 4;
      if (this.\u0005\u2005 == 4)
        this.\u0006\u2006 = 3;
      this.\u0003\u2003 = false;
    }
    if (this.\u0008\u2001)
    {
      if (this.\u0003\u2004 && !this.\u0003\u2002)
      {
        if (this.\u0008\u2008.Left < 180 && this.\u0008\u2008.Top == 150 || this.\u0008\u2008.Left > 170 && this.\u0008\u2008.Top == 150)
        {
          this.\u0008\u2007 = 2;
          this.\u0003\u2004 = false;
          this.\u000E\u2004 = false;
          this.\u0003\u2002 = true;
          this.\u000E\u2002 = false;
        }
        else
        {
          if (this.\u0008\u2008.Top > 150 && (_param3 == 1 && _param4 == 1))
            _param4 = 0;
          if (this.\u0008\u2008.Top < 150 && (_param3 == 1 && _param4 == 1))
            _param3 = 0;
          if (this.\u0008\u2008.Left < 176 && (_param1 == 1 && _param2 == 1))
            _param1 = 0;
          if (this.\u0008\u2008.Left > 176 && (_param1 == 1 && _param2 == 1))
            _param2 = 0;
        }
      }
      this.\u0003\u2000 = 0;
      this.\u0008 = 0;
      while (!this.\u0005\u2003)
      {
        this.\u0008\u2005 = this.\u0006\u2007.Next(1, 5);
        if (this.\u0008\u2005 == 1 && !this.\u0005\u2003 && this.\u0008\u2005 != this.\u000E\u2006 && _param1 == 1)
        {
          this.\u0008 = -this.\u0008\u2007;
          this.\u0005\u2003 = true;
          if (!this.\u0003\u2004 && this.\u0003\u2002)
            this.\u0008\u2008.Image = (Image) \u000E\u2000.\u0006\u2001();
          else if (!this.\u000F\u2004 || this.\u000E\u2002)
          {
            if (!this.\u000F\u2004)
              this.\u0008\u2008.Image = (Image) \u000E\u2000.\u0008\u2000();
            if (this.\u000E\u2002)
              this.\u0008\u2008.Image = (Image) \u000E\u2000.\u000F\u2002();
          }
          else
            this.\u0008\u2008.Image = (Image) \u000E\u2000.\u0008\u2005();
        }
        if (this.\u0008\u2005 == 2 && !this.\u0005\u2003 && this.\u0008\u2005 != this.\u000E\u2006 && _param2 == 1)
        {
          this.\u0008 = this.\u0008\u2007;
          this.\u0005\u2003 = true;
          if (!this.\u0003\u2004 && this.\u0003\u2002)
            this.\u0008\u2008.Image = (Image) \u000E\u2000.\u0005\u2001();
          else if (!this.\u000F\u2004 || this.\u000E\u2002)
          {
            if (!this.\u000F\u2004)
              this.\u0008\u2008.Image = (Image) \u000E\u2000.\u0008\u2000();
            if (this.\u000E\u2002)
              this.\u0008\u2008.Image = (Image) \u000E\u2000.\u000E\u2002();
          }
          else
            this.\u0008\u2008.Image = (Image) \u000E\u2000.\u0008\u2005();
        }
        if (this.\u0008\u2005 == 3 && !this.\u0005\u2003 && this.\u0008\u2005 != this.\u000E\u2006 && _param4 == 1)
        {
          this.\u0003\u2000 = this.\u0008\u2007;
          this.\u0005\u2003 = true;
          if (!this.\u0003\u2004 && this.\u0003\u2002)
            this.\u0008\u2008.Image = (Image) \u000E\u2000.\u0003\u2001();
          else if (!this.\u000F\u2004 || this.\u000E\u2002)
          {
            if (!this.\u000F\u2004)
              this.\u0008\u2008.Image = (Image) \u000E\u2000.\u0008\u2000();
            if (this.\u000E\u2002)
              this.\u0008\u2008.Image = (Image) \u000E\u2000.\u0006\u2002();
          }
          else
            this.\u0008\u2008.Image = (Image) \u000E\u2000.\u0008\u2005();
        }
        if (this.\u0008\u2005 == 4 && !this.\u0005\u2003 && this.\u0008\u2005 != this.\u000E\u2006 && _param3 == 1)
        {
          this.\u0003\u2000 = -this.\u0008\u2007;
          this.\u0005\u2003 = true;
          if (!this.\u0003\u2004 && this.\u0003\u2002)
            this.\u0008\u2008.Image = (Image) \u000E\u2000.\u000E\u2001();
          else if (!this.\u000F\u2004 || this.\u000E\u2002)
          {
            if (!this.\u000F\u2004)
              this.\u0008\u2008.Image = (Image) \u000E\u2000.\u0008\u2000();
            if (this.\u000E\u2002)
              this.\u0008\u2008.Image = (Image) \u000E\u2000.\u0003\u2003();
          }
          else
            this.\u0008\u2008.Image = (Image) \u000E\u2000.\u0008\u2005();
        }
      }
      if (this.\u0008\u2005 == 1)
        this.\u000E\u2006 = 2;
      if (this.\u0008\u2005 == 2)
        this.\u000E\u2006 = 1;
      if (this.\u0008\u2005 == 3)
        this.\u000E\u2006 = 4;
      if (this.\u0008\u2005 == 4)
        this.\u000E\u2006 = 3;
      this.\u0005\u2003 = false;
    }
    if (!this.\u000F\u2000)
      return;
    this.\u0005\u2000 = 0;
    this.\u0006 = 0;
    if (this.\u000E\u2000 == 1 && _param1 == 1 || this.\u000E\u2000 == 2 && _param2 == 1 || this.\u000E\u2000 == 3 && _param3 == 1 || this.\u000E\u2000 == 4 && _param4 == 1)
      this.\u0008\u2000 = this.\u000E\u2000;
    if (this.\u0008\u2000 == 1 && _param1 == 1)
    {
      this.\u0006 = -2;
      this.\u0005​\u2003.Image = (Image) \u000E\u2000.\u000F\u2003();
      this.\u0006\u2000 = this.\u0008\u2000;
    }
    if (this.\u0008\u2000 == 2 && _param2 == 1)
    {
      this.\u0006 = 2;
      this.\u0005​\u2003.Image = (Image) \u000E\u2000.\u0008\u2003();
      this.\u0006\u2000 = this.\u0008\u2000;
    }
    if (this.\u0008\u2000 == 3 && _param3 == 1)
    {
      this.\u0005\u2000 = -2;
      this.\u0005​\u2003.Image = (Image) \u000E\u2000.\u0002\u2004();
      this.\u0006\u2000 = this.\u0008\u2000;
    }
    if (this.\u0008\u2000 == 4 && _param4 == 1)
    {
      this.\u0005\u2000 = 2;
      this.\u0005​\u2003.Image = (Image) \u000E\u2000.\u0005\u2003();
      this.\u0006\u2000 = this.\u0008\u2000;
    }
    if (this.\u0005\u2000 != 0 || this.\u0006 != 0)
      return;
    this.\u000E\u2000 = this.\u0008\u2000;
    this.\u0008\u2000 = this.\u0006\u2000;
    if (this.\u0008\u2000 == 1)
      this.\u0005​\u2003.Image = (Image) \u000E\u2000.\u0005();
    if (this.\u0008\u2000 == 2)
      this.\u0005​\u2003.Image = (Image) \u000E\u2000.\u0003();
    if (this.\u0008\u2000 == 3)
      this.\u0005​\u2003.Image = (Image) \u000E\u2000.\u0008();
    if (this.\u0008\u2000 != 4)
      return;
    this.\u0005​\u2003.Image = (Image) \u000E\u2000.\u0002();
  }

  private void \u0008\u2000()
  {
    this.\u000F\u2000 = true;
    this.\u0002(this.\u0005​\u2003.Left, this.\u0005​\u2003.Top);
    this.\u0005​\u2003.Left += this.\u0006;
    this.\u0005​\u2003.Top += this.\u0005\u2000;
  }

  private void \u0002(int _param1, int _param2)
  {
    if (this.\u000F\u2000)
    {
      switch (_param1)
      {
        case -26:
          if (_param2 == 184)
          {
            this.\u0003(1, 0);
            break;
          }
          break;
        case 24:
          switch (_param2)
          {
            case 28:
              this.\u0002(0, 1, 0, 1);
              break;
            case 76:
              this.\u0002(0, 1, 1, 1);
              break;
            case 112:
              this.\u0002(0, 1, 1, 0);
              break;
            case 256:
              this.\u0002(0, 1, 0, 1);
              break;
            case 292:
              this.\u0002(0, 1, 1, 0);
              break;
            case 328:
              this.\u0002(0, 1, 0, 1);
              break;
            case 364:
              this.\u0002(0, 1, 1, 0);
              break;
          }
        case 48:
          switch (_param2)
          {
            case 292:
              this.\u0002(1, 0, 0, 1);
              break;
            case 328:
              this.\u0002(1, 1, 1, 0);
              break;
          }
        case 84:
          switch (_param2)
          {
            case 28:
              this.\u0002(1, 1, 0, 1);
              break;
            case 76:
              this.\u0002(1, 1, 1, 1);
              break;
            case 112:
              this.\u0002(1, 0, 1, 1);
              break;
            case 184:
              this.\u0002(1, 1, 1, 1);
              break;
            case 256:
              this.\u0002(1, 1, 1, 1);
              break;
            case 292:
              this.\u0002(0, 1, 1, 1);
              break;
            case 328:
              this.\u0002(1, 0, 1, 0);
              break;
          }
        case 120:
          switch (_param2)
          {
            case 76:
              this.\u0002(1, 1, 0, 1);
              break;
            case 112:
              this.\u0002(0, 1, 1, 0);
              break;
            case 148:
              this.\u0002(0, 1, 0, 1);
              break;
            case 184:
              this.\u0002(1, 0, 1, 1);
              break;
            case 220:
              this.\u0002(0, 1, 1, 1);
              break;
            case 256:
              this.\u0002(1, 1, 1, 0);
              break;
            case 292:
              this.\u0002(1, 1, 0, 1);
              break;
            case 328:
              this.\u0002(0, 1, 1, 0);
              break;
          }
        case 156:
          switch (_param2)
          {
            case 28:
              this.\u0002(1, 0, 0, 1);
              break;
            case 76:
              this.\u0002(1, 1, 1, 0);
              break;
            case 112:
              this.\u0002(1, 0, 0, 1);
              break;
            case 148:
              this.\u0002(1, 1, 1, 0);
              break;
            case 256:
              this.\u0002(1, 0, 0, 1);
              break;
            case 292:
              this.\u0002(1, 1, 1, 0);
              break;
            case 328:
              this.\u0002(1, 0, 0, 1);
              break;
            case 364:
              this.\u0002(1, 1, 1, 0);
              break;
          }
        case 174:
          if (_param2 == 148)
          {
            this.\u0002(1, 1, 0, 0);
            break;
          }
          break;
        case 192:
          switch (_param2)
          {
            case 28:
              this.\u0002(0, 1, 0, 1);
              break;
            case 76:
              this.\u0002(1, 1, 1, 0);
              break;
            case 112:
              this.\u0002(0, 1, 0, 1);
              break;
            case 148:
              this.\u0002(1, 1, 1, 0);
              break;
            case 256:
              this.\u0002(0, 1, 0, 1);
              break;
            case 292:
              this.\u0002(1, 1, 1, 0);
              break;
            case 328:
              this.\u0002(0, 1, 0, 1);
              break;
            case 364:
              this.\u0002(1, 1, 1, 0);
              break;
          }
        case 228:
          switch (_param2)
          {
            case 76:
              this.\u0002(1, 1, 0, 1);
              break;
            case 112:
              this.\u0002(1, 0, 1, 0);
              break;
            case 148:
              this.\u0002(1, 0, 0, 1);
              break;
            case 184:
              this.\u0002(0, 1, 1, 1);
              break;
            case 220:
              this.\u0002(1, 0, 1, 1);
              break;
            case 256:
              this.\u0002(1, 1, 1, 0);
              break;
            case 292:
              this.\u0002(1, 1, 0, 1);
              break;
            case 328:
              this.\u0002(1, 0, 1, 0);
              break;
          }
        case 264:
          switch (_param2)
          {
            case 28:
              this.\u0002(1, 1, 0, 1);
              break;
            case 76:
              this.\u0002(1, 1, 1, 1);
              break;
            case 112:
              this.\u0002(0, 1, 1, 1);
              break;
            case 184:
              this.\u0002(1, 1, 1, 1);
              break;
            case 256:
              this.\u0002(1, 1, 1, 1);
              break;
            case 292:
              this.\u0002(1, 0, 1, 1);
              break;
            case 328:
              this.\u0002(0, 1, 1, 0);
              break;
          }
        case 300:
          switch (_param2)
          {
            case 292:
              this.\u0002(0, 1, 0, 1);
              break;
            case 328:
              this.\u0002(1, 1, 1, 0);
              break;
          }
        case 324:
          switch (_param2)
          {
            case 28:
              this.\u0002(1, 0, 0, 1);
              break;
            case 76:
              this.\u0002(1, 0, 1, 1);
              break;
            case 112:
              this.\u0002(1, 0, 1, 0);
              break;
            case 256:
              this.\u0002(1, 0, 0, 1);
              break;
            case 292:
              this.\u0002(1, 0, 1, 0);
              break;
            case 328:
              this.\u0002(1, 0, 0, 1);
              break;
            case 364:
              this.\u0002(1, 0, 1, 0);
              break;
          }
        case 374:
          if (_param2 == 184)
          {
            this.\u0003(0, 1);
            break;
          }
          break;
      }
    }
    else
    {
      switch (_param1)
      {
        case -28:
          if (_param2 == 186)
          {
            this.\u0003(1, 0);
            break;
          }
          break;
        case 26:
          switch (_param2)
          {
            case 30:
              this.\u0002(0, 1, 0, 1);
              break;
            case 78:
              this.\u0002(0, 1, 1, 1);
              break;
            case 114:
              this.\u0002(0, 1, 1, 0);
              break;
            case 258:
              this.\u0002(0, 1, 0, 1);
              break;
            case 294:
              this.\u0002(0, 1, 1, 0);
              break;
            case 330:
              this.\u0002(0, 1, 0, 1);
              break;
            case 366:
              this.\u0002(0, 1, 1, 0);
              break;
          }
        case 50:
          switch (_param2)
          {
            case 294:
              this.\u0002(1, 0, 0, 1);
              break;
            case 330:
              this.\u0002(1, 1, 1, 0);
              break;
          }
        case 86:
          switch (_param2)
          {
            case 30:
              this.\u0002(1, 1, 0, 1);
              break;
            case 78:
              this.\u0002(1, 1, 1, 1);
              break;
            case 114:
              this.\u0002(1, 0, 1, 1);
              break;
            case 186:
              this.\u0002(1, 1, 1, 1);
              break;
            case 258:
              this.\u0002(1, 1, 1, 1);
              break;
            case 294:
              this.\u0002(0, 1, 1, 1);
              break;
            case 330:
              this.\u0002(1, 0, 1, 0);
              break;
          }
        case 122:
          switch (_param2)
          {
            case 78:
              this.\u0002(1, 1, 0, 1);
              break;
            case 114:
              this.\u0002(0, 1, 1, 0);
              break;
            case 150:
              this.\u0002(0, 1, 0, 1);
              break;
            case 186:
              this.\u0002(1, 0, 1, 1);
              break;
            case 222:
              this.\u0002(0, 1, 1, 1);
              break;
            case 258:
              this.\u0002(1, 1, 1, 0);
              break;
            case 294:
              this.\u0002(1, 1, 0, 1);
              break;
            case 330:
              this.\u0002(0, 1, 1, 0);
              break;
          }
        case 158:
          switch (_param2)
          {
            case 30:
              this.\u0002(1, 0, 0, 1);
              break;
            case 78:
              this.\u0002(1, 1, 1, 0);
              break;
            case 114:
              this.\u0002(1, 0, 0, 1);
              break;
            case 150:
              this.\u0002(1, 1, 1, 0);
              break;
            case 258:
              this.\u0002(1, 0, 0, 1);
              break;
            case 294:
              this.\u0002(1, 1, 1, 0);
              break;
            case 330:
              this.\u0002(1, 0, 0, 1);
              break;
            case 366:
              this.\u0002(1, 1, 1, 0);
              break;
          }
        case 176:
          if (_param2 == 150)
          {
            this.\u0002(1, 1, 0, 0);
            break;
          }
          break;
        case 194:
          switch (_param2)
          {
            case 30:
              this.\u0002(0, 1, 0, 1);
              break;
            case 78:
              this.\u0002(1, 1, 1, 0);
              break;
            case 114:
              this.\u0002(0, 1, 0, 1);
              break;
            case 150:
              this.\u0002(1, 1, 1, 0);
              break;
            case 258:
              this.\u0002(0, 1, 0, 1);
              break;
            case 294:
              this.\u0002(1, 1, 1, 0);
              break;
            case 330:
              this.\u0002(0, 1, 0, 1);
              break;
            case 366:
              this.\u0002(1, 1, 1, 0);
              break;
          }
        case 230:
          switch (_param2)
          {
            case 78:
              this.\u0002(1, 1, 0, 1);
              break;
            case 114:
              this.\u0002(1, 0, 1, 0);
              break;
            case 150:
              this.\u0002(1, 0, 0, 1);
              break;
            case 186:
              this.\u0002(0, 1, 1, 1);
              break;
            case 222:
              this.\u0002(1, 0, 1, 1);
              break;
            case 258:
              this.\u0002(1, 1, 1, 0);
              break;
            case 294:
              this.\u0002(1, 1, 0, 1);
              break;
            case 330:
              this.\u0002(1, 0, 1, 0);
              break;
          }
        case 266:
          switch (_param2)
          {
            case 30:
              this.\u0002(1, 1, 0, 1);
              break;
            case 78:
              this.\u0002(1, 1, 1, 1);
              break;
            case 114:
              this.\u0002(0, 1, 1, 1);
              break;
            case 186:
              this.\u0002(1, 1, 1, 1);
              break;
            case 258:
              this.\u0002(1, 1, 1, 1);
              break;
            case 294:
              this.\u0002(1, 0, 1, 1);
              break;
            case 330:
              this.\u0002(0, 1, 1, 0);
              break;
          }
        case 302:
          switch (_param2)
          {
            case 294:
              this.\u0002(0, 1, 0, 1);
              break;
            case 330:
              this.\u0002(1, 1, 1, 0);
              break;
          }
        case 326:
          switch (_param2)
          {
            case 30:
              this.\u0002(1, 0, 0, 1);
              break;
            case 78:
              this.\u0002(1, 0, 1, 1);
              break;
            case 114:
              this.\u0002(1, 0, 1, 0);
              break;
            case 258:
              this.\u0002(1, 0, 0, 1);
              break;
            case 294:
              this.\u0002(1, 0, 1, 0);
              break;
            case 330:
              this.\u0002(1, 0, 0, 1);
              break;
            case 366:
              this.\u0002(1, 0, 1, 0);
              break;
          }
        case 376:
          if (_param2 == 186)
          {
            this.\u0003(0, 1);
            break;
          }
          break;
      }
    }
    this.\u000F\u2000 = false;
    this.\u0002\u2001 = false;
    this.\u0003\u2001 = false;
    this.\u0005\u2001 = false;
    this.\u0008\u2001 = false;
  }

  private void \u0003(int _param1, int _param2)
  {
    if (this.\u000F\u2000)
    {
      if (_param1 == 0)
        this.\u0005​\u2003.Left = -26;
      if (_param2 == 0)
        this.\u0005​\u2003.Left = 374;
    }
    if (this.\u0002\u2001)
    {
      if (_param1 == 0)
        this.\u0003\u2008.Left = -26;
      if (_param2 == 0)
        this.\u0003\u2008.Left = 374;
    }
    if (this.\u0003\u2001)
    {
      if (_param1 == 0)
        this.\u0005\u2008.Left = -26;
      if (_param2 == 0)
        this.\u0005\u2008.Left = 374;
    }
    if (this.\u0005\u2001)
    {
      if (_param1 == 0)
        this.\u0006\u2008.Left = -26;
      if (_param2 == 0)
        this.\u0006\u2008.Left = 374;
    }
    if (!this.\u0008\u2001)
      return;
    if (_param1 == 0)
      this.\u0008\u2008.Left = -26;
    if (_param2 != 0)
      return;
    this.\u0008\u2008.Left = 374;
  }

  private void \u0006\u2000()
  {
    if (this.\u0003\u2008.Enabled)
    {
      this.\u0003\u2008.Left += this.\u0002;
      this.\u0003\u2008.Top += this.\u000E;
      this.\u0002\u2001 = true;
      this.\u0002(this.\u0003\u2008.Left, this.\u0003\u2008.Top);
    }
    if (this.\u0005\u2008.Enabled)
    {
      this.\u0005\u2008.Left += this.\u0003;
      this.\u0005\u2008.Top += this.\u000F;
      this.\u0003\u2001 = true;
      this.\u0002(this.\u0005\u2008.Left, this.\u0005\u2008.Top);
    }
    if (this.\u0006\u2008.Enabled)
    {
      this.\u0006\u2008.Left += this.\u0005;
      this.\u0006\u2008.Top += this.\u0002\u2000;
      this.\u0005\u2001 = true;
      this.\u0002(this.\u0006\u2008.Left, this.\u0006\u2008.Top);
    }
    if (!this.\u0008\u2008.Enabled)
      return;
    this.\u0008\u2008.Left += this.\u0008;
    this.\u0008\u2008.Top += this.\u0003\u2000;
    this.\u0008\u2001 = true;
    this.\u0002(this.\u0008\u2008.Left, this.\u0008\u2008.Top);
  }

  protected override void Dispose(bool _param1)
  {
    if (_param1 && this.\u000F\u2007 != null)
      this.\u000F\u2007.Dispose();
    base.Dispose(_param1);
  }

  private void \u000E\u2000()
  {
    this.\u000F\u2007 = (IContainer) new Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (\u0008\u2000));
    this.\u0002\u2008 = new Timer(this.\u000F\u2007);
    this.\u000E\u2008 = new Label();
    this.\u000F\u2008 = new Label();
    this.\u0005\u2009 = new Label();
    this.\u0008\u2009 = new Timer(this.\u000F\u2007);
    this.\u0006\u2009 = new Timer(this.\u000F\u2007);
    this.\u000E\u2009 = new Timer(this.\u000F\u2007);
    this.\u000F\u2009 = new Timer(this.\u000F\u2007);
    this.\u0002\u200A = new Timer(this.\u000F\u2007);
    this.\u0003\u2009 = new PictureBox();
    this.\u0002\u2009 = new PictureBox();
    this.\u0006\u2008 = new Label();
    this.\u0008\u2008 = new Label();
    this.\u0005\u2008 = new Label();
    this.\u0003\u2008 = new Label();
    this.\u0003\u200A = new Label();
    this.\u0005\u200A = new Label();
    this.\u0008\u200A = new Label();
    this.\u0006\u200A = new Label();
    this.\u000E\u200A = new Label();
    this.\u000F\u200A = new Label();
    this.\u0002​ = new Label();
    this.\u0003​ = new Label();
    this.\u0005​ = new Label();
    this.\u0008​ = new Label();
    this.\u0006​ = new Label();
    this.\u000E​ = new Label();
    this.\u000F​ = new Label();
    this.\u0002\u2000\u2000 = new Label();
    this.\u0003\u2000\u2000 = new Label();
    this.\u0005\u2000\u2000 = new Label();
    this.\u0008\u2000\u2000 = new Label();
    this.\u0006\u2000\u2000 = new Label();
    this.\u000E\u2000\u2000 = new Label();
    this.\u000F\u2000\u2000 = new Label();
    this.\u0002\u2001\u2000 = new Label();
    this.\u0003\u2001\u2000 = new Label();
    this.\u0005\u2001\u2000 = new Label();
    this.\u0008\u2001\u2000 = new Label();
    this.\u0006\u2001\u2000 = new Label();
    this.\u000E\u2001\u2000 = new Label();
    this.\u000F\u2001\u2000 = new Label();
    this.\u0002\u2002\u2000 = new Label();
    this.\u0003\u2002\u2000 = new Label();
    this.\u0005\u2002\u2000 = new Label();
    this.\u0008\u2002\u2000 = new Label();
    this.\u0006\u2002\u2000 = new Label();
    this.\u000E\u2002\u2000 = new Label();
    this.\u000F\u2002\u2000 = new Label();
    this.\u0002\u2003\u2000 = new Label();
    this.\u0003\u2003\u2000 = new Label();
    this.\u0005\u2003\u2000 = new Label();
    this.\u0008\u2003\u2000 = new Label();
    this.\u0006\u2003\u2000 = new Label();
    this.\u000E\u2003\u2000 = new Label();
    this.\u000F\u2003\u2000 = new Label();
    this.\u0002\u2004\u2000 = new Label();
    this.\u0003\u2004\u2000 = new Label();
    this.\u0005\u2004\u2000 = new Label();
    this.\u0008\u2004\u2000 = new Label();
    this.\u0006\u2004\u2000 = new Label();
    this.\u000E\u2004\u2000 = new Label();
    this.\u000F\u2004\u2000 = new Label();
    this.\u0002\u2006\u2000 = new Label();
    this.\u0003\u2006\u2000 = new Label();
    this.\u0005\u2006\u2000 = new Label();
    this.\u0008\u2006\u2000 = new Label();
    this.\u0006\u2006\u2000 = new Label();
    this.\u000E\u2006\u2000 = new Label();
    this.\u000F\u2006\u2000 = new Label();
    this.\u0002\u2007\u2000 = new Label();
    this.\u0003\u2007\u2000 = new Label();
    this.\u0005\u2007\u2000 = new Label();
    this.\u0008\u2007\u2000 = new Label();
    this.\u0006\u2007\u2000 = new Label();
    this.\u000E\u2007\u2000 = new Label();
    this.\u000F\u2007\u2000 = new Label();
    this.\u0002\u2008\u2000 = new Label();
    this.\u0003\u2008\u2000 = new Label();
    this.\u0005\u2008\u2000 = new Label();
    this.\u0008\u2008\u2000 = new Label();
    this.\u0006\u2008\u2000 = new Label();
    this.\u000E\u2008\u2000 = new Label();
    this.\u000F\u2008\u2000 = new Label();
    this.\u0002\u2009\u2000 = new Label();
    this.\u0003\u2009\u2000 = new Label();
    this.\u0005\u2009\u2000 = new Label();
    this.\u0008\u2009\u2000 = new Label();
    this.\u0006\u2009\u2000 = new Label();
    this.\u000E\u2009\u2000 = new Label();
    this.\u000F\u2009\u2000 = new Label();
    this.\u0002\u200A\u2000 = new Label();
    this.\u0003\u200A\u2000 = new Label();
    this.\u0005\u200A\u2000 = new Label();
    this.\u0008\u200A\u2000 = new Label();
    this.\u0006\u200A\u2000 = new Label();
    this.\u000E\u200A\u2000 = new Label();
    this.\u000F\u200A\u2000 = new Label();
    this.\u0002​\u2000 = new Label();
    this.\u0003​\u2000 = new Label();
    this.\u0005​\u2000 = new Label();
    this.\u0008​\u2000 = new Label();
    this.\u0006​\u2000 = new Label();
    this.\u000E​\u2000 = new Label();
    this.\u000F​\u2000 = new Label();
    this.\u0002\u2000\u2001 = new Label();
    this.\u0003\u2000\u2001 = new Label();
    this.\u0005\u2000\u2001 = new Label();
    this.\u0008\u2000\u2001 = new Label();
    this.\u0006\u2000\u2001 = new Label();
    this.\u000E\u2000\u2001 = new Label();
    this.\u000F\u2000\u2001 = new Label();
    this.\u0002\u2001\u2001 = new Label();
    this.\u0003\u2001\u2001 = new Label();
    this.\u0005\u2001\u2001 = new Label();
    this.\u0008\u2001\u2001 = new Label();
    this.\u0006\u2001\u2001 = new Label();
    this.\u000E\u2001\u2001 = new Label();
    this.\u000F\u2001\u2001 = new Label();
    this.\u0002\u2002\u2001 = new Label();
    this.\u0003\u2002\u2001 = new Label();
    this.\u0005\u2002\u2001 = new Label();
    this.\u0008\u2002\u2001 = new Label();
    this.\u0006\u2002\u2001 = new Label();
    this.\u000E\u2002\u2001 = new Label();
    this.\u000F\u2002\u2001 = new Label();
    this.\u0002\u2003\u2001 = new Label();
    this.\u0003\u2003\u2001 = new Label();
    this.\u0005\u2003\u2001 = new Label();
    this.\u0008\u2003\u2001 = new Label();
    this.\u0006\u2003\u2001 = new Label();
    this.\u000E\u2003\u2001 = new Label();
    this.\u000F\u2003\u2001 = new Label();
    this.\u0002\u2004\u2001 = new Label();
    this.\u0003\u2004\u2001 = new Label();
    this.\u0005\u2004\u2001 = new Label();
    this.\u0008\u2004\u2001 = new Label();
    this.\u0006\u2004\u2001 = new Label();
    this.\u000E\u2004\u2001 = new Label();
    this.\u000F\u2004\u2001 = new Label();
    this.\u0002\u2005\u2001 = new Label();
    this.\u0003\u2005\u2001 = new Label();
    this.\u0005\u2005\u2001 = new Label();
    this.\u0008\u2005\u2001 = new Label();
    this.\u0006\u2005\u2001 = new Label();
    this.\u000E\u2005\u2001 = new Label();
    this.\u000F\u2005\u2001 = new Label();
    this.\u0002\u2006\u2001 = new Label();
    this.\u0003\u2006\u2001 = new Label();
    this.\u0005\u2006\u2001 = new Label();
    this.\u0008\u2006\u2001 = new Label();
    this.\u0006\u2006\u2001 = new Label();
    this.\u000E\u2006\u2001 = new Label();
    this.\u000F\u2006\u2001 = new Label();
    this.\u0002\u2007\u2001 = new Label();
    this.\u0003\u2007\u2001 = new Label();
    this.\u0005\u2007\u2001 = new Label();
    this.\u0008\u2007\u2001 = new Label();
    this.\u0006\u2007\u2001 = new Label();
    this.\u000E\u2007\u2001 = new Label();
    this.\u000F\u2007\u2001 = new Label();
    this.\u0002\u2008\u2001 = new Label();
    this.\u0003\u2008\u2001 = new Label();
    this.\u0005\u2008\u2001 = new Label();
    this.\u0008\u2008\u2001 = new Label();
    this.\u0006\u2008\u2001 = new Label();
    this.\u000E\u2008\u2001 = new Label();
    this.\u000F\u2008\u2001 = new Label();
    this.\u0002\u2009\u2001 = new Label();
    this.\u0003\u2009\u2001 = new Label();
    this.\u0005\u2009\u2001 = new Label();
    this.\u0008\u2009\u2001 = new Label();
    this.\u0006\u2009\u2001 = new Label();
    this.\u000E\u2009\u2001 = new Label();
    this.\u000F\u2009\u2001 = new Label();
    this.\u0002\u200A\u2001 = new Label();
    this.\u0003\u200A\u2001 = new Label();
    this.\u0005\u200A\u2001 = new Label();
    this.\u0008\u200A\u2001 = new Label();
    this.\u0006\u200A\u2001 = new Label();
    this.\u000E\u200A\u2001 = new Label();
    this.\u000F\u200A\u2001 = new Label();
    this.\u0002​\u2001 = new Label();
    this.\u0003​\u2001 = new Label();
    this.\u0005​\u2001 = new Label();
    this.\u0008​\u2001 = new Label();
    this.\u0006​\u2001 = new Label();
    this.\u000E​\u2001 = new Label();
    this.\u000F​\u2001 = new Label();
    this.\u0002\u2000\u2002 = new Label();
    this.\u0003\u2000\u2002 = new Label();
    this.\u0005\u2000\u2002 = new Label();
    this.\u0008\u2000\u2002 = new Label();
    this.\u0006\u2000\u2002 = new Label();
    this.\u000E\u2000\u2002 = new Label();
    this.\u000F\u2000\u2002 = new Label();
    this.\u0002\u2001\u2002 = new Label();
    this.\u0003\u2001\u2002 = new Label();
    this.\u0005\u2001\u2002 = new Label();
    this.\u0008\u2001\u2002 = new Label();
    this.\u0006\u2001\u2002 = new Label();
    this.\u000E\u2001\u2002 = new Label();
    this.\u000F\u2001\u2002 = new Label();
    this.\u0002\u2002\u2002 = new Label();
    this.\u0003\u2002\u2002 = new Label();
    this.\u0005\u2002\u2002 = new Label();
    this.\u0008\u2002\u2002 = new Label();
    this.\u0006\u2002\u2002 = new Label();
    this.\u000E\u2002\u2002 = new Label();
    this.\u000F\u2002\u2002 = new Label();
    this.\u0002\u2003\u2002 = new Label();
    this.\u0003\u2003\u2002 = new Label();
    this.\u0005\u2003\u2002 = new Label();
    this.\u0008\u2003\u2002 = new Label();
    this.\u0006\u2003\u2002 = new Label();
    this.\u000E\u2003\u2002 = new Label();
    this.\u000F\u2003\u2002 = new Label();
    this.\u0002\u2004\u2002 = new Label();
    this.\u0003\u2004\u2002 = new Label();
    this.\u0005\u2004\u2002 = new Label();
    this.\u0008\u2004\u2002 = new Label();
    this.\u0006\u2004\u2002 = new Label();
    this.\u000E\u2004\u2002 = new Label();
    this.\u000F\u2004\u2002 = new Label();
    this.\u0002\u2005\u2002 = new Label();
    this.\u0003\u2005\u2002 = new Label();
    this.\u0005\u2005\u2002 = new Label();
    this.\u0008\u2005\u2002 = new Label();
    this.\u0006\u2005\u2002 = new Label();
    this.\u000E\u2005\u2002 = new Label();
    this.\u000F\u2005\u2002 = new Label();
    this.\u0002\u2006\u2002 = new Label();
    this.\u0003\u2006\u2002 = new Label();
    this.\u0005\u2006\u2002 = new Label();
    this.\u0008\u2006\u2002 = new Label();
    this.\u0006\u2006\u2002 = new Label();
    this.\u000E\u2006\u2002 = new Label();
    this.\u000F\u2006\u2002 = new Label();
    this.\u0002\u2007\u2002 = new Label();
    this.\u0003\u2007\u2002 = new Label();
    this.\u0005\u2007\u2002 = new Label();
    this.\u0008\u2007\u2002 = new Label();
    this.\u0006\u2007\u2002 = new Label();
    this.\u000E\u2007\u2002 = new Label();
    this.\u000F\u2007\u2002 = new Label();
    this.\u0002\u2008\u2002 = new Label();
    this.\u0003\u2008\u2002 = new Label();
    this.\u0005\u2008\u2002 = new Label();
    this.\u0008\u2008\u2002 = new Label();
    this.\u0006\u2008\u2002 = new Label();
    this.\u000E\u2008\u2002 = new Label();
    this.\u000F\u2008\u2002 = new Label();
    this.\u0002\u2009\u2002 = new Label();
    this.\u0003\u2009\u2002 = new Label();
    this.\u0005\u2009\u2002 = new Label();
    this.\u0008\u2009\u2002 = new Label();
    this.\u0006\u2009\u2002 = new Label();
    this.\u000E\u2009\u2002 = new Label();
    this.\u000F\u2009\u2002 = new Label();
    this.\u0002\u200A\u2002 = new Label();
    this.\u0003\u200A\u2002 = new Label();
    this.\u0005\u200A\u2002 = new Label();
    this.\u0008\u200A\u2002 = new Label();
    this.\u0006\u200A\u2002 = new Label();
    this.\u000E\u200A\u2002 = new Label();
    this.\u000F\u200A\u2002 = new Label();
    this.\u0002​\u2002 = new Label();
    this.\u0003​\u2002 = new Label();
    this.\u0005​\u2002 = new Label();
    this.\u0008​\u2002 = new Label();
    this.\u0006​\u2002 = new Label();
    this.\u000E​\u2002 = new Label();
    this.\u000F​\u2002 = new Label();
    this.\u0002\u2000\u2003 = new Label();
    this.\u0003\u2000\u2003 = new Label();
    this.\u0005\u2000\u2003 = new Label();
    this.\u0008\u2000\u2003 = new Label();
    this.\u0006\u2000\u2003 = new Label();
    this.\u000E\u2000\u2003 = new Label();
    this.\u000F\u2000\u2003 = new Label();
    this.\u0002\u2001\u2003 = new Label();
    this.\u0003\u2001\u2003 = new Label();
    this.\u0005\u2001\u2003 = new Label();
    this.\u0008\u2001\u2003 = new Label();
    this.\u0006\u2001\u2003 = new Label();
    this.\u000E\u2001\u2003 = new Label();
    this.\u000F\u2001\u2003 = new Label();
    this.\u0002\u2002\u2003 = new Label();
    this.\u0003\u2002\u2003 = new Label();
    this.\u0005\u2002\u2003 = new Label();
    this.\u0008\u2002\u2003 = new Label();
    this.\u0006\u2002\u2003 = new Label();
    this.\u000E\u2002\u2003 = new Label();
    this.\u000F\u2002\u2003 = new Label();
    this.\u0002\u2003\u2003 = new Label();
    this.\u0003\u2003\u2003 = new Label();
    this.\u0005\u2003\u2003 = new Label();
    this.\u0008\u2003\u2003 = new Label();
    this.\u0006\u2003\u2003 = new Label();
    this.\u000E\u2003\u2003 = new Label();
    this.\u000F\u2003\u2003 = new Label();
    this.\u0002\u2004\u2003 = new Label();
    this.\u0003\u2004\u2003 = new Label();
    this.\u0005\u2004\u2003 = new Label();
    this.\u0008\u2004\u2003 = new Label();
    this.\u0006\u2004\u2003 = new Label();
    this.\u000E\u2004\u2003 = new Label();
    this.\u000F\u2004\u2003 = new Label();
    this.\u0002\u2005\u2003 = new Label();
    this.\u0003\u2005\u2003 = new Label();
    this.\u0005\u2005\u2003 = new Label();
    this.\u0008\u2005\u2003 = new Label();
    this.\u0006\u2005\u2003 = new Label();
    this.\u000E\u2005\u2003 = new Label();
    this.\u000F\u2005\u2003 = new Label();
    this.\u0002\u2006\u2003 = new Label();
    this.\u0003\u2006\u2003 = new Label();
    this.\u0005\u2006\u2003 = new Label();
    this.\u0008\u2006\u2003 = new Label();
    this.\u0006\u2006\u2003 = new Label();
    this.\u000E\u2006\u2003 = new Label();
    this.\u000F\u2006\u2003 = new Label();
    this.\u0002\u2007\u2003 = new Label();
    this.\u0003\u2007\u2003 = new Label();
    this.\u0005\u2007\u2003 = new Label();
    this.\u0008\u2007\u2003 = new Label();
    this.\u0006\u2007\u2003 = new Label();
    this.\u000E\u2007\u2003 = new Label();
    this.\u000F\u2007\u2003 = new Label();
    this.\u0002\u2008\u2003 = new Label();
    this.\u0003\u2008\u2003 = new Label();
    this.\u0005\u2008\u2003 = new Label();
    this.\u0008\u2008\u2003 = new Label();
    this.\u0006\u2008\u2003 = new Label();
    this.\u000E\u2008\u2003 = new Label();
    this.\u000F\u2008\u2003 = new Label();
    this.\u0002\u2009\u2003 = new Label();
    this.\u0003\u2009\u2003 = new Label();
    this.\u0005\u2009\u2003 = new Label();
    this.\u0008\u2009\u2003 = new Label();
    this.\u0006\u2009\u2003 = new Label();
    this.\u000E\u2009\u2003 = new Label();
    this.\u000F\u2009\u2003 = new Label();
    this.\u0002\u200A\u2003 = new Label();
    this.\u0003\u200A\u2003 = new Label();
    this.\u0005\u200A\u2003 = new Label();
    this.\u0008\u200A\u2003 = new Label();
    this.\u0006\u200A\u2003 = new Label();
    this.\u000E\u200A\u2003 = new Timer(this.\u000F\u2007);
    this.\u000F\u200A\u2003 = new Panel();
    this.\u000E\u2000\u2004 = new PictureBox();
    this.\u0006\u2000\u2004 = new PictureBox();
    this.\u0003​\u2003 = new PictureBox();
    this.\u0002​\u2003 = new Button();
    this.\u0005​\u2003 = new PictureBox();
    this.\u0008​\u2003 = new Timer(this.\u000F\u2007);
    this.\u0006​\u2003 = new Timer(this.\u000F\u2007);
    this.\u000E​\u2003 = new Timer(this.\u000F\u2007);
    this.\u000F​\u2003 = new Timer(this.\u000F\u2007);
    this.\u0002\u2000\u2004 = new Label();
    this.\u0003\u2000\u2004 = new Label();
    this.\u0005\u2000\u2004 = new Timer(this.\u000F\u2007);
    this.\u0008\u2000\u2004 = new Timer(this.\u000F\u2007);
    this.\u000F\u2000\u2004 = new Label();
    this.\u0002\u2001\u2004 = new Label();
    this.\u0003\u2001\u2004 = new Label();
    this.\u0005\u2001\u2004 = new Label();
    ((ISupportInitialize) this.\u0003\u2009).BeginInit();
    ((ISupportInitialize) this.\u0002\u2009).BeginInit();
    this.\u000F\u200A\u2003.SuspendLayout();
    ((ISupportInitialize) this.\u000E\u2000\u2004).BeginInit();
    ((ISupportInitialize) this.\u0006\u2000\u2004).BeginInit();
    ((ISupportInitialize) this.\u0003​\u2003).BeginInit();
    ((ISupportInitialize) this.\u0005​\u2003).BeginInit();
    this.SuspendLayout();
    this.\u0002\u2008.Interval = 16;
    this.\u0002\u2008.Tick += new EventHandler(this.\u0008\u2000);
    this.\u000E\u2008.BackColor = Color.Black;
    this.\u000E\u2008.Font = new Font(\u000F\u2000.\u0002(-380206080), 16f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.\u000E\u2008.ForeColor = Color.White;
    this.\u000E\u2008.Image = (Image) \u000E\u2000.\u0005\u2005();
    this.\u000E\u2008.Location = new Point(16, 400);
    this.\u000E\u2008.Name = \u000F\u2000.\u0002(-380206053);
    this.\u000E\u2008.Size = new Size(84, 30);
    this.\u000E\u2008.TabIndex = 129;
    this.\u000F\u2008.BackColor = Color.Black;
    this.\u000F\u2008.Font = new Font(\u000F\u2000.\u0002(-380206080), 16f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.\u000F\u2008.ForeColor = Color.White;
    this.\u000F\u2008.Image = (Image) \u000E\u2000.\u000F\u2001();
    this.\u000F\u2008.Location = new Point(226, 399);
    this.\u000F\u2008.Name = \u000F\u2000.\u0002(-380206042);
    this.\u000F\u2008.Size = new Size(69, 30);
    this.\u000F\u2008.TabIndex = 130;
    this.\u0005\u2009.BackColor = Color.Black;
    this.\u0005\u2009.Font = new Font(\u000F\u2000.\u0002(-380206080), 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.\u0005\u2009.ForeColor = Color.White;
    this.\u0005\u2009.Image = (Image) \u000E\u2000.\u0008\u2001();
    this.\u0005\u2009.Location = new Point(123, 222);
    this.\u0005\u2009.Name = \u000F\u2000.\u0002(-380206031);
    this.\u0005\u2009.Size = new Size(125, 19);
    this.\u0005\u2009.TabIndex = 133;
    this.\u0005\u2009.Text = \u000F\u2000.\u0002(-380206020);
    this.\u0005\u2009.TextAlign = ContentAlignment.MiddleRight;
    this.\u0008\u2009.Interval = 3000;
    this.\u0008\u2009.Tick += new EventHandler(this.\u0006\u2000);
    this.\u0006\u2009.Interval = 1;
    this.\u0006\u2009.Tick += new EventHandler(this.\u000E\u2000);
    this.\u000E\u2009.Interval = 1;
    this.\u000E\u2009.Tick += new EventHandler(this.\u000F\u2000);
    this.\u000F\u2009.Interval = 1;
    this.\u000F\u2009.Tick += new EventHandler(this.\u0002\u2001);
    this.\u0002\u200A.Interval = 1;
    this.\u0002\u200A.Tick += new EventHandler(this.\u0003\u2001);
    this.\u0003\u2009.BackgroundImageLayout = ImageLayout.Center;
    this.\u0003\u2009.Image = (Image) \u000E\u2000.\u0005();
    this.\u0003\u2009.Location = new Point(318, 402);
    this.\u0003\u2009.Name = \u000F\u2000.\u0002(-380205997);
    this.\u0003\u2009.Size = new Size(22, 22);
    this.\u0003\u2009.TabIndex = 132;
    this.\u0003\u2009.TabStop = false;
    this.\u0002\u2009.BackgroundImageLayout = ImageLayout.Center;
    this.\u0002\u2009.Image = (Image) \u000E\u2000.\u0005();
    this.\u0002\u2009.Location = new Point(297, 402);
    this.\u0002\u2009.Name = \u000F\u2000.\u0002(-380205983);
    this.\u0002\u2009.Size = new Size(22, 22);
    this.\u0002\u2009.TabIndex = 131;
    this.\u0002\u2009.TabStop = false;
    this.\u0006\u2008.BackColor = Color.Transparent;
    this.\u0006\u2008.Cursor = Cursors.Default;
    this.\u0006\u2008.ForeColor = Color.Transparent;
    this.\u0006\u2008.Image = (Image) \u000E\u2000.\u0003\u2006();
    this.\u0006\u2008.Location = new Point(176, 185);
    this.\u0006\u2008.Margin = new Padding(0);
    this.\u0006\u2008.Name = \u000F\u2000.\u0002(-380205961);
    this.\u0006\u2008.Size = new Size(18, 18);
    this.\u0006\u2008.TabIndex = (int) sbyte.MaxValue;
    this.\u0008\u2008.BackColor = Color.Transparent;
    this.\u0008\u2008.Cursor = Cursors.Default;
    this.\u0008\u2008.ForeColor = Color.Transparent;
    this.\u0008\u2008.Image = (Image) \u000E\u2000.\u000E\u2001();
    this.\u0008\u2008.Location = new Point(199, 185);
    this.\u0008\u2008.Margin = new Padding(0);
    this.\u0008\u2008.Name = \u000F\u2000.\u0002(-380205694);
    this.\u0008\u2008.Size = new Size(18, 18);
    this.\u0008\u2008.TabIndex = 126;
    this.\u0005\u2008.BackColor = Color.Transparent;
    this.\u0005\u2008.Cursor = Cursors.Default;
    this.\u0005\u2008.ForeColor = Color.Transparent;
    this.\u0005\u2008.Image = (Image) \u000E\u2000.\u0002\u2000();
    this.\u0005\u2008.Location = new Point(154, 185);
    this.\u0005\u2008.Margin = new Padding(0);
    this.\u0005\u2008.Name = \u000F\u2000.\u0002(-380205683);
    this.\u0005\u2008.Size = new Size(18, 18);
    this.\u0005\u2008.TabIndex = 125;
    this.\u0003\u2008.BackColor = Color.Transparent;
    this.\u0003\u2008.Cursor = Cursors.Default;
    this.\u0003\u2008.ForeColor = Color.Transparent;
    this.\u0003\u2008.Image = (Image) \u000E\u2000.\u0003\u2005();
    this.\u0003\u2008.Location = new Point(176, 150);
    this.\u0003\u2008.Margin = new Padding(0);
    this.\u0003\u2008.Name = \u000F\u2000.\u0002(-380205672);
    this.\u0003\u2008.Size = new Size(18, 18);
    this.\u0003\u2008.TabIndex = 124;
    this.\u0003\u200A.BackColor = Color.White;
    this.\u0003\u200A.Location = new Point(102, 266);
    this.\u0003\u200A.Name = \u000F\u2000.\u0002(-380205653);
    this.\u0003\u200A.Size = new Size(2, 2);
    this.\u0003\u200A.TabIndex = 134;
    this.\u0005\u200A.BackColor = Color.White;
    this.\u0005\u200A.Location = new Point(111, 266);
    this.\u0005\u200A.Name = \u000F\u2000.\u0002(-380205642);
    this.\u0005\u200A.Size = new Size(2, 2);
    this.\u0005\u200A.TabIndex = 135;
    this.\u0008\u200A.BackColor = Color.White;
    this.\u0008\u200A.Location = new Point(129, 266);
    this.\u0008\u200A.Name = \u000F\u2000.\u0002(-380205631);
    this.\u0008\u200A.Size = new Size(2, 2);
    this.\u0008\u200A.TabIndex = 137;
    this.\u0006\u200A.BackColor = Color.White;
    this.\u0006\u200A.Location = new Point(120, 266);
    this.\u0006\u200A.Name = \u000F\u2000.\u0002(-380205620);
    this.\u0006\u200A.Size = new Size(2, 2);
    this.\u0006\u200A.TabIndex = 136;
    this.\u000E\u200A.BackColor = Color.White;
    this.\u000E\u200A.Location = new Point(165, 266);
    this.\u000E\u200A.Name = \u000F\u2000.\u0002(-380205601);
    this.\u000E\u200A.Size = new Size(2, 2);
    this.\u000E\u200A.TabIndex = 141;
    this.\u000F\u200A.BackColor = Color.White;
    this.\u000F\u200A.Location = new Point(156, 266);
    this.\u000F\u200A.Name = \u000F\u2000.\u0002(-380205590);
    this.\u000F\u200A.Size = new Size(2, 2);
    this.\u000F\u200A.TabIndex = 140;
    this.\u0002​.BackColor = Color.White;
    this.\u0002​.Location = new Point(147, 266);
    this.\u0002​.Name = \u000F\u2000.\u0002(-380205579);
    this.\u0002​.Size = new Size(2, 2);
    this.\u0002​.TabIndex = 139;
    this.\u0003​.BackColor = Color.White;
    this.\u0003​.Location = new Point(138, 266);
    this.\u0003​.Name = \u000F\u2000.\u0002(-380205817);
    this.\u0003​.Size = new Size(2, 2);
    this.\u0003​.TabIndex = 138;
    this.\u0005​.BackColor = Color.White;
    this.\u0005​.Location = new Point(94, 266);
    this.\u0005​.Name = \u000F\u2000.\u0002(-380205807);
    this.\u0005​.Size = new Size(2, 2);
    this.\u0005​.TabIndex = 149;
    this.\u0008​.BackColor = Color.White;
    this.\u0008​.Location = new Point(78, 266);
    this.\u0008​.Name = \u000F\u2000.\u0002(-380205789);
    this.\u0008​.Size = new Size(2, 2);
    this.\u0008​.TabIndex = 148;
    this.\u0006​.BackColor = Color.White;
    this.\u0006​.Location = new Point(69, 266);
    this.\u0006​.Name = \u000F\u2000.\u0002(-380205779);
    this.\u0006​.Size = new Size(2, 2);
    this.\u0006​.TabIndex = 147;
    this.\u000E​.BackColor = Color.White;
    this.\u000E​.Location = new Point(60, 266);
    this.\u000E​.Name = \u000F\u2000.\u0002(-380205761);
    this.\u000E​.Size = new Size(2, 2);
    this.\u000E​.TabIndex = 146;
    this.\u000F​.BackColor = Color.White;
    this.\u000F​.Location = new Point(52, 266);
    this.\u000F​.Name = \u000F\u2000.\u0002(-380205751);
    this.\u000F​.Size = new Size(2, 2);
    this.\u000F​.TabIndex = 145;
    this.\u0002\u2000\u2000.BackColor = Color.White;
    this.\u0002\u2000\u2000.Location = new Point(43, 266);
    this.\u0002\u2000\u2000.Name = \u000F\u2000.\u0002(-380205733);
    this.\u0002\u2000\u2000.Size = new Size(2, 2);
    this.\u0002\u2000\u2000.TabIndex = 144;
    this.\u0003\u2000\u2000.BackColor = Color.White;
    this.\u0003\u2000\u2000.Location = new Point(247, 266);
    this.\u0003\u2000\u2000.Name = \u000F\u2000.\u0002(-380205723);
    this.\u0003\u2000\u2000.Size = new Size(2, 2);
    this.\u0003\u2000\u2000.TabIndex = 163;
    this.\u0005\u2000\u2000.BackColor = Color.White;
    this.\u0005\u2000\u2000.Location = new Point(238, 266);
    this.\u0005\u2000\u2000.Name = \u000F\u2000.\u0002(-380205705);
    this.\u0005\u2000\u2000.Size = new Size(2, 2);
    this.\u0005\u2000\u2000.TabIndex = 162;
    this.\u0008\u2000\u2000.BackColor = Color.White;
    this.\u0008\u2000\u2000.Location = new Point(229, 266);
    this.\u0008\u2000\u2000.Name = \u000F\u2000.\u0002(-380204415);
    this.\u0008\u2000\u2000.Size = new Size(2, 2);
    this.\u0008\u2000\u2000.TabIndex = 161;
    this.\u0006\u2000\u2000.BackColor = Color.White;
    this.\u0006\u2000\u2000.Location = new Point(220, 266);
    this.\u0006\u2000\u2000.Name = \u000F\u2000.\u0002(-380204397);
    this.\u0006\u2000\u2000.Size = new Size(2, 2);
    this.\u0006\u2000\u2000.TabIndex = 160;
    this.\u000E\u2000\u2000.BackColor = Color.White;
    this.\u000E\u2000\u2000.Location = new Point(211, 266);
    this.\u000E\u2000\u2000.Name = \u000F\u2000.\u0002(-380204387);
    this.\u000E\u2000\u2000.Size = new Size(2, 2);
    this.\u000E\u2000\u2000.TabIndex = 159;
    this.\u000F\u2000\u2000.BackColor = Color.White;
    this.\u000F\u2000\u2000.Location = new Point(202, 266);
    this.\u000F\u2000\u2000.Name = \u000F\u2000.\u0002(-380204369);
    this.\u000F\u2000\u2000.Size = new Size(2, 2);
    this.\u000F\u2000\u2000.TabIndex = 158;
    this.\u0002\u2001\u2000.BackColor = Color.White;
    this.\u0002\u2001\u2000.Location = new Point(318, 266);
    this.\u0002\u2001\u2000.Name = \u000F\u2000.\u0002(-380204359);
    this.\u0002\u2001\u2000.Size = new Size(2, 2);
    this.\u0002\u2001\u2000.TabIndex = 157;
    this.\u0003\u2001\u2000.BackColor = Color.White;
    this.\u0003\u2001\u2000.Location = new Point(310, 266);
    this.\u0003\u2001\u2000.Name = \u000F\u2000.\u0002(-380204341);
    this.\u0003\u2001\u2000.Size = new Size(2, 2);
    this.\u0003\u2001\u2000.TabIndex = 156;
    this.\u0005\u2001\u2000.BackColor = Color.White;
    this.\u0005\u2001\u2000.Location = new Point(301, 266);
    this.\u0005\u2001\u2000.Name = \u000F\u2000.\u0002(-380204331);
    this.\u0005\u2001\u2000.Size = new Size(2, 2);
    this.\u0005\u2001\u2000.TabIndex = 155;
    this.\u0008\u2001\u2000.BackColor = Color.White;
    this.\u0008\u2001\u2000.Location = new Point(292, 266);
    this.\u0008\u2001\u2000.Name = \u000F\u2000.\u0002(-380204313);
    this.\u0008\u2001\u2000.Size = new Size(2, 2);
    this.\u0008\u2001\u2000.TabIndex = 154;
    this.\u0006\u2001\u2000.BackColor = Color.White;
    this.\u0006\u2001\u2000.Location = new Point(283, 266);
    this.\u0006\u2001\u2000.Name = \u000F\u2000.\u0002(-380204303);
    this.\u0006\u2001\u2000.Size = new Size(2, 2);
    this.\u0006\u2001\u2000.TabIndex = 153;
    this.\u000E\u2001\u2000.BackColor = Color.White;
    this.\u000E\u2001\u2000.Location = new Point(274, 266);
    this.\u000E\u2001\u2000.Name = \u000F\u2000.\u0002(-380204541);
    this.\u000E\u2001\u2000.Size = new Size(2, 2);
    this.\u000E\u2001\u2000.TabIndex = 152;
    this.\u000F\u2001\u2000.BackColor = Color.White;
    this.\u000F\u2001\u2000.Location = new Point(265, 266);
    this.\u000F\u2001\u2000.Name = \u000F\u2000.\u0002(-380204531);
    this.\u000F\u2001\u2000.Size = new Size(2, 2);
    this.\u000F\u2001\u2000.TabIndex = 151;
    this.\u0002\u2002\u2000.BackColor = Color.White;
    this.\u0002\u2002\u2000.Location = new Point(256, 266);
    this.\u0002\u2002\u2000.Name = \u000F\u2000.\u0002(-380204513);
    this.\u0002\u2002\u2000.Size = new Size(2, 2);
    this.\u0002\u2002\u2000.TabIndex = 150;
    this.\u0003\u2002\u2000.AutoSize = true;
    this.\u0003\u2002\u2000.Font = new Font(\u000F\u2000.\u0002(-380206080), 15f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.\u0003\u2002\u2000.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 51);
    this.\u0003\u2002\u2000.Location = new Point(93, 399);
    this.\u0003\u2002\u2000.Name = \u000F\u2000.\u0002(-380204503);
    this.\u0003\u2002\u2000.Size = new Size(24, 28);
    this.\u0003\u2002\u2000.TabIndex = 164;
    this.\u0003\u2002\u2000.Text = \u000F\u2000.\u0002(-380205190);
    this.\u0005\u2002\u2000.BackColor = Color.White;
    this.\u0005\u2002\u2000.Location = new Point(165, 284);
    this.\u0005\u2002\u2000.Name = \u000F\u2000.\u0002(-380204491);
    this.\u0005\u2002\u2000.Size = new Size(2, 2);
    this.\u0005\u2002\u2000.TabIndex = 180;
    this.\u0008\u2002\u2000.BackColor = Color.White;
    this.\u0008\u2002\u2000.Location = new Point(165, 293);
    this.\u0008\u2002\u2000.Name = \u000F\u2000.\u0002(-380204473);
    this.\u0008\u2002\u2000.Size = new Size(2, 2);
    this.\u0008\u2002\u2000.TabIndex = 181;
    this.\u0006\u2002\u2000.BackColor = Color.White;
    this.\u0006\u2002\u2000.Location = new Point(165, 275);
    this.\u0006\u2002\u2000.Name = \u000F\u2000.\u0002(-380204463);
    this.\u0006\u2002\u2000.Size = new Size(2, 2);
    this.\u0006\u2002\u2000.TabIndex = 179;
    this.\u000E\u2002\u2000.BackColor = Color.White;
    this.\u000E\u2002\u2000.Location = new Point(202, 293);
    this.\u000E\u2002\u2000.Name = \u000F\u2000.\u0002(-380204445);
    this.\u000E\u2002\u2000.Size = new Size(2, 2);
    this.\u000E\u2002\u2000.TabIndex = 185;
    this.\u000F\u2002\u2000.BackColor = Color.White;
    this.\u000F\u2002\u2000.Location = new Point(202, 284);
    this.\u000F\u2002\u2000.Name = \u000F\u2000.\u0002(-380204435);
    this.\u000F\u2002\u2000.Size = new Size(2, 2);
    this.\u000F\u2002\u2000.TabIndex = 184;
    this.\u0002\u2003\u2000.BackColor = Color.White;
    this.\u0002\u2003\u2000.Location = new Point(202, 275);
    this.\u0002\u2003\u2000.Name = \u000F\u2000.\u0002(-380204417);
    this.\u0002\u2003\u2000.Size = new Size(2, 2);
    this.\u0002\u2003\u2000.TabIndex = 183;
    this.\u0003\u2003\u2000.BackColor = Color.White;
    this.\u0003\u2003\u2000.Location = new Point(326, 266);
    this.\u0003\u2003\u2000.Name = \u000F\u2000.\u0002(-380204151);
    this.\u0003\u2003\u2000.Size = new Size(2, 2);
    this.\u0003\u2003\u2000.TabIndex = 186;
    this.\u0005\u2003\u2000.BackColor = Color.White;
    this.\u0005\u2003\u2000.Location = new Point(35, 266);
    this.\u0005\u2003\u2000.Name = \u000F\u2000.\u0002(-380204133);
    this.\u0005\u2003\u2000.Size = new Size(2, 2);
    this.\u0005\u2003\u2000.TabIndex = 187;
    this.\u0008\u2003\u2000.BackColor = Color.White;
    this.\u0008\u2003\u2000.Location = new Point(94, 302);
    this.\u0008\u2003\u2000.Name = \u000F\u2000.\u0002(-380204123);
    this.\u0008\u2003\u2000.Size = new Size(2, 2);
    this.\u0008\u2003\u2000.TabIndex = 196;
    this.\u0006\u2003\u2000.BackColor = Color.White;
    this.\u0006\u2003\u2000.Location = new Point(165, 302);
    this.\u0006\u2003\u2000.Name = \u000F\u2000.\u0002(-380204105);
    this.\u0006\u2003\u2000.Size = new Size(2, 2);
    this.\u0006\u2003\u2000.TabIndex = 195;
    this.\u000E\u2003\u2000.BackColor = Color.White;
    this.\u000E\u2003\u2000.Location = new Point(156, 302);
    this.\u000E\u2003\u2000.Name = \u000F\u2000.\u0002(-380204095);
    this.\u000E\u2003\u2000.Size = new Size(2, 2);
    this.\u000E\u2003\u2000.TabIndex = 194;
    this.\u000F\u2003\u2000.BackColor = Color.White;
    this.\u000F\u2003\u2000.Location = new Point(147, 302);
    this.\u000F\u2003\u2000.Name = \u000F\u2000.\u0002(-380204077);
    this.\u000F\u2003\u2000.Size = new Size(2, 2);
    this.\u000F\u2003\u2000.TabIndex = 193;
    this.\u0002\u2004\u2000.BackColor = Color.White;
    this.\u0002\u2004\u2000.Location = new Point(138, 302);
    this.\u0002\u2004\u2000.Name = \u000F\u2000.\u0002(-380204067);
    this.\u0002\u2004\u2000.Size = new Size(2, 2);
    this.\u0002\u2004\u2000.TabIndex = 192;
    this.\u0003\u2004\u2000.BackColor = Color.White;
    this.\u0003\u2004\u2000.Location = new Point(129, 302);
    this.\u0003\u2004\u2000.Name = \u000F\u2000.\u0002(-380204049);
    this.\u0003\u2004\u2000.Size = new Size(2, 2);
    this.\u0003\u2004\u2000.TabIndex = 191;
    this.\u0005\u2004\u2000.BackColor = Color.White;
    this.\u0005\u2004\u2000.Location = new Point(120, 302);
    this.\u0005\u2004\u2000.Name = \u000F\u2000.\u0002(-380204039);
    this.\u0005\u2004\u2000.Size = new Size(2, 2);
    this.\u0005\u2004\u2000.TabIndex = 190;
    this.\u0008\u2004\u2000.BackColor = Color.White;
    this.\u0008\u2004\u2000.Location = new Point(111, 302);
    this.\u0008\u2004\u2000.Name = \u000F\u2000.\u0002(-380204277);
    this.\u0008\u2004\u2000.Size = new Size(2, 2);
    this.\u0008\u2004\u2000.TabIndex = 189;
    this.\u0006\u2004\u2000.BackColor = Color.White;
    this.\u0006\u2004\u2000.Location = new Point(102, 302);
    this.\u0006\u2004\u2000.Name = \u000F\u2000.\u0002(-380204267);
    this.\u0006\u2004\u2000.Size = new Size(2, 2);
    this.\u0006\u2004\u2000.TabIndex = 188;
    this.\u000E\u2004\u2000.BackColor = Color.White;
    this.\u000E\u2004\u2000.Location = new Point(202, 302);
    this.\u000E\u2004\u2000.Name = \u000F\u2000.\u0002(-380204249);
    this.\u000E\u2004\u2000.Size = new Size(2, 2);
    this.\u000E\u2004\u2000.TabIndex = 205;
    this.\u000F\u2004\u2000.BackColor = Color.White;
    this.\u000F\u2004\u2000.Location = new Point(274, 302);
    this.\u000F\u2004\u2000.Name = \u000F\u2000.\u0002(-380204239);
    this.\u000F\u2004\u2000.Size = new Size(2, 2);
    this.\u000F\u2004\u2000.TabIndex = 204;
    this.\u0002\u2006\u2000.BackColor = Color.White;
    this.\u0002\u2006\u2000.Location = new Point(265, 302);
    this.\u0002\u2006\u2000.Name = \u000F\u2000.\u0002(-380204221);
    this.\u0002\u2006\u2000.Size = new Size(2, 2);
    this.\u0002\u2006\u2000.TabIndex = 203;
    this.\u0003\u2006\u2000.BackColor = Color.White;
    this.\u0003\u2006\u2000.Location = new Point(256, 302);
    this.\u0003\u2006\u2000.Name = \u000F\u2000.\u0002(-380204211);
    this.\u0003\u2006\u2000.Size = new Size(2, 2);
    this.\u0003\u2006\u2000.TabIndex = 202;
    this.\u0005\u2006\u2000.BackColor = Color.White;
    this.\u0005\u2006\u2000.Location = new Point(247, 302);
    this.\u0005\u2006\u2000.Name = \u000F\u2000.\u0002(-380204193);
    this.\u0005\u2006\u2000.Size = new Size(2, 2);
    this.\u0005\u2006\u2000.TabIndex = 201;
    this.\u0008\u2006\u2000.BackColor = Color.White;
    this.\u0008\u2006\u2000.Location = new Point(238, 302);
    this.\u0008\u2006\u2000.Name = \u000F\u2000.\u0002(-380204183);
    this.\u0008\u2006\u2000.Size = new Size(2, 2);
    this.\u0008\u2006\u2000.TabIndex = 200;
    this.\u0006\u2006\u2000.BackColor = Color.White;
    this.\u0006\u2006\u2000.Location = new Point(229, 302);
    this.\u0006\u2006\u2000.Name = \u000F\u2000.\u0002(-380204165);
    this.\u0006\u2006\u2000.Size = new Size(2, 2);
    this.\u0006\u2006\u2000.TabIndex = 199;
    this.\u000E\u2006\u2000.BackColor = Color.White;
    this.\u000E\u2006\u2000.Location = new Point(220, 302);
    this.\u000E\u2006\u2000.Name = \u000F\u2000.\u0002(-380204923);
    this.\u000E\u2006\u2000.Size = new Size(2, 2);
    this.\u000E\u2006\u2000.TabIndex = 198;
    this.\u000F\u2006\u2000.BackColor = Color.White;
    this.\u000F\u2006\u2000.Location = new Point(211, 302);
    this.\u000F\u2006\u2000.Name = \u000F\u2000.\u0002(-380204905);
    this.\u000F\u2006\u2000.Size = new Size(2, 2);
    this.\u000F\u2006\u2000.TabIndex = 197;
    this.\u0002\u2007\u2000.BackColor = Color.White;
    this.\u0002\u2007\u2000.Location = new Point(94, 293);
    this.\u0002\u2007\u2000.Name = \u000F\u2000.\u0002(-380204895);
    this.\u0002\u2007\u2000.Size = new Size(2, 2);
    this.\u0002\u2007\u2000.TabIndex = 208;
    this.\u0003\u2007\u2000.BackColor = Color.White;
    this.\u0003\u2007\u2000.Location = new Point(94, 284);
    this.\u0003\u2007\u2000.Name = \u000F\u2000.\u0002(-380204877);
    this.\u0003\u2007\u2000.Size = new Size(2, 2);
    this.\u0003\u2007\u2000.TabIndex = 207;
    this.\u0005\u2007\u2000.BackColor = Color.White;
    this.\u0005\u2007\u2000.Location = new Point(94, 275);
    this.\u0005\u2007\u2000.Name = \u000F\u2000.\u0002(-380204867);
    this.\u0005\u2007\u2000.Size = new Size(2, 2);
    this.\u0005\u2007\u2000.TabIndex = 206;
    this.\u0008\u2007\u2000.BackColor = Color.White;
    this.\u0008\u2007\u2000.Location = new Point(274, 293);
    this.\u0008\u2007\u2000.Name = \u000F\u2000.\u0002(-380204849);
    this.\u0008\u2007\u2000.Size = new Size(2, 2);
    this.\u0008\u2007\u2000.TabIndex = 211;
    this.\u0006\u2007\u2000.BackColor = Color.White;
    this.\u0006\u2007\u2000.Location = new Point(274, 284);
    this.\u0006\u2007\u2000.Name = \u000F\u2000.\u0002(-380204839);
    this.\u0006\u2007\u2000.Size = new Size(2, 2);
    this.\u0006\u2007\u2000.TabIndex = 210;
    this.\u000E\u2007\u2000.BackColor = Color.White;
    this.\u000E\u2007\u2000.Location = new Point(274, 275);
    this.\u000E\u2007\u2000.Name = \u000F\u2000.\u0002(-380204821);
    this.\u000E\u2007\u2000.Size = new Size(2, 2);
    this.\u000E\u2007\u2000.TabIndex = 209;
    this.\u000F\u2007\u2000.BackColor = Color.White;
    this.\u000F\u2007\u2000.Location = new Point(183, 302);
    this.\u000F\u2007\u2000.Name = \u000F\u2000.\u0002(-380204811);
    this.\u000F\u2007\u2000.Size = new Size(2, 2);
    this.\u000F\u2007\u2000.TabIndex = 213;
    this.\u0002\u2008\u2000.BackColor = Color.White;
    this.\u0002\u2008\u2000.Location = new Point(174, 302);
    this.\u0002\u2008\u2000.Name = \u000F\u2000.\u0002(-380205049);
    this.\u0002\u2008\u2000.Size = new Size(2, 2);
    this.\u0002\u2008\u2000.TabIndex = 212;
    this.\u0003\u2008\u2000.BackColor = Color.White;
    this.\u0003\u2008\u2000.Location = new Point(192, 302);
    this.\u0003\u2008\u2000.Name = \u000F\u2000.\u0002(-380205039);
    this.\u0003\u2008\u2000.Size = new Size(2, 2);
    this.\u0003\u2008\u2000.TabIndex = 214;
    this.\u0005\u2008\u2000.BackColor = Color.White;
    this.\u0005\u2008\u2000.Location = new Point(334, 293);
    this.\u0005\u2008\u2000.Name = \u000F\u2000.\u0002(-380205021);
    this.\u0005\u2008\u2000.Size = new Size(2, 2);
    this.\u0005\u2008\u2000.TabIndex = 217;
    this.\u0008\u2008\u2000.BackColor = Color.White;
    this.\u0008\u2008\u2000.Location = new Point(334, 284);
    this.\u0008\u2008\u2000.Name = \u000F\u2000.\u0002(-380205011);
    this.\u0008\u2008\u2000.Size = new Size(2, 2);
    this.\u0008\u2008\u2000.TabIndex = 216;
    this.\u0006\u2008\u2000.BackColor = Color.White;
    this.\u0006\u2008\u2000.Location = new Point(334, 275);
    this.\u0006\u2008\u2000.Name = \u000F\u2000.\u0002(-380204993);
    this.\u0006\u2008\u2000.Size = new Size(2, 2);
    this.\u0006\u2008\u2000.TabIndex = 215;
    this.\u000E\u2008\u2000.BackColor = Color.White;
    this.\u000E\u2008\u2000.Location = new Point(334, 266);
    this.\u000E\u2008\u2000.Name = \u000F\u2000.\u0002(-380204983);
    this.\u000E\u2008\u2000.Size = new Size(2, 2);
    this.\u000E\u2008\u2000.TabIndex = 218;
    this.\u000F\u2008\u2000.BackColor = Color.Black;
    this.\u000F\u2008\u2000.Image = (Image) componentResourceManager.GetObject(\u000F\u2000.\u0002(-380204965));
    this.\u000F\u2008\u2000.Location = new Point(330, 298);
    this.\u000F\u2008\u2000.Name = \u000F\u2000.\u0002(-380204945);
    this.\u000F\u2008\u2000.Size = new Size(10, 10);
    this.\u000F\u2008\u2000.TabIndex = 222;
    this.\u0002\u2009\u2000.BackColor = Color.White;
    this.\u0002\u2009\u2000.Location = new Point(326, 302);
    this.\u0002\u2009\u2000.Name = \u000F\u2000.\u0002(-380204935);
    this.\u0002\u2009\u2000.Size = new Size(2, 2);
    this.\u0002\u2009\u2000.TabIndex = 221;
    this.\u0003\u2009\u2000.BackColor = Color.White;
    this.\u0003\u2009\u2000.Location = new Point(318, 302);
    this.\u0003\u2009\u2000.Name = \u000F\u2000.\u0002(-380204661);
    this.\u0003\u2009\u2000.Size = new Size(2, 2);
    this.\u0003\u2009\u2000.TabIndex = 220;
    this.\u0005\u2009\u2000.BackColor = Color.White;
    this.\u0005\u2009\u2000.Location = new Point(310, 302);
    this.\u0005\u2009\u2000.Name = \u000F\u2000.\u0002(-380204651);
    this.\u0005\u2009\u2000.Size = new Size(2, 2);
    this.\u0005\u2009\u2000.TabIndex = 219;
    this.\u0008\u2009\u2000.BackColor = Color.White;
    this.\u0008\u2009\u2000.Location = new Point(310, 311);
    this.\u0008\u2009\u2000.Name = \u000F\u2000.\u0002(-380204633);
    this.\u0008\u2009\u2000.Size = new Size(2, 2);
    this.\u0008\u2009\u2000.TabIndex = 226;
    this.\u0006\u2009\u2000.BackColor = Color.White;
    this.\u0006\u2009\u2000.Location = new Point(310, 338);
    this.\u0006\u2009\u2000.Name = \u000F\u2000.\u0002(-380204623);
    this.\u0006\u2009\u2000.Size = new Size(2, 2);
    this.\u0006\u2009\u2000.TabIndex = 225;
    this.\u000E\u2009\u2000.BackColor = Color.White;
    this.\u000E\u2009\u2000.Location = new Point(310, 329);
    this.\u000E\u2009\u2000.Name = \u000F\u2000.\u0002(-380204605);
    this.\u000E\u2009\u2000.Size = new Size(2, 2);
    this.\u000E\u2009\u2000.TabIndex = 224;
    this.\u000F\u2009\u2000.BackColor = Color.White;
    this.\u000F\u2009\u2000.Location = new Point(310, 320);
    this.\u000F\u2009\u2000.Name = \u000F\u2000.\u0002(-380204595);
    this.\u000F\u2009\u2000.Size = new Size(2, 2);
    this.\u000F\u2009\u2000.TabIndex = 223;
    this.\u0002\u200A\u2000.BackColor = Color.White;
    this.\u0002\u200A\u2000.Location = new Point(301, 338);
    this.\u0002\u200A\u2000.Name = \u000F\u2000.\u0002(-380204577);
    this.\u0002\u200A\u2000.Size = new Size(2, 2);
    this.\u0002\u200A\u2000.TabIndex = 230;
    this.\u0003\u200A\u2000.BackColor = Color.White;
    this.\u0003\u200A\u2000.Location = new Point(292, 338);
    this.\u0003\u200A\u2000.Name = \u000F\u2000.\u0002(-380204567);
    this.\u0003\u200A\u2000.Size = new Size(2, 2);
    this.\u0003\u200A\u2000.TabIndex = 229;
    this.\u0005\u200A\u2000.BackColor = Color.White;
    this.\u0005\u200A\u2000.Location = new Point(283, 338);
    this.\u0005\u200A\u2000.Name = \u000F\u2000.\u0002(-380204549);
    this.\u0005\u200A\u2000.Size = new Size(2, 2);
    this.\u0005\u200A\u2000.TabIndex = 228;
    this.\u0008\u200A\u2000.BackColor = Color.White;
    this.\u0008\u200A\u2000.Location = new Point(274, 338);
    this.\u0008\u200A\u2000.Name = \u000F\u2000.\u0002(-380204795);
    this.\u0008\u200A\u2000.Size = new Size(2, 2);
    this.\u0008\u200A\u2000.TabIndex = 227;
    this.\u0006\u200A\u2000.BackColor = Color.White;
    this.\u0006\u200A\u2000.Location = new Point(274, 311);
    this.\u0006\u200A\u2000.Name = \u000F\u2000.\u0002(-380204777);
    this.\u0006\u200A\u2000.Size = new Size(2, 2);
    this.\u0006\u200A\u2000.TabIndex = 233;
    this.\u000E\u200A\u2000.BackColor = Color.White;
    this.\u000E\u200A\u2000.Location = new Point(274, 329);
    this.\u000E\u200A\u2000.Name = \u000F\u2000.\u0002(-380204767);
    this.\u000E\u200A\u2000.Size = new Size(2, 2);
    this.\u000E\u200A\u2000.TabIndex = 232;
    this.\u000F\u200A\u2000.BackColor = Color.White;
    this.\u000F\u200A\u2000.Location = new Point(274, 320);
    this.\u000F\u200A\u2000.Name = \u000F\u2000.\u0002(-380204749);
    this.\u000F\u200A\u2000.Size = new Size(2, 2);
    this.\u000F\u200A\u2000.TabIndex = 231;
    this.\u0002​\u2000.BackColor = Color.White;
    this.\u0002​\u2000.Location = new Point(238, 311);
    this.\u0002​\u2000.Name = \u000F\u2000.\u0002(-380204739);
    this.\u0002​\u2000.Size = new Size(2, 2);
    this.\u0002​\u2000.TabIndex = 237;
    this.\u0003​\u2000.BackColor = Color.White;
    this.\u0003​\u2000.Location = new Point(238, 329);
    this.\u0003​\u2000.Name = \u000F\u2000.\u0002(-380204721);
    this.\u0003​\u2000.Size = new Size(2, 2);
    this.\u0003​\u2000.TabIndex = 236;
    this.\u0005​\u2000.BackColor = Color.White;
    this.\u0005​\u2000.Location = new Point(238, 320);
    this.\u0005​\u2000.Name = \u000F\u2000.\u0002(-380204711);
    this.\u0005​\u2000.Size = new Size(2, 2);
    this.\u0005​\u2000.TabIndex = 235;
    this.\u0008​\u2000.BackColor = Color.White;
    this.\u0008​\u2000.Location = new Point(238, 338);
    this.\u0008​\u2000.Name = \u000F\u2000.\u0002(-380204693);
    this.\u0008​\u2000.Size = new Size(2, 2);
    this.\u0008​\u2000.TabIndex = 234;
    this.\u0006​\u2000.BackColor = Color.White;
    this.\u0006​\u2000.Location = new Point(220, 338);
    this.\u0006​\u2000.Name = \u000F\u2000.\u0002(-380204683);
    this.\u0006​\u2000.Size = new Size(2, 2);
    this.\u0006​\u2000.TabIndex = 242;
    this.\u000E​\u2000.BackColor = Color.White;
    this.\u000E​\u2000.Location = new Point(211, 338);
    this.\u000E​\u2000.Name = \u000F\u2000.\u0002(-380203385);
    this.\u000E​\u2000.Size = new Size(2, 2);
    this.\u000E​\u2000.TabIndex = 241;
    this.\u000F​\u2000.BackColor = Color.White;
    this.\u000F​\u2000.Location = new Point(202, 338);
    this.\u000F​\u2000.Name = \u000F\u2000.\u0002(-380203375);
    this.\u000F​\u2000.Size = new Size(2, 2);
    this.\u000F​\u2000.TabIndex = 240;
    this.\u0002\u2000\u2001.BackColor = Color.White;
    this.\u0002\u2000\u2001.Location = new Point(229, 338);
    this.\u0002\u2000\u2001.Name = \u000F\u2000.\u0002(-380203357);
    this.\u0002\u2000\u2001.Size = new Size(2, 2);
    this.\u0002\u2000\u2001.TabIndex = 238;
    this.\u0003\u2000\u2001.BackColor = Color.White;
    this.\u0003\u2000\u2001.Location = new Point(202, 356);
    this.\u0003\u2000\u2001.Name = \u000F\u2000.\u0002(-380203347);
    this.\u0003\u2000\u2001.Size = new Size(2, 2);
    this.\u0003\u2000\u2001.TabIndex = 247;
    this.\u0005\u2000\u2001.BackColor = Color.White;
    this.\u0005\u2000\u2001.Location = new Point(202, 374);
    this.\u0005\u2000\u2001.Name = \u000F\u2000.\u0002(-380203329);
    this.\u0005\u2000\u2001.Size = new Size(2, 2);
    this.\u0005\u2000\u2001.TabIndex = 246;
    this.\u0008\u2000\u2001.BackColor = Color.White;
    this.\u0008\u2000\u2001.Location = new Point(202, 365);
    this.\u0008\u2000\u2001.Name = \u000F\u2000.\u0002(-380203319);
    this.\u0008\u2000\u2001.Size = new Size(2, 2);
    this.\u0008\u2000\u2001.TabIndex = 245;
    this.\u0006\u2000\u2001.BackColor = Color.White;
    this.\u0006\u2000\u2001.Location = new Point(202, 347);
    this.\u0006\u2000\u2001.Name = \u000F\u2000.\u0002(-380203301);
    this.\u0006\u2000\u2001.Size = new Size(2, 2);
    this.\u0006\u2000\u2001.TabIndex = 243;
    this.\u000E\u2000\u2001.BackColor = Color.White;
    this.\u000E\u2000\u2001.Location = new Point(334, 356);
    this.\u000E\u2000\u2001.Name = \u000F\u2000.\u0002(-380203291);
    this.\u000E\u2000\u2001.Size = new Size(2, 2);
    this.\u000E\u2000\u2001.TabIndex = 252;
    this.\u000F\u2000\u2001.BackColor = Color.White;
    this.\u000F\u2000\u2001.Location = new Point(334, 374);
    this.\u000F\u2000\u2001.Name = \u000F\u2000.\u0002(-380203273);
    this.\u000F\u2000\u2001.Size = new Size(2, 2);
    this.\u000F\u2000\u2001.TabIndex = 251;
    this.\u0002\u2001\u2001.BackColor = Color.White;
    this.\u0002\u2001\u2001.Location = new Point(334, 365);
    this.\u0002\u2001\u2001.Name = \u000F\u2000.\u0002(-380203519);
    this.\u0002\u2001\u2001.Size = new Size(2, 2);
    this.\u0002\u2001\u2001.TabIndex = 250;
    this.\u0003\u2001\u2001.BackColor = Color.White;
    this.\u0003\u2001\u2001.Location = new Point(334, 347);
    this.\u0003\u2001\u2001.Name = \u000F\u2000.\u0002(-380203502);
    this.\u0003\u2001\u2001.Size = new Size(2, 2);
    this.\u0003\u2001\u2001.TabIndex = 249;
    this.\u0005\u2001\u2001.BackColor = Color.White;
    this.\u0005\u2001\u2001.Location = new Point(334, 338);
    this.\u0005\u2001\u2001.Name = \u000F\u2000.\u0002(-380203485);
    this.\u0005\u2001\u2001.Size = new Size(2, 2);
    this.\u0005\u2001\u2001.TabIndex = 248;
    this.\u0008\u2001\u2001.BackColor = Color.White;
    this.\u0008\u2001\u2001.Location = new Point(326, 338);
    this.\u0008\u2001\u2001.Name = \u000F\u2000.\u0002(-380203476);
    this.\u0008\u2001\u2001.Size = new Size(2, 2);
    this.\u0008\u2001\u2001.TabIndex = 254;
    this.\u0006\u2001\u2001.BackColor = Color.White;
    this.\u0006\u2001\u2001.Location = new Point(318, 338);
    this.\u0006\u2001\u2001.Name = \u000F\u2000.\u0002(-380203459);
    this.\u0006\u2001\u2001.Size = new Size(2, 2);
    this.\u0006\u2001\u2001.TabIndex = 253;
    this.\u000E\u2001\u2001.BackColor = Color.White;
    this.\u000E\u2001\u2001.Location = new Point(326, 374);
    this.\u000E\u2001\u2001.Name = \u000F\u2000.\u0002(-380203442);
    this.\u000E\u2001\u2001.Size = new Size(2, 2);
    this.\u000E\u2001\u2001.TabIndex = 268;
    this.\u000F\u2001\u2001.BackColor = Color.White;
    this.\u000F\u2001\u2001.Location = new Point(247, 374);
    this.\u000F\u2001\u2001.Name = \u000F\u2000.\u0002(-380203425);
    this.\u000F\u2001\u2001.Size = new Size(2, 2);
    this.\u000F\u2001\u2001.TabIndex = 267;
    this.\u0002\u2002\u2001.BackColor = Color.White;
    this.\u0002\u2002\u2001.Location = new Point(238, 374);
    this.\u0002\u2002\u2001.Name = \u000F\u2000.\u0002(-380203416);
    this.\u0002\u2002\u2001.Size = new Size(2, 2);
    this.\u0002\u2002\u2001.TabIndex = 266;
    this.\u0003\u2002\u2001.BackColor = Color.White;
    this.\u0003\u2002\u2001.Location = new Point(229, 374);
    this.\u0003\u2002\u2001.Name = \u000F\u2000.\u0002(-380203399);
    this.\u0003\u2002\u2001.Size = new Size(2, 2);
    this.\u0003\u2002\u2001.TabIndex = 265;
    this.\u0005\u2002\u2001.BackColor = Color.White;
    this.\u0005\u2002\u2001.Location = new Point(220, 374);
    this.\u0005\u2002\u2001.Name = \u000F\u2000.\u0002(-380203126);
    this.\u0005\u2002\u2001.Size = new Size(2, 2);
    this.\u0005\u2002\u2001.TabIndex = 264;
    this.\u0008\u2002\u2001.BackColor = Color.White;
    this.\u0008\u2002\u2001.Location = new Point(211, 374);
    this.\u0008\u2002\u2001.Name = \u000F\u2000.\u0002(-380203109);
    this.\u0008\u2002\u2001.Size = new Size(2, 2);
    this.\u0008\u2002\u2001.TabIndex = 263;
    this.\u0006\u2002\u2001.BackColor = Color.White;
    this.\u0006\u2002\u2001.Location = new Point(318, 374);
    this.\u0006\u2002\u2001.Name = \u000F\u2000.\u0002(-380203100);
    this.\u0006\u2002\u2001.Size = new Size(2, 2);
    this.\u0006\u2002\u2001.TabIndex = 262;
    this.\u000E\u2002\u2001.BackColor = Color.White;
    this.\u000E\u2002\u2001.Location = new Point(310, 374);
    this.\u000E\u2002\u2001.Name = \u000F\u2000.\u0002(-380203083);
    this.\u000E\u2002\u2001.Size = new Size(2, 2);
    this.\u000E\u2002\u2001.TabIndex = 261;
    this.\u000F\u2002\u2001.BackColor = Color.White;
    this.\u000F\u2002\u2001.Location = new Point(301, 374);
    this.\u000F\u2002\u2001.Name = \u000F\u2000.\u0002(-380203066);
    this.\u000F\u2002\u2001.Size = new Size(2, 2);
    this.\u000F\u2002\u2001.TabIndex = 260;
    this.\u0002\u2003\u2001.BackColor = Color.White;
    this.\u0002\u2003\u2001.Location = new Point(292, 374);
    this.\u0002\u2003\u2001.Name = \u000F\u2000.\u0002(-380203049);
    this.\u0002\u2003\u2001.Size = new Size(2, 2);
    this.\u0002\u2003\u2001.TabIndex = 259;
    this.\u0003\u2003\u2001.BackColor = Color.White;
    this.\u0003\u2003\u2001.Location = new Point(283, 374);
    this.\u0003\u2003\u2001.Name = \u000F\u2000.\u0002(-380203040);
    this.\u0003\u2003\u2001.Size = new Size(2, 2);
    this.\u0003\u2003\u2001.TabIndex = 258;
    this.\u0005\u2003\u2001.BackColor = Color.White;
    this.\u0005\u2003\u2001.Location = new Point(274, 374);
    this.\u0005\u2003\u2001.Name = \u000F\u2000.\u0002(-380203023);
    this.\u0005\u2003\u2001.Size = new Size(2, 2);
    this.\u0005\u2003\u2001.TabIndex = 257;
    this.\u0008\u2003\u2001.BackColor = Color.White;
    this.\u0008\u2003\u2001.Location = new Point(265, 374);
    this.\u0008\u2003\u2001.Name = \u000F\u2000.\u0002(-380203262);
    this.\u0008\u2003\u2001.Size = new Size(2, 2);
    this.\u0008\u2003\u2001.TabIndex = 256;
    this.\u0006\u2003\u2001.BackColor = Color.White;
    this.\u0006\u2003\u2001.Location = new Point(256, 374);
    this.\u0006\u2003\u2001.Name = \u000F\u2000.\u0002(-380203245);
    this.\u0006\u2003\u2001.Size = new Size(2, 2);
    this.\u0006\u2003\u2001.TabIndex = (int) byte.MaxValue;
    this.\u000E\u2003\u2001.BackColor = Color.White;
    this.\u000E\u2003\u2001.Location = new Point(157, 374);
    this.\u000E\u2003\u2001.Name = \u000F\u2000.\u0002(-380203236);
    this.\u000E\u2003\u2001.Size = new Size(2, 2);
    this.\u000E\u2003\u2001.TabIndex = 312;
    this.\u000F\u2003\u2001.BackColor = Color.White;
    this.\u000F\u2003\u2001.Location = new Point(78, 374);
    this.\u000F\u2003\u2001.Name = \u000F\u2000.\u0002(-380203219);
    this.\u000F\u2003\u2001.Size = new Size(2, 2);
    this.\u000F\u2003\u2001.TabIndex = 311;
    this.\u0002\u2004\u2001.BackColor = Color.White;
    this.\u0002\u2004\u2001.Location = new Point(69, 374);
    this.\u0002\u2004\u2001.Name = \u000F\u2000.\u0002(-380203202);
    this.\u0002\u2004\u2001.Size = new Size(2, 2);
    this.\u0002\u2004\u2001.TabIndex = 310;
    this.\u0003\u2004\u2001.BackColor = Color.White;
    this.\u0003\u2004\u2001.Location = new Point(60, 374);
    this.\u0003\u2004\u2001.Name = \u000F\u2000.\u0002(-380203185);
    this.\u0003\u2004\u2001.Size = new Size(2, 2);
    this.\u0003\u2004\u2001.TabIndex = 309;
    this.\u0005\u2004\u2001.BackColor = Color.White;
    this.\u0005\u2004\u2001.Location = new Point(51, 374);
    this.\u0005\u2004\u2001.Name = \u000F\u2000.\u0002(-380203176);
    this.\u0005\u2004\u2001.Size = new Size(2, 2);
    this.\u0005\u2004\u2001.TabIndex = 308;
    this.\u0008\u2004\u2001.BackColor = Color.White;
    this.\u0008\u2004\u2001.Location = new Point(149, 374);
    this.\u0008\u2004\u2001.Name = \u000F\u2000.\u0002(-380203159);
    this.\u0008\u2004\u2001.Size = new Size(2, 2);
    this.\u0008\u2004\u2001.TabIndex = 306;
    this.\u0006\u2004\u2001.BackColor = Color.White;
    this.\u0006\u2004\u2001.Location = new Point(141, 374);
    this.\u0006\u2004\u2001.Name = \u000F\u2000.\u0002(-380203142);
    this.\u0006\u2004\u2001.Size = new Size(2, 2);
    this.\u0006\u2004\u2001.TabIndex = 305;
    this.\u000E\u2004\u2001.BackColor = Color.White;
    this.\u000E\u2004\u2001.Location = new Point(132, 374);
    this.\u000E\u2004\u2001.Name = \u000F\u2000.\u0002(-380203893);
    this.\u000E\u2004\u2001.Size = new Size(2, 2);
    this.\u000E\u2004\u2001.TabIndex = 304;
    this.\u000F\u2004\u2001.BackColor = Color.White;
    this.\u000F\u2004\u2001.Location = new Point(123, 374);
    this.\u000F\u2004\u2001.Name = \u000F\u2000.\u0002(-380203884);
    this.\u000F\u2004\u2001.Size = new Size(2, 2);
    this.\u000F\u2004\u2001.TabIndex = 303;
    this.\u0002\u2005\u2001.BackColor = Color.White;
    this.\u0002\u2005\u2001.Location = new Point(114, 374);
    this.\u0002\u2005\u2001.Name = \u000F\u2000.\u0002(-380203867);
    this.\u0002\u2005\u2001.Size = new Size(2, 2);
    this.\u0002\u2005\u2001.TabIndex = 302;
    this.\u0003\u2005\u2001.BackColor = Color.White;
    this.\u0003\u2005\u2001.Location = new Point(105, 374);
    this.\u0003\u2005\u2001.Name = \u000F\u2000.\u0002(-380203850);
    this.\u0003\u2005\u2001.Size = new Size(2, 2);
    this.\u0003\u2005\u2001.TabIndex = 301;
    this.\u0005\u2005\u2001.BackColor = Color.White;
    this.\u0005\u2005\u2001.Location = new Point(96, 374);
    this.\u0005\u2005\u2001.Name = \u000F\u2000.\u0002(-380203833);
    this.\u0005\u2005\u2001.Size = new Size(2, 2);
    this.\u0005\u2005\u2001.TabIndex = 300;
    this.\u0008\u2005\u2001.BackColor = Color.White;
    this.\u0008\u2005\u2001.Location = new Point(87, 374);
    this.\u0008\u2005\u2001.Name = \u000F\u2000.\u0002(-380203824);
    this.\u0008\u2005\u2001.Size = new Size(2, 2);
    this.\u0008\u2005\u2001.TabIndex = 299;
    this.\u0006\u2005\u2001.BackColor = Color.White;
    this.\u0006\u2005\u2001.Location = new Point(156, 338);
    this.\u0006\u2005\u2001.Name = \u000F\u2000.\u0002(-380203807);
    this.\u0006\u2005\u2001.Size = new Size(2, 2);
    this.\u0006\u2005\u2001.TabIndex = 298;
    this.\u000E\u2005\u2001.BackColor = Color.White;
    this.\u000E\u2005\u2001.Location = new Point(147, 338);
    this.\u000E\u2005\u2001.Name = \u000F\u2000.\u0002(-380203790);
    this.\u000E\u2005\u2001.Size = new Size(2, 2);
    this.\u000E\u2005\u2001.TabIndex = 297;
    this.\u000F\u2005\u2001.BackColor = Color.White;
    this.\u000F\u2005\u2001.Location = new Point(165, 356);
    this.\u000F\u2005\u2001.Name = \u000F\u2000.\u0002(-380204029);
    this.\u000F\u2005\u2001.Size = new Size(2, 2);
    this.\u000F\u2005\u2001.TabIndex = 296;
    this.\u0002\u2006\u2001.BackColor = Color.White;
    this.\u0002\u2006\u2001.Location = new Point(165, 374);
    this.\u0002\u2006\u2001.Name = \u000F\u2000.\u0002(-380204020);
    this.\u0002\u2006\u2001.Size = new Size(2, 2);
    this.\u0002\u2006\u2001.TabIndex = 295;
    this.\u0003\u2006\u2001.BackColor = Color.White;
    this.\u0003\u2006\u2001.Location = new Point(165, 365);
    this.\u0003\u2006\u2001.Name = \u000F\u2000.\u0002(-380204003);
    this.\u0003\u2006\u2001.Size = new Size(2, 2);
    this.\u0003\u2006\u2001.TabIndex = 294;
    this.\u0005\u2006\u2001.BackColor = Color.White;
    this.\u0005\u2006\u2001.Location = new Point(165, 347);
    this.\u0005\u2006\u2001.Name = \u000F\u2000.\u0002(-380203986);
    this.\u0005\u2006\u2001.Size = new Size(2, 2);
    this.\u0005\u2006\u2001.TabIndex = 293;
    this.\u0008\u2006\u2001.BackColor = Color.White;
    this.\u0008\u2006\u2001.Location = new Point(165, 338);
    this.\u0008\u2006\u2001.Name = \u000F\u2000.\u0002(-380203969);
    this.\u0008\u2006\u2001.Size = new Size(2, 2);
    this.\u0008\u2006\u2001.TabIndex = 292;
    this.\u0006\u2006\u2001.BackColor = Color.White;
    this.\u0006\u2006\u2001.Location = new Point(35, 356);
    this.\u0006\u2006\u2001.Name = \u000F\u2000.\u0002(-380203960);
    this.\u0006\u2006\u2001.Size = new Size(2, 2);
    this.\u0006\u2006\u2001.TabIndex = 291;
    this.\u000E\u2006\u2001.BackColor = Color.White;
    this.\u000E\u2006\u2001.Location = new Point(35, 347);
    this.\u000E\u2006\u2001.Name = \u000F\u2000.\u0002(-380203943);
    this.\u000E\u2006\u2001.Size = new Size(2, 2);
    this.\u000E\u2006\u2001.TabIndex = 288;
    this.\u000F\u2006\u2001.BackColor = Color.White;
    this.\u000F\u2006\u2001.Location = new Point(50, 338);
    this.\u000F\u2006\u2001.Name = \u000F\u2000.\u0002(-380203926);
    this.\u000F\u2006\u2001.Size = new Size(2, 2);
    this.\u000F\u2006\u2001.TabIndex = 287;
    this.\u0002\u2007\u2001.BackColor = Color.White;
    this.\u0002\u2007\u2001.Location = new Point(42, 338);
    this.\u0002\u2007\u2001.Name = \u000F\u2000.\u0002(-380203909);
    this.\u0002\u2007\u2001.Size = new Size(2, 2);
    this.\u0002\u2007\u2001.TabIndex = 286;
    this.\u0003\u2007\u2001.BackColor = Color.White;
    this.\u0003\u2007\u2001.Location = new Point(35, 338);
    this.\u0003\u2007\u2001.Name = \u000F\u2000.\u0002(-380203644);
    this.\u0003\u2007\u2001.Size = new Size(2, 2);
    this.\u0003\u2007\u2001.TabIndex = 285;
    this.\u0005\u2007\u2001.BackColor = Color.White;
    this.\u0005\u2007\u2001.Location = new Point(59, 338);
    this.\u0005\u2007\u2001.Name = \u000F\u2000.\u0002(-380203627);
    this.\u0005\u2007\u2001.Size = new Size(2, 2);
    this.\u0005\u2007\u2001.TabIndex = 284;
    this.\u0008\u2007\u2001.BackColor = Color.White;
    this.\u0008\u2007\u2001.Location = new Point(59, 311);
    this.\u0008\u2007\u2001.Name = \u000F\u2000.\u0002(-380203610);
    this.\u0008\u2007\u2001.Size = new Size(2, 2);
    this.\u0008\u2007\u2001.TabIndex = 283;
    this.\u0006\u2007\u2001.BackColor = Color.White;
    this.\u0006\u2007\u2001.Location = new Point(59, 329);
    this.\u0006\u2007\u2001.Name = \u000F\u2000.\u0002(-380203593);
    this.\u0006\u2007\u2001.Size = new Size(2, 2);
    this.\u0006\u2007\u2001.TabIndex = 282;
    this.\u000E\u2007\u2001.BackColor = Color.White;
    this.\u000E\u2007\u2001.Location = new Point(59, 320);
    this.\u000E\u2007\u2001.Name = \u000F\u2000.\u0002(-380203584);
    this.\u000E\u2007\u2001.Size = new Size(2, 2);
    this.\u000E\u2007\u2001.TabIndex = 281;
    this.\u000F\u2007\u2001.BackColor = Color.White;
    this.\u000F\u2007\u2001.Location = new Point(68, 338);
    this.\u000F\u2007\u2001.Name = \u000F\u2000.\u0002(-380203567);
    this.\u000F\u2007\u2001.Size = new Size(2, 2);
    this.\u000F\u2007\u2001.TabIndex = 280;
    this.\u0002\u2008\u2001.BackColor = Color.White;
    this.\u0002\u2008\u2001.Location = new Point(94, 311);
    this.\u0002\u2008\u2001.Name = \u000F\u2000.\u0002(-380203550);
    this.\u0002\u2008\u2001.Size = new Size(2, 2);
    this.\u0002\u2008\u2001.TabIndex = 279;
    this.\u0003\u2008\u2001.BackColor = Color.White;
    this.\u0003\u2008\u2001.Location = new Point(94, 329);
    this.\u0003\u2008\u2001.Name = \u000F\u2000.\u0002(-380203533);
    this.\u0003\u2008\u2001.Size = new Size(2, 2);
    this.\u0003\u2008\u2001.TabIndex = 278;
    this.\u0005\u2008\u2001.BackColor = Color.White;
    this.\u0005\u2008\u2001.Location = new Point(94, 320);
    this.\u0005\u2008\u2001.Name = \u000F\u2000.\u0002(-380203524);
    this.\u0005\u2008\u2001.Size = new Size(2, 2);
    this.\u0005\u2008\u2001.TabIndex = 277;
    this.\u0008\u2008\u2001.BackColor = Color.White;
    this.\u0008\u2008\u2001.Location = new Point(129, 338);
    this.\u0008\u2008\u2001.Name = \u000F\u2000.\u0002(-380203763);
    this.\u0008\u2008\u2001.Size = new Size(2, 2);
    this.\u0008\u2008\u2001.TabIndex = 276;
    this.\u0006\u2008\u2001.BackColor = Color.White;
    this.\u0006\u2008\u2001.Location = new Point(94, 338);
    this.\u0006\u2008\u2001.Name = \u000F\u2000.\u0002(-380203746);
    this.\u0006\u2008\u2001.Size = new Size(2, 2);
    this.\u0006\u2008\u2001.TabIndex = 275;
    this.\u000E\u2008\u2001.BackColor = Color.White;
    this.\u000E\u2008\u2001.Location = new Point(85, 338);
    this.\u000E\u2008\u2001.Name = \u000F\u2000.\u0002(-380203729);
    this.\u000E\u2008\u2001.Size = new Size(2, 2);
    this.\u000E\u2008\u2001.TabIndex = 274;
    this.\u000F\u2008\u2001.BackColor = Color.White;
    this.\u000F\u2008\u2001.Location = new Point(76, 338);
    this.\u000F\u2008\u2001.Name = \u000F\u2000.\u0002(-380203720);
    this.\u000F\u2008\u2001.Size = new Size(2, 2);
    this.\u000F\u2008\u2001.TabIndex = 273;
    this.\u0002\u2009\u2001.BackColor = Color.White;
    this.\u0002\u2009\u2001.Location = new Point(129, 311);
    this.\u0002\u2009\u2001.Name = \u000F\u2000.\u0002(-380203703);
    this.\u0002\u2009\u2001.Size = new Size(2, 2);
    this.\u0002\u2009\u2001.TabIndex = 272;
    this.\u0003\u2009\u2001.BackColor = Color.White;
    this.\u0003\u2009\u2001.Location = new Point(138, 338);
    this.\u0003\u2009\u2001.Name = \u000F\u2000.\u0002(-380203686);
    this.\u0003\u2009\u2001.Size = new Size(2, 2);
    this.\u0003\u2009\u2001.TabIndex = 271;
    this.\u0005\u2009\u2001.BackColor = Color.White;
    this.\u0005\u2009\u2001.Location = new Point(129, 329);
    this.\u0005\u2009\u2001.Name = \u000F\u2000.\u0002(-380203669);
    this.\u0005\u2009\u2001.Size = new Size(2, 2);
    this.\u0005\u2009\u2001.TabIndex = 270;
    this.\u0008\u2009\u2001.BackColor = Color.White;
    this.\u0008\u2009\u2001.Location = new Point(129, 320);
    this.\u0008\u2009\u2001.Name = \u000F\u2000.\u0002(-380203660);
    this.\u0008\u2009\u2001.Size = new Size(2, 2);
    this.\u0008\u2009\u2001.TabIndex = 269;
    this.\u0006\u2009\u2001.BackColor = Color.White;
    this.\u0006\u2009\u2001.Location = new Point(192, 374);
    this.\u0006\u2009\u2001.Name = \u000F\u2000.\u0002(-380202363);
    this.\u0006\u2009\u2001.Size = new Size(2, 2);
    this.\u0006\u2009\u2001.TabIndex = 315;
    this.\u000E\u2009\u2001.BackColor = Color.White;
    this.\u000E\u2009\u2001.Location = new Point(183, 374);
    this.\u000E\u2009\u2001.Name = \u000F\u2000.\u0002(-380202346);
    this.\u000E\u2009\u2001.Size = new Size(2, 2);
    this.\u000E\u2009\u2001.TabIndex = 314;
    this.\u000F\u2009\u2001.BackColor = Color.White;
    this.\u000F\u2009\u2001.Location = new Point(174, 374);
    this.\u000F\u2009\u2001.Name = \u000F\u2000.\u0002(-380202329);
    this.\u000F\u2009\u2001.Size = new Size(2, 2);
    this.\u000F\u2009\u2001.TabIndex = 313;
    this.\u0002\u200A\u2001.BackColor = Color.White;
    this.\u0002\u200A\u2001.Location = new Point(35, 293);
    this.\u0002\u200A\u2001.Name = \u000F\u2000.\u0002(-380202320);
    this.\u0002\u200A\u2001.Size = new Size(2, 2);
    this.\u0002\u200A\u2001.TabIndex = 318;
    this.\u0003\u200A\u2001.BackColor = Color.White;
    this.\u0003\u200A\u2001.Location = new Point(35, 284);
    this.\u0003\u200A\u2001.Name = \u000F\u2000.\u0002(-380202303);
    this.\u0003\u200A\u2001.Size = new Size(2, 2);
    this.\u0003\u200A\u2001.TabIndex = 317;
    this.\u0005\u200A\u2001.BackColor = Color.White;
    this.\u0005\u200A\u2001.Location = new Point(35, 275);
    this.\u0005\u200A\u2001.Name = \u000F\u2000.\u0002(-380202286);
    this.\u0005\u200A\u2001.Size = new Size(2, 2);
    this.\u0005\u200A\u2001.TabIndex = 316;
    this.\u0008\u200A\u2001.BackColor = Color.White;
    this.\u0008\u200A\u2001.Location = new Point(86, 266);
    this.\u0008\u200A\u2001.Name = \u000F\u2000.\u0002(-380202269);
    this.\u0008\u200A\u2001.Size = new Size(2, 2);
    this.\u0008\u200A\u2001.TabIndex = 319;
    this.\u0006\u200A\u2001.BackColor = Color.White;
    this.\u0006\u200A\u2001.Location = new Point(59, 302);
    this.\u0006\u200A\u2001.Name = \u000F\u2000.\u0002(-380202260);
    this.\u0006\u200A\u2001.Size = new Size(2, 2);
    this.\u0006\u200A\u2001.TabIndex = 323;
    this.\u000E\u200A\u2001.BackColor = Color.White;
    this.\u000E\u200A\u2001.Location = new Point(51, 302);
    this.\u000E\u200A\u2001.Name = \u000F\u2000.\u0002(-380202243);
    this.\u000E\u200A\u2001.Size = new Size(2, 2);
    this.\u000E\u200A\u2001.TabIndex = 322;
    this.\u000F\u200A\u2001.BackColor = Color.White;
    this.\u000F\u200A\u2001.Location = new Point(43, 302);
    this.\u000F\u200A\u2001.Name = \u000F\u2000.\u0002(-380202482);
    this.\u000F\u200A\u2001.Size = new Size(2, 2);
    this.\u000F\u200A\u2001.TabIndex = 321;
    this.\u0002​\u2001.BackColor = Color.Black;
    this.\u0002​\u2001.Image = (Image) componentResourceManager.GetObject(\u000F\u2000.\u0002(-380202465));
    this.\u0002​\u2001.Location = new Point(31, 298);
    this.\u0002​\u2001.Name = \u000F\u2000.\u0002(-380202446);
    this.\u0002​\u2001.Size = new Size(10, 10);
    this.\u0002​\u2001.TabIndex = 320;
    this.\u0003​\u2001.BackColor = Color.White;
    this.\u0003​\u2001.Location = new Point(274, 230);
    this.\u0003​\u2001.Name = \u000F\u2000.\u0002(-380202429);
    this.\u0003​\u2001.Size = new Size(2, 2);
    this.\u0003​\u2001.TabIndex = 333;
    this.\u0005​\u2001.BackColor = Color.White;
    this.\u0005​\u2001.Location = new Point(274, 248);
    this.\u0005​\u2001.Name = \u000F\u2000.\u0002(-380202420);
    this.\u0005​\u2001.Size = new Size(2, 2);
    this.\u0005​\u2001.TabIndex = 332;
    this.\u0008​\u2001.BackColor = Color.White;
    this.\u0008​\u2001.Location = new Point(274, 239);
    this.\u0008​\u2001.Name = \u000F\u2000.\u0002(-380202403);
    this.\u0008​\u2001.Size = new Size(2, 2);
    this.\u0008​\u2001.TabIndex = 331;
    this.\u0006​\u2001.BackColor = Color.White;
    this.\u0006​\u2001.Location = new Point(274, 257);
    this.\u0006​\u2001.Name = \u000F\u2000.\u0002(-380202386);
    this.\u0006​\u2001.Size = new Size(2, 2);
    this.\u0006​\u2001.TabIndex = 330;
    this.\u000E​\u2001.BackColor = Color.White;
    this.\u000E​\u2001.Location = new Point(274, 212);
    this.\u000E​\u2001.Name = \u000F\u2000.\u0002(-380202369);
    this.\u000E​\u2001.Size = new Size(2, 2);
    this.\u000E​\u2001.TabIndex = 329;
    this.\u000F​\u2001.BackColor = Color.White;
    this.\u000F​\u2001.Location = new Point(274, 203);
    this.\u000F​\u2001.Name = \u000F\u2000.\u0002(-380202104);
    this.\u000F​\u2001.Size = new Size(2, 2);
    this.\u000F​\u2001.TabIndex = 328;
    this.\u0002\u2000\u2002.BackColor = Color.White;
    this.\u0002\u2000\u2002.Location = new Point(274, 194);
    this.\u0002\u2000\u2002.Name = \u000F\u2000.\u0002(-380202087);
    this.\u0002\u2000\u2002.Size = new Size(2, 2);
    this.\u0002\u2000\u2002.TabIndex = 327;
    this.\u0003\u2000\u2002.BackColor = Color.White;
    this.\u0003\u2000\u2002.Location = new Point(274, 221);
    this.\u0003\u2000\u2002.Name = \u000F\u2000.\u0002(-380202070);
    this.\u0003\u2000\u2002.Size = new Size(2, 2);
    this.\u0003\u2000\u2002.TabIndex = 326;
    this.\u0005\u2000\u2002.BackColor = Color.White;
    this.\u0005\u2000\u2002.Location = new Point(274, 185);
    this.\u0005\u2000\u2002.Name = \u000F\u2000.\u0002(-380202053);
    this.\u0005\u2000\u2002.Size = new Size(2, 2);
    this.\u0005\u2000\u2002.TabIndex = 325;
    this.\u0008\u2000\u2002.BackColor = Color.White;
    this.\u0008\u2000\u2002.Location = new Point(274, 149);
    this.\u0008\u2000\u2002.Name = \u000F\u2000.\u0002(-380202044);
    this.\u0008\u2000\u2002.Size = new Size(2, 2);
    this.\u0008\u2000\u2002.TabIndex = 342;
    this.\u0006\u2000\u2002.BackColor = Color.White;
    this.\u0006\u2000\u2002.Location = new Point(274, 167);
    this.\u0006\u2000\u2002.Name = \u000F\u2000.\u0002(-380202027);
    this.\u0006\u2000\u2002.Size = new Size(2, 2);
    this.\u0006\u2000\u2002.TabIndex = 341;
    this.\u000E\u2000\u2002.BackColor = Color.White;
    this.\u000E\u2000\u2002.Location = new Point(274, 158);
    this.\u000E\u2000\u2002.Name = \u000F\u2000.\u0002(-380202010);
    this.\u000E\u2000\u2002.Size = new Size(2, 2);
    this.\u000E\u2000\u2002.TabIndex = 340;
    this.\u000F\u2000\u2002.BackColor = Color.White;
    this.\u000F\u2000\u2002.Location = new Point(274, 176);
    this.\u000F\u2000\u2002.Name = \u000F\u2000.\u0002(-380201993);
    this.\u000F\u2000\u2002.Size = new Size(2, 2);
    this.\u000F\u2000\u2002.TabIndex = 339;
    this.\u0002\u2001\u2002.BackColor = Color.White;
    this.\u0002\u2001\u2002.Location = new Point(274, 131);
    this.\u0002\u2001\u2002.Name = \u000F\u2000.\u0002(-380202240);
    this.\u0002\u2001\u2002.Size = new Size(2, 2);
    this.\u0002\u2001\u2002.TabIndex = 338;
    this.\u0003\u2001\u2002.BackColor = Color.White;
    this.\u0003\u2001\u2002.Location = new Point(274, 122);
    this.\u0003\u2001\u2002.Name = \u000F\u2000.\u0002(-380202223);
    this.\u0003\u2001\u2002.Size = new Size(2, 2);
    this.\u0003\u2001\u2002.TabIndex = 337;
    this.\u0005\u2001\u2002.BackColor = Color.White;
    this.\u0005\u2001\u2002.Location = new Point(274, 113);
    this.\u0005\u2001\u2002.Name = \u000F\u2000.\u0002(-380202206);
    this.\u0005\u2001\u2002.Size = new Size(2, 2);
    this.\u0005\u2001\u2002.TabIndex = 336;
    this.\u0008\u2001\u2002.BackColor = Color.White;
    this.\u0008\u2001\u2002.Location = new Point(274, 140);
    this.\u0008\u2001\u2002.Name = \u000F\u2000.\u0002(-380202189);
    this.\u0008\u2001\u2002.Size = new Size(2, 2);
    this.\u0008\u2001\u2002.TabIndex = 335;
    this.\u0006\u2001\u2002.BackColor = Color.White;
    this.\u0006\u2001\u2002.Location = new Point(274, 104);
    this.\u0006\u2001\u2002.Name = \u000F\u2000.\u0002(-380202180);
    this.\u0006\u2001\u2002.Size = new Size(2, 2);
    this.\u0006\u2001\u2002.TabIndex = 334;
    this.\u000E\u2001\u2002.BackColor = Color.White;
    this.\u000E\u2001\u2002.Location = new Point(274, 66);
    this.\u000E\u2001\u2002.Name = \u000F\u2000.\u0002(-380202163);
    this.\u000E\u2001\u2002.Size = new Size(2, 2);
    this.\u000E\u2001\u2002.TabIndex = 351;
    this.\u000F\u2001\u2002.BackColor = Color.White;
    this.\u000F\u2001\u2002.Location = new Point(274, 85);
    this.\u000F\u2001\u2002.Name = \u000F\u2000.\u0002(-380202146);
    this.\u000F\u2001\u2002.Size = new Size(2, 2);
    this.\u000F\u2001\u2002.TabIndex = 350;
    this.\u0002\u2002\u2002.BackColor = Color.White;
    this.\u0002\u2002\u2002.Location = new Point(274, 76);
    this.\u0002\u2002\u2002.Name = \u000F\u2000.\u0002(-380202129);
    this.\u0002\u2002\u2002.Size = new Size(2, 2);
    this.\u0002\u2002\u2002.TabIndex = 349;
    this.\u0003\u2002\u2002.BackColor = Color.White;
    this.\u0003\u2002\u2002.Location = new Point(274, 94);
    this.\u0003\u2002\u2002.Name = \u000F\u2000.\u0002(-380202120);
    this.\u0003\u2002\u2002.Size = new Size(2, 2);
    this.\u0003\u2002\u2002.TabIndex = 348;
    this.\u0005\u2002\u2002.BackColor = Color.White;
    this.\u0005\u2002\u2002.Location = new Point(274, 47);
    this.\u0005\u2002\u2002.Name = \u000F\u2000.\u0002(-380202871);
    this.\u0005\u2002\u2002.Size = new Size(2, 2);
    this.\u0005\u2002\u2002.TabIndex = 347;
    this.\u0008\u2002\u2002.BackColor = Color.White;
    this.\u0008\u2002\u2002.Location = new Point(274, 57);
    this.\u0008\u2002\u2002.Name = \u000F\u2000.\u0002(-380202854);
    this.\u0008\u2002\u2002.Size = new Size(2, 2);
    this.\u0008\u2002\u2002.TabIndex = 344;
    this.\u0006\u2002\u2002.BackColor = Color.White;
    this.\u0006\u2002\u2002.Location = new Point(334, 38);
    this.\u0006\u2002\u2002.Name = \u000F\u2000.\u0002(-380202837);
    this.\u0006\u2002\u2002.Size = new Size(2, 2);
    this.\u0006\u2002\u2002.TabIndex = 367;
    this.\u000E\u2002\u2002.BackColor = Color.White;
    this.\u000E\u2002\u2002.Location = new Point(326, 38);
    this.\u000E\u2002\u2002.Name = \u000F\u2000.\u0002(-380202828);
    this.\u000E\u2002\u2002.Size = new Size(2, 2);
    this.\u000E\u2002\u2002.TabIndex = 366;
    this.\u000F\u2002\u2002.BackColor = Color.White;
    this.\u000F\u2002\u2002.Location = new Point(247, 38);
    this.\u000F\u2002\u2002.Name = \u000F\u2000.\u0002(-380202811);
    this.\u000F\u2002\u2002.Size = new Size(2, 2);
    this.\u000F\u2002\u2002.TabIndex = 365;
    this.\u0002\u2003\u2002.BackColor = Color.White;
    this.\u0002\u2003\u2002.Location = new Point(238, 38);
    this.\u0002\u2003\u2002.Name = \u000F\u2000.\u0002(-380202794);
    this.\u0002\u2003\u2002.Size = new Size(2, 2);
    this.\u0002\u2003\u2002.TabIndex = 364;
    this.\u0003\u2003\u2002.BackColor = Color.White;
    this.\u0003\u2003\u2002.Location = new Point(229, 38);
    this.\u0003\u2003\u2002.Name = \u000F\u2000.\u0002(-380202777);
    this.\u0003\u2003\u2002.Size = new Size(2, 2);
    this.\u0003\u2003\u2002.TabIndex = 363;
    this.\u0005\u2003\u2002.BackColor = Color.White;
    this.\u0005\u2003\u2002.Location = new Point(220, 38);
    this.\u0005\u2003\u2002.Name = \u000F\u2000.\u0002(-380202768);
    this.\u0005\u2003\u2002.Size = new Size(2, 2);
    this.\u0005\u2003\u2002.TabIndex = 362;
    this.\u0008\u2003\u2002.BackColor = Color.White;
    this.\u0008\u2003\u2002.Location = new Point(211, 38);
    this.\u0008\u2003\u2002.Name = \u000F\u2000.\u0002(-380203007);
    this.\u0008\u2003\u2002.Size = new Size(2, 2);
    this.\u0008\u2003\u2002.TabIndex = 361;
    this.\u0006\u2003\u2002.BackColor = Color.White;
    this.\u0006\u2003\u2002.Location = new Point(202, 38);
    this.\u0006\u2003\u2002.Name = \u000F\u2000.\u0002(-380202990);
    this.\u0006\u2003\u2002.Size = new Size(2, 2);
    this.\u0006\u2003\u2002.TabIndex = 360;
    this.\u000E\u2003\u2002.BackColor = Color.White;
    this.\u000E\u2003\u2002.Location = new Point(318, 38);
    this.\u000E\u2003\u2002.Name = \u000F\u2000.\u0002(-380202973);
    this.\u000E\u2003\u2002.Size = new Size(2, 2);
    this.\u000E\u2003\u2002.TabIndex = 359;
    this.\u000F\u2003\u2002.BackColor = Color.White;
    this.\u000F\u2003\u2002.Location = new Point(310, 38);
    this.\u000F\u2003\u2002.Name = \u000F\u2000.\u0002(-380202964);
    this.\u000F\u2003\u2002.Size = new Size(2, 2);
    this.\u000F\u2003\u2002.TabIndex = 358;
    this.\u0002\u2004\u2002.BackColor = Color.White;
    this.\u0002\u2004\u2002.Location = new Point(301, 38);
    this.\u0002\u2004\u2002.Name = \u000F\u2000.\u0002(-380202947);
    this.\u0002\u2004\u2002.Size = new Size(2, 2);
    this.\u0002\u2004\u2002.TabIndex = 357;
    this.\u0003\u2004\u2002.BackColor = Color.White;
    this.\u0003\u2004\u2002.Location = new Point(292, 38);
    this.\u0003\u2004\u2002.Name = \u000F\u2000.\u0002(-380202930);
    this.\u0003\u2004\u2002.Size = new Size(2, 2);
    this.\u0003\u2004\u2002.TabIndex = 356;
    this.\u0005\u2004\u2002.BackColor = Color.White;
    this.\u0005\u2004\u2002.Location = new Point(283, 38);
    this.\u0005\u2004\u2002.Name = \u000F\u2000.\u0002(-380202913);
    this.\u0005\u2004\u2002.Size = new Size(2, 2);
    this.\u0005\u2004\u2002.TabIndex = 355;
    this.\u0008\u2004\u2002.BackColor = Color.White;
    this.\u0008\u2004\u2002.Location = new Point(274, 38);
    this.\u0008\u2004\u2002.Name = \u000F\u2000.\u0002(-380202904);
    this.\u0008\u2004\u2002.Size = new Size(2, 2);
    this.\u0008\u2004\u2002.TabIndex = 354;
    this.\u0006\u2004\u2002.BackColor = Color.White;
    this.\u0006\u2004\u2002.Location = new Point(265, 38);
    this.\u0006\u2004\u2002.Name = \u000F\u2000.\u0002(-380202887);
    this.\u0006\u2004\u2002.Size = new Size(2, 2);
    this.\u0006\u2004\u2002.TabIndex = 353;
    this.\u000E\u2004\u2002.BackColor = Color.White;
    this.\u000E\u2004\u2002.Location = new Point(256, 38);
    this.\u000E\u2004\u2002.Name = \u000F\u2000.\u0002(-380202614);
    this.\u000E\u2004\u2002.Size = new Size(2, 2);
    this.\u000E\u2004\u2002.TabIndex = 352;
    this.\u000F\u2004\u2002.BackColor = Color.White;
    this.\u000F\u2004\u2002.Location = new Point(334, 94);
    this.\u000F\u2004\u2002.Name = \u000F\u2000.\u0002(-380202597);
    this.\u000F\u2004\u2002.Size = new Size(2, 2);
    this.\u000F\u2004\u2002.TabIndex = 376;
    this.\u0002\u2005\u2002.BackColor = Color.White;
    this.\u0002\u2005\u2002.Location = new Point(334, 113);
    this.\u0002\u2005\u2002.Name = \u000F\u2000.\u0002(-380202588);
    this.\u0002\u2005\u2002.Size = new Size(2, 2);
    this.\u0002\u2005\u2002.TabIndex = 375;
    this.\u0003\u2005\u2002.BackColor = Color.White;
    this.\u0003\u2005\u2002.Location = new Point(334, 104);
    this.\u0003\u2005\u2002.Name = \u000F\u2000.\u0002(-380202571);
    this.\u0003\u2005\u2002.Size = new Size(2, 2);
    this.\u0003\u2005\u2002.TabIndex = 374;
    this.\u0005\u2005\u2002.BackColor = Color.White;
    this.\u0005\u2005\u2002.Location = new Point(334, 122);
    this.\u0005\u2005\u2002.Name = \u000F\u2000.\u0002(-380202554);
    this.\u0005\u2005\u2002.Size = new Size(2, 2);
    this.\u0005\u2005\u2002.TabIndex = 373;
    this.\u0008\u2005\u2002.BackColor = Color.White;
    this.\u0008\u2005\u2002.Location = new Point(334, 76);
    this.\u0008\u2005\u2002.Name = \u000F\u2000.\u0002(-380202537);
    this.\u0008\u2005\u2002.Size = new Size(2, 2);
    this.\u0008\u2005\u2002.TabIndex = 372;
    this.\u0006\u2005\u2002.BackColor = Color.White;
    this.\u0006\u2005\u2002.Location = new Point(334, 67);
    this.\u0006\u2005\u2002.Name = \u000F\u2000.\u0002(-380202528);
    this.\u0006\u2005\u2002.Size = new Size(2, 2);
    this.\u0006\u2005\u2002.TabIndex = 371;
    this.\u000E\u2005\u2002.BackColor = Color.Black;
    this.\u000E\u2005\u2002.Image = (Image) componentResourceManager.GetObject(\u000F\u2000.\u0002(-380202511));
    this.\u000E\u2005\u2002.Location = new Point(330, 54);
    this.\u000E\u2005\u2002.Name = \u000F\u2000.\u0002(-380202748);
    this.\u000E\u2005\u2002.Size = new Size(10, 10);
    this.\u000E\u2005\u2002.TabIndex = 370;
    this.\u000F\u2005\u2002.BackColor = Color.White;
    this.\u000F\u2005\u2002.Location = new Point(334, 85);
    this.\u000F\u2005\u2002.Name = \u000F\u2000.\u0002(-380202731);
    this.\u000F\u2005\u2002.Size = new Size(2, 2);
    this.\u000F\u2005\u2002.TabIndex = 369;
    this.\u0002\u2006\u2002.BackColor = Color.White;
    this.\u0002\u2006\u2002.Location = new Point(334, 48);
    this.\u0002\u2006\u2002.Name = \u000F\u2000.\u0002(-380202714);
    this.\u0002\u2006\u2002.Size = new Size(2, 2);
    this.\u0002\u2006\u2002.TabIndex = 368;
    this.\u0003\u2006\u2002.BackColor = Color.White;
    this.\u0003\u2006\u2002.Location = new Point(326, 85);
    this.\u0003\u2006\u2002.Name = \u000F\u2000.\u0002(-380202697);
    this.\u0003\u2006\u2002.Size = new Size(2, 2);
    this.\u0003\u2006\u2002.TabIndex = 382;
    this.\u0005\u2006\u2002.BackColor = Color.White;
    this.\u0005\u2006\u2002.Location = new Point(318, 85);
    this.\u0005\u2006\u2002.Name = \u000F\u2000.\u0002(-380202688);
    this.\u0005\u2006\u2002.Size = new Size(2, 2);
    this.\u0005\u2006\u2002.TabIndex = 381;
    this.\u0008\u2006\u2002.BackColor = Color.White;
    this.\u0008\u2006\u2002.Location = new Point(310, 85);
    this.\u0008\u2006\u2002.Name = \u000F\u2000.\u0002(-380202671);
    this.\u0008\u2006\u2002.Size = new Size(2, 2);
    this.\u0008\u2006\u2002.TabIndex = 380;
    this.\u0006\u2006\u2002.BackColor = Color.White;
    this.\u0006\u2006\u2002.Location = new Point(301, 85);
    this.\u0006\u2006\u2002.Name = \u000F\u2000.\u0002(-380202654);
    this.\u0006\u2006\u2002.Size = new Size(2, 2);
    this.\u0006\u2006\u2002.TabIndex = 379;
    this.\u000E\u2006\u2002.BackColor = Color.White;
    this.\u000E\u2006\u2002.Location = new Point(292, 85);
    this.\u000E\u2006\u2002.Name = \u000F\u2000.\u0002(-380202637);
    this.\u000E\u2006\u2002.Size = new Size(2, 2);
    this.\u000E\u2006\u2002.TabIndex = 378;
    this.\u000F\u2006\u2002.BackColor = Color.White;
    this.\u000F\u2006\u2002.Location = new Point(283, 85);
    this.\u000F\u2006\u2002.Name = \u000F\u2000.\u0002(-380202628);
    this.\u000F\u2006\u2002.Size = new Size(2, 2);
    this.\u000F\u2006\u2002.TabIndex = 377;
    this.\u0002\u2007\u2002.BackColor = Color.White;
    this.\u0002\u2007\u2002.Location = new Point(326, 122);
    this.\u0002\u2007\u2002.Name = \u000F\u2000.\u0002(-380201331);
    this.\u0002\u2007\u2002.Size = new Size(2, 2);
    this.\u0002\u2007\u2002.TabIndex = 388;
    this.\u0003\u2007\u2002.BackColor = Color.White;
    this.\u0003\u2007\u2002.Location = new Point(318, 122);
    this.\u0003\u2007\u2002.Name = \u000F\u2000.\u0002(-380201314);
    this.\u0003\u2007\u2002.Size = new Size(2, 2);
    this.\u0003\u2007\u2002.TabIndex = 387;
    this.\u0005\u2007\u2002.BackColor = Color.White;
    this.\u0005\u2007\u2002.Location = new Point(310, 122);
    this.\u0005\u2007\u2002.Name = \u000F\u2000.\u0002(-380201297);
    this.\u0005\u2007\u2002.Size = new Size(2, 2);
    this.\u0005\u2007\u2002.TabIndex = 386;
    this.\u0008\u2007\u2002.BackColor = Color.White;
    this.\u0008\u2007\u2002.Location = new Point(301, 122);
    this.\u0008\u2007\u2002.Name = \u000F\u2000.\u0002(-380201288);
    this.\u0008\u2007\u2002.Size = new Size(2, 2);
    this.\u0008\u2007\u2002.TabIndex = 385;
    this.\u0006\u2007\u2002.BackColor = Color.White;
    this.\u0006\u2007\u2002.Location = new Point(292, 122);
    this.\u0006\u2007\u2002.Name = \u000F\u2000.\u0002(-380201271);
    this.\u0006\u2007\u2002.Size = new Size(2, 2);
    this.\u0006\u2007\u2002.TabIndex = 384;
    this.\u000E\u2007\u2002.BackColor = Color.White;
    this.\u000E\u2007\u2002.Location = new Point(283, 122);
    this.\u000E\u2007\u2002.Name = \u000F\u2000.\u0002(-380201254);
    this.\u000E\u2007\u2002.Size = new Size(2, 2);
    this.\u000E\u2007\u2002.TabIndex = 383;
    this.\u000F\u2007\u2002.BackColor = Color.White;
    this.\u000F\u2007\u2002.Location = new Point(247, 85);
    this.\u000F\u2007\u2002.Name = \u000F\u2000.\u0002(-380201237);
    this.\u000F\u2007\u2002.Size = new Size(2, 2);
    this.\u000F\u2007\u2002.TabIndex = 396;
    this.\u0002\u2008\u2002.BackColor = Color.White;
    this.\u0002\u2008\u2002.Location = new Point(238, 85);
    this.\u0002\u2008\u2002.Name = \u000F\u2000.\u0002(-380201228);
    this.\u0002\u2008\u2002.Size = new Size(2, 2);
    this.\u0002\u2008\u2002.TabIndex = 395;
    this.\u0003\u2008\u2002.BackColor = Color.White;
    this.\u0003\u2008\u2002.Location = new Point(229, 85);
    this.\u0003\u2008\u2002.Name = \u000F\u2000.\u0002(-380201467);
    this.\u0003\u2008\u2002.Size = new Size(2, 2);
    this.\u0003\u2008\u2002.TabIndex = 394;
    this.\u0005\u2008\u2002.BackColor = Color.White;
    this.\u0005\u2008\u2002.Location = new Point(220, 85);
    this.\u0005\u2008\u2002.Name = \u000F\u2000.\u0002(-380201450);
    this.\u0005\u2008\u2002.Size = new Size(2, 2);
    this.\u0005\u2008\u2002.TabIndex = 393;
    this.\u0008\u2008\u2002.BackColor = Color.White;
    this.\u0008\u2008\u2002.Location = new Point(211, 85);
    this.\u0008\u2008\u2002.Name = \u000F\u2000.\u0002(-380201433);
    this.\u0008\u2008\u2002.Size = new Size(2, 2);
    this.\u0008\u2008\u2002.TabIndex = 392;
    this.\u0006\u2008\u2002.BackColor = Color.White;
    this.\u0006\u2008\u2002.Location = new Point(202, 85);
    this.\u0006\u2008\u2002.Name = \u000F\u2000.\u0002(-380201424);
    this.\u0006\u2008\u2002.Size = new Size(2, 2);
    this.\u0006\u2008\u2002.TabIndex = 391;
    this.\u000E\u2008\u2002.BackColor = Color.White;
    this.\u000E\u2008\u2002.Location = new Point(265, 85);
    this.\u000E\u2008\u2002.Name = \u000F\u2000.\u0002(-380201407);
    this.\u000E\u2008\u2002.Size = new Size(2, 2);
    this.\u000E\u2008\u2002.TabIndex = 390;
    this.\u000F\u2008\u2002.BackColor = Color.White;
    this.\u000F\u2008\u2002.Location = new Point(256, 85);
    this.\u000F\u2008\u2002.Name = \u000F\u2000.\u0002(-380201390);
    this.\u000F\u2008\u2002.Size = new Size(2, 2);
    this.\u000F\u2008\u2002.TabIndex = 389;
    this.\u0002\u2009\u2002.BackColor = Color.White;
    this.\u0002\u2009\u2002.Location = new Point(202, 66);
    this.\u0002\u2009\u2002.Name = \u000F\u2000.\u0002(-380201373);
    this.\u0002\u2009\u2002.Size = new Size(2, 2);
    this.\u0002\u2009\u2002.TabIndex = 400;
    this.\u0003\u2009\u2002.BackColor = Color.White;
    this.\u0003\u2009\u2002.Location = new Point(202, 76);
    this.\u0003\u2009\u2002.Name = \u000F\u2000.\u0002(-380201364);
    this.\u0003\u2009\u2002.Size = new Size(2, 2);
    this.\u0003\u2009\u2002.TabIndex = 399;
    this.\u0005\u2009\u2002.BackColor = Color.White;
    this.\u0005\u2009\u2002.Location = new Point(202, 47);
    this.\u0005\u2009\u2002.Name = \u000F\u2000.\u0002(-380201347);
    this.\u0005\u2009\u2002.Size = new Size(2, 2);
    this.\u0005\u2009\u2002.TabIndex = 398;
    this.\u0008\u2009\u2002.BackColor = Color.White;
    this.\u0008\u2009\u2002.Location = new Point(202, 57);
    this.\u0008\u2009\u2002.Name = \u000F\u2000.\u0002(-380201074);
    this.\u0008\u2009\u2002.Size = new Size(2, 2);
    this.\u0008\u2009\u2002.TabIndex = 397;
    this.\u0006\u2009\u2002.BackColor = Color.White;
    this.\u0006\u2009\u2002.Location = new Point(129, 94);
    this.\u0006\u2009\u2002.Name = \u000F\u2000.\u0002(-380201057);
    this.\u0006\u2009\u2002.Size = new Size(2, 2);
    this.\u0006\u2009\u2002.TabIndex = 419;
    this.\u000E\u2009\u2002.BackColor = Color.White;
    this.\u000E\u2009\u2002.Location = new Point(129, 112);
    this.\u000E\u2009\u2002.Name = \u000F\u2000.\u0002(-380201048);
    this.\u000E\u2009\u2002.Size = new Size(2, 2);
    this.\u000E\u2009\u2002.TabIndex = 418;
    this.\u000F\u2009\u2002.BackColor = Color.White;
    this.\u000F\u2009\u2002.Location = new Point(129, 103);
    this.\u000F\u2009\u2002.Name = \u000F\u2000.\u0002(-380201031);
    this.\u000F\u2009\u2002.Size = new Size(2, 2);
    this.\u000F\u2009\u2002.TabIndex = 417;
    this.\u0002\u200A\u2002.BackColor = Color.White;
    this.\u0002\u200A\u2002.Location = new Point(238, 94);
    this.\u0002\u200A\u2002.Name = \u000F\u2000.\u0002(-380201014);
    this.\u0002\u200A\u2002.Size = new Size(2, 2);
    this.\u0002\u200A\u2002.TabIndex = 416;
    this.\u0003\u200A\u2002.BackColor = Color.White;
    this.\u0003\u200A\u2002.Location = new Point(238, 112);
    this.\u0003\u200A\u2002.Name = \u000F\u2000.\u0002(-380200997);
    this.\u0003\u200A\u2002.Size = new Size(2, 2);
    this.\u0003\u200A\u2002.TabIndex = 415;
    this.\u0005\u200A\u2002.BackColor = Color.White;
    this.\u0005\u200A\u2002.Location = new Point(238, 103);
    this.\u0005\u200A\u2002.Name = \u000F\u2000.\u0002(-380200988);
    this.\u0005\u200A\u2002.Size = new Size(2, 2);
    this.\u0005\u200A\u2002.TabIndex = 414;
    this.\u0008\u200A\u2002.BackColor = Color.White;
    this.\u0008\u200A\u2002.Location = new Point(202, 122);
    this.\u0008\u200A\u2002.Name = \u000F\u2000.\u0002(-380200971);
    this.\u0008\u200A\u2002.Size = new Size(2, 2);
    this.\u0008\u200A\u2002.TabIndex = 410;
    this.\u0006\u200A\u2002.BackColor = Color.White;
    this.\u0006\u200A\u2002.Location = new Point(238, 122);
    this.\u0006\u200A\u2002.Name = \u000F\u2000.\u0002(-380201210);
    this.\u0006\u200A\u2002.Size = new Size(2, 2);
    this.\u0006\u200A\u2002.TabIndex = 409;
    this.\u000E\u200A\u2002.BackColor = Color.White;
    this.\u000E\u200A\u2002.Location = new Point(229, 122);
    this.\u000E\u200A\u2002.Name = \u000F\u2000.\u0002(-380201193);
    this.\u000E\u200A\u2002.Size = new Size(2, 2);
    this.\u000E\u200A\u2002.TabIndex = 408;
    this.\u000F\u200A\u2002.BackColor = Color.White;
    this.\u000F\u200A\u2002.Location = new Point(220, 122);
    this.\u000F\u200A\u2002.Name = \u000F\u2000.\u0002(-380201184);
    this.\u000F\u200A\u2002.Size = new Size(2, 2);
    this.\u000F\u200A\u2002.TabIndex = 407;
    this.\u0002​\u2002.BackColor = Color.White;
    this.\u0002​\u2002.Location = new Point(211, 122);
    this.\u0002​\u2002.Name = \u000F\u2000.\u0002(-380201167);
    this.\u0002​\u2002.Size = new Size(2, 2);
    this.\u0002​\u2002.TabIndex = 406;
    this.\u0003​\u2002.BackColor = Color.White;
    this.\u0003​\u2002.Location = new Point(165, 122);
    this.\u0003​\u2002.Name = \u000F\u2000.\u0002(-380201150);
    this.\u0003​\u2002.Size = new Size(2, 2);
    this.\u0003​\u2002.TabIndex = 405;
    this.\u0005​\u2002.BackColor = Color.White;
    this.\u0005​\u2002.Location = new Point(156, 122);
    this.\u0005​\u2002.Name = \u000F\u2000.\u0002(-380201133);
    this.\u0005​\u2002.Size = new Size(2, 2);
    this.\u0005​\u2002.TabIndex = 404;
    this.\u0008​\u2002.BackColor = Color.White;
    this.\u0008​\u2002.Location = new Point(147, 122);
    this.\u0008​\u2002.Name = \u000F\u2000.\u0002(-380201124);
    this.\u0008​\u2002.Size = new Size(2, 2);
    this.\u0008​\u2002.TabIndex = 403;
    this.\u0006​\u2002.BackColor = Color.White;
    this.\u0006​\u2002.Location = new Point(138, 122);
    this.\u0006​\u2002.Name = \u000F\u2000.\u0002(-380201107);
    this.\u0006​\u2002.Size = new Size(2, 2);
    this.\u0006​\u2002.TabIndex = 402;
    this.\u000E​\u2002.BackColor = Color.White;
    this.\u000E​\u2002.Location = new Point(129, 122);
    this.\u000E​\u2002.Name = \u000F\u2000.\u0002(-380201090);
    this.\u000E​\u2002.Size = new Size(2, 2);
    this.\u000E​\u2002.TabIndex = 401;
    this.\u000F​\u2002.BackColor = Color.White;
    this.\u000F​\u2002.Location = new Point(192, 85);
    this.\u000F​\u2002.Name = \u000F\u2000.\u0002(-380201841);
    this.\u000F​\u2002.Size = new Size(2, 2);
    this.\u000F​\u2002.TabIndex = 432;
    this.\u0002\u2000\u2003.BackColor = Color.White;
    this.\u0002\u2000\u2003.Location = new Point(183, 85);
    this.\u0002\u2000\u2003.Name = \u000F\u2000.\u0002(-380201832);
    this.\u0002\u2000\u2003.Size = new Size(2, 2);
    this.\u0002\u2000\u2003.TabIndex = 431;
    this.\u0003\u2000\u2003.BackColor = Color.White;
    this.\u0003\u2000\u2003.Location = new Point(174, 85);
    this.\u0003\u2000\u2003.Name = \u000F\u2000.\u0002(-380201815);
    this.\u0003\u2000\u2003.Size = new Size(2, 2);
    this.\u0003\u2000\u2003.TabIndex = 430;
    this.\u0005\u2000\u2003.BackColor = Color.White;
    this.\u0005\u2000\u2003.Location = new Point(165, 85);
    this.\u0005\u2000\u2003.Name = \u000F\u2000.\u0002(-380201798);
    this.\u0005\u2000\u2003.Size = new Size(2, 2);
    this.\u0005\u2000\u2003.TabIndex = 424;
    this.\u0008\u2000\u2003.BackColor = Color.White;
    this.\u0008\u2000\u2003.Location = new Point(156, 85);
    this.\u0008\u2000\u2003.Name = \u000F\u2000.\u0002(-380201781);
    this.\u0008\u2000\u2003.Size = new Size(2, 2);
    this.\u0008\u2000\u2003.TabIndex = 423;
    this.\u0006\u2000\u2003.BackColor = Color.White;
    this.\u0006\u2000\u2003.Location = new Point(147, 85);
    this.\u0006\u2000\u2003.Name = \u000F\u2000.\u0002(-380201772);
    this.\u0006\u2000\u2003.Size = new Size(2, 2);
    this.\u0006\u2000\u2003.TabIndex = 422;
    this.\u000E\u2000\u2003.BackColor = Color.White;
    this.\u000E\u2000\u2003.Location = new Point(138, 85);
    this.\u000E\u2000\u2003.Name = \u000F\u2000.\u0002(-380201755);
    this.\u000E\u2000\u2003.Size = new Size(2, 2);
    this.\u000E\u2000\u2003.TabIndex = 421;
    this.\u000F\u2000\u2003.BackColor = Color.White;
    this.\u000F\u2000\u2003.Location = new Point(129, 85);
    this.\u000F\u2000\u2003.Name = \u000F\u2000.\u0002(-380201738);
    this.\u000F\u2000\u2003.Size = new Size(2, 2);
    this.\u000F\u2000\u2003.TabIndex = 420;
    this.\u0002\u2001\u2003.BackColor = Color.White;
    this.\u0002\u2001\u2003.Location = new Point(94, 66);
    this.\u0002\u2001\u2003.Name = \u000F\u2000.\u0002(-380201977);
    this.\u0002\u2001\u2003.Size = new Size(2, 2);
    this.\u0002\u2001\u2003.TabIndex = 449;
    this.\u0003\u2001\u2003.BackColor = Color.White;
    this.\u0003\u2001\u2003.Location = new Point(94, 76);
    this.\u0003\u2001\u2003.Name = \u000F\u2000.\u0002(-380201968);
    this.\u0003\u2001\u2003.Size = new Size(2, 2);
    this.\u0003\u2001\u2003.TabIndex = 448;
    this.\u0005\u2001\u2003.BackColor = Color.White;
    this.\u0005\u2001\u2003.Location = new Point(94, 47);
    this.\u0005\u2001\u2003.Name = \u000F\u2000.\u0002(-380201951);
    this.\u0005\u2001\u2003.Size = new Size(2, 2);
    this.\u0005\u2001\u2003.TabIndex = 447;
    this.\u0008\u2001\u2003.BackColor = Color.White;
    this.\u0008\u2001\u2003.Location = new Point(94, 57);
    this.\u0008\u2001\u2003.Name = \u000F\u2000.\u0002(-380201934);
    this.\u0008\u2001\u2003.Size = new Size(2, 2);
    this.\u0008\u2001\u2003.TabIndex = 446;
    this.\u0006\u2001\u2003.BackColor = Color.White;
    this.\u0006\u2001\u2003.Location = new Point(138, 38);
    this.\u0006\u2001\u2003.Name = \u000F\u2000.\u0002(-380201917);
    this.\u0006\u2001\u2003.Size = new Size(2, 2);
    this.\u0006\u2001\u2003.TabIndex = 445;
    this.\u000E\u2001\u2003.BackColor = Color.White;
    this.\u000E\u2001\u2003.Location = new Point(129, 38);
    this.\u000E\u2001\u2003.Name = \u000F\u2000.\u0002(-380201908);
    this.\u000E\u2001\u2003.Size = new Size(2, 2);
    this.\u000E\u2001\u2003.TabIndex = 444;
    this.\u000F\u2001\u2003.BackColor = Color.White;
    this.\u000F\u2001\u2003.Location = new Point(120, 38);
    this.\u000F\u2001\u2003.Name = \u000F\u2000.\u0002(-380201891);
    this.\u000F\u2001\u2003.Size = new Size(2, 2);
    this.\u000F\u2001\u2003.TabIndex = 443;
    this.\u0002\u2002\u2003.BackColor = Color.White;
    this.\u0002\u2002\u2003.Location = new Point(111, 38);
    this.\u0002\u2002\u2003.Name = \u000F\u2000.\u0002(-380201874);
    this.\u0002\u2002\u2003.Size = new Size(2, 2);
    this.\u0002\u2002\u2003.TabIndex = 442;
    this.\u0003\u2002\u2003.BackColor = Color.White;
    this.\u0003\u2002\u2003.Location = new Point(102, 38);
    this.\u0003\u2002\u2003.Name = \u000F\u2000.\u0002(-380201857);
    this.\u0003\u2002\u2003.Size = new Size(2, 2);
    this.\u0003\u2002\u2003.TabIndex = 441;
    this.\u0005\u2002\u2003.BackColor = Color.White;
    this.\u0005\u2002\u2003.Location = new Point(94, 38);
    this.\u0005\u2002\u2003.Name = \u000F\u2000.\u0002(-380201592);
    this.\u0005\u2002\u2003.Size = new Size(2, 2);
    this.\u0005\u2002\u2003.TabIndex = 440;
    this.\u0008\u2002\u2003.BackColor = Color.White;
    this.\u0008\u2002\u2003.Location = new Point(165, 38);
    this.\u0008\u2002\u2003.Name = \u000F\u2000.\u0002(-380201575);
    this.\u0008\u2002\u2003.Size = new Size(2, 2);
    this.\u0008\u2002\u2003.TabIndex = 439;
    this.\u0006\u2002\u2003.BackColor = Color.White;
    this.\u0006\u2002\u2003.Location = new Point(156, 38);
    this.\u0006\u2002\u2003.Name = \u000F\u2000.\u0002(-380201558);
    this.\u0006\u2002\u2003.Size = new Size(2, 2);
    this.\u0006\u2002\u2003.TabIndex = 438;
    this.\u000E\u2002\u2003.BackColor = Color.White;
    this.\u000E\u2002\u2003.Location = new Point(147, 38);
    this.\u000E\u2002\u2003.Name = \u000F\u2000.\u0002(-380201541);
    this.\u000E\u2002\u2003.Size = new Size(2, 2);
    this.\u000E\u2002\u2003.TabIndex = 437;
    this.\u000F\u2002\u2003.BackColor = Color.White;
    this.\u000F\u2002\u2003.Location = new Point(165, 66);
    this.\u000F\u2002\u2003.Name = \u000F\u2000.\u0002(-380201532);
    this.\u000F\u2002\u2003.Size = new Size(2, 2);
    this.\u000F\u2002\u2003.TabIndex = 436;
    this.\u0002\u2003\u2003.BackColor = Color.White;
    this.\u0002\u2003\u2003.Location = new Point(165, 76);
    this.\u0002\u2003\u2003.Name = \u000F\u2000.\u0002(-380201515);
    this.\u0002\u2003\u2003.Size = new Size(2, 2);
    this.\u0002\u2003\u2003.TabIndex = 435;
    this.\u0003\u2003\u2003.BackColor = Color.White;
    this.\u0003\u2003\u2003.Location = new Point(165, 47);
    this.\u0003\u2003\u2003.Name = \u000F\u2000.\u0002(-380201498);
    this.\u0003\u2003\u2003.Size = new Size(2, 2);
    this.\u0003\u2003\u2003.TabIndex = 434;
    this.\u0005\u2003\u2003.BackColor = Color.White;
    this.\u0005\u2003\u2003.Location = new Point(165, 57);
    this.\u0005\u2003\u2003.Name = \u000F\u2000.\u0002(-380201481);
    this.\u0005\u2003\u2003.Size = new Size(2, 2);
    this.\u0005\u2003\u2003.TabIndex = 433;
    this.\u0008\u2003\u2003.BackColor = Color.White;
    this.\u0008\u2003\u2003.Location = new Point(49, 85);
    this.\u0008\u2003\u2003.Name = \u000F\u2000.\u0002(-380201728);
    this.\u0008\u2003\u2003.Size = new Size(2, 2);
    this.\u0008\u2003\u2003.TabIndex = 459;
    this.\u0006\u2003\u2003.BackColor = Color.White;
    this.\u0006\u2003\u2003.Location = new Point(40, 85);
    this.\u0006\u2003\u2003.Name = \u000F\u2000.\u0002(-380201711);
    this.\u0006\u2003\u2003.Size = new Size(2, 2);
    this.\u0006\u2003\u2003.TabIndex = 458;
    this.\u000E\u2003\u2003.BackColor = Color.White;
    this.\u000E\u2003\u2003.Location = new Point(111, 85);
    this.\u000E\u2003\u2003.Name = \u000F\u2000.\u0002(-380201694);
    this.\u000E\u2003\u2003.Size = new Size(2, 2);
    this.\u000E\u2003\u2003.TabIndex = 457;
    this.\u000F\u2003\u2003.BackColor = Color.White;
    this.\u000F\u2003\u2003.Location = new Point(103, 85);
    this.\u000F\u2003\u2003.Name = \u000F\u2000.\u0002(-380201677);
    this.\u000F\u2003\u2003.Size = new Size(2, 2);
    this.\u000F\u2003\u2003.TabIndex = 456;
    this.\u0002\u2004\u2003.BackColor = Color.White;
    this.\u0002\u2004\u2003.Location = new Point(94, 85);
    this.\u0002\u2004\u2003.Name = \u000F\u2000.\u0002(-380201668);
    this.\u0002\u2004\u2003.Size = new Size(2, 2);
    this.\u0002\u2004\u2003.TabIndex = 455;
    this.\u0003\u2004\u2003.BackColor = Color.White;
    this.\u0003\u2004\u2003.Location = new Point(85, 85);
    this.\u0003\u2004\u2003.Name = \u000F\u2000.\u0002(-380201651);
    this.\u0003\u2004\u2003.Size = new Size(2, 2);
    this.\u0003\u2004\u2003.TabIndex = 454;
    this.\u0005\u2004\u2003.BackColor = Color.White;
    this.\u0005\u2004\u2003.Location = new Point(76, 85);
    this.\u0005\u2004\u2003.Name = \u000F\u2000.\u0002(-380201634);
    this.\u0005\u2004\u2003.Size = new Size(2, 2);
    this.\u0005\u2004\u2003.TabIndex = 453;
    this.\u0008\u2004\u2003.BackColor = Color.White;
    this.\u0008\u2004\u2003.Location = new Point(67, 85);
    this.\u0008\u2004\u2003.Name = \u000F\u2000.\u0002(-380201617);
    this.\u0008\u2004\u2003.Size = new Size(2, 2);
    this.\u0008\u2004\u2003.TabIndex = 452;
    this.\u0006\u2004\u2003.BackColor = Color.White;
    this.\u0006\u2004\u2003.Location = new Point(120, 85);
    this.\u0006\u2004\u2003.Name = \u000F\u2000.\u0002(-380201608);
    this.\u0006\u2004\u2003.Size = new Size(2, 2);
    this.\u0006\u2004\u2003.TabIndex = 451;
    this.\u000E\u2004\u2003.BackColor = Color.White;
    this.\u000E\u2004\u2003.Location = new Point(58, 85);
    this.\u000E\u2004\u2003.Name = \u000F\u2000.\u0002(-380200311);
    this.\u000E\u2004\u2003.Size = new Size(2, 2);
    this.\u000E\u2004\u2003.TabIndex = 450;
    this.\u000F\u2004\u2003.BackColor = Color.White;
    this.\u000F\u2004\u2003.Location = new Point(32, 94);
    this.\u000F\u2004\u2003.Name = \u000F\u2000.\u0002(-380200294);
    this.\u000F\u2004\u2003.Size = new Size(2, 2);
    this.\u000F\u2004\u2003.TabIndex = 469;
    this.\u0002\u2005\u2003.BackColor = Color.White;
    this.\u0002\u2005\u2003.Location = new Point(32, 113);
    this.\u0002\u2005\u2003.Name = \u000F\u2000.\u0002(-380200277);
    this.\u0002\u2005\u2003.Size = new Size(2, 2);
    this.\u0002\u2005\u2003.TabIndex = 468;
    this.\u0003\u2005\u2003.BackColor = Color.White;
    this.\u0003\u2005\u2003.Location = new Point(32, 104);
    this.\u0003\u2005\u2003.Name = \u000F\u2000.\u0002(-380200268);
    this.\u0003\u2005\u2003.Size = new Size(2, 2);
    this.\u0003\u2005\u2003.TabIndex = 467;
    this.\u0005\u2005\u2003.BackColor = Color.White;
    this.\u0005\u2005\u2003.Location = new Point(32, 122);
    this.\u0005\u2005\u2003.Name = \u000F\u2000.\u0002(-380200251);
    this.\u0005\u2005\u2003.Size = new Size(2, 2);
    this.\u0005\u2005\u2003.TabIndex = 466;
    this.\u0008\u2005\u2003.BackColor = Color.White;
    this.\u0008\u2005\u2003.Location = new Point(32, 76);
    this.\u0008\u2005\u2003.Name = \u000F\u2000.\u0002(-380200234);
    this.\u0008\u2005\u2003.Size = new Size(2, 2);
    this.\u0008\u2005\u2003.TabIndex = 465;
    this.\u0006\u2005\u2003.BackColor = Color.White;
    this.\u0006\u2005\u2003.Location = new Point(32, 67);
    this.\u0006\u2005\u2003.Name = \u000F\u2000.\u0002(-380200217);
    this.\u0006\u2005\u2003.Size = new Size(2, 2);
    this.\u0006\u2005\u2003.TabIndex = 464;
    this.\u000E\u2005\u2003.BackColor = Color.Black;
    this.\u000E\u2005\u2003.Image = (Image) componentResourceManager.GetObject(\u000F\u2000.\u0002(-380200208));
    this.\u000E\u2005\u2003.Location = new Point(28, 54);
    this.\u000E\u2005\u2003.Name = \u000F\u2000.\u0002(-380200437);
    this.\u000E\u2005\u2003.Size = new Size(10, 10);
    this.\u000E\u2005\u2003.TabIndex = 463;
    this.\u000F\u2005\u2003.BackColor = Color.White;
    this.\u000F\u2005\u2003.Location = new Point(32, 85);
    this.\u000F\u2005\u2003.Name = \u000F\u2000.\u0002(-380200428);
    this.\u000F\u2005\u2003.Size = new Size(2, 2);
    this.\u000F\u2005\u2003.TabIndex = 462;
    this.\u0002\u2006\u2003.BackColor = Color.White;
    this.\u0002\u2006\u2003.Location = new Point(32, 48);
    this.\u0002\u2006\u2003.Name = \u000F\u2000.\u0002(-380200411);
    this.\u0002\u2006\u2003.Size = new Size(2, 2);
    this.\u0002\u2006\u2003.TabIndex = 461;
    this.\u0003\u2006\u2003.BackColor = Color.White;
    this.\u0003\u2006\u2003.Location = new Point(32, 38);
    this.\u0003\u2006\u2003.Name = \u000F\u2000.\u0002(-380200394);
    this.\u0003\u2006\u2003.Size = new Size(2, 2);
    this.\u0003\u2006\u2003.TabIndex = 460;
    this.\u0005\u2006\u2003.BackColor = Color.White;
    this.\u0005\u2006\u2003.Location = new Point(85, 38);
    this.\u0005\u2006\u2003.Name = \u000F\u2000.\u0002(-380200377);
    this.\u0005\u2006\u2003.Size = new Size(2, 2);
    this.\u0005\u2006\u2003.TabIndex = 475;
    this.\u0008\u2006\u2003.BackColor = Color.White;
    this.\u0008\u2006\u2003.Location = new Point(77, 38);
    this.\u0008\u2006\u2003.Name = \u000F\u2000.\u0002(-380200368);
    this.\u0008\u2006\u2003.Size = new Size(2, 2);
    this.\u0008\u2006\u2003.TabIndex = 474;
    this.\u0006\u2006\u2003.BackColor = Color.White;
    this.\u0006\u2006\u2003.Location = new Point(68, 38);
    this.\u0006\u2006\u2003.Name = \u000F\u2000.\u0002(-380200351);
    this.\u0006\u2006\u2003.Size = new Size(2, 2);
    this.\u0006\u2006\u2003.TabIndex = 473;
    this.\u000E\u2006\u2003.BackColor = Color.White;
    this.\u000E\u2006\u2003.Location = new Point(59, 38);
    this.\u000E\u2006\u2003.Name = \u000F\u2000.\u0002(-380200334);
    this.\u000E\u2006\u2003.Size = new Size(2, 2);
    this.\u000E\u2006\u2003.TabIndex = 472;
    this.\u000F\u2006\u2003.BackColor = Color.White;
    this.\u000F\u2006\u2003.Location = new Point(50, 38);
    this.\u000F\u2006\u2003.Name = \u000F\u2000.\u0002(-380200061);
    this.\u000F\u2006\u2003.Size = new Size(2, 2);
    this.\u000F\u2006\u2003.TabIndex = 471;
    this.\u0002\u2007\u2003.BackColor = Color.White;
    this.\u0002\u2007\u2003.Location = new Point(41, 38);
    this.\u0002\u2007\u2003.Name = \u000F\u2000.\u0002(-380200052);
    this.\u0002\u2007\u2003.Size = new Size(2, 2);
    this.\u0002\u2007\u2003.TabIndex = 470;
    this.\u0003\u2007\u2003.BackColor = Color.White;
    this.\u0003\u2007\u2003.Location = new Point(85, 122);
    this.\u0003\u2007\u2003.Name = \u000F\u2000.\u0002(-380200035);
    this.\u0003\u2007\u2003.Size = new Size(2, 2);
    this.\u0003\u2007\u2003.TabIndex = 482;
    this.\u0005\u2007\u2003.BackColor = Color.White;
    this.\u0005\u2007\u2003.Location = new Point(76, 122);
    this.\u0005\u2007\u2003.Name = \u000F\u2000.\u0002(-380200018);
    this.\u0005\u2007\u2003.Size = new Size(2, 2);
    this.\u0005\u2007\u2003.TabIndex = 481;
    this.\u0008\u2007\u2003.BackColor = Color.White;
    this.\u0008\u2007\u2003.Location = new Point(67, 122);
    this.\u0008\u2007\u2003.Name = \u000F\u2000.\u0002(-380200001);
    this.\u0008\u2007\u2003.Size = new Size(2, 2);
    this.\u0008\u2007\u2003.TabIndex = 480;
    this.\u0006\u2007\u2003.BackColor = Color.White;
    this.\u0006\u2007\u2003.Location = new Point(58, 122);
    this.\u0006\u2007\u2003.Name = \u000F\u2000.\u0002(-380199992);
    this.\u0006\u2007\u2003.Size = new Size(2, 2);
    this.\u0006\u2007\u2003.TabIndex = 479;
    this.\u000E\u2007\u2003.BackColor = Color.White;
    this.\u000E\u2007\u2003.Location = new Point(49, 122);
    this.\u000E\u2007\u2003.Name = \u000F\u2000.\u0002(-380199975);
    this.\u000E\u2007\u2003.Size = new Size(2, 2);
    this.\u000E\u2007\u2003.TabIndex = 478;
    this.\u000F\u2007\u2003.BackColor = Color.White;
    this.\u000F\u2007\u2003.Location = new Point(40, 122);
    this.\u000F\u2007\u2003.Name = \u000F\u2000.\u0002(-380199958);
    this.\u000F\u2007\u2003.Size = new Size(2, 2);
    this.\u000F\u2007\u2003.TabIndex = 477;
    this.\u0002\u2008\u2003.BackColor = Color.White;
    this.\u0002\u2008\u2003.Location = new Point(94, 122);
    this.\u0002\u2008\u2003.Name = \u000F\u2000.\u0002(-380199941);
    this.\u0002\u2008\u2003.Size = new Size(2, 2);
    this.\u0002\u2008\u2003.TabIndex = 476;
    this.\u0003\u2008\u2003.BackColor = Color.White;
    this.\u0003\u2008\u2003.Location = new Point(94, 103);
    this.\u0003\u2008\u2003.Name = \u000F\u2000.\u0002(-380200188);
    this.\u0003\u2008\u2003.Size = new Size(2, 2);
    this.\u0003\u2008\u2003.TabIndex = 486;
    this.\u0005\u2008\u2003.BackColor = Color.White;
    this.\u0005\u2008\u2003.Location = new Point(94, 113);
    this.\u0005\u2008\u2003.Name = \u000F\u2000.\u0002(-380200171);
    this.\u0005\u2008\u2003.Size = new Size(2, 2);
    this.\u0005\u2008\u2003.TabIndex = 485;
    this.\u0008\u2008\u2003.BackColor = Color.White;
    this.\u0008\u2008\u2003.Location = new Point(94, 94);
    this.\u0008\u2008\u2003.Name = \u000F\u2000.\u0002(-380200154);
    this.\u0008\u2008\u2003.Size = new Size(2, 2);
    this.\u0008\u2008\u2003.TabIndex = 483;
    this.\u0006\u2008\u2003.BackColor = Color.White;
    this.\u0006\u2008\u2003.Location = new Point(94, 149);
    this.\u0006\u2008\u2003.Name = \u000F\u2000.\u0002(-380200137);
    this.\u0006\u2008\u2003.Size = new Size(2, 2);
    this.\u0006\u2008\u2003.TabIndex = 501;
    this.\u000E\u2008\u2003.BackColor = Color.White;
    this.\u000E\u2008\u2003.Location = new Point(94, 167);
    this.\u000E\u2008\u2003.Name = \u000F\u2000.\u0002(-380200128);
    this.\u000E\u2008\u2003.Size = new Size(2, 2);
    this.\u000E\u2008\u2003.TabIndex = 500;
    this.\u000F\u2008\u2003.BackColor = Color.White;
    this.\u000F\u2008\u2003.Location = new Point(94, 158);
    this.\u000F\u2008\u2003.Name = \u000F\u2000.\u0002(-380200111);
    this.\u000F\u2008\u2003.Size = new Size(2, 2);
    this.\u000F\u2008\u2003.TabIndex = 499;
    this.\u0002\u2009\u2003.BackColor = Color.White;
    this.\u0002\u2009\u2003.Location = new Point(94, 176);
    this.\u0002\u2009\u2003.Name = \u000F\u2000.\u0002(-380200094);
    this.\u0002\u2009\u2003.Size = new Size(2, 2);
    this.\u0002\u2009\u2003.TabIndex = 498;
    this.\u0003\u2009\u2003.BackColor = Color.White;
    this.\u0003\u2009\u2003.Location = new Point(94, 131);
    this.\u0003\u2009\u2003.Name = \u000F\u2000.\u0002(-380200077);
    this.\u0003\u2009\u2003.Size = new Size(2, 2);
    this.\u0003\u2009\u2003.TabIndex = 497;
    this.\u0005\u2009\u2003.BackColor = Color.White;
    this.\u0005\u2009\u2003.Location = new Point(94, 140);
    this.\u0005\u2009\u2003.Name = \u000F\u2000.\u0002(-380200068);
    this.\u0005\u2009\u2003.Size = new Size(2, 2);
    this.\u0005\u2009\u2003.TabIndex = 496;
    this.\u0008\u2009\u2003.BackColor = Color.White;
    this.\u0008\u2009\u2003.Location = new Point(94, 230);
    this.\u0008\u2009\u2003.Name = \u000F\u2000.\u0002(-380200819);
    this.\u0008\u2009\u2003.Size = new Size(2, 2);
    this.\u0008\u2009\u2003.TabIndex = 495;
    this.\u0006\u2009\u2003.BackColor = Color.White;
    this.\u0006\u2009\u2003.Location = new Point(94, 248);
    this.\u0006\u2009\u2003.Name = \u000F\u2000.\u0002(-380200802);
    this.\u0006\u2009\u2003.Size = new Size(2, 2);
    this.\u0006\u2009\u2003.TabIndex = 494;
    this.\u000E\u2009\u2003.BackColor = Color.White;
    this.\u000E\u2009\u2003.Location = new Point(94, 239);
    this.\u000E\u2009\u2003.Name = \u000F\u2000.\u0002(-380200785);
    this.\u000E\u2009\u2003.Size = new Size(2, 2);
    this.\u000E\u2009\u2003.TabIndex = 493;
    this.\u000F\u2009\u2003.BackColor = Color.White;
    this.\u000F\u2009\u2003.Location = new Point(94, 257);
    this.\u000F\u2009\u2003.Name = \u000F\u2000.\u0002(-380200776);
    this.\u000F\u2009\u2003.Size = new Size(2, 2);
    this.\u000F\u2009\u2003.TabIndex = 492;
    this.\u0002\u200A\u2003.BackColor = Color.White;
    this.\u0002\u200A\u2003.Location = new Point(94, 212);
    this.\u0002\u200A\u2003.Name = \u000F\u2000.\u0002(-380200759);
    this.\u0002\u200A\u2003.Size = new Size(2, 2);
    this.\u0002\u200A\u2003.TabIndex = 491;
    this.\u0003\u200A\u2003.BackColor = Color.White;
    this.\u0003\u200A\u2003.Location = new Point(94, 203);
    this.\u0003\u200A\u2003.Name = \u000F\u2000.\u0002(-380200742);
    this.\u0003\u200A\u2003.Size = new Size(2, 2);
    this.\u0003\u200A\u2003.TabIndex = 490;
    this.\u0005\u200A\u2003.BackColor = Color.White;
    this.\u0005\u200A\u2003.Location = new Point(94, 194);
    this.\u0005\u200A\u2003.Name = \u000F\u2000.\u0002(-380200725);
    this.\u0005\u200A\u2003.Size = new Size(2, 2);
    this.\u0005\u200A\u2003.TabIndex = 489;
    this.\u0008\u200A\u2003.BackColor = Color.White;
    this.\u0008\u200A\u2003.Location = new Point(94, 221);
    this.\u0008\u200A\u2003.Name = \u000F\u2000.\u0002(-380200716);
    this.\u0008\u200A\u2003.Size = new Size(2, 2);
    this.\u0008\u200A\u2003.TabIndex = 488;
    this.\u0006\u200A\u2003.BackColor = Color.White;
    this.\u0006\u200A\u2003.Location = new Point(94, 185);
    this.\u0006\u200A\u2003.Name = \u000F\u2000.\u0002(-380200955);
    this.\u0006\u200A\u2003.Size = new Size(2, 2);
    this.\u0006\u200A\u2003.TabIndex = 487;
    this.\u000E\u200A\u2003.Interval = 700;
    this.\u000E\u200A\u2003.Tick += new EventHandler(this.\u0008\u2001);
    this.\u000F\u200A\u2003.Controls.Add((Control) this.\u000F\u2000\u2004);
    this.\u000F\u200A\u2003.Controls.Add((Control) this.\u0002\u2001\u2004);
    this.\u000F\u200A\u2003.Controls.Add((Control) this.\u0003\u2001\u2004);
    this.\u000F\u200A\u2003.Controls.Add((Control) this.\u0005\u2001\u2004);
    this.\u000F\u200A\u2003.Controls.Add((Control) this.\u000E\u2000\u2004);
    this.\u000F\u200A\u2003.Controls.Add((Control) this.\u0006\u2000\u2004);
    this.\u000F\u200A\u2003.Controls.Add((Control) this.\u0003​\u2003);
    this.\u000F\u200A\u2003.Controls.Add((Control) this.\u0002​\u2003);
    this.\u000F\u200A\u2003.Dock = DockStyle.Fill;
    this.\u000F\u200A\u2003.Location = new Point(0, 0);
    this.\u000F\u200A\u2003.Name = \u000F\u2000.\u0002(-380200938);
    this.\u000F\u200A\u2003.Size = new Size(370, 430);
    this.\u000F\u200A\u2003.TabIndex = 502;
    this.\u000F\u200A\u2003.Paint += new PaintEventHandler(this.\u0002);
    this.\u000E\u2000\u2004.Image = (Image) \u000E\u2000.\u0005\u2000();
    this.\u000E\u2000\u2004.Location = new Point(12, 226);
    this.\u000E\u2000\u2004.Name = \u000F\u2000.\u0002(-380200927);
    this.\u000E\u2000\u2004.Size = new Size(348, 171);
    this.\u000E\u2000\u2004.SizeMode = PictureBoxSizeMode.StretchImage;
    this.\u000E\u2000\u2004.TabIndex = 7;
    this.\u000E\u2000\u2004.TabStop = false;
    this.\u000E\u2000\u2004.Click += new EventHandler(this.\u0003);
    this.\u0006\u2000\u2004.Image = (Image) \u000E\u2000.\u0006\u2000();
    this.\u0006\u2000\u2004.Location = new Point(163, 158);
    this.\u0006\u2000\u2004.Name = \u000F\u2000.\u0002(-380200905);
    this.\u0006\u2000\u2004.Size = new Size(50, 50);
    this.\u0006\u2000\u2004.SizeMode = PictureBoxSizeMode.StretchImage;
    this.\u0006\u2000\u2004.TabIndex = 2;
    this.\u0006\u2000\u2004.TabStop = false;
    this.\u0006\u2000\u2004.Click += new EventHandler(this.\u000E);
    this.\u0003​\u2003.Image = (Image) \u000E\u2000.\u0006\u2003();
    this.\u0003​\u2003.Location = new Point(12, 18);
    this.\u0003​\u2003.Name = \u000F\u2000.\u0002(-380200891);
    this.\u0003​\u2003.Size = new Size(348, 101);
    this.\u0003​\u2003.SizeMode = PictureBoxSizeMode.StretchImage;
    this.\u0003​\u2003.TabIndex = 1;
    this.\u0003​\u2003.TabStop = false;
    this.\u0003​\u2003.Visible = false;
    this.\u0002​\u2003.Cursor = Cursors.Hand;
    this.\u0002​\u2003.FlatAppearance.BorderColor = Color.Black;
    this.\u0002​\u2003.FlatAppearance.BorderSize = 0;
    this.\u0002​\u2003.FlatAppearance.MouseDownBackColor = Color.Black;
    this.\u0002​\u2003.FlatAppearance.MouseOverBackColor = Color.Black;
    this.\u0002​\u2003.FlatStyle = FlatStyle.Flat;
    this.\u0002​\u2003.Image = (Image) \u000E\u2000.\u0005\u2004();
    this.\u0002​\u2003.Location = new Point(123, 124);
    this.\u0002​\u2003.Name = \u000F\u2000.\u0002(-380200869);
    this.\u0002​\u2003.Size = new Size(136, 36);
    this.\u0002​\u2003.TabIndex = 0;
    this.\u0002​\u2003.UseVisualStyleBackColor = true;
    this.\u0002​\u2003.Visible = false;
    this.\u0002​\u2003.Click += new EventHandler(this.\u0002\u2000);
    this.\u0002​\u2003.MouseEnter += new EventHandler(this.\u0005\u2000);
    this.\u0002​\u2003.MouseLeave += new EventHandler(this.\u0003\u2000);
    this.\u0005​\u2003.BackgroundImageLayout = ImageLayout.None;
    this.\u0005​\u2003.Cursor = Cursors.Default;
    this.\u0005​\u2003.Image = (Image) \u000E\u2000.\u0008\u2003();
    this.\u0005​\u2003.Location = new Point(24, 364);
    this.\u0005​\u2003.Name = \u000F\u2000.\u0002(-380200859);
    this.\u0005​\u2003.Size = new Size(22, 22);
    this.\u0005​\u2003.TabIndex = 503;
    this.\u0005​\u2003.TabStop = false;
    this.\u0008​\u2003.Interval = 10000;
    this.\u0008​\u2003.Tick += new EventHandler(this.\u0005\u2001);
    this.\u0006​\u2003.Interval = 2500;
    this.\u0006​\u2003.Tick += new EventHandler(this.\u000E\u2001);
    this.\u000E​\u2003.Enabled = true;
    this.\u000E​\u2003.Interval = 200;
    this.\u000E​\u2003.Tick += new EventHandler(this.\u0006\u2001);
    this.\u000F​\u2003.Interval = 500;
    this.\u000F​\u2003.Tick += new EventHandler(this.\u0003\u2002);
    this.\u0002\u2000\u2004.BackColor = Color.Black;
    this.\u0002\u2000\u2004.Font = new Font(\u000F\u2000.\u0002(-380206080), 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.\u0002\u2000\u2004.ForeColor = Color.White;
    this.\u0002\u2000\u2004.Image = (Image) \u000E\u2000.\u000E\u2000();
    this.\u0002\u2000\u2004.Location = new Point(123, 222);
    this.\u0002\u2000\u2004.Name = \u000F\u2000.\u0002(-380200848);
    this.\u0002\u2000\u2004.Size = new Size(125, 19);
    this.\u0002\u2000\u2004.TabIndex = 504;
    this.\u0002\u2000\u2004.Text = \u000F\u2000.\u0002(-380206020);
    this.\u0002\u2000\u2004.TextAlign = ContentAlignment.MiddleRight;
    this.\u0002\u2000\u2004.Visible = false;
    this.\u0003\u2000\u2004.BackColor = Color.Black;
    this.\u0003\u2000\u2004.Font = new Font(\u000F\u2000.\u0002(-380206080), 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.\u0003\u2000\u2004.ForeColor = Color.White;
    this.\u0003\u2000\u2004.Image = (Image) \u000E\u2000.\u0002\u2001();
    this.\u0003\u2000\u2004.Location = new Point(125, 222);
    this.\u0003\u2000\u2004.Name = \u000F\u2000.\u0002(-380200575);
    this.\u0003\u2000\u2004.Size = new Size(125, 19);
    this.\u0003\u2000\u2004.TabIndex = 505;
    this.\u0003\u2000\u2004.Text = \u000F\u2000.\u0002(-380206020);
    this.\u0003\u2000\u2004.TextAlign = ContentAlignment.MiddleRight;
    this.\u0003\u2000\u2004.Visible = false;
    this.\u0005\u2000\u2004.Interval = 7000;
    this.\u0005\u2000\u2004.Tick += new EventHandler(this.\u0002\u2002);
    this.\u0008\u2000\u2004.Interval = 400;
    this.\u0008\u2000\u2004.Tick += new EventHandler(this.\u000F\u2001);
    this.\u000F\u2000\u2004.AutoSize = true;
    this.\u000F\u2000\u2004.Font = new Font(\u000F\u2000.\u0002(-380200558), 12.25f, FontStyle.Bold);
    this.\u000F\u2000\u2004.ForeColor = Color.White;
    this.\u000F\u2000\u2004.Location = new Point(128, 354);
    this.\u000F\u2000\u2004.Name = \u000F\u2000.\u0002(-380200543);
    this.\u000F\u2000\u2004.Size = new Size(122, 20);
    this.\u000F\u2000\u2004.TabIndex = 11;
    this.\u000F\u2000\u2004.Text = \u000F\u2000.\u0002(-380200526);
    this.\u000F\u2000\u2004.Click += new EventHandler(this.\u0002);
    this.\u0002\u2001\u2004.AutoSize = true;
    this.\u0002\u2001\u2004.Font = new Font(\u000F\u2000.\u0002(-380200558), 13.25f, FontStyle.Bold);
    this.\u0002\u2001\u2004.ForeColor = Color.White;
    this.\u0002\u2001\u2004.Location = new Point(97, 331);
    this.\u0002\u2001\u2004.Name = \u000F\u2000.\u0002(-380200506);
    this.\u0002\u2001\u2004.Size = new Size(197, 21);
    this.\u0002\u2001\u2004.TabIndex = 10;
    this.\u0002\u2001\u2004.Text = \u000F\u2000.\u0002(-380200489);
    this.\u0003\u2001\u2004.AutoSize = true;
    this.\u0003\u2001\u2004.Font = new Font(\u000F\u2000.\u0002(-380200558), 12.25f, FontStyle.Bold);
    this.\u0003\u2001\u2004.ForeColor = Color.White;
    this.\u0003\u2001\u2004.Location = new Point(126, 277);
    this.\u0003\u2001\u2004.Name = \u000F\u2000.\u0002(-380200467);
    this.\u0003\u2001\u2004.Size = new Size(122, 20);
    this.\u0003\u2001\u2004.TabIndex = 9;
    this.\u0003\u2001\u2004.Text = \u000F\u2000.\u0002(-380200450);
    this.\u0005\u2001\u2004.AutoSize = true;
    this.\u0005\u2001\u2004.BackColor = Color.Transparent;
    this.\u0005\u2001\u2004.Font = new Font(\u000F\u2000.\u0002(-380200558), 12.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.\u0005\u2001\u2004.ForeColor = SystemColors.Window;
    this.\u0005\u2001\u2004.Location = new Point(53, (int) byte.MaxValue);
    this.\u0005\u2001\u2004.Name = \u000F\u2000.\u0002(-380200686);
    this.\u0005\u2001\u2004.Size = new Size(266, 20);
    this.\u0005\u2001\u2004.TabIndex = 8;
    this.\u0005\u2001\u2004.Text = \u000F\u2000.\u0002(-380200669);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.Black;
    this.BackgroundImage = (Image) \u000E\u2000.\u0003\u2004();
    this.BackgroundImageLayout = ImageLayout.None;
    this.ClientSize = new Size(370, 430);
    this.Controls.Add((Control) this.\u000F\u200A\u2003);
    this.Controls.Add((Control) this.\u0006\u2008);
    this.Controls.Add((Control) this.\u0008\u2008);
    this.Controls.Add((Control) this.\u0005\u2008);
    this.Controls.Add((Control) this.\u0003\u2008);
    this.Controls.Add((Control) this.\u0003\u2000\u2004);
    this.Controls.Add((Control) this.\u0002\u2000\u2004);
    this.Controls.Add((Control) this.\u0005​\u2003);
    this.Controls.Add((Control) this.\u0005\u2009);
    this.Controls.Add((Control) this.\u0006\u2008\u2003);
    this.Controls.Add((Control) this.\u000E\u2008\u2003);
    this.Controls.Add((Control) this.\u000F\u2008\u2003);
    this.Controls.Add((Control) this.\u0002\u2009\u2003);
    this.Controls.Add((Control) this.\u0003\u2009\u2003);
    this.Controls.Add((Control) this.\u0005\u2009\u2003);
    this.Controls.Add((Control) this.\u0008\u2009\u2003);
    this.Controls.Add((Control) this.\u0006\u2009\u2003);
    this.Controls.Add((Control) this.\u000E\u2009\u2003);
    this.Controls.Add((Control) this.\u000F\u2009\u2003);
    this.Controls.Add((Control) this.\u0002\u200A\u2003);
    this.Controls.Add((Control) this.\u0003\u200A\u2003);
    this.Controls.Add((Control) this.\u0005\u200A\u2003);
    this.Controls.Add((Control) this.\u0008\u200A\u2003);
    this.Controls.Add((Control) this.\u0006\u200A\u2003);
    this.Controls.Add((Control) this.\u0003\u2008\u2003);
    this.Controls.Add((Control) this.\u0005\u2008\u2003);
    this.Controls.Add((Control) this.\u0008\u2008\u2003);
    this.Controls.Add((Control) this.\u0003\u2007\u2003);
    this.Controls.Add((Control) this.\u0005\u2007\u2003);
    this.Controls.Add((Control) this.\u0008\u2007\u2003);
    this.Controls.Add((Control) this.\u0006\u2007\u2003);
    this.Controls.Add((Control) this.\u000E\u2007\u2003);
    this.Controls.Add((Control) this.\u000F\u2007\u2003);
    this.Controls.Add((Control) this.\u0002\u2008\u2003);
    this.Controls.Add((Control) this.\u0005\u2006\u2003);
    this.Controls.Add((Control) this.\u0008\u2006\u2003);
    this.Controls.Add((Control) this.\u0006\u2006\u2003);
    this.Controls.Add((Control) this.\u000E\u2006\u2003);
    this.Controls.Add((Control) this.\u000F\u2006\u2003);
    this.Controls.Add((Control) this.\u0002\u2007\u2003);
    this.Controls.Add((Control) this.\u000F\u2004\u2003);
    this.Controls.Add((Control) this.\u0002\u2005\u2003);
    this.Controls.Add((Control) this.\u0003\u2005\u2003);
    this.Controls.Add((Control) this.\u0005\u2005\u2003);
    this.Controls.Add((Control) this.\u0008\u2005\u2003);
    this.Controls.Add((Control) this.\u0006\u2005\u2003);
    this.Controls.Add((Control) this.\u000E\u2005\u2003);
    this.Controls.Add((Control) this.\u000F\u2005\u2003);
    this.Controls.Add((Control) this.\u0002\u2006\u2003);
    this.Controls.Add((Control) this.\u0003\u2006\u2003);
    this.Controls.Add((Control) this.\u0008\u2003\u2003);
    this.Controls.Add((Control) this.\u0006\u2003\u2003);
    this.Controls.Add((Control) this.\u000E\u2003\u2003);
    this.Controls.Add((Control) this.\u000F\u2003\u2003);
    this.Controls.Add((Control) this.\u0002\u2004\u2003);
    this.Controls.Add((Control) this.\u0003\u2004\u2003);
    this.Controls.Add((Control) this.\u0005\u2004\u2003);
    this.Controls.Add((Control) this.\u0008\u2004\u2003);
    this.Controls.Add((Control) this.\u0006\u2004\u2003);
    this.Controls.Add((Control) this.\u000E\u2004\u2003);
    this.Controls.Add((Control) this.\u0002\u2001\u2003);
    this.Controls.Add((Control) this.\u0003\u2001\u2003);
    this.Controls.Add((Control) this.\u0005\u2001\u2003);
    this.Controls.Add((Control) this.\u0008\u2001\u2003);
    this.Controls.Add((Control) this.\u0006\u2001\u2003);
    this.Controls.Add((Control) this.\u000E\u2001\u2003);
    this.Controls.Add((Control) this.\u000F\u2001\u2003);
    this.Controls.Add((Control) this.\u0002\u2002\u2003);
    this.Controls.Add((Control) this.\u0003\u2002\u2003);
    this.Controls.Add((Control) this.\u0005\u2002\u2003);
    this.Controls.Add((Control) this.\u0008\u2002\u2003);
    this.Controls.Add((Control) this.\u0006\u2002\u2003);
    this.Controls.Add((Control) this.\u000E\u2002\u2003);
    this.Controls.Add((Control) this.\u000F\u2002\u2003);
    this.Controls.Add((Control) this.\u0002\u2003\u2003);
    this.Controls.Add((Control) this.\u0003\u2003\u2003);
    this.Controls.Add((Control) this.\u0005\u2003\u2003);
    this.Controls.Add((Control) this.\u000F​\u2002);
    this.Controls.Add((Control) this.\u0002\u2000\u2003);
    this.Controls.Add((Control) this.\u0003\u2000\u2003);
    this.Controls.Add((Control) this.\u0005\u2000\u2003);
    this.Controls.Add((Control) this.\u0008\u2000\u2003);
    this.Controls.Add((Control) this.\u0006\u2000\u2003);
    this.Controls.Add((Control) this.\u000E\u2000\u2003);
    this.Controls.Add((Control) this.\u000F\u2000\u2003);
    this.Controls.Add((Control) this.\u0006\u2009\u2002);
    this.Controls.Add((Control) this.\u000E\u2009\u2002);
    this.Controls.Add((Control) this.\u000F\u2009\u2002);
    this.Controls.Add((Control) this.\u0002\u200A\u2002);
    this.Controls.Add((Control) this.\u0003\u200A\u2002);
    this.Controls.Add((Control) this.\u0005\u200A\u2002);
    this.Controls.Add((Control) this.\u0008\u200A\u2002);
    this.Controls.Add((Control) this.\u0006\u200A\u2002);
    this.Controls.Add((Control) this.\u000E\u200A\u2002);
    this.Controls.Add((Control) this.\u000F\u200A\u2002);
    this.Controls.Add((Control) this.\u0002​\u2002);
    this.Controls.Add((Control) this.\u0003​\u2002);
    this.Controls.Add((Control) this.\u0005​\u2002);
    this.Controls.Add((Control) this.\u0008​\u2002);
    this.Controls.Add((Control) this.\u0006​\u2002);
    this.Controls.Add((Control) this.\u000E​\u2002);
    this.Controls.Add((Control) this.\u0002\u2009\u2002);
    this.Controls.Add((Control) this.\u0003\u2009\u2002);
    this.Controls.Add((Control) this.\u0005\u2009\u2002);
    this.Controls.Add((Control) this.\u0008\u2009\u2002);
    this.Controls.Add((Control) this.\u000F\u2007\u2002);
    this.Controls.Add((Control) this.\u0002\u2008\u2002);
    this.Controls.Add((Control) this.\u0003\u2008\u2002);
    this.Controls.Add((Control) this.\u0005\u2008\u2002);
    this.Controls.Add((Control) this.\u0008\u2008\u2002);
    this.Controls.Add((Control) this.\u0006\u2008\u2002);
    this.Controls.Add((Control) this.\u000E\u2008\u2002);
    this.Controls.Add((Control) this.\u000F\u2008\u2002);
    this.Controls.Add((Control) this.\u0002\u2007\u2002);
    this.Controls.Add((Control) this.\u0003\u2007\u2002);
    this.Controls.Add((Control) this.\u0005\u2007\u2002);
    this.Controls.Add((Control) this.\u0008\u2007\u2002);
    this.Controls.Add((Control) this.\u0006\u2007\u2002);
    this.Controls.Add((Control) this.\u000E\u2007\u2002);
    this.Controls.Add((Control) this.\u0003\u2006\u2002);
    this.Controls.Add((Control) this.\u0005\u2006\u2002);
    this.Controls.Add((Control) this.\u0008\u2006\u2002);
    this.Controls.Add((Control) this.\u0006\u2006\u2002);
    this.Controls.Add((Control) this.\u000E\u2006\u2002);
    this.Controls.Add((Control) this.\u000F\u2006\u2002);
    this.Controls.Add((Control) this.\u000F\u2004\u2002);
    this.Controls.Add((Control) this.\u0002\u2005\u2002);
    this.Controls.Add((Control) this.\u0003\u2005\u2002);
    this.Controls.Add((Control) this.\u0005\u2005\u2002);
    this.Controls.Add((Control) this.\u0008\u2005\u2002);
    this.Controls.Add((Control) this.\u0006\u2005\u2002);
    this.Controls.Add((Control) this.\u000E\u2005\u2002);
    this.Controls.Add((Control) this.\u000F\u2005\u2002);
    this.Controls.Add((Control) this.\u0002\u2006\u2002);
    this.Controls.Add((Control) this.\u0006\u2002\u2002);
    this.Controls.Add((Control) this.\u000E\u2002\u2002);
    this.Controls.Add((Control) this.\u000F\u2002\u2002);
    this.Controls.Add((Control) this.\u0002\u2003\u2002);
    this.Controls.Add((Control) this.\u0003\u2003\u2002);
    this.Controls.Add((Control) this.\u0005\u2003\u2002);
    this.Controls.Add((Control) this.\u0008\u2003\u2002);
    this.Controls.Add((Control) this.\u0006\u2003\u2002);
    this.Controls.Add((Control) this.\u000E\u2003\u2002);
    this.Controls.Add((Control) this.\u000F\u2003\u2002);
    this.Controls.Add((Control) this.\u0002\u2004\u2002);
    this.Controls.Add((Control) this.\u0003\u2004\u2002);
    this.Controls.Add((Control) this.\u0005\u2004\u2002);
    this.Controls.Add((Control) this.\u0008\u2004\u2002);
    this.Controls.Add((Control) this.\u0006\u2004\u2002);
    this.Controls.Add((Control) this.\u000E\u2004\u2002);
    this.Controls.Add((Control) this.\u000E\u2001\u2002);
    this.Controls.Add((Control) this.\u000F\u2001\u2002);
    this.Controls.Add((Control) this.\u0002\u2002\u2002);
    this.Controls.Add((Control) this.\u0003\u2002\u2002);
    this.Controls.Add((Control) this.\u0005\u2002\u2002);
    this.Controls.Add((Control) this.\u0008\u2002\u2002);
    this.Controls.Add((Control) this.\u0008\u2000\u2002);
    this.Controls.Add((Control) this.\u0006\u2000\u2002);
    this.Controls.Add((Control) this.\u000E\u2000\u2002);
    this.Controls.Add((Control) this.\u000F\u2000\u2002);
    this.Controls.Add((Control) this.\u0002\u2001\u2002);
    this.Controls.Add((Control) this.\u0003\u2001\u2002);
    this.Controls.Add((Control) this.\u0005\u2001\u2002);
    this.Controls.Add((Control) this.\u0008\u2001\u2002);
    this.Controls.Add((Control) this.\u0006\u2001\u2002);
    this.Controls.Add((Control) this.\u0003​\u2001);
    this.Controls.Add((Control) this.\u0005​\u2001);
    this.Controls.Add((Control) this.\u0008​\u2001);
    this.Controls.Add((Control) this.\u0006​\u2001);
    this.Controls.Add((Control) this.\u000E​\u2001);
    this.Controls.Add((Control) this.\u000F​\u2001);
    this.Controls.Add((Control) this.\u0002\u2000\u2002);
    this.Controls.Add((Control) this.\u0003\u2000\u2002);
    this.Controls.Add((Control) this.\u0005\u2000\u2002);
    this.Controls.Add((Control) this.\u0006\u200A\u2001);
    this.Controls.Add((Control) this.\u000E\u200A\u2001);
    this.Controls.Add((Control) this.\u000F\u200A\u2001);
    this.Controls.Add((Control) this.\u0002​\u2001);
    this.Controls.Add((Control) this.\u0008\u200A\u2001);
    this.Controls.Add((Control) this.\u0002\u200A\u2001);
    this.Controls.Add((Control) this.\u0003\u200A\u2001);
    this.Controls.Add((Control) this.\u0005\u200A\u2001);
    this.Controls.Add((Control) this.\u0006\u2009\u2001);
    this.Controls.Add((Control) this.\u000E\u2009\u2001);
    this.Controls.Add((Control) this.\u000F\u2009\u2001);
    this.Controls.Add((Control) this.\u000E\u2003\u2001);
    this.Controls.Add((Control) this.\u000F\u2003\u2001);
    this.Controls.Add((Control) this.\u0002\u2004\u2001);
    this.Controls.Add((Control) this.\u0003\u2004\u2001);
    this.Controls.Add((Control) this.\u0005\u2004\u2001);
    this.Controls.Add((Control) this.\u0008\u2004\u2001);
    this.Controls.Add((Control) this.\u0006\u2004\u2001);
    this.Controls.Add((Control) this.\u000E\u2004\u2001);
    this.Controls.Add((Control) this.\u000F\u2004\u2001);
    this.Controls.Add((Control) this.\u0002\u2005\u2001);
    this.Controls.Add((Control) this.\u0003\u2005\u2001);
    this.Controls.Add((Control) this.\u0005\u2005\u2001);
    this.Controls.Add((Control) this.\u0008\u2005\u2001);
    this.Controls.Add((Control) this.\u0006\u2005\u2001);
    this.Controls.Add((Control) this.\u000E\u2005\u2001);
    this.Controls.Add((Control) this.\u000F\u2005\u2001);
    this.Controls.Add((Control) this.\u0002\u2006\u2001);
    this.Controls.Add((Control) this.\u0003\u2006\u2001);
    this.Controls.Add((Control) this.\u0005\u2006\u2001);
    this.Controls.Add((Control) this.\u0008\u2006\u2001);
    this.Controls.Add((Control) this.\u0006\u2006\u2001);
    this.Controls.Add((Control) this.\u000E\u2006\u2001);
    this.Controls.Add((Control) this.\u000F\u2006\u2001);
    this.Controls.Add((Control) this.\u0002\u2007\u2001);
    this.Controls.Add((Control) this.\u0003\u2007\u2001);
    this.Controls.Add((Control) this.\u0005\u2007\u2001);
    this.Controls.Add((Control) this.\u0008\u2007\u2001);
    this.Controls.Add((Control) this.\u0006\u2007\u2001);
    this.Controls.Add((Control) this.\u000E\u2007\u2001);
    this.Controls.Add((Control) this.\u000F\u2007\u2001);
    this.Controls.Add((Control) this.\u0002\u2008\u2001);
    this.Controls.Add((Control) this.\u0003\u2008\u2001);
    this.Controls.Add((Control) this.\u0005\u2008\u2001);
    this.Controls.Add((Control) this.\u0008\u2008\u2001);
    this.Controls.Add((Control) this.\u0006\u2008\u2001);
    this.Controls.Add((Control) this.\u000E\u2008\u2001);
    this.Controls.Add((Control) this.\u000F\u2008\u2001);
    this.Controls.Add((Control) this.\u0002\u2009\u2001);
    this.Controls.Add((Control) this.\u0003\u2009\u2001);
    this.Controls.Add((Control) this.\u0005\u2009\u2001);
    this.Controls.Add((Control) this.\u0008\u2009\u2001);
    this.Controls.Add((Control) this.\u000E\u2001\u2001);
    this.Controls.Add((Control) this.\u000F\u2001\u2001);
    this.Controls.Add((Control) this.\u0002\u2002\u2001);
    this.Controls.Add((Control) this.\u0003\u2002\u2001);
    this.Controls.Add((Control) this.\u0005\u2002\u2001);
    this.Controls.Add((Control) this.\u0008\u2002\u2001);
    this.Controls.Add((Control) this.\u0006\u2002\u2001);
    this.Controls.Add((Control) this.\u000E\u2002\u2001);
    this.Controls.Add((Control) this.\u000F\u2002\u2001);
    this.Controls.Add((Control) this.\u0002\u2003\u2001);
    this.Controls.Add((Control) this.\u0003\u2003\u2001);
    this.Controls.Add((Control) this.\u0005\u2003\u2001);
    this.Controls.Add((Control) this.\u0008\u2003\u2001);
    this.Controls.Add((Control) this.\u0006\u2003\u2001);
    this.Controls.Add((Control) this.\u0008\u2001\u2001);
    this.Controls.Add((Control) this.\u0006\u2001\u2001);
    this.Controls.Add((Control) this.\u000E\u2000\u2001);
    this.Controls.Add((Control) this.\u000F\u2000\u2001);
    this.Controls.Add((Control) this.\u0002\u2001\u2001);
    this.Controls.Add((Control) this.\u0003\u2001\u2001);
    this.Controls.Add((Control) this.\u0005\u2001\u2001);
    this.Controls.Add((Control) this.\u0003\u2000\u2001);
    this.Controls.Add((Control) this.\u0005\u2000\u2001);
    this.Controls.Add((Control) this.\u0008\u2000\u2001);
    this.Controls.Add((Control) this.\u0006\u2000\u2001);
    this.Controls.Add((Control) this.\u0006​\u2000);
    this.Controls.Add((Control) this.\u000E​\u2000);
    this.Controls.Add((Control) this.\u000F​\u2000);
    this.Controls.Add((Control) this.\u0002\u2000\u2001);
    this.Controls.Add((Control) this.\u0002​\u2000);
    this.Controls.Add((Control) this.\u0003​\u2000);
    this.Controls.Add((Control) this.\u0005​\u2000);
    this.Controls.Add((Control) this.\u0008​\u2000);
    this.Controls.Add((Control) this.\u0006\u200A\u2000);
    this.Controls.Add((Control) this.\u000E\u200A\u2000);
    this.Controls.Add((Control) this.\u000F\u200A\u2000);
    this.Controls.Add((Control) this.\u0002\u200A\u2000);
    this.Controls.Add((Control) this.\u0003\u200A\u2000);
    this.Controls.Add((Control) this.\u0005\u200A\u2000);
    this.Controls.Add((Control) this.\u0008\u200A\u2000);
    this.Controls.Add((Control) this.\u0008\u2009\u2000);
    this.Controls.Add((Control) this.\u0006\u2009\u2000);
    this.Controls.Add((Control) this.\u000E\u2009\u2000);
    this.Controls.Add((Control) this.\u000F\u2009\u2000);
    this.Controls.Add((Control) this.\u000F\u2008\u2000);
    this.Controls.Add((Control) this.\u0002\u2009\u2000);
    this.Controls.Add((Control) this.\u0003\u2009\u2000);
    this.Controls.Add((Control) this.\u0005\u2009\u2000);
    this.Controls.Add((Control) this.\u000E\u2008\u2000);
    this.Controls.Add((Control) this.\u0005\u2008\u2000);
    this.Controls.Add((Control) this.\u0008\u2008\u2000);
    this.Controls.Add((Control) this.\u0006\u2008\u2000);
    this.Controls.Add((Control) this.\u0003\u2008\u2000);
    this.Controls.Add((Control) this.\u000F\u2007\u2000);
    this.Controls.Add((Control) this.\u0002\u2008\u2000);
    this.Controls.Add((Control) this.\u0008\u2007\u2000);
    this.Controls.Add((Control) this.\u0006\u2007\u2000);
    this.Controls.Add((Control) this.\u000E\u2007\u2000);
    this.Controls.Add((Control) this.\u0002\u2007\u2000);
    this.Controls.Add((Control) this.\u0003\u2007\u2000);
    this.Controls.Add((Control) this.\u0005\u2007\u2000);
    this.Controls.Add((Control) this.\u000E\u2004\u2000);
    this.Controls.Add((Control) this.\u000F\u2004\u2000);
    this.Controls.Add((Control) this.\u0002\u2006\u2000);
    this.Controls.Add((Control) this.\u0003\u2006\u2000);
    this.Controls.Add((Control) this.\u0005\u2006\u2000);
    this.Controls.Add((Control) this.\u0008\u2006\u2000);
    this.Controls.Add((Control) this.\u0006\u2006\u2000);
    this.Controls.Add((Control) this.\u000E\u2006\u2000);
    this.Controls.Add((Control) this.\u000F\u2006\u2000);
    this.Controls.Add((Control) this.\u0008\u2003\u2000);
    this.Controls.Add((Control) this.\u0006\u2003\u2000);
    this.Controls.Add((Control) this.\u000E\u2003\u2000);
    this.Controls.Add((Control) this.\u000F\u2003\u2000);
    this.Controls.Add((Control) this.\u0002\u2004\u2000);
    this.Controls.Add((Control) this.\u0003\u2004\u2000);
    this.Controls.Add((Control) this.\u0005\u2004\u2000);
    this.Controls.Add((Control) this.\u0008\u2004\u2000);
    this.Controls.Add((Control) this.\u0006\u2004\u2000);
    this.Controls.Add((Control) this.\u0005\u2003\u2000);
    this.Controls.Add((Control) this.\u0003\u2003\u2000);
    this.Controls.Add((Control) this.\u000E\u2002\u2000);
    this.Controls.Add((Control) this.\u000F\u2002\u2000);
    this.Controls.Add((Control) this.\u0002\u2003\u2000);
    this.Controls.Add((Control) this.\u0008\u2002\u2000);
    this.Controls.Add((Control) this.\u0005\u2002\u2000);
    this.Controls.Add((Control) this.\u0006\u2002\u2000);
    this.Controls.Add((Control) this.\u0003\u2000\u2000);
    this.Controls.Add((Control) this.\u0005\u2000\u2000);
    this.Controls.Add((Control) this.\u0008\u2000\u2000);
    this.Controls.Add((Control) this.\u0006\u2000\u2000);
    this.Controls.Add((Control) this.\u000E\u2000\u2000);
    this.Controls.Add((Control) this.\u000F\u2000\u2000);
    this.Controls.Add((Control) this.\u0002\u2001\u2000);
    this.Controls.Add((Control) this.\u0003\u2001\u2000);
    this.Controls.Add((Control) this.\u0005\u2001\u2000);
    this.Controls.Add((Control) this.\u0008\u2001\u2000);
    this.Controls.Add((Control) this.\u0006\u2001\u2000);
    this.Controls.Add((Control) this.\u000E\u2001\u2000);
    this.Controls.Add((Control) this.\u000F\u2001\u2000);
    this.Controls.Add((Control) this.\u0002\u2002\u2000);
    this.Controls.Add((Control) this.\u0005​);
    this.Controls.Add((Control) this.\u0008​);
    this.Controls.Add((Control) this.\u0006​);
    this.Controls.Add((Control) this.\u000E​);
    this.Controls.Add((Control) this.\u000F​);
    this.Controls.Add((Control) this.\u0002\u2000\u2000);
    this.Controls.Add((Control) this.\u000E\u200A);
    this.Controls.Add((Control) this.\u000F\u200A);
    this.Controls.Add((Control) this.\u0002​);
    this.Controls.Add((Control) this.\u0003​);
    this.Controls.Add((Control) this.\u0008\u200A);
    this.Controls.Add((Control) this.\u0006\u200A);
    this.Controls.Add((Control) this.\u0005\u200A);
    this.Controls.Add((Control) this.\u0003\u200A);
    this.Controls.Add((Control) this.\u0003\u2002\u2000);
    this.Controls.Add((Control) this.\u0003\u2009);
    this.Controls.Add((Control) this.\u0002\u2009);
    this.Controls.Add((Control) this.\u000F\u2008);
    this.Controls.Add((Control) this.\u000E\u2008);
    this.Cursor = Cursors.Default;
    this.DoubleBuffered = true;
    this.Font = new Font(\u000F\u2000.\u0002(-380200637), 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Icon = (Icon) componentResourceManager.GetObject(\u000F\u2000.\u0002(-380200616));
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MaximumSize = new Size(386, 469);
    this.MinimizeBox = false;
    this.MinimumSize = new Size(386, 469);
    this.Name = \u000F\u2000.\u0002(-380200593);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = \u000F\u2000.\u0002(-380200581);
    this.TransparencyKey = Color.Fuchsia;
    this.KeyDown += new KeyEventHandler(this.\u0002);
    ((ISupportInitialize) this.\u0003\u2009).EndInit();
    ((ISupportInitialize) this.\u0002\u2009).EndInit();
    this.\u000F\u200A\u2003.ResumeLayout(false);
    this.\u000F\u200A\u2003.PerformLayout();
    ((ISupportInitialize) this.\u000E\u2000\u2004).EndInit();
    ((ISupportInitialize) this.\u0006\u2000\u2004).EndInit();
    ((ISupportInitialize) this.\u0003​\u2003).EndInit();
    ((ISupportInitialize) this.\u0005​\u2003).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
