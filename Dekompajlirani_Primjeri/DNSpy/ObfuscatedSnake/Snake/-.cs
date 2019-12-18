using System;
using Microsoft.Win32;

// Token: 0x02000002 RID: 2
internal static class \u0002
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	public static string \u0002()
	{
		return \u0006\u2000.\u0002(1257959238);
	}

	// Token: 0x06000002 RID: 2 RVA: 0x0000205C File Offset: 0x0000025C
	public static bool \u0002()
	{
		bool result;
		try
		{
			OperatingSystem osversion = Environment.OSVersion;
			if (osversion.Platform == PlatformID.Win32NT)
			{
				result = (osversion.Version >= new Version(6, 0));
			}
			else
			{
				result = false;
			}
		}
		catch
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06000003 RID: 3 RVA: 0x000020A8 File Offset: 0x000002A8
	public static bool \u0003()
	{
		bool result;
		try
		{
			PlatformID platform = Environment.OSVersion.Platform;
			if (platform <= PlatformID.Win32NT)
			{
				result = true;
			}
			else
			{
				result = false;
			}
		}
		catch
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06000004 RID: 4 RVA: 0x000020E4 File Offset: 0x000002E4
	public static bool \u0005()
	{
		return global::\u0002.\u0003() != null;
	}

	// Token: 0x06000005 RID: 5 RVA: 0x000020F0 File Offset: 0x000002F0
	private static string \u0003()
	{
		string result;
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(global::\u0002.\u0005());
			if (registryKey == null)
			{
				registryKey = Registry.LocalMachine.OpenSubKey(global::\u0002.\u0008());
			}
			if (registryKey == null)
			{
				result = null;
			}
			else
			{
				string text = (string)registryKey.GetValue(\u0006\u2000.\u0002(1257959256), null);
				registryKey.Close();
				result = text;
			}
		}
		catch
		{
			result = null;
		}
		return result;
	}

	// Token: 0x06000006 RID: 6 RVA: 0x0000215C File Offset: 0x0000035C
	private static string \u0005()
	{
		return \u0006\u2000.\u0002(1257959273) + global::\u0002.\u0002();
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00002174 File Offset: 0x00000374
	private static string \u0008()
	{
		return \u0006\u2000.\u0002(1257959173) + global::\u0002.\u0002();
	}
}
