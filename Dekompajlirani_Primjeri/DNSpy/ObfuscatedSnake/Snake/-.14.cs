using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x02000012 RID: 18
internal static class \u000F\u2000
{
	// Token: 0x0600002D RID: 45 RVA: 0x0000381C File Offset: 0x00001A1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long \u0002()
	{
		if (Assembly.GetCallingAssembly() != typeof(\u000F\u2000).Assembly || !\u000F\u2000.\u0002())
		{
			return 0L;
		}
		long result;
		lock (\u000F\u2000.\u0002)
		{
			long num = \u000F\u2000.\u0002.\u0002();
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
				int num2 = \u000F\u2000.\u0002(typeof(\u000F\u2000));
				int num3 = \u000F\u2000.\u0005.\u0002();
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
				num ^= -2321961055637633712L;
				\u000F\u2000.\u0002.\u0002(num);
			}
			result = num;
		}
		return result;
	}

	// Token: 0x0600002E RID: 46 RVA: 0x000039E4 File Offset: 0x00001BE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool \u0002()
	{
		return \u000F\u2000.\u0003();
	}

	// Token: 0x0600002F RID: 47 RVA: 0x000039F0 File Offset: 0x00001BF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool \u0003()
	{
		StackTrace stackTrace = new StackTrace();
		StackFrame frame = stackTrace.GetFrame(3);
		MethodBase methodBase = (frame == null) ? null : frame.GetMethod();
		Type type = (methodBase == null) ? null : methodBase.DeclaringType;
		return type != typeof(RuntimeMethodHandle) && type != null && type.Assembly == typeof(\u000F\u2000).Assembly;
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00003A54 File Offset: 0x00001C54
	private static int \u0002(Type \u0002)
	{
		return \u0002.MetadataToken;
	}

	// Token: 0x04000014 RID: 20
	private static \u000F\u2000.\u0002 \u0002 = new \u000F\u2000.\u0002();

	// Token: 0x02000013 RID: 19
	private sealed class \u0002
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00003A5C File Offset: 0x00001C5C
		internal \u0002()
		{
			this.\u0002(0L);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003A6C File Offset: 0x00001C6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal long \u0002()
		{
			if (Assembly.GetCallingAssembly() != typeof(\u000F\u2000.\u0002).Assembly)
			{
				return 2918384L;
			}
			if (!\u000F\u2000.\u0002())
			{
				return 2918384L;
			}
			int[] array = new int[]
			{
				0,
				0,
				0,
				~(-(~(-(-(~(~(-(~549419311))))))))
			};
			array[1] = -(~(-(~(-(~(~(-(~(-(~642810094))))))))));
			array[2] = -(~(-(~(~(-(~(-(~(-(~-1579114406))))))))));
			array[0] = -(~(~(-(~(-(~(-(~-1431756118))))))));
			int num = this.\u0002;
			int num2 = this.\u0003;
			int num3 = ~(-(~(-(-(~(~(-(~1640531524))))))));
			int num4 = ~(-(-(~(~(-(~(-(-(~(~957401310))))))))));
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

		// Token: 0x06000033 RID: 51 RVA: 0x00003B88 File Offset: 0x00001D88
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void \u0002(long \u0002)
		{
			if (Assembly.GetCallingAssembly() != typeof(\u000F\u2000.\u0002).Assembly)
			{
				return;
			}
			if (!\u000F\u2000.\u0002())
			{
				return;
			}
			int[] array = new int[4];
			array[1] = -(~(~(-(~(-(-(~(-(~(~642810094))))))))));
			array[0] = -(~(-(~(~(-(-(~(~(-(~-1431756115))))))))));
			array[2] = ~(-(~(-(-(~(~(-(~-1579114407))))))));
			array[3] = -(~(~(-(~(-(-(~(~(-(~549419312))))))))));
			int num = -(~(~(-(~(-(-(~(~(-(~1640531525))))))))));
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

		// Token: 0x04000015 RID: 21
		private int \u0002;

		// Token: 0x04000016 RID: 22
		private int \u0003;
	}

	// Token: 0x02000014 RID: 20
	private sealed class \u0002\u2000
	{
		// Token: 0x06000035 RID: 53 RVA: 0x00003C90 File Offset: 0x00001E90
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int \u0002()
		{
			return \u000F\u2000.\u0003.\u0002(\u000F\u2000.\u0002(typeof(\u000F\u2000.\u0002\u2000)), \u000F\u2000.\u0003.\u0005(\u000F\u2000.\u0003.\u0003(\u000F\u2000.\u0002(typeof(\u000F\u2000.\u000F)), \u000F\u2000.\u0002(typeof(\u000F\u2000.\u0005))), \u000F\u2000.\u0003.\u0005(\u000F\u2000.\u0002(typeof(\u000F\u2000.\u0008)) ^ ~(-(~(-(-(~(~(-(~1140344186)))))))), \u000F\u2000.\u000F.\u0002())));
		}
	}

	// Token: 0x02000015 RID: 21
	private static class \u0003
	{
		// Token: 0x06000036 RID: 54 RVA: 0x00003D04 File Offset: 0x00001F04
		internal static int \u0002(int \u0002, int \u0003)
		{
			return \u0002 ^ \u0003 - ~(-(-(~(~(-(~(-(-(~(~-2022811286))))))))));
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00003D1C File Offset: 0x00001F1C
		internal static int \u0003(int \u0002, int \u0003)
		{
			return \u0002 - -(~(-(~(-(~(~(-(~1689796184)))))))) ^ \u0003 + -(~(-(~(-(~(~(-(~-1823220423))))))));
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00003D40 File Offset: 0x00001F40
		internal static int \u0005(int \u0002, int \u0003)
		{
			return \u0002 ^ (\u0003 - ~(-(-(~(~(-(~(-(-(~(~-269855288)))))))))) ^ \u0002 - \u0003);
		}
	}

	// Token: 0x02000016 RID: 22
	private sealed class \u0005
	{
		// Token: 0x0600003A RID: 58 RVA: 0x00003D64 File Offset: 0x00001F64
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int \u0002()
		{
			return \u000F\u2000.\u0003.\u0005(\u000F\u2000.\u0003.\u0003(\u000F\u2000.\u0002(typeof(\u000F\u2000.\u0006)), \u000F\u2000.\u0003.\u0005(\u000F\u2000.\u0002(typeof(\u000F\u2000.\u0005)), \u000F\u2000.\u0002(typeof(\u000F\u2000.\u000F)))), \u000F\u2000.\u0002\u2000.\u0002());
		}
	}

	// Token: 0x02000017 RID: 23
	private sealed class \u0006
	{
		// Token: 0x0600003C RID: 60 RVA: 0x00003DBC File Offset: 0x00001FBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int \u0002()
		{
			return \u000F\u2000.\u0003.\u0002(\u000F\u2000.\u0002(typeof(\u000F\u2000.\u0008)), \u000F\u2000.\u0002(typeof(\u000F\u2000.\u000E)) ^ \u000F\u2000.\u0003.\u0003(\u000F\u2000.\u0002(typeof(\u000F\u2000.\u0006)), \u000F\u2000.\u0003.\u0005(\u000F\u2000.\u0002(typeof(\u000F\u2000.\u0002\u2000)), \u000F\u2000.\u000E.\u0002())));
		}
	}

	// Token: 0x02000018 RID: 24
	private sealed class \u0008
	{
		// Token: 0x0600003E RID: 62 RVA: 0x00003E24 File Offset: 0x00002024
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int \u0002()
		{
			return \u000F\u2000.\u0003.\u0005(\u000F\u2000.\u0003.\u0002(\u000F\u2000.\u0006.\u0002() ^ -(~(-(~(~(-(-(~(~-527758445)))))))), \u000F\u2000.\u0002(typeof(\u000F\u2000.\u000E))), \u000F\u2000.\u0003.\u0003(\u000F\u2000.\u0002(typeof(\u000F\u2000.\u0005)) ^ \u000F\u2000.\u0002(typeof(\u000F\u2000.\u0002\u2000)), -(~(~(-(~(-(~(-(~396877143))))))))));
		}
	}

	// Token: 0x02000019 RID: 25
	private sealed class \u000E
	{
		// Token: 0x06000040 RID: 64 RVA: 0x00003E98 File Offset: 0x00002098
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int \u0002()
		{
			return \u000F\u2000.\u0003.\u0005(\u000F\u2000.\u0002(typeof(\u000F\u2000.\u000E)), \u000F\u2000.\u0003.\u0002(\u000F\u2000.\u0002(typeof(\u000F\u2000.\u0005)), \u000F\u2000.\u0003.\u0003(\u000F\u2000.\u0002(typeof(\u000F\u2000.\u0006)), \u000F\u2000.\u0003.\u0005(\u000F\u2000.\u0002(typeof(\u000F\u2000.\u0008)), \u000F\u2000.\u0003.\u0002(\u000F\u2000.\u0002(typeof(\u000F\u2000.\u000F)), \u000F\u2000.\u0002(typeof(\u000F\u2000.\u0002\u2000)))))));
		}
	}

	// Token: 0x0200001A RID: 26
	private sealed class \u000F
	{
		// Token: 0x06000042 RID: 66 RVA: 0x00003F20 File Offset: 0x00002120
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int \u0002()
		{
			return \u000F\u2000.\u0003.\u0003(\u000F\u2000.\u0003.\u0003(\u000F\u2000.\u0008.\u0002(), \u000F\u2000.\u0003.\u0002(\u000F\u2000.\u0002(typeof(\u000F\u2000.\u000F)), \u000F\u2000.\u0006.\u0002())), \u000F\u2000.\u0002(typeof(\u000F\u2000.\u0002\u2000)));
		}
	}
}
