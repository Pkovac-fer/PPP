using System;
using System.Diagnostics;
using System.Threading;

// Token: 0x02000016 RID: 22
internal static class \u0008
{
	// Token: 0x02000017 RID: 23
	internal sealed class \u0002 : \u000E<int>, \u0006, \u0003\u2000<int>, \u0002\u2000, \u000F
	{
		// Token: 0x06000035 RID: 53 RVA: 0x00002F88 File Offset: 0x00001188
		[DebuggerHidden]
		public \u0002(int \u0002)
		{
			this.\u0002 = \u0002;
			this.\u0005 = Thread.CurrentThread.ManagedThreadId;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002FA8 File Offset: 0x000011A8
		[DebuggerHidden]
		void \u0002\u2000.\u0002\u200A\u2007\u2005\u2002\u0002()
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002FAC File Offset: 0x000011AC
		bool \u000F.\u000F\u200A\u2007\u2005\u2002\u0002()
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

		// Token: 0x06000038 RID: 56 RVA: 0x000030E4 File Offset: 0x000012E4
		[DebuggerHidden]
		int \u0003\u2000<int>.\u0002\u200A\u2007\u2005\u2002\u0002()
		{
			return this.\u0003;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000030EC File Offset: 0x000012EC
		[DebuggerHidden]
		void \u000F.\u0002\u200A\u2007\u2005\u2002\u0003()
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000030F4 File Offset: 0x000012F4
		[DebuggerHidden]
		object \u000F.\u0002\u200A\u2007\u2005\u2002\u0002()
		{
			return this.\u0003;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003104 File Offset: 0x00001304
		[DebuggerHidden]
		\u0003\u2000<int> \u000E<int>.\u0002\u200A\u2007\u2005\u2002\u0002()
		{
			\u0008.\u0002 u;
			if (this.\u0002 == -2 && this.\u0005 == Thread.CurrentThread.ManagedThreadId)
			{
				this.\u0002 = 0;
				u = this;
			}
			else
			{
				u = new \u0008.\u0002(0);
			}
			u.\u0008 = this.\u0006;
			return u;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000314C File Offset: 0x0000134C
		[DebuggerHidden]
		\u000F \u0006.\u0002\u200A\u2007\u2005\u2002\u0002()
		{
			return this.\u0002\u200A\u2007\u2005\u2002\u0002();
		}

		// Token: 0x04000007 RID: 7
		private int \u0002;

		// Token: 0x04000008 RID: 8
		private int \u0003;

		// Token: 0x04000009 RID: 9
		private int \u0005;

		// Token: 0x0400000A RID: 10
		private int \u0008;

		// Token: 0x0400000B RID: 11
		public int \u0006;
	}
}
