// Decompiled with JetBrains decompiler
// Type: 
// Assembly: Pacman_Zagorschi_Franco, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C2E3103A-7060-4739-85EE-FB357D9D720D
// Assembly location: C:\Users\Petar\OneDrive\Desktop\Originalni_Primjeri\Pacman\Pacman_Zagorschi_Franco\bin\Debug\Pacman_Zagorschi_Franco.exe

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

internal sealed class \u0003 : Form
{
  public \u0003(string _param1, string _param2)
    : this(_param1, _param2, MessageBoxButtons.OK)
  {
  }

  public \u0003(string _param1, string _param2, MessageBoxButtons _param3)
    : this(_param1, _param2, \u000F\u2000.\u0002(-380206356), _param3)
  {
  }

  public \u0003(string _param1, string _param2, string _param3, MessageBoxButtons _param4)
  {
    Label label = new Label();
    PictureBox pictureBox = new PictureBox();
    this.SuspendLayout();
    pictureBox.Image = (Image) \u0003.\u0002(_param3);
    pictureBox.Location = new Point(8, 8);
    pictureBox.Size = new Size(48, 48);
    pictureBox.TabStop = false;
    label.Location = new Point(64, 24);
    label.Size = new Size(310, 114);
    label.Text = _param1;
    switch (_param4)
    {
      case MessageBoxButtons.OK:
        this.\u0002();
        break;
      case MessageBoxButtons.YesNo:
        this.\u0003();
        break;
    }
    this.AutoScaleBaseSize = new Size(5, 13);
    this.ClientSize = new Size(388, 197);
    this.Controls.AddRange(new Control[2]
    {
      (Control) label,
      (Control) pictureBox
    });
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Text = _param2;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.TopMost = true;
    this.ResumeLayout(false);
  }

  private void \u0002()
  {
    Button button1 = new Button();
    button1.FlatStyle = FlatStyle.System;
    button1.Location = new Point(169, 162);
    button1.TabIndex = 0;
    button1.Text = \u000F\u2000.\u0002(-380206344);
    button1.DialogResult = DialogResult.OK;
    Button button2 = button1;
    button2.Click += new EventHandler(this.\u0002);
    this.Controls.Add((Control) button2);
    this.AcceptButton = (IButtonControl) button2;
    this.CancelButton = (IButtonControl) button2;
  }

  private void \u0002(object _param1, EventArgs _param2)
  {
    this.Close();
  }

  private void \u0003()
  {
    Button button1 = new Button();
    button1.FlatStyle = FlatStyle.System;
    button1.Location = new Point(124, 162);
    button1.TabIndex = 1;
    button1.Text = \u000F\u2000.\u0002(-380206585);
    button1.DialogResult = DialogResult.Yes;
    Button button2 = button1;
    Button button3 = new Button();
    button3.FlatStyle = FlatStyle.System;
    button3.Location = new Point(214, 162);
    button3.TabIndex = 0;
    button3.Text = \u000F\u2000.\u0002(-380206579);
    button3.DialogResult = DialogResult.No;
    Button button4 = button3;
    this.Controls.AddRange(new Control[2]
    {
      (Control) button2,
      (Control) button4
    });
    this.AcceptButton = (IButtonControl) button2;
    this.CancelButton = (IButtonControl) button4;
  }

  private static Bitmap \u0002(string _param0)
  {
    Stream manifestResourceStream = typeof (\u0003).Assembly.GetManifestResourceStream(\u000F\u2000.\u0002(-380206572) + _param0 + \u000F\u2000.\u0002(-380206514));
    if (manifestResourceStream != null)
      return new Bitmap(manifestResourceStream);
    return (Bitmap) null;
  }
}
