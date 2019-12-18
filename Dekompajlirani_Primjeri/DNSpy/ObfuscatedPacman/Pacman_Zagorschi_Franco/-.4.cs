using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

// Token: 0x02000005 RID: 5
internal sealed partial class \u0003 : Form
{
	// Token: 0x06000009 RID: 9 RVA: 0x0000218C File Offset: 0x0000038C
	public \u0003(string \u0002, string \u0003) : this(\u0002, \u0003, MessageBoxButtons.OK)
	{
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002198 File Offset: 0x00000398
	public \u0003(string \u0002, string \u0003, MessageBoxButtons \u0005) : this(\u0002, \u0003, \u000F\u2000.\u0002(1132139802), \u0005)
	{
	}

	// Token: 0x0600000B RID: 11 RVA: 0x000021B0 File Offset: 0x000003B0
	public \u0003(string \u0002, string \u0003, string \u0005, MessageBoxButtons \u0008)
	{
		Label label = new Label();
		PictureBox pictureBox = new PictureBox();
		base.SuspendLayout();
		pictureBox.Image = global::\u0003.\u0002(\u0005);
		pictureBox.Location = new Point(8, 8);
		pictureBox.Size = new Size(48, 48);
		pictureBox.TabStop = false;
		label.Location = new Point(64, 24);
		label.Size = new Size(310, 114);
		label.Text = \u0002;
		if (\u0008 != MessageBoxButtons.OK)
		{
			if (\u0008 == MessageBoxButtons.YesNo)
			{
				this.\u0003();
			}
		}
		else
		{
			this.\u0002();
		}
		this.AutoScaleBaseSize = new Size(5, 13);
		base.ClientSize = new Size(388, 197);
		base.Controls.AddRange(new Control[]
		{
			label,
			pictureBox
		});
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		this.Text = \u0003;
		base.StartPosition = FormStartPosition.CenterScreen;
		base.TopMost = true;
		base.ResumeLayout(false);
	}

	// Token: 0x0600000C RID: 12 RVA: 0x000022B4 File Offset: 0x000004B4
	private void \u0002()
	{
		Button button = new Button
		{
			FlatStyle = FlatStyle.System,
			Location = new Point(169, 162),
			TabIndex = 0,
			Text = \u000F\u2000.\u0002(1132139790),
			DialogResult = DialogResult.OK
		};
		button.Click += this.\u0002;
		base.Controls.Add(button);
		base.AcceptButton = button;
		base.CancelButton = button;
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002330 File Offset: 0x00000530
	private void \u0002(object \u0002, EventArgs \u0003)
	{
		base.Close();
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00002338 File Offset: 0x00000538
	private void \u0003()
	{
		Button button = new Button
		{
			FlatStyle = FlatStyle.System,
			Location = new Point(124, 162),
			TabIndex = 1,
			Text = \u000F\u2000.\u0002(1132140017),
			DialogResult = DialogResult.Yes
		};
		Button button2 = new Button
		{
			FlatStyle = FlatStyle.System,
			Location = new Point(214, 162),
			TabIndex = 0,
			Text = \u000F\u2000.\u0002(1132140027),
			DialogResult = DialogResult.No
		};
		base.Controls.AddRange(new Control[]
		{
			button,
			button2
		});
		base.AcceptButton = button;
		base.CancelButton = button2;
	}

	// Token: 0x0600000F RID: 15 RVA: 0x000023EC File Offset: 0x000005EC
	private static Bitmap \u0002(string \u0002)
	{
		Stream manifestResourceStream = typeof(\u0003).Assembly.GetManifestResourceStream(\u000F\u2000.\u0002(1132140002) + \u0002 + \u000F\u2000.\u0002(1132139960));
		if (manifestResourceStream != null)
		{
			return new Bitmap(manifestResourceStream);
		}
		return null;
	}
}
