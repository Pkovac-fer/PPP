using System;

namespace SpaceInvaders
{
	// Token: 0x02000013 RID: 19
	public interface IUserInterface
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000045 RID: 69
		// (remove) Token: 0x06000046 RID: 70
		event EventHandler OnLeftPressed;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000047 RID: 71
		// (remove) Token: 0x06000048 RID: 72
		event EventHandler OnRightPressed;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000049 RID: 73
		// (remove) Token: 0x0600004A RID: 74
		event EventHandler OnActionPressed;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600004B RID: 75
		// (remove) Token: 0x0600004C RID: 76
		event EventHandler OnEscapePressed;

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600004D RID: 77
		// (remove) Token: 0x0600004E RID: 78
		event EventHandler OnUpPressed;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x0600004F RID: 79
		// (remove) Token: 0x06000050 RID: 80
		event EventHandler OnDownPressed;

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000051 RID: 81
		// (remove) Token: 0x06000052 RID: 82
		event EventHandler OnEnterPressed;

		// Token: 0x06000053 RID: 83
		void PauseProcessInput();

		// Token: 0x06000054 RID: 84
		void RunProcessInput();
	}
}
