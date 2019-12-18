using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x0200000A RID: 10
internal static class \u0006\u2000
{
	// Token: 0x06000016 RID: 22 RVA: 0x0000242C File Offset: 0x0000062C
	[MethodImpl(MethodImplOptions.NoInlining)]
	static \u0006\u2000()
	{
		int num = 1566722180;
		int num2 = num ^ -80144619;
		\u0006\u2000.\u0002 = new Dictionary<int, string>(18);
		int num3 = 2;
		StackTrace stackTrace = new StackTrace(num3, false);
		num3 -= 2;
		StackFrame frame = stackTrace.GetFrame(num3);
		int num4 = num3;
		if (frame == null)
		{
			stackTrace = new StackTrace();
			num4 = 1;
			frame = stackTrace.GetFrame(num4);
		}
		int num5 = -(~(~(-(~(-(-(~(-(~(~(-1155816376 + num - num2))))))))))) ^ -(~(-(~(~(-(~(-(-(~(~(-1467922927 - num ^ num2)))))))))));
		MethodBase methodBase = (frame != null) ? frame.GetMethod() : null;
		if (frame != null)
		{
			num5 ^= ~(-(-(~(~(-(-(~(-(~(~((-826075371 ^ num) - num2)))))))))));
		}
		Type type = (methodBase != null) ? methodBase.DeclaringType : null;
		if (type == typeof(RuntimeMethodHandle))
		{
			\u0006\u2000.\u0003\u2000 = ((\u0006\u2000.\u0002)4 | \u0006\u2000.\u0003\u2000);
			num5 ^= (num + 1224283186 ^ num2) + num3;
		}
		else if (type == null)
		{
			if (\u0006\u2000.\u0002(stackTrace, num4))
			{
				\u0006\u2000.\u0003\u2000 = ((\u0006\u2000.\u0002)16 | \u0006\u2000.\u0003\u2000);
				num5 ^= -(~(~(-(-(~(-(~(~((-80131798 ^ num) - num2))))))))) - num3;
			}
			else
			{
				num5 ^= -(~(~(-(~(-(-(~(~(-(~(-62798029 + num + num2)))))))))));
				\u0006\u2000.\u0003\u2000 = ((\u0006\u2000.\u0002)1 | \u0006\u2000.\u0003\u2000);
			}
		}
		else
		{
			\u0006\u2000.\u0003\u2000 = ((\u0006\u2000.\u0002)16 | \u0006\u2000.\u0003\u2000);
			num5 ^= -(~(-(~(~(-(-(~(~(-1224260080 - num ^ num2))))))))) - num3;
		}
		\u0006\u2000.\u0002\u2000 += num5;
	}

	// Token: 0x06000017 RID: 23 RVA: 0x000025A4 File Offset: 0x000007A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static string \u0002(int \u0002)
	{
		Dictionary<int, string> u = \u0006\u2000.\u0002;
		string result;
		lock (u)
		{
			string text;
			if (\u0006\u2000.\u0002.TryGetValue(\u0002, out text))
			{
				result = text;
			}
			else
			{
				result = \u0006\u2000.\u0002(\u0002, true);
			}
		}
		return result;
	}

	// Token: 0x06000018 RID: 24 RVA: 0x000025F4 File Offset: 0x000007F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string \u0002(int \u0002, bool \u0003)
	{
		int num = -2122777739;
		int num2 = 1875596143 + num;
		string text = null;
		byte[] array;
		int num20;
		do
		{
			int num7;
			if (\u0006\u2000.\u0003 == null)
			{
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				Assembly u = Assembly.GetCallingAssembly();
				\u0006\u2000.\u0006 |= (num ^ -1884505877) + num2;
				Assembly assembly = executingAssembly;
				StringBuilder stringBuilder = new StringBuilder();
				int num3 = 1387883108 - num ^ num2;
				stringBuilder.Append((char)(num3 >> 16)).Append((char)num3);
				num3 = num + -1882426510 - num2;
				stringBuilder.Append((char)(num3 >> 16)).Append((char)num3);
				num3 = -1338717028 - num + num2;
				stringBuilder.Append((char)(num3 >> 16)).Append((char)num3);
				num3 = num + -1882164360 - num2;
				stringBuilder.Append((char)(num3 >> 16)).Append((char)num3);
				num3 = (1388800610 - num ^ num2);
				stringBuilder.Append((char)num3).Append((char)(num3 >> 16));
				num3 = -1387801169 + num + num2;
				stringBuilder.Append((char)(num3 >> 16)).Append((char)num3);
				num3 = (1883018651 ^ num ^ num2);
				stringBuilder.Append((char)num3);
				Stream manifestResourceStream = assembly.GetManifestResourceStream(stringBuilder.ToString());
				int num4 = 2;
				StackTrace stackTrace = new StackTrace(num4, false);
				\u0006\u2000.\u0006 ^= (-1875589673 - num + num2 | num4);
				num4 -= 2;
				StackFrame frame = stackTrace.GetFrame(num4);
				int num5 = num4;
				if (frame == null)
				{
					stackTrace = new StackTrace();
					num5 = 1;
					frame = stackTrace.GetFrame(num5);
				}
				MethodBase methodBase = (frame != null) ? frame.GetMethod() : null;
				\u0006\u2000.\u0006 ^= num4 + ((num ^ 1883026449) - num2);
				Type type = (methodBase != null) ? methodBase.DeclaringType : null;
				if (frame == null)
				{
					\u0006\u2000.\u0006 ^= (1925190092 - num ^ num2);
				}
				bool flag = type == typeof(RuntimeMethodHandle);
				\u0006\u2000.\u0006 ^= (num ^ -1883026743) + num2;
				if (!flag)
				{
					flag = (type == null);
					if (flag)
					{
						if (\u0006\u2000.\u0002(stackTrace, num5))
						{
							flag = false;
						}
						else
						{
							\u0006\u2000.\u0006 ^= (1925190124 - num ^ num2);
						}
					}
				}
				if (flag == (stackTrace != null))
				{
					\u0006\u2000.\u0006 ^= 32;
				}
				\u0006\u2000.\u0006 ^= ((num ^ 1883018047) - num2 | num4 + 1);
				\u0006\u2000.\u0003 = new \u0006\u2000.\u0003(manifestResourceStream);
				short num6 = \u0006\u2000.\u0003.\u0002() ^ (short)(-(short)(~(short)(~(short)(-(short)(-(short)(~(short)(-(short)(~(short)(~(short)(-(short)(~(short)(-1925016785 + num + num2))))))))))));
				if (num6 == 0)
				{
					\u0006\u2000.\u0008 = (\u0006\u2000.\u0003.\u0002() ^ (short)(-(short)(~(short)(~(short)(-(short)(-(short)(~(short)(-(short)(~(short)(-(short)(~(short)(~(short)(1924989800 - num - num2)))))))))))));
				}
				else
				{
					\u0006\u2000.\u0005 = \u0006\u2000.\u0003.\u0002((int)num6);
				}
				u = executingAssembly;
				AssemblyName u2 = \u0006\u2000.\u0002(u);
				\u0006\u2000.\u000E = \u0006\u2000.\u0002(u2);
				num7 = \u0006\u2000.\u0002\u2000;
				num7 ^= (num + 407773106 ^ num2);
				\u0006\u2000.\u0002\u2000 = 0;
				long num8 = \u000F\u2000.\u0002();
				num7 ^= (int)((uint)num8);
				num7 ^= (num ^ -2098810788) - num2;
				int num9 = num7;
				int num10 = num9;
				int num11 = 0;
				int num12 = (-717736264 - num ^ num2) + num10 ^ -659912509 + num + num2;
				int num13 = num12 * (num ^ 1883021628 ^ num2) % (1952749638 - num - num2);
				int u3 = num13;
				\u0002\u2000<int> enumerator = ((\u0006<int>)new \u0005.\u0002(num + -1925007963 | num2)
				{
					\u0006 = u3
				}).GetEnumerator();
				try
				{
					while (enumerator.\u000E\u2005\u2006\u0002())
					{
						int num14 = enumerator.\u000E\u2005\u2006\u0002();
						num13 ^= num14 - num11;
						num11 += num13 >> 1;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						enumerator.\u000F\u2005\u2006\u0002();
					}
				}
				int num15 = num13;
				num7 ^= -(~(~(-(~(-(~(-(~(-83055000 ^ num ^ num2)))))))));
				num7 = num15 + num7;
				\u0006\u2000.\u0006 = ((\u0006\u2000.\u0006 & 2144031457 + num - num2) ^ (1925009365 - num ^ num2));
				\u0006\u2000.\u000F = num7;
				if ((\u0006\u2000.\u0003\u2000 & -(~(-(~(-(~(~(-(-(~(~(num + (\u0006\u2000.\u0002)1875596129 - num2)))))))))))) == (\u0006\u2000.\u0002)0)
				{
					\u0006\u2000.\u0006 = (1925046483 - num ^ num2);
				}
			}
			else
			{
				num7 = \u0006\u2000.\u000F;
			}
			if (\u0006\u2000.\u0006 == num + -1924963999 + num2)
			{
				goto Block_14;
			}
			int num16 = \u0002 ^ -499652743 - num - num2 ^ num7;
			num16 ^= num + -1768267034 + num2;
			\u0006\u2000.\u0003.\u0002().Position = (long)num16;
			if (\u0006\u2000.\u0005 != null)
			{
				array = \u0006\u2000.\u0005;
			}
			else
			{
				short num17;
				if (\u0006\u2000.\u0008 == -1)
				{
					num17 = (short)((int)\u0006\u2000.\u0003.\u0002() ^ (1883041456 ^ num) - num2 ^ num16);
				}
				else
				{
					num17 = \u0006\u2000.\u0008;
				}
				if (num17 == 0)
				{
					array = null;
				}
				else
				{
					array = \u0006\u2000.\u0003.\u0002((int)num17);
					for (int num18 = 0; num18 != array.Length; num18 = 1 + num18)
					{
						byte[] array2 = array;
						int num19 = num18;
						array2[num19] ^= (byte)(\u0006\u2000.\u000F >> ((num18 & 3) << 3));
					}
				}
			}
			num20 = (\u0006\u2000.\u0003.\u0002() ^ num16 ^ -(~(-(~(-(~(~(-(~(-(~(num + 1043875348 + num2))))))))))) ^ num7);
			if (num20 != ((num ^ -1883026833) | num2))
			{
				goto IL_57D;
			}
			byte[] array3 = \u0006\u2000.\u0003.\u0002(4);
			\u0002 = (-1093287166 + num - num2 ^ num7);
			\u0002 = (((int)array3[2] | (int)array3[3] << 16 | (int)array3[0] << 8 | (int)array3[1] << 24) ^ -\u0002);
		}
		while (!\u0006\u2000.\u0002.TryGetValue(\u0002, out text));
		return text;
		Block_14:
		text = new string(new char[]
		{
			(char)(1925008049 - num - num2),
			'0',
			(char)(1875596103 + num ^ num2)
		});
		return text;
		IL_57D:
		bool flag2 = (num20 & 271887505 - num + num2) != 0;
		bool flag3 = (num20 & -1882500241 + num - num2) != 0;
		bool flag4 = (num20 & (809285009 ^ num ^ num2)) != 0;
		num20 &= 2144031598 + num - num2;
		byte[] array4 = array;
		byte[] array5 = \u0006\u2000.\u0003.\u0002(num20);
		byte[] array6 = array4;
		byte b = array6[1];
		int num21 = array5.Length;
		byte b2 = (byte)(11 + num21 ^ (int)(b + 7));
		uint num22 = (uint)(((int)array6[0] | (int)array6[2] << 8) + ((int)b2 << 3));
		ushort num23 = 0;
		int i = 0;
		while (i < num21)
		{
			if ((i & 1) == 0)
			{
				num22 = num22 * (uint)(1925187726 - num ^ num2) + (uint)(num + 1878127154 - num2);
				num23 = (ushort)(num22 >> 16);
			}
			byte b3 = (byte)num23;
			num23 = (ushort)(num23 >> 8);
			byte b4 = array5[i];
			array5[i] = (b ^ b4 ^ 3 + b2 ^ b3);
			i = 1 + i;
			b2 = b4;
		}
		byte[] array7 = array5;
		if (\u0006\u2000.\u000E != null != (\u0006\u2000.\u0006 != (1926611415 - num ^ num2)))
		{
			for (int j = 0; j < num20; j = 1 + j)
			{
				byte b5 = \u0006\u2000.\u000E[7 & j];
				b5 = (byte)((int)b5 << 3 | b5 >> 5);
				array7[j] ^= b5;
			}
		}
		int num24 = \u0006\u2000.\u0006 - 12;
		byte[] array8;
		int num25;
		if (!flag3)
		{
			array8 = array7;
			num25 = num20;
		}
		else
		{
			num25 = ((int)array7[2] | (int)array7[0] << 16 | (int)array7[3] << 8 | (int)array7[1] << 24);
			array8 = new byte[num25];
			\u0006\u2000.\u0002(array7, 4, array8);
		}
		if (flag2 && num24 == num + 1877203945 - num2)
		{
			char[] array9 = new char[num25];
			for (int k = 0; k < num25; k = 1 + k)
			{
				array9[k] = (char)array8[k];
			}
			text = new string(array9);
		}
		else
		{
			text = Encoding.Unicode.GetString(array8, 0, array8.Length);
		}
		num24 += (1925007888 - num ^ num2) + (num24 & 3) << 5;
		if (num24 != -1923396031 + num + num2)
		{
			int num26 = num20 + \u0002 ^ (num ^ 1881825833) - num2 ^ (num24 & num + -1925006668 + num2);
			StringBuilder stringBuilder = new StringBuilder();
			int num3 = 1883026889 ^ num ^ num2;
			stringBuilder.Append((char)((byte)num3));
			text = num26.ToString(stringBuilder.ToString());
		}
		if (!flag4 && \u0003)
		{
			text = string.Intern(text);
			\u0006\u2000.\u0002[\u0002] = text;
			if (\u0006\u2000.\u0002.Count == 18)
			{
				\u0006\u2000.\u0003.\u0003();
				\u0006\u2000.\u0003 = null;
				\u0006\u2000.\u0005 = null;
				\u0006\u2000.\u000E = null;
			}
		}
		return text;
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002E18 File Offset: 0x00001018
	private static AssemblyName \u0002(Assembly \u0002)
	{
		AssemblyName result;
		try
		{
			result = \u0002.GetName();
		}
		catch
		{
			result = new AssemblyName(\u0002.FullName);
		}
		return result;
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00002E50 File Offset: 0x00001050
	private static byte[] \u0002(AssemblyName \u0002)
	{
		byte[] array = \u0002.GetPublicKeyToken();
		if (array != null && array.Length == 0)
		{
			array = null;
		}
		return array;
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002E70 File Offset: 0x00001070
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool \u0002(StackTrace \u0002, int \u0003)
	{
		StackFrame frame = \u0002.GetFrame(++\u0003);
		Assembly assembly;
		if (frame == null)
		{
			assembly = null;
		}
		else
		{
			MethodBase method = frame.GetMethod();
			if (method == null)
			{
				assembly = null;
			}
			else
			{
				Type declaringType = method.DeclaringType;
				assembly = ((declaringType != null) ? declaringType.Assembly : null);
			}
		}
		Assembly assembly2 = assembly;
		if (assembly2 != null)
		{
			AssemblyName u = \u0006\u2000.\u0002(assembly2);
			byte[] array = \u0006\u2000.\u0002(u);
			if (array != null && array.Length == 8 && array[0] == 183 && array[7] == 137)
			{
				return true;
			}
		}
		do
		{
			frame = \u0002.GetFrame(++\u0003);
			if (frame == null)
			{
				return false;
			}
			MethodBase method2 = frame.GetMethod();
			Assembly assembly3;
			if (method2 == null)
			{
				assembly3 = null;
			}
			else
			{
				Type declaringType2 = method2.DeclaringType;
				assembly3 = ((declaringType2 != null) ? declaringType2.Assembly : null);
			}
			assembly2 = assembly3;
		}
		while (assembly2 == null || assembly2 != typeof(\u0006\u2000).Assembly);
		return true;
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00002F2C File Offset: 0x0000112C
	private static void \u0002(byte[] \u0002, int \u0003, byte[] \u0005)
	{
		int i = 0;
		int num = 0;
		int num2 = 128;
		int num3 = \u0005.Length;
		while (i < num3)
		{
			if ((num2 <<= 1) == 256)
			{
				num2 = 1;
				num = (int)\u0002[\u0003++];
			}
			if ((num & num2) != 0)
			{
				int num4 = (\u0002[\u0003] >> 2) + 3;
				int num5 = ((int)\u0002[\u0003] << 8 | (int)\u0002[\u0003 + 1]) & 1023;
				\u0003 += 2;
				int num6 = i - num5;
				if (num6 < 0)
				{
					return;
				}
				while (--num4 >= 0)
				{
					if (i >= num3)
					{
						break;
					}
					\u0005[i++] = \u0005[num6++];
				}
			}
			else
			{
				\u0005[i++] = \u0002[\u0003++];
			}
		}
	}

	// Token: 0x04000008 RID: 8
	private static \u0006\u2000.\u0003 \u0003;

	// Token: 0x04000009 RID: 9
	private static byte[] \u0005;

	// Token: 0x0400000A RID: 10
	private static int \u000F;

	// Token: 0x0400000B RID: 11
	private static short \u0008;

	// Token: 0x0400000C RID: 12
	private static \u0006\u2000.\u0002 \u0003\u2000;

	// Token: 0x0400000D RID: 13
	private static int \u0002\u2000;

	// Token: 0x0400000E RID: 14
	private static int \u0006;

	// Token: 0x0400000F RID: 15
	private static byte[] \u000E;

	// Token: 0x04000010 RID: 16
	private static Dictionary<int, string> \u0002;

	// Token: 0x0200000B RID: 11
	private enum \u0002
	{

	}

	// Token: 0x0200000C RID: 12
	private sealed class \u0003
	{
		// Token: 0x0600001D RID: 29 RVA: 0x00002FD0 File Offset: 0x000011D0
		public \u0003(Stream \u0002)
		{
			this.\u0002 = \u0002;
			this.\u0003 = new byte[4];
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002FEC File Offset: 0x000011EC
		public Stream \u0002()
		{
			return this.\u0002;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002FF4 File Offset: 0x000011F4
		public short \u0002()
		{
			this.\u0002(2);
			return (short)((int)this.\u0003[0] | (int)this.\u0003[1] << 8);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003014 File Offset: 0x00001214
		public int \u0002()
		{
			this.\u0002(4);
			return (int)this.\u0003[0] | (int)this.\u0003[1] << 8 | (int)this.\u0003[2] << 16 | (int)this.\u0003[3] << 24;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003048 File Offset: 0x00001248
		private void \u0002()
		{
			throw new EndOfStreamException();
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003050 File Offset: 0x00001250
		private void \u0002(int \u0002)
		{
			int num = 0;
			if (\u0002 == 1)
			{
				int num2 = this.\u0002.ReadByte();
				if (num2 == -1)
				{
					this.\u0002();
				}
				this.\u0003[0] = (byte)num2;
				return;
			}
			do
			{
				int num2 = this.\u0002.Read(this.\u0003, num, \u0002 - num);
				if (num2 == 0)
				{
					this.\u0002();
				}
				num += num2;
			}
			while (num < \u0002);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000030B0 File Offset: 0x000012B0
		public void \u0003()
		{
			Stream u = this.\u0002;
			this.\u0002 = null;
			if (u != null)
			{
				u.Close();
			}
			this.\u0003 = null;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000030DC File Offset: 0x000012DC
		public byte[] \u0002(int \u0002)
		{
			if (\u0002 < 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			byte[] array = new byte[\u0002];
			int num = 0;
			do
			{
				int num2 = this.\u0002.Read(array, num, \u0002);
				if (num2 == 0)
				{
					break;
				}
				num += num2;
				\u0002 -= num2;
			}
			while (\u0002 > 0);
			if (num != array.Length)
			{
				byte[] array2 = new byte[num];
				Buffer.BlockCopy(array, 0, array2, 0, num);
				array = array2;
			}
			return array;
		}

		// Token: 0x04000012 RID: 18
		private Stream \u0002;

		// Token: 0x04000013 RID: 19
		private byte[] \u0003;
	}
}
