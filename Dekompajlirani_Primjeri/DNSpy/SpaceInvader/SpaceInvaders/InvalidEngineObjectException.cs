using System;

namespace SpaceInvaders
{
	// Token: 0x02000010 RID: 16
	public class InvalidEngineObjectException : ApplicationException
	{
		// Token: 0x0600003D RID: 61 RVA: 0x00003461 File Offset: 0x00001661
		public InvalidEngineObjectException(string msg) : base(msg)
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000346C File Offset: 0x0000166C
		public InvalidEngineObjectException(string msg, Exception innerEx) : base(msg, innerEx)
		{
		}
	}
}
