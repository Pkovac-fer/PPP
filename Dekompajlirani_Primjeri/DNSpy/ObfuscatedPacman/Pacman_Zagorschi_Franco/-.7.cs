using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

// Token: 0x02000010 RID: 16
internal static class \u0005
{
	// Token: 0x06000028 RID: 40 RVA: 0x00002B88 File Offset: 0x00000D88
	private static bool \u0002(bool \u0002)
	{
		DateTime t = DateTime.Parse(\u000F\u2000.\u0002(1132140460), CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);
		DateTime utcNow = DateTime.UtcNow;
		if (utcNow > t || utcNow < t.AddDays(-21.0))
		{
			string name = typeof(\u0005).Assembly.GetName().Name;
			string text = string.Format(\u000F\u2000.\u0002(1132140425), name);
			if (\u0002)
			{
				throw new Exception(text);
			}
			\u0005.\u0002();
			Application.Run(new global::\u0003(text, \u000F\u2000.\u0002(1132138871)));
			return false;
		}
		else
		{
			if (!global::\u0002.\u0002())
			{
				return \u0005.\u0003(\u0002);
			}
			if (global::\u0002.\u0005())
			{
				return true;
			}
			try
			{
				\u0005.\u0002();
				new global::\u0003(\u000F\u2000.\u0002(1132138857), \u000F\u2000.\u0002(1132140390))
				{
					BackColor = Color.White
				}.ShowDialog();
			}
			catch
			{
			}
			if (\u0002)
			{
				throw new Exception(\u000F\u2000.\u0002(1132138616));
			}
			return false;
		}
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00002C98 File Offset: 0x00000E98
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool \u0003(bool \u0002)
	{
		\u0005.\u0002 u = new \u0005.\u0002();
		u.\u0002 = null;
		try
		{
			string text = AppDomain.CurrentDomain.GetData(\u000F\u2000.\u0002(1132138665)) as string;
			if (text != null)
			{
				if (text == \u000F\u2000.\u0002(1132138636))
				{
					u.\u0002 = new bool?(false);
				}
				else if (text == \u000F\u2000.\u0002(1132139380))
				{
					u.\u0002 = new bool?(true);
				}
			}
		}
		catch
		{
		}
		bool flag = u.\u0002 != null;
		if (u.\u0002 == null)
		{
			try
			{
				if (global::\u0002.\u0003())
				{
					\u0005.\u0002(new ThreadStart(u.\u0002));
				}
				else
				{
					\u0005.\u0002(new ThreadStart(u.\u0003));
				}
			}
			catch
			{
			}
		}
		if (!flag && u.\u0002 != null)
		{
			try
			{
				AppDomain.CurrentDomain.SetData(\u000F\u2000.\u0002(1132138665), u.\u0002.Value ? \u000F\u2000.\u0002(1132139380) : \u000F\u2000.\u0002(1132138636));
			}
			catch
			{
			}
		}
		if (u.\u0002.GetValueOrDefault())
		{
			return true;
		}
		if (\u0002)
		{
			throw new Exception(\u000F\u2000.\u0002(1132139388));
		}
		return false;
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00002DF8 File Offset: 0x00000FF8
	private static void \u0002(ThreadStart \u0002)
	{
		\u0005.\u0003 u = new \u0005.\u0003();
		u.\u0002 = \u0002;
		u.\u0003 = null;
		Thread thread = new Thread(new ThreadStart(u.\u0002));
		thread.SetApartmentState(ApartmentState.STA);
		thread.IsBackground = true;
		thread.Start();
		thread.Join();
		if (u.\u0003 != null)
		{
			throw u.\u0003;
		}
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00002E54 File Offset: 0x00001054
	private static void \u0002()
	{
		try
		{
			Application.EnableVisualStyles();
			Application.DoEvents();
		}
		catch
		{
		}
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00002E80 File Offset: 0x00001080
	public static bool \u0002()
	{
		return \u0005.\u0002(false);
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00002E88 File Offset: 0x00001088
	public static void \u0003()
	{
		\u0005.\u0002(true);
	}

	// Token: 0x02000011 RID: 17
	private sealed class \u0002
	{
		// Token: 0x0600002F RID: 47 RVA: 0x00002E9C File Offset: 0x0000109C
		internal void \u0002()
		{
			global::\u0003 u = new global::\u0003(\u000F\u2000.\u0002(1132139949), \u000F\u2000.\u0002(1132140390), MessageBoxButtons.YesNo)
			{
				BackColor = Color.White
			};
			this.\u0002 = new bool?(u.ShowDialog() == DialogResult.Yes);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002EE4 File Offset: 0x000010E4
		internal void \u0003()
		{
			global::\u0003 u = new global::\u0003(\u000F\u2000.\u0002(1132140354), \u000F\u2000.\u0002(1132140390))
			{
				BackColor = Color.White
			};
			this.\u0002 = new bool?(u.ShowDialog() == DialogResult.OK);
		}

		// Token: 0x04000004 RID: 4
		public bool? \u0002;
	}

	// Token: 0x02000012 RID: 18
	private sealed class \u0003
	{
		// Token: 0x06000032 RID: 50 RVA: 0x00002F34 File Offset: 0x00001134
		internal void \u0002()
		{
			try
			{
				this.\u0002();
			}
			catch (Exception u)
			{
				this.\u0003 = u;
			}
		}

		// Token: 0x04000005 RID: 5
		public ThreadStart \u0002;

		// Token: 0x04000006 RID: 6
		public Exception \u0003;
	}
}
