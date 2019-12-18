using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x0200001C RID: 28
internal static class \u000F\u2000
{
	// Token: 0x060000A3 RID: 163 RVA: 0x00014E98 File Offset: 0x00013098
	[MethodImpl(MethodImplOptions.NoInlining)]
	static \u000F\u2000()
	{
		int num = -297420002;
		int num2 = num ^ -905966255;
		\u000F\u2000.\u0002 = new Dictionary<int, string>(311128851 - num ^ num2);
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
		int num5 = ~(-(-(~(~(-(~(-(-(~(~(1344833892 + num - num2))))))))))) ^ ~(-(-(~(~(-(~(-(~(-(~(-1220161675 - num ^ num2)))))))))));
		MethodBase methodBase = (frame != null) ? frame.GetMethod() : null;
		if (frame != null)
		{
			num5 ^= ~(-(-(~(-(~(~(-(-(~(~((-3273391 ^ num) - num2)))))))))));
		}
		Type type = (methodBase != null) ? methodBase.DeclaringType : null;
		if (type == typeof(RuntimeMethodHandle))
		{
			\u000F\u2000.\u0003\u2000 = ((\u000F\u2000.\u0002)4 | \u000F\u2000.\u0003\u2000);
			num5 ^= (311128198 - num ^ num2) + num3;
		}
		else if (type == null)
		{
			if (\u000F\u2000.\u0002(stackTrace, num4))
			{
				\u000F\u2000.\u0003\u2000 = ((\u000F\u2000.\u0002)16 | \u000F\u2000.\u0003\u2000);
				num5 ^= ~(-(-(~(-(~(-(~(~(-(~(num + -311152465 + num2))))))))))) - num3;
			}
			else
			{
				num5 ^= -(~(-(~(-(~(~(-(~(905929242 ^ num ^ num2)))))))));
				\u000F\u2000.\u0003\u2000 |= (\u000F\u2000.\u0002)1;
			}
		}
		else
		{
			\u000F\u2000.\u0003\u2000 = ((\u000F\u2000.\u0002)16 | \u000F\u2000.\u0003\u2000);
			num5 ^= -(~(-(~(-(~(~(-(~(num + -311152464 + num2))))))))) - num3;
		}
		\u000F\u2000.\u0002\u2000 += num5;
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x00015014 File Offset: 0x00013214
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static string \u0002(int \u0002)
	{
		Dictionary<int, string> u = \u000F\u2000.\u0002;
		string result;
		lock (u)
		{
			string text;
			if (\u000F\u2000.\u0002.TryGetValue(\u0002, out text))
			{
				result = text;
			}
			else
			{
				result = \u000F\u2000.\u0002(\u0002, true);
			}
		}
		return result;
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x00015064 File Offset: 0x00013264
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string \u0002(int \u0002, bool \u0003)
	{
		int num = 710889651;
		int num2 = -199636051 - num;
		string text = null;
		byte[] array;
		int num20;
		do
		{
			int num7;
			if (\u000F\u2000.\u0003 == null)
			{
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				Assembly u = Assembly.GetCallingAssembly();
				\u000F\u2000.\u0006 |= (-477340209 ^ num) - num2;
				Assembly assembly = executingAssembly;
				StringBuilder stringBuilder = new StringBuilder();
				int num3 = num + 737236062 + num2;
				stringBuilder.Append((char)(num3 >> 16)).Append((char)num3);
				num3 = (336636844 - num ^ num2);
				stringBuilder.Append((char)(num3 >> 16)).Append((char)num3);
				num3 = (num ^ -1008677961) - num2;
				stringBuilder.Append((char)(num3 >> 16)).Append((char)num3);
				num3 = num + 736580699 + num2;
				stringBuilder.Append((char)(num3 >> 16)).Append((char)num3);
				num3 = (-1008727477 ^ num ^ num2);
				stringBuilder.Append((char)num3).Append((char)(num3 >> 16));
				num3 = 737039450 + num + num2;
				stringBuilder.Append((char)(num3 >> 16)).Append((char)num3);
				num3 = (num ^ -471479732) - num2;
				stringBuilder.Append((char)num3);
				Stream manifestResourceStream = assembly.GetManifestResourceStream(stringBuilder.ToString());
				int num4 = 2;
				StackTrace stackTrace = new StackTrace(num4, false);
				\u000F\u2000.\u0006 ^= ((-199642001 - num ^ num2) | num4);
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
				\u000F\u2000.\u0006 ^= num4 + ((num ^ 471520565) + num2);
				Type type = (methodBase != null) ? methodBase.DeclaringType : null;
				if (frame == null)
				{
					\u000F\u2000.\u0006 ^= (-1621503594 + num ^ num2);
				}
				bool flag = type == typeof(RuntimeMethodHandle);
				\u000F\u2000.\u0006 ^= 1621415513 - num + num2;
				if (!flag)
				{
					flag = (type == null);
					if (flag)
					{
						if (\u000F\u2000.\u0002(stackTrace, num5))
						{
							flag = false;
						}
						else
						{
							\u000F\u2000.\u0006 ^= (num ^ -471694530) - num2;
						}
					}
				}
				if (flag == (stackTrace != null))
				{
					\u000F\u2000.\u0006 ^= 32;
				}
				\u000F\u2000.\u0006 ^= (199642553 + num + num2 | 1 + num4);
				\u000F\u2000.\u0003 = new \u000F\u2000.\u0003(manifestResourceStream);
				short num6 = \u000F\u2000.\u0003.\u0002() ^ (short)(~(short)(-(short)(~(short)(-(short)(-(short)(~(short)(~(short)(-(short)(~(short)(-199617313 - num - num2))))))))));
				if (num6 == 0)
				{
					\u000F\u2000.\u0008 = (\u000F\u2000.\u0003.\u0002() ^ (short)(-(short)(~(short)(~(short)(-(short)(~(short)(-(short)(~(short)(-(short)(~(short)((num ^ 471500284) + num2)))))))))));
				}
				else
				{
					\u000F\u2000.\u0005 = \u000F\u2000.\u0003.\u0002((int)num6);
				}
				u = executingAssembly;
				AssemblyName u2 = \u000F\u2000.\u0002(u);
				\u000F\u2000.\u000E = \u000F\u2000.\u0002(u2);
				num7 = \u000F\u2000.\u0002\u2000;
				num7 ^= (-879198228 - num ^ num2);
				\u000F\u2000.\u0002\u2000 = 0;
				long num8 = \u0003\u2001.\u0002();
				num7 ^= (int)((uint)num8);
				num7 ^= -1313528180 + num - num2;
				int num9 = num7;
				int num10 = num9;
				int num11 = 0;
				int num12 = (num ^ 1092509678 ^ num2) + num10 ^ -1408456491 - num + num2;
				int num13 = num12 * (num + -1621410060 - num2) % (-226719798 - num ^ num2);
				int u3 = num13;
				\u0003\u2000<int> enumerator = ((\u000E<int>)new \u0008.\u0002(199636049 + num | num2)
				{
					\u0006 = u3
				}).GetEnumerator();
				try
				{
					while (enumerator.\u000F\u200A\u2007\u2005\u2002\u0002())
					{
						int num14 = enumerator.\u000F\u200A\u2007\u2005\u2002\u0002();
						num13 ^= num14 - num11;
						num11 += num13 >> 1;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						enumerator.\u0002\u2000\u200A\u2007\u2005\u2002\u0002();
					}
				}
				int num15 = num13;
				num7 ^= ~(-(-(~(-(~(-(~(~(-(~(-545623323 - num + num2)))))))))));
				num7 = num15 + num7;
				\u000F\u2000.\u0006 = ((\u000F\u2000.\u0006 & (-333785797 ^ num ^ num2)) ^ num + -1621408565 - num2);
				\u000F\u2000.\u000F = num7;
				if ((\u000F\u2000.\u0003\u2000 & (\u000F\u2000.\u0002)(-(\u000F\u2000.\u0002)(~(\u000F\u2000.\u0002)(-(\u000F\u2000.\u0002)(~(\u000F\u2000.\u0002)(~(\u000F\u2000.\u0002)(-(\u000F\u2000.\u0002)(~(\u000F\u2000.\u0002)(-(\u000F\u2000.\u0002)(~(\u000F\u2000.\u0002)(-(\u000F\u2000.\u0002)(~(\u000F\u2000.\u0002)((num ^ 471520327) + num2))))))))))))) == (\u000F\u2000.\u0002)0)
				{
					\u000F\u2000.\u0006 = -199592089 - num - num2;
				}
			}
			else
			{
				num7 = \u000F\u2000.\u000F;
			}
			if (\u000F\u2000.\u0006 == (471425139 ^ num) + num2)
			{
				goto Block_14;
			}
			int num16 = \u0002 ^ 1472800031 + num - num2 ^ num7;
			num16 ^= (-347264904 - num ^ num2);
			\u000F\u2000.\u0003.\u0002().Position = (long)num16;
			if (\u000F\u2000.\u0005 != null)
			{
				array = \u000F\u2000.\u0005;
			}
			else
			{
				short num17;
				if (\u000F\u2000.\u0008 == -1)
				{
					num17 = (short)((int)\u000F\u2000.\u0003.\u0002() ^ num + 199613758 + num2 ^ num16);
				}
				else
				{
					num17 = \u000F\u2000.\u0008;
				}
				if (num17 == 0)
				{
					array = null;
				}
				else
				{
					array = \u000F\u2000.\u0003.\u0002((int)num17);
					for (int num18 = 0; num18 != array.Length; num18 = 1 + num18)
					{
						byte[] array2 = array;
						int num19 = num18;
						array2[num19] ^= (byte)(\u000F\u2000.\u000F >> ((3 & num18) << 3));
					}
				}
			}
			num20 = (\u000F\u2000.\u0003.\u0002() ^ num16 ^ -(~(-(~(~(-(~(-(-(~(~((342669397 ^ num) - num2))))))))))) ^ num7);
			if (num20 != (1621415351 - num | num2))
			{
				goto IL_57B;
			}
			byte[] array3 = \u000F\u2000.\u0003.\u0002(4);
			\u0002 = ((-342669399 ^ num) + num2 ^ num7);
			\u0002 = (((int)array3[2] | (int)array3[3] << 16 | (int)array3[0] << 8 | (int)array3[1] << 24) ^ -\u0002);
		}
		while (!\u000F\u2000.\u0002.TryGetValue(\u0002, out text));
		return text;
		Block_14:
		text = new string(new char[]
		{
			(char)(num + -1621415265 - num2),
			'0',
			(char)(-471520751 ^ num ^ num2)
		});
		return text;
		IL_57B:
		bool flag2 = (num20 & 526068295 + num - num2) != 0;
		bool flag3 = (num20 & (-1008391607 ^ num ^ num2)) != 0;
		bool flag4 = (num20 & -1599810119 - num + num2) != 0;
		num20 &= (num + -1679412142 ^ num2);
		byte[] array4 = array;
		byte[] array5 = \u000F\u2000.\u0003.\u0002(num20);
		byte[] array6 = array4;
		byte b = array6[1];
		int num21 = array5.Length;
		byte b2 = (byte)(num21 + 11 ^ (int)(b + 7));
		uint num22 = (uint)(((int)array6[0] | (int)array6[2] << 8) + ((int)b2 << 3));
		ushort num23 = 0;
		int i = 0;
		while (i < num21)
		{
			if ((1 & i) == 0)
			{
				num22 = num22 * (uint)((num ^ 471308720) + num2) + (uint)(num + -1618884342 - num2);
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
		if (\u000F\u2000.\u000E != null != (\u000F\u2000.\u0006 != 1623023167 - num + num2))
		{
			for (int j = 0; j < num20; j = 1 + j)
			{
				byte b5 = \u000F\u2000.\u000E[7 & j];
				b5 = (byte)((int)b5 << 3 | b5 >> 5);
				array7[j] ^= b5;
			}
		}
		int num24 = \u000F\u2000.\u0006 - 12;
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
			\u000F\u2000.\u0002(array7, 4, array8);
		}
		if (flag2 && num24 == -1619807551 + num - num2)
		{
			char[] array9 = new char[num25];
			for (int k = 0; k < num25; k++)
			{
				array9[k] = (char)array8[k];
			}
			text = new string(array9);
		}
		else
		{
			text = Encoding.Unicode.GetString(array8, 0, array8.Length);
		}
		num24 += (num ^ -471520714 ^ num2) + (3 & num24) << 5;
		if (num24 != num + -1619803423 - num2)
		{
			int num26 = \u0002 + num20 ^ (-471113679 ^ num ^ num2) ^ (num24 & -199634758 - num - num2);
			StringBuilder stringBuilder = new StringBuilder();
			int num3 = num ^ -471520751 ^ num2;
			stringBuilder.Append((char)((byte)num3));
			text = num26.ToString(stringBuilder.ToString());
		}
		if (!flag4 && \u0003)
		{
			text = string.Intern(text);
			\u000F\u2000.\u0002[\u0002] = text;
			if (\u000F\u2000.\u0002.Count == -199635609 - num - num2)
			{
				\u000F\u2000.\u0003.\u0003();
				\u000F\u2000.\u0003 = null;
				\u000F\u2000.\u0005 = null;
				\u000F\u2000.\u000E = null;
			}
		}
		return text;
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x00015890 File Offset: 0x00013A90
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

	// Token: 0x060000A7 RID: 167 RVA: 0x000158C8 File Offset: 0x00013AC8
	private static byte[] \u0002(AssemblyName \u0002)
	{
		byte[] array = \u0002.GetPublicKeyToken();
		if (array != null && array.Length == 0)
		{
			array = null;
		}
		return array;
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x000158E8 File Offset: 0x00013AE8
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
			AssemblyName u = \u000F\u2000.\u0002(assembly2);
			byte[] array = \u000F\u2000.\u0002(u);
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
		while (assembly2 == null || assembly2 != typeof(\u000F\u2000).Assembly);
		return true;
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x000159A4 File Offset: 0x00013BA4
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

	// Token: 0x040001BC RID: 444
	private static \u000F\u2000.\u0003 \u0003;

	// Token: 0x040001BD RID: 445
	private static byte[] \u0005;

	// Token: 0x040001BE RID: 446
	private static int \u000F;

	// Token: 0x040001BF RID: 447
	private static short \u0008;

	// Token: 0x040001C0 RID: 448
	private static \u000F\u2000.\u0002 \u0003\u2000;

	// Token: 0x040001C1 RID: 449
	private static int \u0002\u2000;

	// Token: 0x040001C2 RID: 450
	private static int \u0006;

	// Token: 0x040001C3 RID: 451
	private static byte[] \u000E;

	// Token: 0x040001C4 RID: 452
	private static Dictionary<int, string> \u0002;

	// Token: 0x0200001D RID: 29
	private enum \u0002
	{

	}

	// Token: 0x0200001E RID: 30
	private sealed class \u0003
	{
		// Token: 0x060000AA RID: 170 RVA: 0x00015A48 File Offset: 0x00013C48
		public \u0003(Stream \u0002)
		{
			this.\u0002 = \u0002;
			this.\u0003 = new byte[4];
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00015A64 File Offset: 0x00013C64
		public Stream \u0002()
		{
			return this.\u0002;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00015A6C File Offset: 0x00013C6C
		public short \u0002()
		{
			this.\u0002(2);
			return (short)((int)this.\u0003[0] | (int)this.\u0003[1] << 8);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00015A8C File Offset: 0x00013C8C
		public int \u0002()
		{
			this.\u0002(4);
			return (int)this.\u0003[0] | (int)this.\u0003[1] << 8 | (int)this.\u0003[2] << 16 | (int)this.\u0003[3] << 24;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00015AC0 File Offset: 0x00013CC0
		private void \u0002()
		{
			throw new EndOfStreamException();
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00015AC8 File Offset: 0x00013CC8
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

		// Token: 0x060000B0 RID: 176 RVA: 0x00015B28 File Offset: 0x00013D28
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

		// Token: 0x060000B1 RID: 177 RVA: 0x00015B54 File Offset: 0x00013D54
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

		// Token: 0x040001C6 RID: 454
		private Stream \u0002;

		// Token: 0x040001C7 RID: 455
		private byte[] \u0003;
	}
}
