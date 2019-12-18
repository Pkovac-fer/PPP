using System;
using System.Globalization;

// Token: 0x02000004 RID: 4
internal static class \u0003
{
	// Token: 0x06000009 RID: 9 RVA: 0x0000218C File Offset: 0x0000038C
	private static bool \u0002(bool \u0002)
	{
		DateTime t = DateTime.Parse(\u0006\u2000.\u0002(1257959213), CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);
		DateTime utcNow = DateTime.UtcNow;
		if (!(utcNow > t) && !(utcNow < t.AddDays(-21.0)))
		{
			if (!global::\u0002.\u0005())
			{
				try
				{
					Console.WriteLine(\u0006\u2000.\u0002(1257958984));
				}
				catch
				{
				}
			}
			return true;
		}
		string text = string.Format(\u0006\u2000.\u0002(1257959376), new object[]
		{
			\u0006\u2000.\u0002(1257959352)
		});
		if (\u0002)
		{
			throw new Exception(text);
		}
		Console.WriteLine(text);
		return false;
	}

	// Token: 0x0600000A RID: 10 RVA: 0x0000223C File Offset: 0x0000043C
	public static bool \u0002()
	{
		return \u0003.\u0002(true);
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002244 File Offset: 0x00000444
	public static void \u0002()
	{
		\u0003.\u0002(true);
	}
}
