using System;
using System.Diagnostics;

namespace SpaceInvaders
{
	// Token: 0x02000014 RID: 20
	public class KeyboardController : IUserInterface
	{
		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000055 RID: 85 RVA: 0x00003478 File Offset: 0x00001678
		// (remove) Token: 0x06000056 RID: 86 RVA: 0x000034B0 File Offset: 0x000016B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event EventHandler OnLeftPressed;

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000057 RID: 87 RVA: 0x000034E8 File Offset: 0x000016E8
		// (remove) Token: 0x06000058 RID: 88 RVA: 0x00003520 File Offset: 0x00001720
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event EventHandler OnRightPressed;

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000059 RID: 89 RVA: 0x00003558 File Offset: 0x00001758
		// (remove) Token: 0x0600005A RID: 90 RVA: 0x00003590 File Offset: 0x00001790
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event EventHandler OnActionPressed;

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x0600005B RID: 91 RVA: 0x000035C8 File Offset: 0x000017C8
		// (remove) Token: 0x0600005C RID: 92 RVA: 0x00003600 File Offset: 0x00001800
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event EventHandler OnEscapePressed;

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x0600005D RID: 93 RVA: 0x00003638 File Offset: 0x00001838
		// (remove) Token: 0x0600005E RID: 94 RVA: 0x00003670 File Offset: 0x00001870
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event EventHandler OnUpPressed;

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x0600005F RID: 95 RVA: 0x000036A8 File Offset: 0x000018A8
		// (remove) Token: 0x06000060 RID: 96 RVA: 0x000036E0 File Offset: 0x000018E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event EventHandler OnDownPressed;

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06000061 RID: 97 RVA: 0x00003718 File Offset: 0x00001918
		// (remove) Token: 0x06000062 RID: 98 RVA: 0x00003750 File Offset: 0x00001950
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event EventHandler OnEnterPressed;

		// Token: 0x06000063 RID: 99 RVA: 0x00003788 File Offset: 0x00001988
		public void PauseProcessInput()
		{
			bool keyAvailable = Console.KeyAvailable;
			if (keyAvailable)
			{
				ConsoleKeyInfo keyInfo = Console.ReadKey(true);
				while (Console.KeyAvailable)
				{
					Console.ReadKey();
				}
				bool flag = keyInfo.Key.Equals(ConsoleKey.Escape);
				if (flag)
				{
					bool flag2 = this.OnEscapePressed != null;
					if (flag2)
					{
						this.OnEscapePressed(this, new EventArgs());
					}
				}
				bool flag3 = keyInfo.Key.Equals(ConsoleKey.UpArrow);
				if (flag3)
				{
					bool flag4 = this.OnUpPressed != null;
					if (flag4)
					{
						this.OnUpPressed(this, new EventArgs());
					}
				}
				bool flag5 = keyInfo.Key.Equals(ConsoleKey.DownArrow);
				if (flag5)
				{
					bool flag6 = this.OnDownPressed != null;
					if (flag6)
					{
						this.OnDownPressed(this, new EventArgs());
					}
				}
				bool flag7 = keyInfo.Key.Equals(ConsoleKey.Enter);
				if (flag7)
				{
					bool flag8 = this.OnEnterPressed != null;
					if (flag8)
					{
						this.OnEnterPressed(this, new EventArgs());
					}
				}
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000038DC File Offset: 0x00001ADC
		public void RunProcessInput()
		{
			bool keyAvailable = Console.KeyAvailable;
			if (keyAvailable)
			{
				ConsoleKeyInfo keyInfo = Console.ReadKey(true);
				while (Console.KeyAvailable)
				{
					Console.ReadKey();
				}
				bool flag = keyInfo.Key.Equals(ConsoleKey.LeftArrow);
				if (flag)
				{
					bool flag2 = this.OnLeftPressed != null;
					if (flag2)
					{
						this.OnLeftPressed(this, new EventArgs());
					}
				}
				bool flag3 = keyInfo.Key.Equals(ConsoleKey.RightArrow);
				if (flag3)
				{
					bool flag4 = this.OnRightPressed != null;
					if (flag4)
					{
						this.OnRightPressed(this, new EventArgs());
					}
				}
				bool flag5 = keyInfo.Key.Equals(ConsoleKey.Spacebar);
				if (flag5)
				{
					bool flag6 = this.OnActionPressed != null;
					if (flag6)
					{
						this.OnActionPressed(this, new EventArgs());
					}
				}
				bool flag7 = keyInfo.Key.Equals(ConsoleKey.Escape);
				if (flag7)
				{
					bool flag8 = this.OnEscapePressed != null;
					if (flag8)
					{
						this.OnEscapePressed(this, new EventArgs());
					}
				}
			}
		}
	}
}
