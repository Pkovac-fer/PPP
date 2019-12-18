using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x02000007 RID: 7
internal static class \u0003\u2001
{
	// Token: 0x06000012 RID: 18 RVA: 0x00002440 File Offset: 0x00000640
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long \u0002()
	{
		if (Assembly.GetCallingAssembly() != typeof(\u0003\u2001).Assembly || !\u0003\u2001.\u0002())
		{
			return 0L;
		}
		long result;
		lock (\u0003\u2001.\u0002)
		{
			long num = \u0003\u2001.\u0002.\u0002();
			if (num == 0L)
			{
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				List<byte> list = new List<byte>();
				AssemblyName assemblyName;
				try
				{
					assemblyName = executingAssembly.GetName();
				}
				catch
				{
					assemblyName = new AssemblyName(executingAssembly.FullName);
				}
				byte[] array = assemblyName.GetPublicKeyToken();
				if (array != null && array.Length == 0)
				{
					array = null;
				}
				if (array != null)
				{
					list.AddRange(array);
				}
				list.AddRange(Encoding.Unicode.GetBytes(assemblyName.Name));
				int num2 = \u0003\u2001.\u0002(typeof(\u0003\u2001));
				int num3 = \u0003\u2001.\u0005.\u0002();
				list.Add((byte)(num2 >> 24));
				list.Add((byte)(num3 >> 16));
				list.Add((byte)(num2 >> 8));
				list.Add((byte)num3);
				list.Add((byte)(num2 >> 16));
				list.Add((byte)(num3 >> 8));
				list.Add((byte)num2);
				list.Add((byte)(num3 >> 24));
				int count = list.Count;
				ulong num4 = 0UL;
				for (int num5 = 0; num5 != count; num5++)
				{
					num4 += (ulong)list[num5];
					num4 += num4 << 20;
					num4 ^= num4 >> 12;
					list[num5] = 0;
				}
				num4 += num4 << 6;
				num4 ^= num4 >> 22;
				num4 += num4 << 30;
				num = (long)num4;
				num ^= 341799707827893499L;
				\u0003\u2001.\u0002.\u0002(num);
			}
			result = num;
		}
		return result;
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00002608 File Offset: 0x00000808
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool \u0002()
	{
		return \u0003\u2001.\u0003();
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00002614 File Offset: 0x00000814
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool \u0003()
	{
		StackTrace stackTrace = new StackTrace();
		StackFrame frame = stackTrace.GetFrame(3);
		MethodBase methodBase = (frame == null) ? null : frame.GetMethod();
		Type type = (methodBase == null) ? null : methodBase.DeclaringType;
		return type != typeof(RuntimeMethodHandle) && type != null && type.Assembly == typeof(\u0003\u2001).Assembly;
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002678 File Offset: 0x00000878
	private static int \u0002(Type \u0002)
	{
		return \u0002.MetadataToken;
	}

	// Token: 0x04000001 RID: 1
	private static \u0003\u2001.\u0002 \u0002 = new \u0003\u2001.\u0002();

	// Token: 0x02000008 RID: 8
	private sealed class \u0002
	{
		// Token: 0x06000016 RID: 22 RVA: 0x00002680 File Offset: 0x00000880
		internal \u0002()
		{
			this.\u0002(0L);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002690 File Offset: 0x00000890
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal long \u0002()
		{
			if (Assembly.GetCallingAssembly() != typeof(\u0003\u2001.\u0002).Assembly)
			{
				return 2918384L;
			}
			if (!\u0003\u2001.\u0002())
			{
				return 2918384L;
			}
			int[] array = new int[]
			{
				0,
				0,
				0,
				-(~(~(-(-(~(-(~(-(~(~426578886))))))))))
			};
			array[1] = -(~(-(~(~(-(-(~(-(~(~-520264422))))))))));
			array[2] = -(~(~(-(-(~(-(~(~(-(~7678188))))))))));
			array[0] = ~(-(-(~(~(-(-(~(-(~(~-1810167450))))))))));
			int num = this.\u0002;
			int num2 = this.\u0003;
			int num3 = ~(-(-(~(~(-(~(-(~1640531524))))))));
			int num4 = -(~(-(~(~(-(-(~(~957401313))))))));
			for (int num5 = 0; num5 != 32; num5++)
			{
				num2 -= ((num << 4 ^ num >> 5) + num ^ num4 + array[num4 >> 11 & 3]);
				num4 -= num3;
				num -= ((num2 << 4 ^ num2 >> 5) + num2 ^ num4 + array[num4 & 3]);
			}
			for (int num6 = 0; num6 != 4; num6++)
			{
				array[num6] = 0;
			}
			ulong num7 = (ulong)((ulong)((long)num2) << 32);
			return (long)(num7 | (ulong)num);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000027B0 File Offset: 0x000009B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void \u0002(long \u0002)
		{
			if (Assembly.GetCallingAssembly() != typeof(\u0003\u2001.\u0002).Assembly)
			{
				return;
			}
			if (!\u0003\u2001.\u0002())
			{
				return;
			}
			int[] array = new int[4];
			array[1] = ~(-(-(~(~(-(-(~(~(-(~-520264426))))))))));
			array[0] = ~(-(~(-(-(~(~(-(~(-(~-1810167454))))))))));
			array[2] = -(~(~(-(~(-(~(-(~(-(~7678184))))))))));
			array[3] = ~(-(-(~(~(-(~(-(~426578881))))))));
			int num = ~(-(-(~(~(-(~(-(-(~(~1640531525))))))))));
			int num2 = (int)\u0002;
			int num3 = (int)(\u0002 >> 32);
			int num4 = 0;
			for (int num5 = 0; num5 != 32; num5++)
			{
				num2 += ((num3 << 4 ^ num3 >> 5) + num3 ^ num4 + array[num4 & 3]);
				num4 += num;
				num3 += ((num2 << 4 ^ num2 >> 5) + num2 ^ num4 + array[num4 >> 11 & 3]);
			}
			for (int num6 = 0; num6 != 4; num6++)
			{
				array[num6] = 0;
			}
			this.\u0002 = num2;
			this.\u0003 = num3;
		}

		// Token: 0x04000002 RID: 2
		private int \u0002;

		// Token: 0x04000003 RID: 3
		private int \u0003;
	}

	// Token: 0x02000009 RID: 9
	private sealed class \u0002\u2000
	{
		// Token: 0x0600001A RID: 26 RVA: 0x000028B8 File Offset: 0x00000AB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int \u0002()
		{
			return \u0003\u2001.\u0003.\u0002(\u0003\u2001.\u0002(typeof(\u0003\u2001.\u0002\u2000)), \u0003\u2001.\u0003.\u0005(\u0003\u2001.\u0003.\u0003(\u0003\u2001.\u0002(typeof(\u0003\u2001.\u000F)), \u0003\u2001.\u0002(typeof(\u0003\u2001.\u0005))), \u0003\u2001.\u0003.\u0005(\u0003\u2001.\u0002(typeof(\u0003\u2001.\u0008)) ^ -(~(~(-(~(-(~(-(~699261535)))))))), \u0003\u2001.\u000F.\u0002())));
		}
	}

	// Token: 0x0200000A RID: 10
	private static class \u0003
	{
		// Token: 0x0600001B RID: 27 RVA: 0x0000292C File Offset: 0x00000B2C
		internal static int \u0002(int \u0002, int \u0003)
		{
			return \u0002 ^ \u0003 - -(~(-(~(~(-(~(-(-(~(~-932362219))))))))));
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002944 File Offset: 0x00000B44
		internal static int \u0003(int \u0002, int \u0003)
		{
			return \u0002 - ~(-(-(~(~(-(-(~(~(-(~1805435038)))))))))) ^ \u0003 + ~(-(-(~(~(-(~(-(-(~(~-58543220))))))))));
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000296C File Offset: 0x00000B6C
		internal static int \u0005(int \u0002, int \u0003)
		{
			return \u0002 ^ (\u0003 - -(~(-(~(~(-(-(~(~-859698281)))))))) ^ \u0002 - \u0003);
		}
	}

	// Token: 0x0200000B RID: 11
	private sealed class \u0005
	{
		// Token: 0x0600001F RID: 31 RVA: 0x0000298C File Offset: 0x00000B8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int \u0002()
		{
			return \u0003\u2001.\u0003.\u0005(\u0003\u2001.\u0003.\u0003(\u0003\u2001.\u0002(typeof(\u0003\u2001.\u0006)), \u0003\u2001.\u0003.\u0005(\u0003\u2001.\u0002(typeof(\u0003\u2001.\u0005)), \u0003\u2001.\u0002(typeof(\u0003\u2001.\u000F)))), \u0003\u2001.\u0002\u2000.\u0002());
		}
	}

	// Token: 0x0200000C RID: 12
	private sealed class \u0006
	{
		// Token: 0x06000021 RID: 33 RVA: 0x000029E4 File Offset: 0x00000BE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int \u0002()
		{
			return \u0003\u2001.\u0003.\u0002(\u0003\u2001.\u0002(typeof(\u0003\u2001.\u0008)), \u0003\u2001.\u0002(typeof(\u0003\u2001.\u000E)) ^ \u0003\u2001.\u0003.\u0003(\u0003\u2001.\u0002(typeof(\u0003\u2001.\u0006)), \u0003\u2001.\u0003.\u0005(\u0003\u2001.\u0002(typeof(\u0003\u2001.\u0002\u2000)), \u0003\u2001.\u000E.\u0002())));
		}
	}

	// Token: 0x0200000D RID: 13
	private sealed class \u0008
	{
		// Token: 0x06000023 RID: 35 RVA: 0x00002A4C File Offset: 0x00000C4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int \u0002()
		{
			return \u0003\u2001.\u0003.\u0005(\u0003\u2001.\u0003.\u0002(\u0003\u2001.\u0006.\u0002() ^ -(~(-(~(~(-(~(-(~(-(~-527758448)))))))))), \u0003\u2001.\u0002(typeof(\u0003\u2001.\u000E))), \u0003\u2001.\u0003.\u0003(\u0003\u2001.\u0002(typeof(\u0003\u2001.\u0005)) ^ \u0003\u2001.\u0002(typeof(\u0003\u2001.\u0002\u2000)), -(~(-(~(-(~(~(-(~1367235172))))))))));
		}
	}

	// Token: 0x0200000E RID: 14
	private sealed class \u000E
	{
		// Token: 0x06000025 RID: 37 RVA: 0x00002AC4 File Offset: 0x00000CC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int \u0002()
		{
			return \u0003\u2001.\u0003.\u0005(\u0003\u2001.\u0002(typeof(\u0003\u2001.\u000E)), \u0003\u2001.\u0003.\u0002(\u0003\u2001.\u0002(typeof(\u0003\u2001.\u0005)), \u0003\u2001.\u0003.\u0003(\u0003\u2001.\u0002(typeof(\u0003\u2001.\u0006)), \u0003\u2001.\u0003.\u0005(\u0003\u2001.\u0002(typeof(\u0003\u2001.\u0008)), \u0003\u2001.\u0003.\u0002(\u0003\u2001.\u0002(typeof(\u0003\u2001.\u000F)), \u0003\u2001.\u0002(typeof(\u0003\u2001.\u0002\u2000)))))));
		}
	}

	// Token: 0x0200000F RID: 15
	private sealed class \u000F
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00002B4C File Offset: 0x00000D4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int \u0002()
		{
			return \u0003\u2001.\u0003.\u0003(\u0003\u2001.\u0003.\u0003(\u0003\u2001.\u0008.\u0002(), \u0003\u2001.\u0003.\u0002(\u0003\u2001.\u0002(typeof(\u0003\u2001.\u000F)), \u0003\u2001.\u0006.\u0002())), \u0003\u2001.\u0002(typeof(\u0003\u2001.\u0002\u2000)));
		}
	}
}
