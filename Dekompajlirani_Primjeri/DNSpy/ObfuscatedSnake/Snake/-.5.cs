using System;
using System.Diagnostics;
using System.Threading;

// Token: 0x02000006 RID: 6
internal static class \u0005
{
	// Token: 0x02000007 RID: 7
	internal sealed class \u0002 : \u0006<int>, \u0008, \u0002\u2000<int>, \u000F, \u000E
	{
		// Token: 0x0600000C RID: 12 RVA: 0x00002250 File Offset: 0x00000450
		[DebuggerHidden]
		public \u0002(int \u0002)
		{
			this.\u0002 = \u0002;
			this.\u0005 = Thread.CurrentThread.ManagedThreadId;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002270 File Offset: 0x00000470
		[DebuggerHidden]
		void \u000F.\u0002\u2005\u2006\u0002()
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002274 File Offset: 0x00000474
		bool \u000E.\u000E\u2005\u2006\u0002()
		{
			switch (this.\u0002)
			{
			case 0:
				this.\u0002 = -1;
				this.\u0003 = 250489705;
				this.\u0002 = 1;
				return true;
			case 1:
				this.\u0002 = -1;
				this.\u0003 = (this.\u0008 ^ -2566833);
				this.\u0002 = 2;
				return true;
			case 2:
				this.\u0002 = -1;
				this.\u0003 = -633790635;
				this.\u0002 = 3;
				return true;
			case 3:
				this.\u0002 = -1;
				this.\u0003 = (this.\u0008 ^ -2566833);
				this.\u0002 = 4;
				return true;
			case 4:
				this.\u0002 = -1;
				this.\u0003 = 1511105469;
				this.\u0002 = 5;
				return true;
			case 5:
				this.\u0002 = -1;
				this.\u0003 = (this.\u0008 ^ 872045545);
				this.\u0002 = 6;
				return true;
			case 6:
				this.\u0002 = -1;
				this.\u0003 = -708120235;
				this.\u0002 = 7;
				return true;
			case 7:
				this.\u0002 = -1;
				this.\u0003 = 2037083242;
				this.\u0002 = 8;
				return true;
			case 8:
				this.\u0002 = -1;
				return false;
			default:
				return false;
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000023AC File Offset: 0x000005AC
		[DebuggerHidden]
		int \u0002\u2000<int>.\u0002\u2005\u2006\u0002()
		{
			return this.\u0003;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000023B4 File Offset: 0x000005B4
		[DebuggerHidden]
		void \u000E.\u0002\u2005\u2006\u0003()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000023BC File Offset: 0x000005BC
		[DebuggerHidden]
		object \u000E.\u0002\u2005\u2006\u0002()
		{
			return this.\u0003;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000023CC File Offset: 0x000005CC
		[DebuggerHidden]
		\u0002\u2000<int> \u0006<int>.\u0002\u2005\u2006\u0002()
		{
			\u0005.\u0002 u;
			if (this.\u0002 == -2 && this.\u0005 == Thread.CurrentThread.ManagedThreadId)
			{
				this.\u0002 = 0;
				u = this;
			}
			else
			{
				u = new \u0005.\u0002(0);
			}
			u.\u0008 = this.\u0006;
			return u;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002414 File Offset: 0x00000614
		[DebuggerHidden]
		\u000E \u0008.\u0002\u2005\u2006\u0002()
		{
			return this.\u0002\u2005\u2006\u0002();
		}

		// Token: 0x04000001 RID: 1
		private int \u0002;

		// Token: 0x04000002 RID: 2
		private int \u0003;

		// Token: 0x04000003 RID: 3
		private int \u0005;

		// Token: 0x04000004 RID: 4
		private int \u0008;

		// Token: 0x04000005 RID: 5
		public int \u0006;
	}
}
