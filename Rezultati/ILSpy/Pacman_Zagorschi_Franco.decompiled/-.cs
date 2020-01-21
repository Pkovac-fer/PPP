using Microsoft.Win32;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

internal static class _0002
{
	public static string _0002()
	{
		return _000F_2000._0002(-380206457);
	}

	public static bool _0002()
	{
		try
		{
			OperatingSystem oSVersion = Environment.OSVersion;
			if (oSVersion.Platform == PlatformID.Win32NT)
			{
				return oSVersion.Version >= new Version(6, 0);
			}
			return false;
		}
		catch
		{
			return false;
		}
	}

	public static bool _0003()
	{
		try
		{
			PlatformID platform = Environment.OSVersion.Platform;
			if ((uint)platform <= 2u)
			{
				return true;
			}
			return false;
		}
		catch
		{
			return false;
		}
	}

	public static bool _0005()
	{
		return global::_0002._0003() != null;
	}

	private static string _0003()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(global::_0002._0005());
			if (registryKey == null)
			{
				registryKey = Registry.LocalMachine.OpenSubKey(_0008());
			}
			if (registryKey == null)
			{
				return null;
			}
			string result = (string)registryKey.GetValue(_000F_2000._0002(-380206439), null);
			registryKey.Close();
			return result;
		}
		catch
		{
			return null;
		}
	}

	private static string _0005()
	{
		return _000F_2000._0002(-380206424) + global::_0002._0002();
	}

	private static string _0008()
	{
		return _000F_2000._0002(-380206396) + global::_0002._0002();
	}
}
internal interface _0002_2000
{
	void _0002_2000_2005_2000_0002();
}
internal static class _0002_2001
{
}
internal sealed class _0003 : Form
{
	public _0003(string _0002, string _0003)
		: this(_0002, _0003, MessageBoxButtons.OK)
	{
	}

	public _0003(string _0002, string _0003, MessageBoxButtons _0005)
		: this(_0002, _0003, _000F_2000._0002(-380206356), _0005)
	{
	}

	public _0003(string _0002, string _0003, string _0005, MessageBoxButtons _0008)
	{
		Label label = new Label();
		PictureBox pictureBox = new PictureBox();
		SuspendLayout();
		pictureBox.Image = global::_0003._0002(_0005);
		pictureBox.Location = new Point(8, 8);
		pictureBox.Size = new Size(48, 48);
		pictureBox.TabStop = false;
		label.Location = new Point(64, 24);
		label.Size = new Size(310, 114);
		label.Text = _0002;
		switch (_0008)
		{
		case MessageBoxButtons.OK:
			this._0002();
			break;
		case MessageBoxButtons.YesNo:
			this._0003();
			break;
		}
		AutoScaleBaseSize = new Size(5, 13);
		base.ClientSize = new Size(388, 197);
		base.Controls.AddRange(new Control[2]
		{
			label,
			pictureBox
		});
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		Text = _0003;
		base.StartPosition = FormStartPosition.CenterScreen;
		base.TopMost = true;
		ResumeLayout(performLayout: false);
	}

	private void _0002()
	{
		Button button = new Button
		{
			FlatStyle = FlatStyle.System,
			Location = new Point(169, 162),
			TabIndex = 0,
			Text = _000F_2000._0002(-380206344),
			DialogResult = DialogResult.OK
		};
		button.Click += _0002;
		base.Controls.Add(button);
		base.AcceptButton = button;
		base.CancelButton = button;
	}

	private void _0002(object _0002, EventArgs _0003)
	{
		Close();
	}

	private void _0003()
	{
		Button button = new Button
		{
			FlatStyle = FlatStyle.System,
			Location = new Point(124, 162),
			TabIndex = 1,
			Text = _000F_2000._0002(-380206585),
			DialogResult = DialogResult.Yes
		};
		Button button2 = new Button
		{
			FlatStyle = FlatStyle.System,
			Location = new Point(214, 162),
			TabIndex = 0,
			Text = _000F_2000._0002(-380206579),
			DialogResult = DialogResult.No
		};
		base.Controls.AddRange(new Control[2]
		{
			button,
			button2
		});
		base.AcceptButton = button;
		base.CancelButton = button2;
	}

	private static Bitmap _0002(string _0002)
	{
		Stream manifestResourceStream = typeof(_0003).Assembly.GetManifestResourceStream(_000F_2000._0002(-380206572) + _0002 + _000F_2000._0002(-380206514));
		if (manifestResourceStream != null)
		{
			return new Bitmap(manifestResourceStream);
		}
		return null;
	}
}
internal interface _0003_2000<_0002> : _000F, _0002_2000
{
	new _0002 _000F_2005_2000_0002();
}
internal static class _0003_2001
{
	private sealed class _0002
	{
		private int m__0002;

		private int _0003;

		internal _0002()
		{
			_0002(0L);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal long _0002()
		{
			if ((object)Assembly.GetCallingAssembly() != typeof(_0002).Assembly)
			{
				return 2918384L;
			}
			if (!_0003_2001._0002())
			{
				return 2918384L;
			}
			int[] array = new int[4];
			array[3] = -(~(~(-(-(~(-(~(~-341868575))))))));
			array[1] = -(~(-(~(~(-(-(~(~1434731115))))))));
			array[2] = ~(-(~(-(-(~(~(-(~220375303))))))));
			array[0] = -(~(-(~(~(-(~(-(~(-(~-114738776))))))))));
			int num = this.m__0002;
			int num2 = _0003;
			int num3 = ~(-(-(~(~(-(~(-(~1640531524))))))));
			int num4 = ~(-(~(-(-(~(-(~(~(-(~957401310))))))))));
			for (int i = 0; i != 32; i++)
			{
				num2 -= ((((num << 4) ^ (num >> 5)) + num) ^ (num4 + array[(num4 >> 11) & 3]));
				num4 -= num3;
				num -= ((((num2 << 4) ^ (num2 >> 5)) + num2) ^ (num4 + array[num4 & 3]));
			}
			for (int j = 0; j != 4; j++)
			{
				array[j] = 0;
			}
			ulong num5 = (ulong)((long)num2 << 32);
			return (long)(num5 | (uint)num);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _0002(long _0002)
		{
			if ((object)Assembly.GetCallingAssembly() == typeof(_0002).Assembly && _0003_2001._0002())
			{
				int[] array = new int[4];
				array[1] = -(~(~(-(~(-(~(-(~1434731111))))))));
				array[0] = -(~(~(-(-(~(-(~(~-114738773))))))));
				array[2] = -(~(~(-(~(-(-(~(-(~(~220375306))))))))));
				array[3] = -(~(-(~(-(~(~(-(~-341868575))))))));
				int num = -(~(-(~(-(~(-(~(~(-(~1640531529))))))))));
				int num2 = (int)_0002;
				int num3 = (int)(_0002 >> 32);
				int num4 = 0;
				for (int i = 0; i != 32; i++)
				{
					num2 += ((((num3 << 4) ^ (num3 >> 5)) + num3) ^ (num4 + array[num4 & 3]));
					num4 += num;
					num3 += ((((num2 << 4) ^ (num2 >> 5)) + num2) ^ (num4 + array[(num4 >> 11) & 3]));
				}
				for (int j = 0; j != 4; j++)
				{
					array[j] = 0;
				}
				this.m__0002 = num2;
				_0003 = num3;
			}
		}
	}

	private sealed class _0002_2000
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int _0002()
		{
			return _0003_2001._0003._0002(_0003_2001._0002(typeof(_0002_2000)), _0003_2001._0003._0005(_0003_2001._0003._0003(_0003_2001._0002(typeof(_000F)), _0003_2001._0002(typeof(_0005))), _0003_2001._0003._0005(_0003_2001._0002(typeof(_0008)) ^ ~(-(~(-(-(~(~(-(~1109880753)))))))), _000F._0002())));
		}
	}

	private static class _0003
	{
		internal static int _0002(int _0002, int _0003)
		{
			return _0002 ^ (_0003 - -(~(~(-(~(-(~(-(~1110557904)))))))));
		}

		internal static int _0003(int _0002, int _0003)
		{
			return (_0002 - -(~(~(-(-(~(-(~(~-1162723130))))))))) ^ (_0003 + -(~(-(~(-(~(~(-(-(~(~-590915957)))))))))));
		}

		internal static int _0005(int _0002, int _0003)
		{
			return _0002 ^ ((_0003 - -(~(-(~(-(~(~(-(-(~(~917961678))))))))))) ^ (_0002 - _0003));
		}
	}

	private sealed class _0005
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int _0002()
		{
			return _0003_2001._0003._0005(_0003_2001._0003._0003(_0003_2001._0002(typeof(_0006)), _0003_2001._0003._0005(_0003_2001._0002(typeof(_0005)), _0003_2001._0002(typeof(_000F)))), _0002_2000._0002());
		}
	}

	private sealed class _0006
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int _0002()
		{
			return _0003_2001._0003._0002(_0003_2001._0002(typeof(_0008)), _0003_2001._0002(typeof(_000E)) ^ _0003_2001._0003._0003(_0003_2001._0002(typeof(_0006)), _0003_2001._0003._0005(_0003_2001._0002(typeof(_0002_2000)), _000E._0002())));
		}
	}

	private sealed class _0008
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int _0002()
		{
			return _0003_2001._0003._0005(_0003_2001._0003._0002(_0006._0002() ^ -(~(-(~(-(~(~(-(~-527758445)))))))), _0003_2001._0002(typeof(_000E))), _0003_2001._0003._0003(_0003_2001._0002(typeof(_0005)) ^ _0003_2001._0002(typeof(_0002_2000)), ~(-(~(-(-(~(~(-(~-25004897))))))))));
		}
	}

	private sealed class _000E
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int _0002()
		{
			return _0003_2001._0003._0005(_0003_2001._0002(typeof(_000E)), _0003_2001._0003._0002(_0003_2001._0002(typeof(_0005)), _0003_2001._0003._0003(_0003_2001._0002(typeof(_0006)), _0003_2001._0003._0005(_0003_2001._0002(typeof(_0008)), _0003_2001._0003._0002(_0003_2001._0002(typeof(_000F)), _0003_2001._0002(typeof(_0002_2000)))))));
		}
	}

	private sealed class _000F
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int _0002()
		{
			return _0003_2001._0003._0003(_0003_2001._0003._0003(_0008._0002(), _0003_2001._0003._0002(_0003_2001._0002(typeof(_000F)), _0006._0002())), _0003_2001._0002(typeof(_0002_2000)));
		}
	}

	private static _0002 m__0002 = new _0002();

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long _0002()
	{
		if ((object)Assembly.GetCallingAssembly() != typeof(_0003_2001).Assembly || !_0003_2001._0002())
		{
			return 0L;
		}
		lock (_0003_2001.m__0002)
		{
			long num = _0003_2001.m__0002._0002();
			if (num == 0)
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
				int num2 = _0002(typeof(_0003_2001));
				int num3 = _0005._0002();
				list.Add((byte)(num2 >> 24));
				list.Add((byte)(num3 >> 16));
				list.Add((byte)(num2 >> 8));
				list.Add((byte)num3);
				list.Add((byte)(num2 >> 16));
				list.Add((byte)(num3 >> 8));
				list.Add((byte)num2);
				list.Add((byte)(num3 >> 24));
				int count = list.Count;
				ulong num4 = 0uL;
				for (int i = 0; i != count; i++)
				{
					num4 += list[i];
					num4 += num4 << 20;
					num4 ^= num4 >> 12;
					list[i] = 0;
				}
				num4 += num4 << 6;
				num4 ^= num4 >> 22;
				num4 += num4 << 30;
				num = (long)num4;
				num ^= -8961918403086190218L;
				_0003_2001.m__0002._0002(num);
			}
			return num;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool _0002()
	{
		if (!_0003())
		{
			return false;
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool _0003()
	{
		StackTrace stackTrace = new StackTrace();
		Type type = (stackTrace.GetFrame(3)?.GetMethod())?.DeclaringType;
		if ((object)type == typeof(RuntimeMethodHandle))
		{
			return false;
		}
		if ((object)type == null)
		{
			return false;
		}
		if ((object)type.Assembly != typeof(_0003_2001).Assembly)
		{
			return false;
		}
		return true;
	}

	private static int _0002(Type _0002)
	{
		return _0002.MetadataToken;
	}
}
internal static class _0005
{
	private sealed class _0002
	{
		public bool? _0002;

		internal void _0002()
		{
			global::_0003 _0003 = new global::_0003(_000F_2000._0002(-380206501), _000F_2000._0002(-380206960), MessageBoxButtons.YesNo)
			{
				BackColor = Color.White
			};
			this._0002 = (_0003.ShowDialog() == DialogResult.Yes);
		}

		internal void _0003()
		{
			global::_0003 _0003 = new global::_0003(_000F_2000._0002(-380206924), _000F_2000._0002(-380206960))
			{
				BackColor = Color.White
			};
			this._0002 = (_0003.ShowDialog() == DialogResult.OK);
		}
	}

	private sealed class _0003
	{
		public ThreadStart _0002;

		public Exception _0003;

		internal void _0002()
		{
			try
			{
				this._0002();
			}
			catch (Exception ex)
			{
				Exception ex2 = _0003 = ex;
			}
		}
	}

	private static bool _0002(bool _0002)
	{
		DateTime t = DateTime.Parse(_000F_2000._0002(-380207014), CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);
		DateTime utcNow = DateTime.UtcNow;
		if (utcNow > t || utcNow < t.AddDays(-21.0))
		{
			string name = typeof(_0005).Assembly.GetName().Name;
			string text = string.Format(_000F_2000._0002(-380206977), name);
			if (_0002)
			{
				throw new Exception(text);
			}
			_0005._0002();
			Application.Run(new global::_0003(text, _000F_2000._0002(-380205439)));
			return false;
		}
		if (!global::_0002._0002())
		{
			return _0005._0003(_0002);
		}
		if (!global::_0002._0005())
		{
			try
			{
				_0005._0002();
				global::_0003 _0003 = new global::_0003(_000F_2000._0002(-380205409), _000F_2000._0002(-380206960));
				_0003.BackColor = Color.White;
				_0003.ShowDialog();
			}
			catch
			{
			}
			if (_0002)
			{
				throw new Exception(_000F_2000._0002(-380205170));
			}
			return false;
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool _0003(bool _0002)
	{
		_0002 _00022 = new _0002();
		_00022._0002 = null;
		try
		{
			string text = AppDomain.CurrentDomain.GetData(_000F_2000._0002(-380205217)) as string;
			if (text != null)
			{
				if (text == _000F_2000._0002(-380205190))
				{
					_00022._0002 = false;
				}
				else if (text == _000F_2000._0002(-380205950))
				{
					_00022._0002 = true;
				}
			}
		}
		catch
		{
		}
		bool hasValue = _00022._0002.HasValue;
		if (!_00022._0002.HasValue)
		{
			try
			{
				if (global::_0002._0003())
				{
					_0005._0002(_00022._0002);
				}
				else
				{
					_0005._0002(_00022._0003);
				}
			}
			catch
			{
			}
		}
		if (!hasValue && _00022._0002.HasValue)
		{
			try
			{
				AppDomain.CurrentDomain.SetData(_000F_2000._0002(-380205217), _00022._0002.Value ? _000F_2000._0002(-380205950) : _000F_2000._0002(-380205190));
			}
			catch
			{
			}
		}
		if (_00022._0002.GetValueOrDefault())
		{
			return true;
		}
		if (_0002)
		{
			throw new Exception(_000F_2000._0002(-380205942));
		}
		return false;
	}

	private static void _0002(ThreadStart _0002)
	{
		_0003 _0003 = new _0003();
		_0003._0002 = _0002;
		_0003._0003 = null;
		Thread thread = new Thread(_0003._0002);
		thread.SetApartmentState(ApartmentState.STA);
		thread.IsBackground = true;
		thread.Start();
		thread.Join();
		if (_0003._0003 != null)
		{
			throw _0003._0003;
		}
	}

	private static void _0002()
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

	public static bool _0002()
	{
		return _0002(_0002: false);
	}

	public static void _0003()
	{
		_0002(_0002: true);
	}
}
internal static class _0005_2000
{
}
internal interface _0006
{
	_000F _0006_2005_2000_0002();
}
internal static class _0006_2000
{
	[STAThread]
	private static void _0002()
	{
		if (_0005._0002())
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(defaultValue: false);
			Application.Run(new _0008_2000());
		}
	}
}
internal static class _0008
{
	internal sealed class _0002 : global::_000E<int>, _0006, global::_0003_2000<int>, _0002_2000, _000F
	{
		private int m__0002;

		private int _0003;

		private int _0005;

		private int _0008;

		public int _0006;

		[DebuggerHidden]
		public _0002(int _0002)
		{
			this.m__0002 = _0002;
			_0005 = Thread.CurrentThread.ManagedThreadId;
		}

		[DebuggerHidden]
		private void _0002_2005_2000_0002()
		{
		}

		void _0002_2000._0002_2000_2005_2000_0002()
		{
			//ILSpy generated this explicit interface implementation from .override directive in   
			this._0002_2005_2000_0002();
		}

		private bool _000F_2005_2000_0002()
		{
			switch (m__0002)
			{
			default:
				return false;
			case 0:
				m__0002 = -1;
				_0003 = 250489705;
				m__0002 = 1;
				return true;
			case 1:
				m__0002 = -1;
				_0003 = (_0008 ^ -2566833);
				m__0002 = 2;
				return true;
			case 2:
				m__0002 = -1;
				_0003 = -633790635;
				m__0002 = 3;
				return true;
			case 3:
				m__0002 = -1;
				_0003 = (_0008 ^ -2566833);
				m__0002 = 4;
				return true;
			case 4:
				m__0002 = -1;
				_0003 = 1511105469;
				m__0002 = 5;
				return true;
			case 5:
				m__0002 = -1;
				_0003 = (_0008 ^ 0x33FA5BE9);
				m__0002 = 6;
				return true;
			case 6:
				m__0002 = -1;
				_0003 = -708120235;
				m__0002 = 7;
				return true;
			case 7:
				m__0002 = -1;
				_0003 = 2037083242;
				m__0002 = 8;
				return true;
			case 8:
				m__0002 = -1;
				return false;
			}
		}

		bool _000F._000F_2005_2000_0002()
		{
			//ILSpy generated this explicit interface implementation from .override directive in   
			return this._000F_2005_2000_0002();
		}

		[DebuggerHidden]
		private int _0002_2005_2000_0002()
		{
			return _0003;
		}

		int global::_0003_2000<int>._000F_2005_2000_0002()
		{
			//ILSpy generated this explicit interface implementation from .override directive in   
			return this._0002_2005_2000_0002();
		}

		[DebuggerHidden]
		private void _0002_2005_2000_0003()
		{
			throw new NotSupportedException();
		}

		void _000F._000F_2005_2000_0002()
		{
			//ILSpy generated this explicit interface implementation from .override directive in   
			this._0002_2005_2000_0003();
		}

		[DebuggerHidden]
		private object _0002_2005_2000_0002()
		{
			return _0003;
		}

		object _000F._000F_2005_2000_0002()
		{
			//ILSpy generated this explicit interface implementation from .override directive in   
			return this._0002_2005_2000_0002();
		}

		[DebuggerHidden]
		private global::_0003_2000<int> _0002_2005_2000_0002()
		{
			_0002 _0002;
			if (this.m__0002 == -2 && _0005 == Thread.CurrentThread.ManagedThreadId)
			{
				this.m__0002 = 0;
				_0002 = this;
			}
			else
			{
				_0002 = new _0002(0);
			}
			_0002._0008 = _0006;
			return _0002;
		}

		global::_0003_2000<int> global::_000E<int>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in   
			return this._0002_2005_2000_0002();
		}

		[DebuggerHidden]
		private _000F _0002_2005_2000_0002()
		{
			return this._0002_2005_2000_0002();
		}

		_000F _0006._0006_2005_2000_0002()
		{
			//ILSpy generated this explicit interface implementation from .override directive in   
			return this._0002_2005_2000_0002();
		}
	}
}
public sealed class _0008_2000 : Form
{
	public int _0002;

	public int _0003;

	public int _0005;

	public int _0008;

	public int _0006;

	public int _000E;

	public int _000F;

	public int _0002_2000;

	public int _0003_2000;

	public int _0005_2000;

	public int _0008_2000;

	public int _0006_2000;

	public int _000E_2000 = 1;

	public bool _000F_2000;

	public bool _0002_2001;

	public bool _0003_2001;

	public bool _0005_2001;

	public bool _0008_2001;

	public bool _0006_2001;

	public bool _000E_2001;

	public bool _000F_2001;

	public bool _0002_2002;

	public bool _0003_2002;

	public bool _0005_2002;

	public bool _0008_2002;

	public bool _0006_2002;

	public bool _000E_2002;

	public bool _000F_2002;

	public bool _0002_2003;

	public bool _0003_2003;

	public bool _0005_2003;

	public bool _0008_2003;

	public bool _0006_2003;

	public bool _000E_2003;

	public bool _000F_2003;

	public bool _0002_2004;

	public bool _0003_2004;

	public bool _0005_2004;

	public bool _0008_2004;

	public bool _0006_2004;

	public bool _000E_2004;

	public bool _000F_2004 = true;

	public int _0002_2005;

	public int _0003_2005;

	public int _0005_2005;

	public int _0008_2005;

	public int _0006_2005 = 3;

	public int _000E_2005;

	public int _000F_2005;

	public int _0002_2006;

	public int _0003_2006;

	public int _0005_2006;

	public int _0008_2006;

	public int _0006_2006;

	public int _000E_2006;

	public int _000F_2006 = 1;

	public int _0002_2007 = 2;

	public int _0003_2007 = 2;

	public int _0005_2007 = 2;

	public int _0008_2007 = 2;

	public Random _0006_2007 = new Random();

	public List<object> _000E_2007 = new List<object>();

	private IContainer _000F_2007 = null;

	private System.Windows.Forms.Timer _0002_2008;

	private Label _0003_2008;

	private Label _0005_2008;

	private Label _0008_2008;

	private Label _0006_2008;

	private Label _000E_2008;

	private Label _000F_2008;

	private PictureBox _0002_2009;

	private PictureBox _0003_2009;

	private Label _0005_2009;

	private System.Windows.Forms.Timer _0008_2009;

	private System.Windows.Forms.Timer _0006_2009;

	private System.Windows.Forms.Timer _000E_2009;

	private System.Windows.Forms.Timer _000F_2009;

	private System.Windows.Forms.Timer _0002_200A;

	private Label _0003_200A;

	private Label _0005_200A;

	private Label _0008_200A;

	private Label _0006_200A;

	private Label _000E_200A;

	private Label _000F_200A;

	private Label _0002_200B;

	private Label _0003_200B;

	private Label _0005_200B;

	private Label _0008_200B;

	private Label _0006_200B;

	private Label _000E_200B;

	private Label _000F_200B;

	private Label _0002_2000_2000;

	private Label _0003_2000_2000;

	private Label _0005_2000_2000;

	private Label _0008_2000_2000;

	private Label _0006_2000_2000;

	private Label _000E_2000_2000;

	private Label _000F_2000_2000;

	private Label _0002_2001_2000;

	private Label _0003_2001_2000;

	private Label _0005_2001_2000;

	private Label _0008_2001_2000;

	private Label _0006_2001_2000;

	private Label _000E_2001_2000;

	private Label _000F_2001_2000;

	private Label _0002_2002_2000;

	private Label _0003_2002_2000;

	private Label _0005_2002_2000;

	private Label _0008_2002_2000;

	private Label _0006_2002_2000;

	private Label _000E_2002_2000;

	private Label _000F_2002_2000;

	private Label _0002_2003_2000;

	private Label _0003_2003_2000;

	private Label _0005_2003_2000;

	private Label _0008_2003_2000;

	private Label _0006_2003_2000;

	private Label _000E_2003_2000;

	private Label _000F_2003_2000;

	private Label _0002_2004_2000;

	private Label _0003_2004_2000;

	private Label _0005_2004_2000;

	private Label _0008_2004_2000;

	private Label _0006_2004_2000;

	private Label _000E_2004_2000;

	private Label _000F_2004_2000;

	private Label _0002_2006_2000;

	private Label _0003_2006_2000;

	private Label _0005_2006_2000;

	private Label _0008_2006_2000;

	private Label _0006_2006_2000;

	private Label _000E_2006_2000;

	private Label _000F_2006_2000;

	private Label _0002_2007_2000;

	private Label _0003_2007_2000;

	private Label _0005_2007_2000;

	private Label _0008_2007_2000;

	private Label _0006_2007_2000;

	private Label _000E_2007_2000;

	private Label _000F_2007_2000;

	private Label _0002_2008_2000;

	private Label _0003_2008_2000;

	private Label _0005_2008_2000;

	private Label _0008_2008_2000;

	private Label _0006_2008_2000;

	private Label _000E_2008_2000;

	private Label _000F_2008_2000;

	private Label _0002_2009_2000;

	private Label _0003_2009_2000;

	private Label _0005_2009_2000;

	private Label _0008_2009_2000;

	private Label _0006_2009_2000;

	private Label _000E_2009_2000;

	private Label _000F_2009_2000;

	private Label _0002_200A_2000;

	private Label _0003_200A_2000;

	private Label _0005_200A_2000;

	private Label _0008_200A_2000;

	private Label _0006_200A_2000;

	private Label _000E_200A_2000;

	private Label _000F_200A_2000;

	private Label _0002_200B_2000;

	private Label _0003_200B_2000;

	private Label _0005_200B_2000;

	private Label _0008_200B_2000;

	private Label _0006_200B_2000;

	private Label _000E_200B_2000;

	private Label _000F_200B_2000;

	private Label _0002_2000_2001;

	private Label _0003_2000_2001;

	private Label _0005_2000_2001;

	private Label _0008_2000_2001;

	private Label _0006_2000_2001;

	private Label _000E_2000_2001;

	private Label _000F_2000_2001;

	private Label _0002_2001_2001;

	private Label _0003_2001_2001;

	private Label _0005_2001_2001;

	private Label _0008_2001_2001;

	private Label _0006_2001_2001;

	private Label _000E_2001_2001;

	private Label _000F_2001_2001;

	private Label _0002_2002_2001;

	private Label _0003_2002_2001;

	private Label _0005_2002_2001;

	private Label _0008_2002_2001;

	private Label _0006_2002_2001;

	private Label _000E_2002_2001;

	private Label _000F_2002_2001;

	private Label _0002_2003_2001;

	private Label _0003_2003_2001;

	private Label _0005_2003_2001;

	private Label _0008_2003_2001;

	private Label _0006_2003_2001;

	private Label _000E_2003_2001;

	private Label _000F_2003_2001;

	private Label _0002_2004_2001;

	private Label _0003_2004_2001;

	private Label _0005_2004_2001;

	private Label _0008_2004_2001;

	private Label _0006_2004_2001;

	private Label _000E_2004_2001;

	private Label _000F_2004_2001;

	private Label _0002_2005_2001;

	private Label _0003_2005_2001;

	private Label _0005_2005_2001;

	private Label _0008_2005_2001;

	private Label _0006_2005_2001;

	private Label _000E_2005_2001;

	private Label _000F_2005_2001;

	private Label _0002_2006_2001;

	private Label _0003_2006_2001;

	private Label _0005_2006_2001;

	private Label _0008_2006_2001;

	private Label _0006_2006_2001;

	private Label _000E_2006_2001;

	private Label _000F_2006_2001;

	private Label _0002_2007_2001;

	private Label _0003_2007_2001;

	private Label _0005_2007_2001;

	private Label _0008_2007_2001;

	private Label _0006_2007_2001;

	private Label _000E_2007_2001;

	private Label _000F_2007_2001;

	private Label _0002_2008_2001;

	private Label _0003_2008_2001;

	private Label _0005_2008_2001;

	private Label _0008_2008_2001;

	private Label _0006_2008_2001;

	private Label _000E_2008_2001;

	private Label _000F_2008_2001;

	private Label _0002_2009_2001;

	private Label _0003_2009_2001;

	private Label _0005_2009_2001;

	private Label _0008_2009_2001;

	private Label _0006_2009_2001;

	private Label _000E_2009_2001;

	private Label _000F_2009_2001;

	private Label _0002_200A_2001;

	private Label _0003_200A_2001;

	private Label _0005_200A_2001;

	private Label _0008_200A_2001;

	private Label _0006_200A_2001;

	private Label _000E_200A_2001;

	private Label _000F_200A_2001;

	private Label _0002_200B_2001;

	private Label _0003_200B_2001;

	private Label _0005_200B_2001;

	private Label _0008_200B_2001;

	private Label _0006_200B_2001;

	private Label _000E_200B_2001;

	private Label _000F_200B_2001;

	private Label _0002_2000_2002;

	private Label _0003_2000_2002;

	private Label _0005_2000_2002;

	private Label _0008_2000_2002;

	private Label _0006_2000_2002;

	private Label _000E_2000_2002;

	private Label _000F_2000_2002;

	private Label _0002_2001_2002;

	private Label _0003_2001_2002;

	private Label _0005_2001_2002;

	private Label _0008_2001_2002;

	private Label _0006_2001_2002;

	private Label _000E_2001_2002;

	private Label _000F_2001_2002;

	private Label _0002_2002_2002;

	private Label _0003_2002_2002;

	private Label _0005_2002_2002;

	private Label _0008_2002_2002;

	private Label _0006_2002_2002;

	private Label _000E_2002_2002;

	private Label _000F_2002_2002;

	private Label _0002_2003_2002;

	private Label _0003_2003_2002;

	private Label _0005_2003_2002;

	private Label _0008_2003_2002;

	private Label _0006_2003_2002;

	private Label _000E_2003_2002;

	private Label _000F_2003_2002;

	private Label _0002_2004_2002;

	private Label _0003_2004_2002;

	private Label _0005_2004_2002;

	private Label _0008_2004_2002;

	private Label _0006_2004_2002;

	private Label _000E_2004_2002;

	private Label _000F_2004_2002;

	private Label _0002_2005_2002;

	private Label _0003_2005_2002;

	private Label _0005_2005_2002;

	private Label _0008_2005_2002;

	private Label _0006_2005_2002;

	private Label _000E_2005_2002;

	private Label _000F_2005_2002;

	private Label _0002_2006_2002;

	private Label _0003_2006_2002;

	private Label _0005_2006_2002;

	private Label _0008_2006_2002;

	private Label _0006_2006_2002;

	private Label _000E_2006_2002;

	private Label _000F_2006_2002;

	private Label _0002_2007_2002;

	private Label _0003_2007_2002;

	private Label _0005_2007_2002;

	private Label _0008_2007_2002;

	private Label _0006_2007_2002;

	private Label _000E_2007_2002;

	private Label _000F_2007_2002;

	private Label _0002_2008_2002;

	private Label _0003_2008_2002;

	private Label _0005_2008_2002;

	private Label _0008_2008_2002;

	private Label _0006_2008_2002;

	private Label _000E_2008_2002;

	private Label _000F_2008_2002;

	private Label _0002_2009_2002;

	private Label _0003_2009_2002;

	private Label _0005_2009_2002;

	private Label _0008_2009_2002;

	private Label _0006_2009_2002;

	private Label _000E_2009_2002;

	private Label _000F_2009_2002;

	private Label _0002_200A_2002;

	private Label _0003_200A_2002;

	private Label _0005_200A_2002;

	private Label _0008_200A_2002;

	private Label _0006_200A_2002;

	private Label _000E_200A_2002;

	private Label _000F_200A_2002;

	private Label _0002_200B_2002;

	private Label _0003_200B_2002;

	private Label _0005_200B_2002;

	private Label _0008_200B_2002;

	private Label _0006_200B_2002;

	private Label _000E_200B_2002;

	private Label _000F_200B_2002;

	private Label _0002_2000_2003;

	private Label _0003_2000_2003;

	private Label _0005_2000_2003;

	private Label _0008_2000_2003;

	private Label _0006_2000_2003;

	private Label _000E_2000_2003;

	private Label _000F_2000_2003;

	private Label _0002_2001_2003;

	private Label _0003_2001_2003;

	private Label _0005_2001_2003;

	private Label _0008_2001_2003;

	private Label _0006_2001_2003;

	private Label _000E_2001_2003;

	private Label _000F_2001_2003;

	private Label _0002_2002_2003;

	private Label _0003_2002_2003;

	private Label _0005_2002_2003;

	private Label _0008_2002_2003;

	private Label _0006_2002_2003;

	private Label _000E_2002_2003;

	private Label _000F_2002_2003;

	private Label _0002_2003_2003;

	private Label _0003_2003_2003;

	private Label _0005_2003_2003;

	private Label _0008_2003_2003;

	private Label _0006_2003_2003;

	private Label _000E_2003_2003;

	private Label _000F_2003_2003;

	private Label _0002_2004_2003;

	private Label _0003_2004_2003;

	private Label _0005_2004_2003;

	private Label _0008_2004_2003;

	private Label _0006_2004_2003;

	private Label _000E_2004_2003;

	private Label _000F_2004_2003;

	private Label _0002_2005_2003;

	private Label _0003_2005_2003;

	private Label _0005_2005_2003;

	private Label _0008_2005_2003;

	private Label _0006_2005_2003;

	private Label _000E_2005_2003;

	private Label _000F_2005_2003;

	private Label _0002_2006_2003;

	private Label _0003_2006_2003;

	private Label _0005_2006_2003;

	private Label _0008_2006_2003;

	private Label _0006_2006_2003;

	private Label _000E_2006_2003;

	private Label _000F_2006_2003;

	private Label _0002_2007_2003;

	private Label _0003_2007_2003;

	private Label _0005_2007_2003;

	private Label _0008_2007_2003;

	private Label _0006_2007_2003;

	private Label _000E_2007_2003;

	private Label _000F_2007_2003;

	private Label _0002_2008_2003;

	private Label _0003_2008_2003;

	private Label _0005_2008_2003;

	private Label _0008_2008_2003;

	private Label _0006_2008_2003;

	private Label _000E_2008_2003;

	private Label _000F_2008_2003;

	private Label _0002_2009_2003;

	private Label _0003_2009_2003;

	private Label _0005_2009_2003;

	private Label _0008_2009_2003;

	private Label _0006_2009_2003;

	private Label _000E_2009_2003;

	private Label _000F_2009_2003;

	private Label _0002_200A_2003;

	private Label _0003_200A_2003;

	private Label _0005_200A_2003;

	private Label _0008_200A_2003;

	private Label _0006_200A_2003;

	private System.Windows.Forms.Timer _000E_200A_2003;

	private Panel _000F_200A_2003;

	private Button _0002_200B_2003;

	private PictureBox _0003_200B_2003;

	private PictureBox _0005_200B_2003;

	private System.Windows.Forms.Timer _0008_200B_2003;

	private System.Windows.Forms.Timer _0006_200B_2003;

	private System.Windows.Forms.Timer _000E_200B_2003;

	private System.Windows.Forms.Timer _000F_200B_2003;

	private Label _0002_2000_2004;

	private Label _0003_2000_2004;

	private System.Windows.Forms.Timer _0005_2000_2004;

	private System.Windows.Forms.Timer _0008_2000_2004;

	private PictureBox _0006_2000_2004;

	private PictureBox _000E_2000_2004;

	private Label _000F_2000_2004;

	private Label _0002_2001_2004;

	private Label _0003_2001_2004;

	private Label _0005_2001_2004;

	public _0008_2000()
	{
		_000E_2000();
		_000E_2007.Add(_0003_200A);
		_000E_2007.Add(_0005_200A);
		_000E_2007.Add(_0008_200A);
		_000E_2007.Add(_0006_200A);
		_000E_2007.Add(_000E_200A);
		_000E_2007.Add(_000F_200A);
		_000E_2007.Add(_0002_200B);
		_000E_2007.Add(_0003_200B);
		_000E_2007.Add(_0005_200B);
		_000E_2007.Add(_0008_200B);
		_000E_2007.Add(_0006_200B);
		_000E_2007.Add(_000E_200B);
		_000E_2007.Add(_000F_200B);
		_000E_2007.Add(_0002_2000_2000);
		_000E_2007.Add(_0003_2000_2000);
		_000E_2007.Add(_0005_2000_2000);
		_000E_2007.Add(_0008_2000_2000);
		_000E_2007.Add(_0006_2000_2000);
		_000E_2007.Add(_000E_2000_2000);
		_000E_2007.Add(_000F_2000_2000);
		_000E_2007.Add(_0002_2001_2000);
		_000E_2007.Add(_0003_2001_2000);
		_000E_2007.Add(_0005_2001_2000);
		_000E_2007.Add(_0008_2001_2000);
		_000E_2007.Add(_0006_2001_2000);
		_000E_2007.Add(_000E_2001_2000);
		_000E_2007.Add(_000F_2001_2000);
		_000E_2007.Add(_0002_2002_2000);
		_000E_2007.Add(_0006_2002_2000);
		_000E_2007.Add(_0008_2003_2000);
		_000E_2007.Add(_0006_2003_2000);
		_000E_2007.Add(_000E_2003_2000);
		_000E_2007.Add(_000F_2003_2000);
		_000E_2007.Add(_0002_2004_2000);
		_000E_2007.Add(_0003_2004_2000);
		_000E_2007.Add(_0005_2004_2000);
		_000E_2007.Add(_0008_2004_2000);
		_000E_2007.Add(_0006_2004_2000);
		_000E_2007.Add(_000E_2004_2000);
		_000E_2007.Add(_0005_2002_2000);
		_000E_2007.Add(_0008_2002_2000);
		_000E_2007.Add(_000E_2002_2000);
		_000E_2007.Add(_000F_2002_2000);
		_000E_2007.Add(_0002_2003_2000);
		_000E_2007.Add(_000F_2004_2000);
		_000E_2007.Add(_0003_2003_2000);
		_000E_2007.Add(_0005_2003_2000);
		_000E_2007.Add(_0002_2006_2000);
		_000E_2007.Add(_0003_2006_2000);
		_000E_2007.Add(_0005_2006_2000);
		_000E_2007.Add(_0008_2006_2000);
		_000E_2007.Add(_0006_2006_2000);
		_000E_2007.Add(_000E_2006_2000);
		_000E_2007.Add(_000F_2006_2000);
		_000E_2007.Add(_0002_2007_2000);
		_000E_2007.Add(_0003_2007_2000);
		_000E_2007.Add(_0005_2007_2000);
		_000E_2007.Add(_0008_2007_2000);
		_000E_2007.Add(_0006_2007_2000);
		_000E_2007.Add(_000E_2007_2000);
		_000E_2007.Add(_000F_2007_2000);
		_000E_2007.Add(_0002_2008_2000);
		_000E_2007.Add(_0003_2008_2000);
		_000E_2007.Add(_0005_2008_2000);
		_000E_2007.Add(_0008_2008_2000);
		_000E_2007.Add(_0006_2008_2000);
		_000E_2007.Add(_000E_2008_2000);
		_000E_2007.Add(_000F_2008_2000);
		_000E_2007.Add(_0002_2009_2000);
		_000E_2007.Add(_0003_2009_2000);
		_000E_2007.Add(_0005_2009_2000);
		_000E_2007.Add(_0006_200A_2000);
		_000E_2007.Add(_0008_2009_2000);
		_000E_2007.Add(_0006_2009_2000);
		_000E_2007.Add(_000E_2009_2000);
		_000E_2007.Add(_000F_2009_2000);
		_000E_2007.Add(_0002_200A_2000);
		_000E_2007.Add(_0003_200A_2000);
		_000E_2007.Add(_0005_200A_2000);
		_000E_2007.Add(_0008_200A_2000);
		_000E_2007.Add(_000E_200A_2000);
		_000E_2007.Add(_000F_200A_2000);
		_000E_2007.Add(_0002_200B_2000);
		_000E_2007.Add(_0003_200B_2000);
		_000E_2007.Add(_0005_200B_2000);
		_000E_2007.Add(_0008_200B_2000);
		_000E_2007.Add(_0006_200B_2000);
		_000E_2007.Add(_000E_200B_2000);
		_000E_2007.Add(_000F_200B_2000);
		_000E_2007.Add(_0003_2000_2001);
		_000E_2007.Add(_0002_2000_2001);
		_000E_2007.Add(_0005_2000_2001);
		_000E_2007.Add(_0008_2000_2001);
		_000E_2007.Add(_000E_2000_2001);
		_000E_2007.Add(_0006_2000_2001);
		_000E_2007.Add(_000F_2000_2001);
		_000E_2007.Add(_0002_2001_2001);
		_000E_2007.Add(_0003_2001_2001);
		_000E_2007.Add(_0005_2001_2001);
		_000E_2007.Add(_0008_2001_2001);
		_000E_2007.Add(_0006_2001_2001);
		_000E_2007.Add(_000E_2001_2001);
		_000E_2007.Add(_000F_2001_2001);
		_000E_2007.Add(_0002_2002_2001);
		_000E_2007.Add(_0003_2002_2001);
		_000E_2007.Add(_0005_2002_2001);
		_000E_2007.Add(_0008_2002_2001);
		_000E_2007.Add(_0006_2002_2001);
		_000E_2007.Add(_000E_2002_2001);
		_000E_2007.Add(_000F_2002_2001);
		_000E_2007.Add(_0002_2003_2001);
		_000E_2007.Add(_0003_2003_2001);
		_000E_2007.Add(_0005_2003_2001);
		_000E_2007.Add(_0008_2003_2001);
		_000E_2007.Add(_0006_2003_2001);
		_000E_2007.Add(_000E_2003_2001);
		_000E_2007.Add(_000F_2003_2001);
		_000E_2007.Add(_0002_2004_2001);
		_000E_2007.Add(_0003_2004_2001);
		_000E_2007.Add(_0005_2004_2001);
		_000E_2007.Add(_0008_2004_2001);
		_000E_2007.Add(_0006_2004_2001);
		_000E_2007.Add(_000E_2004_2001);
		_000E_2007.Add(_000F_2004_2001);
		_000E_2007.Add(_0002_2005_2001);
		_000E_2007.Add(_0003_2005_2001);
		_000E_2007.Add(_0005_2005_2001);
		_000E_2007.Add(_0008_2005_2001);
		_000E_2007.Add(_0006_2005_2001);
		_000E_2007.Add(_000E_2005_2001);
		_000E_2007.Add(_000F_2005_2001);
		_000E_2007.Add(_0002_2006_2001);
		_000E_2007.Add(_0003_2006_2001);
		_000E_2007.Add(_0005_2006_2001);
		_000E_2007.Add(_0008_2006_2001);
		_000E_2007.Add(_0006_2006_2001);
		_000E_2007.Add(_000E_2006_2001);
		_000E_2007.Add(_000F_2006_2001);
		_000E_2007.Add(_0002_2007_2001);
		_000E_2007.Add(_0003_2007_2001);
		_000E_2007.Add(_0005_2007_2001);
		_000E_2007.Add(_0008_2007_2001);
		_000E_2007.Add(_0006_2007_2001);
		_000E_2007.Add(_000E_2007_2001);
		_000E_2007.Add(_000F_2007_2001);
		_000E_2007.Add(_0002_2008_2001);
		_000E_2007.Add(_0003_2008_2001);
		_000E_2007.Add(_0005_2008_2001);
		_000E_2007.Add(_0008_2008_2001);
		_000E_2007.Add(_0006_2008_2001);
		_000E_2007.Add(_000E_2008_2001);
		_000E_2007.Add(_000F_2008_2001);
		_000E_2007.Add(_0002_2009_2001);
		_000E_2007.Add(_0003_2009_2001);
		_000E_2007.Add(_0005_2009_2001);
		_000E_2007.Add(_0008_2009_2001);
		_000E_2007.Add(_0006_2009_2001);
		_000E_2007.Add(_000E_2009_2001);
		_000E_2007.Add(_000F_2009_2001);
		_000E_2007.Add(_0002_200A_2001);
		_000E_2007.Add(_0003_200A_2001);
		_000E_2007.Add(_0005_200A_2001);
		_000E_2007.Add(_0008_200A_2001);
		_000E_2007.Add(_0006_200A_2001);
		_000E_2007.Add(_000E_200A_2001);
		_000E_2007.Add(_000F_200A_2001);
		_000E_2007.Add(_0002_200B_2001);
		_000E_2007.Add(_0003_200B_2001);
		_000E_2007.Add(_0005_200B_2001);
		_000E_2007.Add(_0008_200B_2001);
		_000E_2007.Add(_0006_200B_2001);
		_000E_2007.Add(_000E_200B_2001);
		_000E_2007.Add(_000F_200B_2001);
		_000E_2007.Add(_0002_2000_2002);
		_000E_2007.Add(_0003_2000_2002);
		_000E_2007.Add(_0005_2000_2002);
		_000E_2007.Add(_0008_2000_2002);
		_000E_2007.Add(_0006_2000_2002);
		_000E_2007.Add(_000E_2000_2002);
		_000E_2007.Add(_000F_2000_2002);
		_000E_2007.Add(_0002_2001_2002);
		_000E_2007.Add(_0003_2001_2002);
		_000E_2007.Add(_0005_2001_2002);
		_000E_2007.Add(_0008_2001_2002);
		_000E_2007.Add(_0006_2001_2002);
		_000E_2007.Add(_000E_2001_2002);
		_000E_2007.Add(_000F_2001_2002);
		_000E_2007.Add(_0002_2002_2002);
		_000E_2007.Add(_0003_2002_2002);
		_000E_2007.Add(_0005_2002_2002);
		_000E_2007.Add(_000F_2004_2002);
		_000E_2007.Add(_0006_2002_2002);
		_000E_2007.Add(_0008_2002_2002);
		_000E_2007.Add(_000E_2002_2002);
		_000E_2007.Add(_000F_2002_2002);
		_000E_2007.Add(_0002_2003_2002);
		_000E_2007.Add(_0003_2003_2002);
		_000E_2007.Add(_0005_2003_2002);
		_000E_2007.Add(_0008_2003_2002);
		_000E_2007.Add(_0006_2003_2002);
		_000E_2007.Add(_000E_2003_2002);
		_000E_2007.Add(_000F_2003_2002);
		_000E_2007.Add(_0002_2004_2002);
		_000E_2007.Add(_0003_2004_2002);
		_000E_2007.Add(_0005_2004_2002);
		_000E_2007.Add(_0008_2004_2002);
		_000E_2007.Add(_0006_2004_2002);
		_000E_2007.Add(_000E_2004_2002);
		_000E_2007.Add(_0002_2005_2002);
		_000E_2007.Add(_0003_2005_2002);
		_000E_2007.Add(_0005_2005_2002);
		_000E_2007.Add(_0008_2005_2002);
		_000E_2007.Add(_0006_2005_2002);
		_000E_2007.Add(_000E_2005_2002);
		_000E_2007.Add(_000F_2005_2002);
		_000E_2007.Add(_0002_2006_2002);
		_000E_2007.Add(_0003_2006_2002);
		_000E_2007.Add(_0005_2006_2002);
		_000E_2007.Add(_0008_2006_2002);
		_000E_2007.Add(_0006_2006_2002);
		_000E_2007.Add(_000E_2006_2002);
		_000E_2007.Add(_000F_2006_2002);
		_000E_2007.Add(_0002_2007_2002);
		_000E_2007.Add(_0003_2007_2002);
		_000E_2007.Add(_0005_2007_2002);
		_000E_2007.Add(_0008_2007_2002);
		_000E_2007.Add(_0006_2007_2002);
		_000E_2007.Add(_000E_2007_2002);
		_000E_2007.Add(_000F_2007_2002);
		_000E_2007.Add(_0002_2008_2002);
		_000E_2007.Add(_0003_2008_2002);
		_000E_2007.Add(_0005_2008_2002);
		_000E_2007.Add(_0008_2008_2002);
		_000E_2007.Add(_0006_2008_2002);
		_000E_2007.Add(_000E_2008_2002);
		_000E_2007.Add(_000F_2008_2002);
		_000E_2007.Add(_0002_2009_2002);
		_000E_2007.Add(_0003_2009_2002);
		_000E_2007.Add(_0005_2009_2002);
		_000E_2007.Add(_0008_2009_2002);
		_000E_2007.Add(_0006_2009_2002);
		_000E_2007.Add(_000E_2009_2002);
		_000E_2007.Add(_000F_2009_2002);
		_000E_2007.Add(_0002_200A_2002);
		_000E_2007.Add(_0003_200A_2002);
		_000E_2007.Add(_0005_200A_2002);
		_000E_2007.Add(_0008_200A_2002);
		_000E_2007.Add(_0006_200A_2002);
		_000E_2007.Add(_000E_200A_2002);
		_000E_2007.Add(_000F_200A_2002);
		_000E_2007.Add(_0002_200B_2002);
		_000E_2007.Add(_0003_200B_2002);
		_000E_2007.Add(_0005_200B_2002);
		_000E_2007.Add(_0008_200B_2002);
		_000E_2007.Add(_0006_200B_2002);
		_000E_2007.Add(_000E_200B_2002);
		_000E_2007.Add(_0002_2001_2003);
		_000E_2007.Add(_0003_2001_2003);
		_000E_2007.Add(_0005_2001_2003);
		_000E_2007.Add(_0008_2001_2003);
		_000E_2007.Add(_0006_2001_2003);
		_000E_2007.Add(_000E_2001_2003);
		_000E_2007.Add(_000F_200B_2002);
		_000E_2007.Add(_0002_2000_2003);
		_000E_2007.Add(_0003_2000_2003);
		_000E_2007.Add(_000F_2001_2003);
		_000E_2007.Add(_0002_2002_2003);
		_000E_2007.Add(_0003_2002_2003);
		_000E_2007.Add(_0005_2002_2003);
		_000E_2007.Add(_0008_2002_2003);
		_000E_2007.Add(_0005_2000_2003);
		_000E_2007.Add(_0008_2000_2003);
		_000E_2007.Add(_0006_2000_2003);
		_000E_2007.Add(_000E_2000_2003);
		_000E_2007.Add(_000F_2000_2003);
		_000E_2007.Add(_0006_2002_2003);
		_000E_2007.Add(_000E_2002_2003);
		_000E_2007.Add(_000F_2002_2003);
		_000E_2007.Add(_0002_2003_2003);
		_000E_2007.Add(_0003_2003_2003);
		_000E_2007.Add(_0005_2003_2003);
		_000E_2007.Add(_000F_2004_2003);
		_000E_2007.Add(_0002_2005_2003);
		_000E_2007.Add(_0008_2003_2003);
		_000E_2007.Add(_0006_2003_2003);
		_000E_2007.Add(_000E_2003_2003);
		_000E_2007.Add(_000F_2003_2003);
		_000E_2007.Add(_0002_2004_2003);
		_000E_2007.Add(_0003_2004_2003);
		_000E_2007.Add(_0005_2004_2003);
		_000E_2007.Add(_0008_2004_2003);
		_000E_2007.Add(_0006_2004_2003);
		_000E_2007.Add(_000E_2004_2003);
		_000E_2007.Add(_0003_2005_2003);
		_000E_2007.Add(_0005_2005_2003);
		_000E_2007.Add(_0008_2005_2003);
		_000E_2007.Add(_0006_2005_2003);
		_000E_2007.Add(_000E_2005_2003);
		_000E_2007.Add(_000F_2005_2003);
		_000E_2007.Add(_0002_2006_2003);
		_000E_2007.Add(_0003_2006_2003);
		_000E_2007.Add(_0005_2006_2003);
		_000E_2007.Add(_0008_2006_2003);
		_000E_2007.Add(_0006_2006_2003);
		_000E_2007.Add(_000E_2006_2003);
		_000E_2007.Add(_000F_2006_2003);
		_000E_2007.Add(_0002_2007_2003);
		_000E_2007.Add(_0003_2007_2003);
		_000E_2007.Add(_0005_2007_2003);
		_000E_2007.Add(_0008_2007_2003);
		_000E_2007.Add(_0006_2007_2003);
		_000E_2007.Add(_000E_2007_2003);
		_000E_2007.Add(_000F_2007_2003);
		_000E_2007.Add(_0002_2008_2003);
		_000E_2007.Add(_0003_2008_2003);
		_000E_2007.Add(_0005_2008_2003);
		_000E_2007.Add(_0006_2008_2003);
		_000E_2007.Add(_0008_2008_2003);
		_000E_2007.Add(_000E_2008_2003);
		_000E_2007.Add(_000F_2008_2003);
		_000E_2007.Add(_0002_2009_2003);
		_000E_2007.Add(_0003_2009_2003);
		_000E_2007.Add(_0005_2009_2003);
		_000E_2007.Add(_0008_2009_2003);
		_000E_2007.Add(_0006_2009_2003);
		_000E_2007.Add(_000E_2009_2003);
		_000E_2007.Add(_000F_2009_2003);
		_000E_2007.Add(_0002_200A_2003);
		_000E_2007.Add(_0003_200A_2003);
		_000E_2007.Add(_0005_200A_2003);
		_000E_2007.Add(_0008_200A_2003);
		_000E_2007.Add(_0006_200A_2003);
	}

	private void _0002(object _0002, EventArgs _0003)
	{
	}

	private void _0003(object _0002, EventArgs _0003)
	{
	}

	private void _0005(object _0002, EventArgs _0003)
	{
	}

	private void _0008(object _0002, EventArgs _0003)
	{
	}

	private void _0002(object _0002, PaintEventArgs _0003)
	{
	}

	private void _0006(object _0002, EventArgs _0003)
	{
	}

	private void _000E(object _0002, EventArgs _0003)
	{
		Close();
	}

	private void _000F(object _0002, EventArgs _0003)
	{
	}

	private void _0002_2000(object _0002, EventArgs _0003)
	{
		this._0006_2001 = true;
		_0005();
		_0002_2000();
		_000F_200A_2003.Visible = false;
		this._0002();
	}

	private void _0002(object _0002, KeyEventArgs _0003)
	{
		if (_0003.KeyCode == Keys.Left)
		{
			this._0008_2000 = 1;
		}
		if (_0003.KeyCode == Keys.Right)
		{
			this._0008_2000 = 2;
		}
		if (_0003.KeyCode == Keys.Up)
		{
			this._0008_2000 = 3;
		}
		if (_0003.KeyCode == Keys.Down)
		{
			this._0008_2000 = 4;
		}
		if (_0003.KeyCode == Keys.Escape)
		{
			Close();
		}
		this._000E_2000 = this._0008_2000;
	}

	private void _0003_2000(object _0002, EventArgs _0003)
	{
		_0002_200B_2003.Image = global::_000E_2000._0005_2004();
	}

	private void _0005_2000(object _0002, EventArgs _0003)
	{
		_0002_200B_2003.Image = global::_000E_2000._0008_2004();
	}

	private void _0008_2000(object _0002, EventArgs _0003)
	{
		if (_0005_200B_2003.Enabled)
		{
			_0008_2000();
			_0005_2000();
		}
		if (_0003_2008.Enabled || _0005_2008.Enabled || _0006_2008.Enabled || _0008_2008.Enabled)
		{
			_0006_2000();
		}
		if (_0008_2003)
		{
			this._0003();
		}
		_0008();
		_0002_2000();
		_000E();
	}

	private void _0006_2000(object _0002, EventArgs _0003)
	{
		_0005_2009.Visible = false;
		_0002_2008.Enabled = true;
		_0008_2009.Enabled = false;
		_0008_2003 = true;
	}

	private void _000E_2000(object _0002, EventArgs _0003)
	{
		if (_0005_2008.Top == 180)
		{
			_000F_2006 = 2;
		}
		if (_0005_2008.Top == 192)
		{
			_000F_2006 = 1;
		}
		if (_000F_2006 == 1)
		{
			_0005_2008.Top--;
			_0008_2008.Top--;
		}
		if (_000F_2006 == 2)
		{
			_0005_2008.Top++;
			_0008_2008.Top++;
		}
	}

	private void _000F_2000(object _0002, EventArgs _0003)
	{
		_000E_2005++;
		if (_0006_2008.Top > 150 && _000E_2005 > 100)
		{
			_0005_2006 = 3;
			_0006_2008.Top--;
		}
		if (_0006_2008.Top == 150)
		{
			_000E_2009.Enabled = false;
		}
	}

	private void _0002_2001(object _0002, EventArgs _0003)
	{
		_000F_2005++;
		if (_0005_2008.Left > 153 && _0005_2008.Left < 176 && _000F_2005 > 300)
		{
			_0005_2008.Left++;
		}
		if (_0005_2008.Top > 150 && _0005_2008.Left == 176)
		{
			_0005_2008.Top--;
		}
		if (_0005_2008.Top == 150)
		{
			_0002_200A.Enabled = true;
			_000F_2009.Enabled = false;
		}
	}

	private void _0003_2001(object _0002, EventArgs _0003)
	{
		_0002_2006++;
		if (_0008_2008.Left > 176 && _0008_2008.Left < 200 && _0002_2006 > 100)
		{
			_0008_2008.Left--;
		}
		if (_0008_2008.Top > 150 && _0008_2008.Left == 176)
		{
			_0008_2008.Top--;
		}
		if (_0008_2008.Top == 150)
		{
			_0002_200A.Enabled = false;
		}
	}

	private void _0005_2001(object _0002, EventArgs _0003)
	{
		_000F_2004 = false;
		if (!_0005_2002)
		{
			_0005_2004 = false;
			this._000E_2001 = true;
			_000E_2003 = false;
			_0002_2007 = 2;
		}
		if (!_0008_2002)
		{
			_0008_2004 = false;
			this._000F_2001 = true;
			_000F_2003 = false;
			_0003_2007 = 2;
		}
		if (!_0006_2002)
		{
			_0006_2004 = false;
			this._0002_2002 = true;
			_0002_2004 = false;
			_0005_2007 = 2;
		}
		if (!_000E_2002)
		{
			_000E_2004 = false;
			this._0003_2002 = true;
			_0003_2004 = false;
			_0008_2007 = 2;
		}
		_0006_2003 = false;
		_0008_200B_2003.Enabled = false;
		_0005_2000_2004.Enabled = false;
		if (_0005_2006 == 1 && !_0005_2002)
		{
			if ((_0003_2008.Left & 1) == 0)
			{
				this._0002 = _0002_2007;
			}
			_0003_2008.Image = global::_000E_2000._000E_2004();
		}
		if (_0005_2006 == 2 && !_0005_2002)
		{
			if ((_0003_2008.Left & 1) == 0)
			{
				this._0002 = -_0002_2007;
			}
			_0003_2008.Image = global::_000E_2000._0002_2005();
		}
		if (_0005_2006 == 3 && !_0005_2002)
		{
			if ((_0003_2008.Top & 1) == 0)
			{
				this._000E = -_0002_2007;
			}
			_0003_2008.Image = global::_000E_2000._0003_2005();
		}
		if (_0005_2006 == 4 && !_0005_2002)
		{
			if ((_0003_2008.Top & 1) == 0)
			{
				this._000E = _0002_2007;
			}
			_0003_2008.Image = global::_000E_2000._0006_2004();
		}
		if (_0008_2006 == 1 && !_0008_2002)
		{
			if ((_0005_2008.Left & 1) == 0)
			{
				this._0003 = _0003_2007;
			}
			_0005_2008.Image = global::_000E_2000._000E();
		}
		if (_0008_2006 == 2 && !_0008_2002)
		{
			if ((_0005_2008.Left & 1) == 0)
			{
				this._0003 = -_0003_2007;
			}
			_0005_2008.Image = global::_000E_2000._000F();
		}
		if (_0008_2006 == 3 && !_0008_2002)
		{
			if ((_0005_2008.Top & 1) == 0)
			{
				this._000F = -_0003_2007;
			}
			_0005_2008.Image = global::_000E_2000._0002_2000();
		}
		if (_0008_2006 == 4 && !_0008_2002)
		{
			if ((_0005_2008.Top & 1) == 0)
			{
				this._000F = _0003_2007;
			}
			_0005_2008.Image = global::_000E_2000._0006();
		}
		if (_0006_2006 == 1 && !_0006_2002)
		{
			if ((_0006_2008.Left & 1) == 0)
			{
				this._0005 = _0005_2007;
			}
			_0006_2008.Image = global::_000E_2000._000E_2005();
		}
		if (_0006_2006 == 2 && !_0006_2002)
		{
			if ((_0006_2008.Left & 1) == 0)
			{
				this._0005 = -_0005_2007;
			}
			_0006_2008.Image = global::_000E_2000._0002_2006();
		}
		if (_0006_2006 == 3 && !_0006_2002)
		{
			if ((_0006_2008.Top & 1) == 0)
			{
				this._0002_2000 = -_0005_2007;
			}
			_0006_2008.Image = global::_000E_2000._0003_2006();
		}
		if (_0006_2006 == 4 && !_0006_2002)
		{
			if ((_0006_2008.Top & 1) == 0)
			{
				this._0002_2000 = _0005_2007;
			}
			_0006_2008.Image = global::_000E_2000._0006_2005();
		}
		if (_000E_2006 == 1 && !_000E_2002)
		{
			if ((_0008_2008.Left & 1) == 0)
			{
				this._0008 = _0008_2007;
			}
			_0008_2008.Image = global::_000E_2000._0005_2001();
		}
		if (_000E_2006 == 2 && !_000E_2002)
		{
			if ((_0008_2008.Left & 1) == 0)
			{
				this._0008 = -_0008_2007;
			}
			_0008_2008.Image = global::_000E_2000._0006_2001();
		}
		if (_000E_2006 == 3 && !_000E_2002)
		{
			if ((_0008_2008.Top & 1) == 0)
			{
				this._0003_2000 = -_0008_2007;
			}
			_0008_2008.Image = global::_000E_2000._000E_2001();
		}
		if (_000E_2006 == 4 && !_000E_2002)
		{
			if ((_0008_2008.Top & 1) == 0)
			{
				this._0003_2000 = _0008_2007;
			}
			_0003_2008.Image = global::_000E_2000._0003_2001();
		}
	}

	private void _0008_2001(object _0002, EventArgs _0003)
	{
		_0005_200B_2003.SetBounds(_0005_200B_2003.Left, _0005_200B_2003.Top, 0, 0);
		_0005_2002 = false;
		_0008_2002 = false;
		_0006_2002 = false;
		_000E_2002 = false;
		_0005_2004 = false;
		_0008_2004 = false;
		_0006_2004 = false;
		_000E_2004 = false;
		this._000E_2001 = true;
		this._000F_2001 = true;
		this._0002_2002 = true;
		this._0003_2002 = true;
		_0003_2008.Visible = false;
		_0005_2008.Visible = false;
		_0006_2008.Visible = false;
		_0008_2008.Visible = false;
		_0005_200B_2003.Visible = false;
		_000E_2005 = 0;
		_000F_2005 = 0;
		_0002_2006 = 0;
		_0006_2003 = false;
		_000E_2003 = false;
		_000F_2003 = false;
		_0002_2004 = false;
		_0003_2004 = false;
		_0002_2007 = 2;
		_0003_2007 = 2;
		_0005_2007 = 2;
		_0008_2007 = 2;
		_0006_2005--;
		_0005();
		_0005_2006 = 0;
		_0008_2006 = 0;
		_0006_2006 = 0;
		_000E_2006 = 0;
		_000F_2006 = 1;
		_000F_2002 = false;
		_0002_2003 = false;
		_0003_2003 = false;
		_0005_2003 = false;
		_0008_2003 = false;
		this._0008_2000 = 0;
		this._000E_2000 = 1;
		this._0006_2000 = 0;
		_0005_200B_2003.Left = 24;
		_0005_200B_2003.Top = 364;
		_0003_2008.Left = 176;
		_0003_2008.Top = 150;
		_0005_2008.Left = 154;
		_0005_2008.Top = 185;
		_0006_2008.Left = 176;
		_0006_2008.Top = 185;
		_0008_2008.Left = 199;
		_0008_2008.Top = 185;
		this._0002 = 0;
		this._0003 = 0;
		this._0005 = 0;
		this._0008 = 0;
		this._000E = 0;
		this._000F = 0;
		this._0002_2000 = 0;
		this._0003_2000 = 0;
		this._0006 = 0;
		this._0005_2000 = 0;
		_000E_200A_2003.Enabled = false;
		_0005_200B_2003.Image = global::_000E_2000._0003();
		_0003_2008.Image = global::_000E_2000._0003_2005();
		_0005_2008.Image = global::_000E_2000._0002_2000();
		_0006_2008.Image = global::_000E_2000._0003_2006();
		_0008_2008.Image = global::_000E_2000._000E_2001();
		_0003_2008.Visible = true;
		_0005_2008.Visible = true;
		_0006_2008.Visible = true;
		_0008_2008.Visible = true;
		_0005_200B_2003.SetBounds(_0005_200B_2003.Left, _0005_200B_2003.Top, 22, 22);
		_0005_200B_2003.Visible = true;
		_0008_2009.Enabled = true;
		_0006_2009.Enabled = true;
		_000E_200A_2003.Interval = 1900;
	}

	private void _0006_2001(object _0002, EventArgs _0003)
	{
		_0003_200B_2003.Visible = true;
		_0002_200B_2003.Visible = true;
		_000E_200B_2003.Enabled = false;
	}

	private void _0002()
	{
		_0005_2002 = false;
		_0008_2002 = false;
		_0006_2002 = false;
		_000E_2002 = false;
		_0005_2004 = false;
		_0008_2004 = false;
		_0006_2004 = false;
		_000E_2004 = false;
		this._000E_2001 = true;
		this._000F_2001 = true;
		this._0002_2002 = true;
		this._0003_2002 = true;
		_0002_2000_2004.Visible = false;
		_0003_2000_2004.Visible = false;
		_0005_200B_2003.SetBounds(_0005_200B_2003.Left, _0005_200B_2003.Top, 22, 22);
		_000E_2005 = 0;
		_000F_2005 = 0;
		_0002_2006 = 0;
		_0006_2003 = false;
		_000E_2003 = false;
		_000F_2003 = false;
		_0002_2004 = false;
		_0003_2004 = false;
		_0002_2007 = 2;
		_0003_2007 = 2;
		_0005_2007 = 2;
		_0008_2007 = 2;
		_0005();
		_0005_2006 = 0;
		_0008_2006 = 0;
		_0006_2006 = 0;
		_000E_2006 = 0;
		_000F_2006 = 1;
		_000F_2002 = false;
		_0002_2003 = false;
		_0003_2003 = false;
		_0005_2003 = false;
		_0008_2003 = false;
		this._0008_2000 = 0;
		this._000E_2000 = 1;
		this._0006_2000 = 0;
		_0005_200B_2003.Left = 24;
		_0005_200B_2003.Top = 364;
		_0003_2008.Left = 176;
		_0003_2008.Top = 150;
		_0005_2008.Left = 154;
		_0005_2008.Top = 185;
		_0006_2008.Left = 176;
		_0006_2008.Top = 185;
		_0008_2008.Left = 199;
		_0008_2008.Top = 185;
		this._0002 = 0;
		this._0003 = 0;
		this._0005 = 0;
		this._0008 = 0;
		this._000E = 0;
		this._000F = 0;
		this._0002_2000 = 0;
		this._0003_2000 = 0;
		this._0006 = 0;
		this._0005_2000 = 0;
		_0005_200B_2003.Image = global::_000E_2000._0003();
		_0003_2008.Image = global::_000E_2000._0003_2005();
		_0005_2008.Image = global::_000E_2000._0002_2000();
		_0006_2008.Image = global::_000E_2000._0003_2006();
		_0008_2008.Image = global::_000E_2000._000E_2001();
		_0002_2008.Enabled = false;
		_000E_2009.Enabled = false;
		_000F_2009.Enabled = false;
		_0002_200A.Enabled = false;
		_0006_200B_2003.Enabled = false;
		_000E_200A_2003.Enabled = false;
		_0008_200B_2003.Enabled = false;
		_0005_2000_2004.Enabled = false;
		if (this._0006_2001)
		{
			_0008_2009.Enabled = true;
			_0006_2009.Enabled = true;
		}
		this._0006_2001 = false;
		for (int i = 0; i < 332; i++)
		{
			((Label)_000E_2007[i]).Visible = true;
		}
	}

	private void _000E_2001(object _0002, EventArgs _0003)
	{
		_0006_200B_2003.Enabled = false;
		_000F_200A_2003.Visible = true;
		_0008_2000_2004.Enabled = true;
	}

	private void _000F_2001(object _0002, EventArgs _0003)
	{
		this._0002();
		_0008_2000_2004.Enabled = false;
	}

	private void _0003()
	{
		if (_0005_2008.Top == 185)
		{
			_0006_2009.Enabled = false;
			_000E_2009.Enabled = true;
			_0008_2003 = false;
			_000F_2009.Enabled = true;
		}
	}

	private void _0005()
	{
		if (_0006_2005 == 3)
		{
			_0002_2009.Visible = true;
			_0003_2009.Visible = true;
		}
		if (_0006_2005 == 2)
		{
			_0002_2009.Visible = true;
			_0003_2009.Visible = false;
		}
		if (_0006_2005 == 1)
		{
			_0002_2009.Visible = false;
			_0003_2009.Visible = false;
		}
	}

	private void _0008()
	{
		if (_0005_200B_2003.Bounds.IntersectsWith(_0002_200B_2001.Bounds) && _0002_200B_2001.Visible)
		{
			_0006();
		}
		if (_0005_200B_2003.Bounds.IntersectsWith(_000E_2005_2003.Bounds) && _000E_2005_2003.Visible)
		{
			_0006();
		}
		if (_0005_200B_2003.Bounds.IntersectsWith(_000E_2005_2002.Bounds) && _000E_2005_2002.Visible)
		{
			_0006();
		}
		if (_0005_200B_2003.Bounds.IntersectsWith(_000F_2008_2000.Bounds) && _000F_2008_2000.Visible)
		{
			_0006();
		}
	}

	private void _0006()
	{
		if (!_0005_2002)
		{
			_0005_2004 = false;
			_0002_2007 = 2;
			_000E_2003 = true;
			_0003_2008.Image = global::_000E_2000._0008_2000();
			this._000E_2001 = true;
		}
		if (!_0008_2002)
		{
			_0008_2004 = false;
			_0003_2007 = 2;
			_000F_2003 = true;
			_0005_2008.Image = global::_000E_2000._0008_2000();
			this._000F_2001 = true;
		}
		if (!_0006_2002)
		{
			_0006_2004 = false;
			_0005_2007 = 2;
			_0002_2004 = true;
			_0006_2008.Image = global::_000E_2000._0008_2000();
			this._0002_2002 = true;
		}
		if (!_000E_2002)
		{
			_000E_2004 = false;
			_0008_2007 = 2;
			_0003_2004 = true;
			_0008_2008.Image = global::_000E_2000._0008_2000();
			this._0003_2002 = true;
		}
		_0008_200B_2003.Enabled = false;
		_0005_2000_2004.Enabled = false;
		_0005_2000_2004.Enabled = true;
		_000F_2004 = false;
		_0008_200B_2003.Enabled = true;
		_0006_2003 = true;
	}

	private void _0002_2002(object _0002, EventArgs _0003)
	{
		_000F_2004 = true;
		_0005_2000_2004.Enabled = false;
	}

	private void _000E()
	{
		if (!_0005_200B_2003.Bounds.IntersectsWith(_0003_2008.Bounds) && !_0005_200B_2003.Bounds.IntersectsWith(_0005_2008.Bounds) && !_0005_200B_2003.Bounds.IntersectsWith(_0006_2008.Bounds) && !_0005_200B_2003.Bounds.IntersectsWith(_0008_2008.Bounds))
		{
			return;
		}
		if (_0005_200B_2003.Bounds.IntersectsWith(_0003_2008.Bounds) && !_000E_2003)
		{
			_000F();
		}
		if (_0005_200B_2003.Bounds.IntersectsWith(_0005_2008.Bounds) && !_000F_2003)
		{
			_000F();
		}
		if (_0005_200B_2003.Bounds.IntersectsWith(_0006_2008.Bounds) && !_0002_2004)
		{
			_000F();
		}
		if (_0005_200B_2003.Bounds.IntersectsWith(_0008_2008.Bounds) && !_0003_2004)
		{
			_000F();
		}
		if (_0006_2003)
		{
			if (_0005_200B_2003.Bounds.IntersectsWith(_0003_2008.Bounds) && !_000E_2003)
			{
				_000F();
			}
			if (_0005_200B_2003.Bounds.IntersectsWith(_0005_2008.Bounds) && !_000F_2003)
			{
				_000F();
			}
			if (_0005_200B_2003.Bounds.IntersectsWith(_0006_2008.Bounds) && !_0002_2004)
			{
				_000F();
			}
			if (_0005_200B_2003.Bounds.IntersectsWith(_0008_2008.Bounds) && !_0003_2004)
			{
				_000F();
			}
		}
		if (_0005_200B_2003.Bounds.IntersectsWith(_0003_2008.Bounds) && this._000E_2001 && _000E_2003)
		{
			_0005_2002 = true;
			_0005_2004 = true;
			this._000E_2001 = false;
			_0002_2008.Enabled = false;
			_000F_200B_2003.Enabled = true;
			_0002_2007 = 4;
		}
		if (_0005_200B_2003.Bounds.IntersectsWith(_0005_2008.Bounds) && this._000F_2001 && _000F_2003)
		{
			_0008_2002 = true;
			_0008_2004 = true;
			this._000F_2001 = false;
			_0002_2008.Enabled = false;
			_000F_200B_2003.Enabled = true;
			_0003_2007 = 4;
		}
		if (_0005_200B_2003.Bounds.IntersectsWith(_0006_2008.Bounds) && this._0002_2002 && _0002_2004)
		{
			_0006_2002 = true;
			_0006_2004 = true;
			this._0002_2002 = false;
			_0002_2008.Enabled = false;
			_000F_200B_2003.Enabled = true;
			_0005_2007 = 4;
		}
		if (_0005_200B_2003.Bounds.IntersectsWith(_0008_2008.Bounds) && this._0003_2002 && _0003_2004)
		{
			_000E_2002 = true;
			_000E_2004 = true;
			this._0003_2002 = false;
			_0002_2008.Enabled = false;
			_000F_200B_2003.Enabled = true;
			_0008_2007 = 4;
		}
	}

	private void _0003_2002(object _0002, EventArgs _0003)
	{
		_0002_2008.Enabled = true;
		_000F_200B_2003.Enabled = false;
	}

	private void _000F()
	{
		_0005_200B_2003.Image = global::_000E_2000._000E_2003();
		if (_0006_2005 - 1 <= 0)
		{
			_0002_2000_2004.Visible = true;
			_0003_2000();
			return;
		}
		this._0005_2000 = 0;
		this._0006 = 0;
		this._000E = 0;
		this._000F = 0;
		this._0002_2000 = 0;
		this._0003_2000 = 0;
		this._0002 = 0;
		this._0003 = 0;
		this._0005 = 0;
		this._0008 = 0;
		_0002_2008.Enabled = false;
		_000E_2009.Enabled = false;
		_000F_2009.Enabled = false;
		_0002_200A.Enabled = false;
		this._000F_2000 = false;
		this._0002_2001 = false;
		this._0003_2001 = false;
		this._0005_2001 = false;
		this._0008_2001 = false;
		_000E_200A_2003.Enabled = true;
	}

	private void _0002_2000()
	{
		for (int i = 0; i < 332; i++)
		{
			if (((Label)_000E_2007[i]).Visible && _0005_200B_2003.Bounds.IntersectsWith(((Label)_000E_2007[i]).Bounds))
			{
				_0003_2006++;
				((Label)_000E_2007[i]).Visible = false;
			}
		}
		_0003_2002_2000.Text = _0003_2006.ToString();
		if (_0003_2006 >= 332)
		{
			_0003_2000();
			_0003_2000_2004.Visible = true;
		}
	}

	private void _0003_2000()
	{
		_0003_2006 = 0;
		_0006_2005 = 3;
		_0002_2008.Enabled = false;
		_0008_2009.Enabled = false;
		_0006_2009.Enabled = false;
		_000E_2009.Enabled = false;
		_000F_2009.Enabled = false;
		_0002_200A.Enabled = false;
		_0005_2000_2004.Enabled = false;
		_0008_200B_2003.Enabled = false;
		_0006_200B_2003.Enabled = true;
	}

	private void _0005_2000()
	{
		switch (this._0006_2000)
		{
		case 1:
			if (this._0008_2000 == 2)
			{
				this._0006 = 2;
				_0005_200B_2003.Image = global::_000E_2000._0008_2003();
				this._0006_2000 = this._0008_2000;
				this._000E_2000 = this._0008_2000;
			}
			break;
		case 2:
			if (this._0008_2000 == 1)
			{
				this._0006 = -2;
				_0005_200B_2003.Image = global::_000E_2000._000F_2003();
				this._0006_2000 = this._0008_2000;
				this._000E_2000 = this._0008_2000;
			}
			break;
		case 3:
			if (this._0008_2000 == 4)
			{
				this._0005_2000 = 2;
				_0005_200B_2003.Image = global::_000E_2000._0005_2003();
				this._0006_2000 = this._0008_2000;
				this._000E_2000 = this._0008_2000;
			}
			break;
		case 4:
			if (this._0008_2000 == 3)
			{
				this._0005_2000 = -2;
				_0005_200B_2003.Image = global::_000E_2000._0002_2004();
				this._0006_2000 = this._0008_2000;
				this._000E_2000 = this._0008_2000;
			}
			break;
		}
	}

	private void _0002(int _0002, int _0003, int _0005, int _0008)
	{
		if (this._0002_2001)
		{
			if (_000E_2003 && !this._000E_2001)
			{
				if ((_0003_2008.Left < 180 && _0003_2008.Top == 150) || (_0003_2008.Left > 170 && _0003_2008.Top == 150))
				{
					_0002_2007 = 2;
					_000E_2003 = false;
					_0005_2004 = false;
					this._000E_2001 = true;
					_0005_2002 = false;
				}
				else
				{
					if (_0003_2008.Top < 150 && _0005 == 1 && _0008 == 1)
					{
						_0005 = 0;
					}
					if (_0003_2008.Top > 150 && _0005 == 1 && _0008 == 1)
					{
						_0008 = 0;
					}
					if (_0003_2008.Left < 176 && _0002 == 1 && _0003 == 1)
					{
						_0002 = 0;
					}
					if (_0003_2008.Left > 176 && _0002 == 1 && _0003 == 1)
					{
						_0003 = 0;
					}
				}
			}
			this._000E = 0;
			this._0002 = 0;
			while (!_000F_2002)
			{
				_0002_2005 = _0006_2007.Next(1, 5);
				if (_0002_2005 == 1 && !_000F_2002 && _0002_2005 != _0005_2006 && _0002 == 1)
				{
					this._0002 = -_0002_2007;
					_000F_2002 = true;
					if (!_000E_2003 && this._000E_2001)
					{
						_0003_2008.Image = global::_000E_2000._0002_2005();
					}
					else if (!_000F_2004 || _0005_2002)
					{
						if (!_000F_2004)
						{
							_0003_2008.Image = global::_000E_2000._0008_2000();
						}
						if (_0005_2002)
						{
							_0003_2008.Image = global::_000E_2000._000F_2002();
						}
					}
					else
					{
						_0003_2008.Image = global::_000E_2000._0008_2005();
					}
				}
				if (_0002_2005 == 2 && !_000F_2002 && _0002_2005 != _0005_2006 && _0003 == 1)
				{
					this._0002 = _0002_2007;
					_000F_2002 = true;
					if (!_000E_2003 && this._000E_2001)
					{
						_0003_2008.Image = global::_000E_2000._000E_2004();
					}
					else if (!_000F_2004 || _0005_2002)
					{
						if (!_000F_2004)
						{
							_0003_2008.Image = global::_000E_2000._0008_2000();
						}
						if (_0005_2002)
						{
							_0003_2008.Image = global::_000E_2000._000E_2002();
						}
					}
					else
					{
						_0003_2008.Image = global::_000E_2000._0008_2005();
					}
				}
				if (_0002_2005 == 3 && !_000F_2002 && _0002_2005 != _0005_2006 && _0008 == 1)
				{
					this._000E = _0002_2007;
					_000F_2002 = true;
					if (!_000E_2003 && this._000E_2001)
					{
						_0003_2008.Image = global::_000E_2000._0006_2004();
					}
					else if (!_000F_2004 || _0005_2002)
					{
						if (!_000F_2004)
						{
							_0003_2008.Image = global::_000E_2000._0008_2000();
						}
						if (_0005_2002)
						{
							_0003_2008.Image = global::_000E_2000._0006_2002();
						}
					}
					else
					{
						_0003_2008.Image = global::_000E_2000._0008_2005();
					}
				}
				if (_0002_2005 != 4 || _000F_2002 || _0002_2005 == _0005_2006 || _0005 != 1)
				{
					continue;
				}
				this._000E = -_0002_2007;
				_000F_2002 = true;
				if (!_000E_2003 && this._000E_2001)
				{
					_0003_2008.Image = global::_000E_2000._0003_2005();
				}
				else if (!_000F_2004 || _0005_2002)
				{
					if (!_000F_2004)
					{
						_0003_2008.Image = global::_000E_2000._0008_2000();
					}
					if (_0005_2002)
					{
						_0003_2008.Image = global::_000E_2000._0003_2003();
					}
				}
				else
				{
					_0003_2008.Image = global::_000E_2000._0008_2005();
				}
			}
			if (_0002_2005 == 1)
			{
				_0005_2006 = 2;
			}
			if (_0002_2005 == 2)
			{
				_0005_2006 = 1;
			}
			if (_0002_2005 == 3)
			{
				_0005_2006 = 4;
			}
			if (_0002_2005 == 4)
			{
				_0005_2006 = 3;
			}
			_000F_2002 = false;
		}
		if (this._0003_2001)
		{
			if (_000F_2003 && !this._000F_2001)
			{
				if ((_0005_2008.Left < 180 && _0005_2008.Top == 150) || (_0005_2008.Left > 170 && _0005_2008.Top == 150))
				{
					_0003_2007 = 2;
					_000F_2003 = false;
					_0008_2004 = false;
					this._000F_2001 = true;
					_0008_2002 = false;
				}
				else
				{
					if (_0005_2008.Top < 150 && _0005 == 1 && _0008 == 1)
					{
						_0005 = 0;
					}
					if (_0005_2008.Top > 150 && _0005 == 1 && _0008 == 1)
					{
						_0008 = 0;
					}
					if (_0005_2008.Left < 176 && _0002 == 1 && _0003 == 1)
					{
						_0002 = 0;
					}
					if (_0005_2008.Left > 176 && _0002 == 1 && _0003 == 1)
					{
						_0003 = 0;
					}
				}
			}
			this._000F = 0;
			this._0003 = 0;
			while (!_0002_2003)
			{
				_0003_2005 = _0006_2007.Next(1, 5);
				if (_0003_2005 == 1 && !_0002_2003 && _0003_2005 != _0008_2006 && _0002 == 1)
				{
					this._0003 = -_0003_2007;
					_0002_2003 = true;
					if (!_000F_2003 && this._000F_2001)
					{
						_0005_2008.Image = global::_000E_2000._000F();
					}
					else if (!_000F_2004 || _0008_2002)
					{
						if (!_000F_2004)
						{
							_0005_2008.Image = global::_000E_2000._0008_2000();
						}
						if (_0008_2002)
						{
							_0005_2008.Image = global::_000E_2000._000F_2002();
						}
					}
					else
					{
						_0005_2008.Image = global::_000E_2000._0008_2005();
					}
				}
				if (_0003_2005 == 2 && !_0002_2003 && _0003_2005 != _0008_2006 && _0003 == 1)
				{
					this._0003 = _0003_2007;
					_0002_2003 = true;
					if (!_000F_2003 && this._000F_2001)
					{
						_0005_2008.Image = global::_000E_2000._000E();
					}
					else if (!_000F_2004 || _0008_2002)
					{
						if (!_000F_2004)
						{
							_0005_2008.Image = global::_000E_2000._0008_2000();
						}
						if (_0008_2002)
						{
							_0005_2008.Image = global::_000E_2000._000E_2002();
						}
					}
					else
					{
						_0005_2008.Image = global::_000E_2000._0008_2005();
					}
				}
				if (_0003_2005 == 3 && !_0002_2003 && _0003_2005 != _0008_2006 && _0008 == 1)
				{
					this._000F = _0003_2007;
					_0002_2003 = true;
					if (!_000F_2003 && this._000F_2001)
					{
						_0005_2008.Image = global::_000E_2000._0006();
					}
					else if (!_000F_2004 || _0008_2002)
					{
						if (!_000F_2004)
						{
							_0005_2008.Image = global::_000E_2000._0008_2000();
						}
						if (_0008_2002)
						{
							_0005_2008.Image = global::_000E_2000._0006_2002();
						}
					}
					else
					{
						_0005_2008.Image = global::_000E_2000._0008_2005();
					}
				}
				if (_0003_2005 != 4 || _0002_2003 || _0003_2005 == _0008_2006 || _0005 != 1)
				{
					continue;
				}
				this._000F = -_0003_2007;
				_0002_2003 = true;
				if (!_000F_2003 && this._000F_2001)
				{
					_0005_2008.Image = global::_000E_2000._0002_2000();
				}
				else if (!_000F_2004 || _0008_2002)
				{
					if (!_000F_2004)
					{
						_0005_2008.Image = global::_000E_2000._0008_2000();
					}
					if (_0008_2002)
					{
						_0005_2008.Image = global::_000E_2000._0003_2003();
					}
				}
				else
				{
					_0005_2008.Image = global::_000E_2000._0008_2005();
				}
			}
			if (_0003_2005 == 1)
			{
				_0008_2006 = 2;
			}
			if (_0003_2005 == 2)
			{
				_0008_2006 = 1;
			}
			if (_0003_2005 == 3)
			{
				_0008_2006 = 4;
			}
			if (_0003_2005 == 4)
			{
				_0008_2006 = 3;
			}
			_0002_2003 = false;
		}
		if (this._0005_2001)
		{
			if (_0002_2004 && !this._0002_2002)
			{
				if ((_0006_2008.Left < 180 && _0006_2008.Top == 150) || (_0006_2008.Left > 170 && _0006_2008.Top == 150))
				{
					_0005_2007 = 2;
					_0002_2004 = false;
					_0006_2004 = false;
					this._0002_2002 = true;
					_0006_2002 = false;
				}
				else
				{
					if (_0006_2008.Top > 150 && _0005 == 1 && _0008 == 1)
					{
						_0008 = 0;
					}
					if (_0006_2008.Top < 150 && _0005 == 1 && _0008 == 1)
					{
						_0005 = 0;
					}
					if (_0006_2008.Left < 176 && _0002 == 1 && _0003 == 1)
					{
						_0002 = 0;
					}
					if (_0006_2008.Left > 176 && _0002 == 1 && _0003 == 1)
					{
						_0003 = 0;
					}
				}
			}
			this._0002_2000 = 0;
			this._0005 = 0;
			while (!_0003_2003)
			{
				_0005_2005 = _0006_2007.Next(1, 5);
				if (_0005_2005 == 1 && !_0003_2003 && _0005_2005 != _0006_2006 && _0002 == 1)
				{
					this._0005 = -_0005_2007;
					_0003_2003 = true;
					if (!_0002_2004 && this._0002_2002)
					{
						_0006_2008.Image = global::_000E_2000._0002_2006();
					}
					else if (!_000F_2004 || _0006_2002)
					{
						if (!_000F_2004)
						{
							_0006_2008.Image = global::_000E_2000._0008_2000();
						}
						if (_0006_2002)
						{
							_0006_2008.Image = global::_000E_2000._000F_2002();
						}
					}
					else
					{
						_0006_2008.Image = global::_000E_2000._0008_2005();
					}
				}
				if (_0005_2005 == 2 && !_0003_2003 && _0005_2005 != _0006_2006 && _0003 == 1)
				{
					this._0005 = _0005_2007;
					_0003_2003 = true;
					if (!_0002_2004 && this._0002_2002)
					{
						_0006_2008.Image = global::_000E_2000._000E_2005();
					}
					else if (!_000F_2004 || _0006_2002)
					{
						if (!_000F_2004)
						{
							_0006_2008.Image = global::_000E_2000._0008_2000();
						}
						if (_0006_2002)
						{
							_0006_2008.Image = global::_000E_2000._000E_2002();
						}
					}
					else
					{
						_0006_2008.Image = global::_000E_2000._0008_2005();
					}
				}
				if (_0005_2005 == 3 && !_0003_2003 && _0005_2005 != _0006_2006 && _0008 == 1)
				{
					this._0002_2000 = _0005_2007;
					_0003_2003 = true;
					if (!_0002_2004 && this._0002_2002)
					{
						_0006_2008.Image = global::_000E_2000._0006_2005();
					}
					else if (!_000F_2004 || _0006_2002)
					{
						if (!_000F_2004)
						{
							_0006_2008.Image = global::_000E_2000._0008_2000();
						}
						if (_0006_2002)
						{
							_0006_2008.Image = global::_000E_2000._0006_2002();
						}
					}
					else
					{
						_0006_2008.Image = global::_000E_2000._0008_2005();
					}
				}
				if (_0005_2005 != 4 || _0003_2003 || _0005_2005 == _0006_2006 || _0005 != 1)
				{
					continue;
				}
				this._0002_2000 = -_0005_2007;
				_0003_2003 = true;
				if (!_0002_2004 && this._0002_2002)
				{
					_0006_2008.Image = global::_000E_2000._0003_2006();
				}
				else if (!_000F_2004 || _0006_2002)
				{
					if (!_000F_2004)
					{
						_0006_2008.Image = global::_000E_2000._0008_2000();
					}
					if (_0006_2002)
					{
						_0006_2008.Image = global::_000E_2000._0003_2003();
					}
				}
				else
				{
					_0006_2008.Image = global::_000E_2000._0008_2005();
				}
			}
			if (_0005_2005 == 1)
			{
				_0006_2006 = 2;
			}
			if (_0005_2005 == 2)
			{
				_0006_2006 = 1;
			}
			if (_0005_2005 == 3)
			{
				_0006_2006 = 4;
			}
			if (_0005_2005 == 4)
			{
				_0006_2006 = 3;
			}
			_0003_2003 = false;
		}
		if (this._0008_2001)
		{
			if (_0003_2004 && !this._0003_2002)
			{
				if ((_0008_2008.Left < 180 && _0008_2008.Top == 150) || (_0008_2008.Left > 170 && _0008_2008.Top == 150))
				{
					_0008_2007 = 2;
					_0003_2004 = false;
					_000E_2004 = false;
					this._0003_2002 = true;
					_000E_2002 = false;
				}
				else
				{
					if (_0008_2008.Top > 150 && _0005 == 1 && _0008 == 1)
					{
						_0008 = 0;
					}
					if (_0008_2008.Top < 150 && _0005 == 1 && _0008 == 1)
					{
						_0005 = 0;
					}
					if (_0008_2008.Left < 176 && _0002 == 1 && _0003 == 1)
					{
						_0002 = 0;
					}
					if (_0008_2008.Left > 176 && _0002 == 1 && _0003 == 1)
					{
						_0003 = 0;
					}
				}
			}
			this._0003_2000 = 0;
			this._0008 = 0;
			while (!_0005_2003)
			{
				_0008_2005 = _0006_2007.Next(1, 5);
				if (_0008_2005 == 1 && !_0005_2003 && _0008_2005 != _000E_2006 && _0002 == 1)
				{
					this._0008 = -_0008_2007;
					_0005_2003 = true;
					if (!_0003_2004 && this._0003_2002)
					{
						_0008_2008.Image = global::_000E_2000._0006_2001();
					}
					else if (!_000F_2004 || _000E_2002)
					{
						if (!_000F_2004)
						{
							_0008_2008.Image = global::_000E_2000._0008_2000();
						}
						if (_000E_2002)
						{
							_0008_2008.Image = global::_000E_2000._000F_2002();
						}
					}
					else
					{
						_0008_2008.Image = global::_000E_2000._0008_2005();
					}
				}
				if (_0008_2005 == 2 && !_0005_2003 && _0008_2005 != _000E_2006 && _0003 == 1)
				{
					this._0008 = _0008_2007;
					_0005_2003 = true;
					if (!_0003_2004 && this._0003_2002)
					{
						_0008_2008.Image = global::_000E_2000._0005_2001();
					}
					else if (!_000F_2004 || _000E_2002)
					{
						if (!_000F_2004)
						{
							_0008_2008.Image = global::_000E_2000._0008_2000();
						}
						if (_000E_2002)
						{
							_0008_2008.Image = global::_000E_2000._000E_2002();
						}
					}
					else
					{
						_0008_2008.Image = global::_000E_2000._0008_2005();
					}
				}
				if (_0008_2005 == 3 && !_0005_2003 && _0008_2005 != _000E_2006 && _0008 == 1)
				{
					this._0003_2000 = _0008_2007;
					_0005_2003 = true;
					if (!_0003_2004 && this._0003_2002)
					{
						_0008_2008.Image = global::_000E_2000._0003_2001();
					}
					else if (!_000F_2004 || _000E_2002)
					{
						if (!_000F_2004)
						{
							_0008_2008.Image = global::_000E_2000._0008_2000();
						}
						if (_000E_2002)
						{
							_0008_2008.Image = global::_000E_2000._0006_2002();
						}
					}
					else
					{
						_0008_2008.Image = global::_000E_2000._0008_2005();
					}
				}
				if (_0008_2005 != 4 || _0005_2003 || _0008_2005 == _000E_2006 || _0005 != 1)
				{
					continue;
				}
				this._0003_2000 = -_0008_2007;
				_0005_2003 = true;
				if (!_0003_2004 && this._0003_2002)
				{
					_0008_2008.Image = global::_000E_2000._000E_2001();
				}
				else if (!_000F_2004 || _000E_2002)
				{
					if (!_000F_2004)
					{
						_0008_2008.Image = global::_000E_2000._0008_2000();
					}
					if (_000E_2002)
					{
						_0008_2008.Image = global::_000E_2000._0003_2003();
					}
				}
				else
				{
					_0008_2008.Image = global::_000E_2000._0008_2005();
				}
			}
			if (_0008_2005 == 1)
			{
				_000E_2006 = 2;
			}
			if (_0008_2005 == 2)
			{
				_000E_2006 = 1;
			}
			if (_0008_2005 == 3)
			{
				_000E_2006 = 4;
			}
			if (_0008_2005 == 4)
			{
				_000E_2006 = 3;
			}
			_0005_2003 = false;
		}
		if (!this._000F_2000)
		{
			return;
		}
		this._0005_2000 = 0;
		this._0006 = 0;
		if ((this._000E_2000 == 1 && _0002 == 1) || (this._000E_2000 == 2 && _0003 == 1) || (this._000E_2000 == 3 && _0005 == 1) || (this._000E_2000 == 4 && _0008 == 1))
		{
			this._0008_2000 = this._000E_2000;
		}
		if (this._0008_2000 == 1 && _0002 == 1)
		{
			this._0006 = -2;
			_0005_200B_2003.Image = global::_000E_2000._000F_2003();
			this._0006_2000 = this._0008_2000;
		}
		if (this._0008_2000 == 2 && _0003 == 1)
		{
			this._0006 = 2;
			_0005_200B_2003.Image = global::_000E_2000._0008_2003();
			this._0006_2000 = this._0008_2000;
		}
		if (this._0008_2000 == 3 && _0005 == 1)
		{
			this._0005_2000 = -2;
			_0005_200B_2003.Image = global::_000E_2000._0002_2004();
			this._0006_2000 = this._0008_2000;
		}
		if (this._0008_2000 == 4 && _0008 == 1)
		{
			this._0005_2000 = 2;
			_0005_200B_2003.Image = global::_000E_2000._0005_2003();
			this._0006_2000 = this._0008_2000;
		}
		if (this._0005_2000 == 0 && this._0006 == 0)
		{
			this._000E_2000 = this._0008_2000;
			this._0008_2000 = this._0006_2000;
			if (this._0008_2000 == 1)
			{
				_0005_200B_2003.Image = global::_000E_2000._0005();
			}
			if (this._0008_2000 == 2)
			{
				_0005_200B_2003.Image = global::_000E_2000._0003();
			}
			if (this._0008_2000 == 3)
			{
				_0005_200B_2003.Image = global::_000E_2000._0008();
			}
			if (this._0008_2000 == 4)
			{
				_0005_200B_2003.Image = global::_000E_2000._0002();
			}
		}
	}

	private void _0008_2000()
	{
		this._000F_2000 = true;
		_0002(_0005_200B_2003.Left, _0005_200B_2003.Top);
		_0005_200B_2003.Left += this._0006;
		_0005_200B_2003.Top += this._0005_2000;
	}

	private void _0002(int _0002, int _0003)
	{
		if (this._000F_2000)
		{
			switch (_0002)
			{
			case 174:
				if (_0003 == 148)
				{
					this._0002(1, 1, 0, 0);
				}
				break;
			case 24:
				switch (_0003)
				{
				case 364:
					this._0002(0, 1, 1, 0);
					break;
				case 328:
					this._0002(0, 1, 0, 1);
					break;
				case 292:
					this._0002(0, 1, 1, 0);
					break;
				case 256:
					this._0002(0, 1, 0, 1);
					break;
				case 112:
					this._0002(0, 1, 1, 0);
					break;
				case 76:
					this._0002(0, 1, 1, 1);
					break;
				case 28:
					this._0002(0, 1, 0, 1);
					break;
				}
				break;
			case 48:
				switch (_0003)
				{
				case 328:
					this._0002(1, 1, 1, 0);
					break;
				case 292:
					this._0002(1, 0, 0, 1);
					break;
				}
				break;
			case 84:
				switch (_0003)
				{
				case 256:
					this._0002(1, 1, 1, 1);
					break;
				case 328:
					this._0002(1, 0, 1, 0);
					break;
				case 292:
					this._0002(0, 1, 1, 1);
					break;
				case 184:
					this._0002(1, 1, 1, 1);
					break;
				case 112:
					this._0002(1, 0, 1, 1);
					break;
				case 28:
					this._0002(1, 1, 0, 1);
					break;
				case 76:
					this._0002(1, 1, 1, 1);
					break;
				}
				break;
			case 120:
				switch (_0003)
				{
				case 292:
					this._0002(1, 1, 0, 1);
					break;
				case 328:
					this._0002(0, 1, 1, 0);
					break;
				case 256:
					this._0002(1, 1, 1, 0);
					break;
				case 220:
					this._0002(0, 1, 1, 1);
					break;
				case 76:
					this._0002(1, 1, 0, 1);
					break;
				case 112:
					this._0002(0, 1, 1, 0);
					break;
				case 148:
					this._0002(0, 1, 0, 1);
					break;
				case 184:
					this._0002(1, 0, 1, 1);
					break;
				}
				break;
			case 156:
				switch (_0003)
				{
				case 328:
					this._0002(1, 0, 0, 1);
					break;
				case 364:
					this._0002(1, 1, 1, 0);
					break;
				case 256:
					this._0002(1, 0, 0, 1);
					break;
				case 292:
					this._0002(1, 1, 1, 0);
					break;
				case 76:
					this._0002(1, 1, 1, 0);
					break;
				case 112:
					this._0002(1, 0, 0, 1);
					break;
				case 148:
					this._0002(1, 1, 1, 0);
					break;
				case 28:
					this._0002(1, 0, 0, 1);
					break;
				}
				break;
			case 192:
				switch (_0003)
				{
				case 292:
					this._0002(1, 1, 1, 0);
					break;
				case 256:
					this._0002(0, 1, 0, 1);
					break;
				case 364:
					this._0002(1, 1, 1, 0);
					break;
				case 328:
					this._0002(0, 1, 0, 1);
					break;
				case 28:
					this._0002(0, 1, 0, 1);
					break;
				case 76:
					this._0002(1, 1, 1, 0);
					break;
				case 112:
					this._0002(0, 1, 0, 1);
					break;
				case 148:
					this._0002(1, 1, 1, 0);
					break;
				}
				break;
			case 228:
				switch (_0003)
				{
				case 256:
					this._0002(1, 1, 1, 0);
					break;
				case 328:
					this._0002(1, 0, 1, 0);
					break;
				case 292:
					this._0002(1, 1, 0, 1);
					break;
				case 220:
					this._0002(1, 0, 1, 1);
					break;
				case 184:
					this._0002(0, 1, 1, 1);
					break;
				case 76:
					this._0002(1, 1, 0, 1);
					break;
				case 112:
					this._0002(1, 0, 1, 0);
					break;
				case 148:
					this._0002(1, 0, 0, 1);
					break;
				}
				break;
			case 264:
				switch (_0003)
				{
				case 256:
					this._0002(1, 1, 1, 1);
					break;
				case 292:
					this._0002(1, 0, 1, 1);
					break;
				case 328:
					this._0002(0, 1, 1, 0);
					break;
				case 184:
					this._0002(1, 1, 1, 1);
					break;
				case 112:
					this._0002(0, 1, 1, 1);
					break;
				case 28:
					this._0002(1, 1, 0, 1);
					break;
				case 76:
					this._0002(1, 1, 1, 1);
					break;
				}
				break;
			case 324:
				switch (_0003)
				{
				case 256:
					this._0002(1, 0, 0, 1);
					break;
				case 292:
					this._0002(1, 0, 1, 0);
					break;
				case 328:
					this._0002(1, 0, 0, 1);
					break;
				case 364:
					this._0002(1, 0, 1, 0);
					break;
				case 112:
					this._0002(1, 0, 1, 0);
					break;
				case 76:
					this._0002(1, 0, 1, 1);
					break;
				case 28:
					this._0002(1, 0, 0, 1);
					break;
				}
				break;
			case 300:
				switch (_0003)
				{
				case 292:
					this._0002(0, 1, 0, 1);
					break;
				case 328:
					this._0002(1, 1, 1, 0);
					break;
				}
				break;
			case 374:
				if (_0003 == 184)
				{
					this._0003(0, 1);
				}
				break;
			case -26:
				if (_0003 == 184)
				{
					this._0003(1, 0);
				}
				break;
			}
		}
		else
		{
			switch (_0002)
			{
			case 176:
				if (_0003 == 150)
				{
					this._0002(1, 1, 0, 0);
				}
				break;
			case 26:
				switch (_0003)
				{
				case 366:
					this._0002(0, 1, 1, 0);
					break;
				case 330:
					this._0002(0, 1, 0, 1);
					break;
				case 294:
					this._0002(0, 1, 1, 0);
					break;
				case 258:
					this._0002(0, 1, 0, 1);
					break;
				case 114:
					this._0002(0, 1, 1, 0);
					break;
				case 78:
					this._0002(0, 1, 1, 1);
					break;
				case 30:
					this._0002(0, 1, 0, 1);
					break;
				}
				break;
			case 50:
				switch (_0003)
				{
				case 330:
					this._0002(1, 1, 1, 0);
					break;
				case 294:
					this._0002(1, 0, 0, 1);
					break;
				}
				break;
			case 86:
				switch (_0003)
				{
				case 258:
					this._0002(1, 1, 1, 1);
					break;
				case 330:
					this._0002(1, 0, 1, 0);
					break;
				case 294:
					this._0002(0, 1, 1, 1);
					break;
				case 186:
					this._0002(1, 1, 1, 1);
					break;
				case 114:
					this._0002(1, 0, 1, 1);
					break;
				case 30:
					this._0002(1, 1, 0, 1);
					break;
				case 78:
					this._0002(1, 1, 1, 1);
					break;
				}
				break;
			case 122:
				switch (_0003)
				{
				case 294:
					this._0002(1, 1, 0, 1);
					break;
				case 330:
					this._0002(0, 1, 1, 0);
					break;
				case 258:
					this._0002(1, 1, 1, 0);
					break;
				case 222:
					this._0002(0, 1, 1, 1);
					break;
				case 78:
					this._0002(1, 1, 0, 1);
					break;
				case 114:
					this._0002(0, 1, 1, 0);
					break;
				case 150:
					this._0002(0, 1, 0, 1);
					break;
				case 186:
					this._0002(1, 0, 1, 1);
					break;
				}
				break;
			case 158:
				switch (_0003)
				{
				case 330:
					this._0002(1, 0, 0, 1);
					break;
				case 366:
					this._0002(1, 1, 1, 0);
					break;
				case 258:
					this._0002(1, 0, 0, 1);
					break;
				case 294:
					this._0002(1, 1, 1, 0);
					break;
				case 78:
					this._0002(1, 1, 1, 0);
					break;
				case 114:
					this._0002(1, 0, 0, 1);
					break;
				case 150:
					this._0002(1, 1, 1, 0);
					break;
				case 30:
					this._0002(1, 0, 0, 1);
					break;
				}
				break;
			case 194:
				switch (_0003)
				{
				case 294:
					this._0002(1, 1, 1, 0);
					break;
				case 258:
					this._0002(0, 1, 0, 1);
					break;
				case 366:
					this._0002(1, 1, 1, 0);
					break;
				case 330:
					this._0002(0, 1, 0, 1);
					break;
				case 30:
					this._0002(0, 1, 0, 1);
					break;
				case 78:
					this._0002(1, 1, 1, 0);
					break;
				case 114:
					this._0002(0, 1, 0, 1);
					break;
				case 150:
					this._0002(1, 1, 1, 0);
					break;
				}
				break;
			case 230:
				switch (_0003)
				{
				case 258:
					this._0002(1, 1, 1, 0);
					break;
				case 330:
					this._0002(1, 0, 1, 0);
					break;
				case 294:
					this._0002(1, 1, 0, 1);
					break;
				case 222:
					this._0002(1, 0, 1, 1);
					break;
				case 186:
					this._0002(0, 1, 1, 1);
					break;
				case 78:
					this._0002(1, 1, 0, 1);
					break;
				case 114:
					this._0002(1, 0, 1, 0);
					break;
				case 150:
					this._0002(1, 0, 0, 1);
					break;
				}
				break;
			case 266:
				switch (_0003)
				{
				case 258:
					this._0002(1, 1, 1, 1);
					break;
				case 294:
					this._0002(1, 0, 1, 1);
					break;
				case 330:
					this._0002(0, 1, 1, 0);
					break;
				case 186:
					this._0002(1, 1, 1, 1);
					break;
				case 114:
					this._0002(0, 1, 1, 1);
					break;
				case 30:
					this._0002(1, 1, 0, 1);
					break;
				case 78:
					this._0002(1, 1, 1, 1);
					break;
				}
				break;
			case 326:
				switch (_0003)
				{
				case 258:
					this._0002(1, 0, 0, 1);
					break;
				case 294:
					this._0002(1, 0, 1, 0);
					break;
				case 330:
					this._0002(1, 0, 0, 1);
					break;
				case 366:
					this._0002(1, 0, 1, 0);
					break;
				case 114:
					this._0002(1, 0, 1, 0);
					break;
				case 78:
					this._0002(1, 0, 1, 1);
					break;
				case 30:
					this._0002(1, 0, 0, 1);
					break;
				}
				break;
			case 302:
				switch (_0003)
				{
				case 294:
					this._0002(0, 1, 0, 1);
					break;
				case 330:
					this._0002(1, 1, 1, 0);
					break;
				}
				break;
			case 376:
				if (_0003 == 186)
				{
					this._0003(0, 1);
				}
				break;
			case -28:
				if (_0003 == 186)
				{
					this._0003(1, 0);
				}
				break;
			}
		}
		this._000F_2000 = false;
		this._0002_2001 = false;
		this._0003_2001 = false;
		this._0005_2001 = false;
		this._0008_2001 = false;
	}

	private void _0003(int _0002, int _0003)
	{
		if (this._000F_2000)
		{
			if (_0002 == 0)
			{
				_0005_200B_2003.Left = -26;
			}
			if (_0003 == 0)
			{
				_0005_200B_2003.Left = 374;
			}
		}
		if (this._0002_2001)
		{
			if (_0002 == 0)
			{
				_0003_2008.Left = -26;
			}
			if (_0003 == 0)
			{
				_0003_2008.Left = 374;
			}
		}
		if (this._0003_2001)
		{
			if (_0002 == 0)
			{
				_0005_2008.Left = -26;
			}
			if (_0003 == 0)
			{
				_0005_2008.Left = 374;
			}
		}
		if (this._0005_2001)
		{
			if (_0002 == 0)
			{
				_0006_2008.Left = -26;
			}
			if (_0003 == 0)
			{
				_0006_2008.Left = 374;
			}
		}
		if (this._0008_2001)
		{
			if (_0002 == 0)
			{
				_0008_2008.Left = -26;
			}
			if (_0003 == 0)
			{
				_0008_2008.Left = 374;
			}
		}
	}

	private void _0006_2000()
	{
		if (_0003_2008.Enabled)
		{
			_0003_2008.Left += this._0002;
			_0003_2008.Top += this._000E;
			this._0002_2001 = true;
			_0002(_0003_2008.Left, _0003_2008.Top);
		}
		if (_0005_2008.Enabled)
		{
			_0005_2008.Left += this._0003;
			_0005_2008.Top += this._000F;
			this._0003_2001 = true;
			_0002(_0005_2008.Left, _0005_2008.Top);
		}
		if (_0006_2008.Enabled)
		{
			_0006_2008.Left += this._0005;
			_0006_2008.Top += this._0002_2000;
			this._0005_2001 = true;
			_0002(_0006_2008.Left, _0006_2008.Top);
		}
		if (_0008_2008.Enabled)
		{
			_0008_2008.Left += this._0008;
			_0008_2008.Top += this._0003_2000;
			this._0008_2001 = true;
			_0002(_0008_2008.Left, _0008_2008.Top);
		}
	}

	protected override void Dispose(bool _0002)
	{
		if (_0002 && _000F_2007 != null)
		{
			_000F_2007.Dispose();
		}
		base.Dispose(_0002);
	}

	private void _000E_2000()
	{
		_000F_2007 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(_0008_2000));
		_0002_2008 = new System.Windows.Forms.Timer(_000F_2007);
		_000E_2008 = new Label();
		_000F_2008 = new Label();
		_0005_2009 = new Label();
		_0008_2009 = new System.Windows.Forms.Timer(_000F_2007);
		_0006_2009 = new System.Windows.Forms.Timer(_000F_2007);
		_000E_2009 = new System.Windows.Forms.Timer(_000F_2007);
		_000F_2009 = new System.Windows.Forms.Timer(_000F_2007);
		_0002_200A = new System.Windows.Forms.Timer(_000F_2007);
		_0003_2009 = new PictureBox();
		_0002_2009 = new PictureBox();
		_0006_2008 = new Label();
		_0008_2008 = new Label();
		_0005_2008 = new Label();
		_0003_2008 = new Label();
		_0003_200A = new Label();
		_0005_200A = new Label();
		_0008_200A = new Label();
		_0006_200A = new Label();
		_000E_200A = new Label();
		_000F_200A = new Label();
		_0002_200B = new Label();
		_0003_200B = new Label();
		_0005_200B = new Label();
		_0008_200B = new Label();
		_0006_200B = new Label();
		_000E_200B = new Label();
		_000F_200B = new Label();
		_0002_2000_2000 = new Label();
		_0003_2000_2000 = new Label();
		_0005_2000_2000 = new Label();
		_0008_2000_2000 = new Label();
		_0006_2000_2000 = new Label();
		_000E_2000_2000 = new Label();
		_000F_2000_2000 = new Label();
		_0002_2001_2000 = new Label();
		_0003_2001_2000 = new Label();
		_0005_2001_2000 = new Label();
		_0008_2001_2000 = new Label();
		_0006_2001_2000 = new Label();
		_000E_2001_2000 = new Label();
		_000F_2001_2000 = new Label();
		_0002_2002_2000 = new Label();
		_0003_2002_2000 = new Label();
		_0005_2002_2000 = new Label();
		_0008_2002_2000 = new Label();
		_0006_2002_2000 = new Label();
		_000E_2002_2000 = new Label();
		_000F_2002_2000 = new Label();
		_0002_2003_2000 = new Label();
		_0003_2003_2000 = new Label();
		_0005_2003_2000 = new Label();
		_0008_2003_2000 = new Label();
		_0006_2003_2000 = new Label();
		_000E_2003_2000 = new Label();
		_000F_2003_2000 = new Label();
		_0002_2004_2000 = new Label();
		_0003_2004_2000 = new Label();
		_0005_2004_2000 = new Label();
		_0008_2004_2000 = new Label();
		_0006_2004_2000 = new Label();
		_000E_2004_2000 = new Label();
		_000F_2004_2000 = new Label();
		_0002_2006_2000 = new Label();
		_0003_2006_2000 = new Label();
		_0005_2006_2000 = new Label();
		_0008_2006_2000 = new Label();
		_0006_2006_2000 = new Label();
		_000E_2006_2000 = new Label();
		_000F_2006_2000 = new Label();
		_0002_2007_2000 = new Label();
		_0003_2007_2000 = new Label();
		_0005_2007_2000 = new Label();
		_0008_2007_2000 = new Label();
		_0006_2007_2000 = new Label();
		_000E_2007_2000 = new Label();
		_000F_2007_2000 = new Label();
		_0002_2008_2000 = new Label();
		_0003_2008_2000 = new Label();
		_0005_2008_2000 = new Label();
		_0008_2008_2000 = new Label();
		_0006_2008_2000 = new Label();
		_000E_2008_2000 = new Label();
		_000F_2008_2000 = new Label();
		_0002_2009_2000 = new Label();
		_0003_2009_2000 = new Label();
		_0005_2009_2000 = new Label();
		_0008_2009_2000 = new Label();
		_0006_2009_2000 = new Label();
		_000E_2009_2000 = new Label();
		_000F_2009_2000 = new Label();
		_0002_200A_2000 = new Label();
		_0003_200A_2000 = new Label();
		_0005_200A_2000 = new Label();
		_0008_200A_2000 = new Label();
		_0006_200A_2000 = new Label();
		_000E_200A_2000 = new Label();
		_000F_200A_2000 = new Label();
		_0002_200B_2000 = new Label();
		_0003_200B_2000 = new Label();
		_0005_200B_2000 = new Label();
		_0008_200B_2000 = new Label();
		_0006_200B_2000 = new Label();
		_000E_200B_2000 = new Label();
		_000F_200B_2000 = new Label();
		_0002_2000_2001 = new Label();
		_0003_2000_2001 = new Label();
		_0005_2000_2001 = new Label();
		_0008_2000_2001 = new Label();
		_0006_2000_2001 = new Label();
		_000E_2000_2001 = new Label();
		_000F_2000_2001 = new Label();
		_0002_2001_2001 = new Label();
		_0003_2001_2001 = new Label();
		_0005_2001_2001 = new Label();
		_0008_2001_2001 = new Label();
		_0006_2001_2001 = new Label();
		_000E_2001_2001 = new Label();
		_000F_2001_2001 = new Label();
		_0002_2002_2001 = new Label();
		_0003_2002_2001 = new Label();
		_0005_2002_2001 = new Label();
		_0008_2002_2001 = new Label();
		_0006_2002_2001 = new Label();
		_000E_2002_2001 = new Label();
		_000F_2002_2001 = new Label();
		_0002_2003_2001 = new Label();
		_0003_2003_2001 = new Label();
		_0005_2003_2001 = new Label();
		_0008_2003_2001 = new Label();
		_0006_2003_2001 = new Label();
		_000E_2003_2001 = new Label();
		_000F_2003_2001 = new Label();
		_0002_2004_2001 = new Label();
		_0003_2004_2001 = new Label();
		_0005_2004_2001 = new Label();
		_0008_2004_2001 = new Label();
		_0006_2004_2001 = new Label();
		_000E_2004_2001 = new Label();
		_000F_2004_2001 = new Label();
		_0002_2005_2001 = new Label();
		_0003_2005_2001 = new Label();
		_0005_2005_2001 = new Label();
		_0008_2005_2001 = new Label();
		_0006_2005_2001 = new Label();
		_000E_2005_2001 = new Label();
		_000F_2005_2001 = new Label();
		_0002_2006_2001 = new Label();
		_0003_2006_2001 = new Label();
		_0005_2006_2001 = new Label();
		_0008_2006_2001 = new Label();
		_0006_2006_2001 = new Label();
		_000E_2006_2001 = new Label();
		_000F_2006_2001 = new Label();
		_0002_2007_2001 = new Label();
		_0003_2007_2001 = new Label();
		_0005_2007_2001 = new Label();
		_0008_2007_2001 = new Label();
		_0006_2007_2001 = new Label();
		_000E_2007_2001 = new Label();
		_000F_2007_2001 = new Label();
		_0002_2008_2001 = new Label();
		_0003_2008_2001 = new Label();
		_0005_2008_2001 = new Label();
		_0008_2008_2001 = new Label();
		_0006_2008_2001 = new Label();
		_000E_2008_2001 = new Label();
		_000F_2008_2001 = new Label();
		_0002_2009_2001 = new Label();
		_0003_2009_2001 = new Label();
		_0005_2009_2001 = new Label();
		_0008_2009_2001 = new Label();
		_0006_2009_2001 = new Label();
		_000E_2009_2001 = new Label();
		_000F_2009_2001 = new Label();
		_0002_200A_2001 = new Label();
		_0003_200A_2001 = new Label();
		_0005_200A_2001 = new Label();
		_0008_200A_2001 = new Label();
		_0006_200A_2001 = new Label();
		_000E_200A_2001 = new Label();
		_000F_200A_2001 = new Label();
		_0002_200B_2001 = new Label();
		_0003_200B_2001 = new Label();
		_0005_200B_2001 = new Label();
		_0008_200B_2001 = new Label();
		_0006_200B_2001 = new Label();
		_000E_200B_2001 = new Label();
		_000F_200B_2001 = new Label();
		_0002_2000_2002 = new Label();
		_0003_2000_2002 = new Label();
		_0005_2000_2002 = new Label();
		_0008_2000_2002 = new Label();
		_0006_2000_2002 = new Label();
		_000E_2000_2002 = new Label();
		_000F_2000_2002 = new Label();
		_0002_2001_2002 = new Label();
		_0003_2001_2002 = new Label();
		_0005_2001_2002 = new Label();
		_0008_2001_2002 = new Label();
		_0006_2001_2002 = new Label();
		_000E_2001_2002 = new Label();
		_000F_2001_2002 = new Label();
		_0002_2002_2002 = new Label();
		_0003_2002_2002 = new Label();
		_0005_2002_2002 = new Label();
		_0008_2002_2002 = new Label();
		_0006_2002_2002 = new Label();
		_000E_2002_2002 = new Label();
		_000F_2002_2002 = new Label();
		_0002_2003_2002 = new Label();
		_0003_2003_2002 = new Label();
		_0005_2003_2002 = new Label();
		_0008_2003_2002 = new Label();
		_0006_2003_2002 = new Label();
		_000E_2003_2002 = new Label();
		_000F_2003_2002 = new Label();
		_0002_2004_2002 = new Label();
		_0003_2004_2002 = new Label();
		_0005_2004_2002 = new Label();
		_0008_2004_2002 = new Label();
		_0006_2004_2002 = new Label();
		_000E_2004_2002 = new Label();
		_000F_2004_2002 = new Label();
		_0002_2005_2002 = new Label();
		_0003_2005_2002 = new Label();
		_0005_2005_2002 = new Label();
		_0008_2005_2002 = new Label();
		_0006_2005_2002 = new Label();
		_000E_2005_2002 = new Label();
		_000F_2005_2002 = new Label();
		_0002_2006_2002 = new Label();
		_0003_2006_2002 = new Label();
		_0005_2006_2002 = new Label();
		_0008_2006_2002 = new Label();
		_0006_2006_2002 = new Label();
		_000E_2006_2002 = new Label();
		_000F_2006_2002 = new Label();
		_0002_2007_2002 = new Label();
		_0003_2007_2002 = new Label();
		_0005_2007_2002 = new Label();
		_0008_2007_2002 = new Label();
		_0006_2007_2002 = new Label();
		_000E_2007_2002 = new Label();
		_000F_2007_2002 = new Label();
		_0002_2008_2002 = new Label();
		_0003_2008_2002 = new Label();
		_0005_2008_2002 = new Label();
		_0008_2008_2002 = new Label();
		_0006_2008_2002 = new Label();
		_000E_2008_2002 = new Label();
		_000F_2008_2002 = new Label();
		_0002_2009_2002 = new Label();
		_0003_2009_2002 = new Label();
		_0005_2009_2002 = new Label();
		_0008_2009_2002 = new Label();
		_0006_2009_2002 = new Label();
		_000E_2009_2002 = new Label();
		_000F_2009_2002 = new Label();
		_0002_200A_2002 = new Label();
		_0003_200A_2002 = new Label();
		_0005_200A_2002 = new Label();
		_0008_200A_2002 = new Label();
		_0006_200A_2002 = new Label();
		_000E_200A_2002 = new Label();
		_000F_200A_2002 = new Label();
		_0002_200B_2002 = new Label();
		_0003_200B_2002 = new Label();
		_0005_200B_2002 = new Label();
		_0008_200B_2002 = new Label();
		_0006_200B_2002 = new Label();
		_000E_200B_2002 = new Label();
		_000F_200B_2002 = new Label();
		_0002_2000_2003 = new Label();
		_0003_2000_2003 = new Label();
		_0005_2000_2003 = new Label();
		_0008_2000_2003 = new Label();
		_0006_2000_2003 = new Label();
		_000E_2000_2003 = new Label();
		_000F_2000_2003 = new Label();
		_0002_2001_2003 = new Label();
		_0003_2001_2003 = new Label();
		_0005_2001_2003 = new Label();
		_0008_2001_2003 = new Label();
		_0006_2001_2003 = new Label();
		_000E_2001_2003 = new Label();
		_000F_2001_2003 = new Label();
		_0002_2002_2003 = new Label();
		_0003_2002_2003 = new Label();
		_0005_2002_2003 = new Label();
		_0008_2002_2003 = new Label();
		_0006_2002_2003 = new Label();
		_000E_2002_2003 = new Label();
		_000F_2002_2003 = new Label();
		_0002_2003_2003 = new Label();
		_0003_2003_2003 = new Label();
		_0005_2003_2003 = new Label();
		_0008_2003_2003 = new Label();
		_0006_2003_2003 = new Label();
		_000E_2003_2003 = new Label();
		_000F_2003_2003 = new Label();
		_0002_2004_2003 = new Label();
		_0003_2004_2003 = new Label();
		_0005_2004_2003 = new Label();
		_0008_2004_2003 = new Label();
		_0006_2004_2003 = new Label();
		_000E_2004_2003 = new Label();
		_000F_2004_2003 = new Label();
		_0002_2005_2003 = new Label();
		_0003_2005_2003 = new Label();
		_0005_2005_2003 = new Label();
		_0008_2005_2003 = new Label();
		_0006_2005_2003 = new Label();
		_000E_2005_2003 = new Label();
		_000F_2005_2003 = new Label();
		_0002_2006_2003 = new Label();
		_0003_2006_2003 = new Label();
		_0005_2006_2003 = new Label();
		_0008_2006_2003 = new Label();
		_0006_2006_2003 = new Label();
		_000E_2006_2003 = new Label();
		_000F_2006_2003 = new Label();
		_0002_2007_2003 = new Label();
		_0003_2007_2003 = new Label();
		_0005_2007_2003 = new Label();
		_0008_2007_2003 = new Label();
		_0006_2007_2003 = new Label();
		_000E_2007_2003 = new Label();
		_000F_2007_2003 = new Label();
		_0002_2008_2003 = new Label();
		_0003_2008_2003 = new Label();
		_0005_2008_2003 = new Label();
		_0008_2008_2003 = new Label();
		_0006_2008_2003 = new Label();
		_000E_2008_2003 = new Label();
		_000F_2008_2003 = new Label();
		_0002_2009_2003 = new Label();
		_0003_2009_2003 = new Label();
		_0005_2009_2003 = new Label();
		_0008_2009_2003 = new Label();
		_0006_2009_2003 = new Label();
		_000E_2009_2003 = new Label();
		_000F_2009_2003 = new Label();
		_0002_200A_2003 = new Label();
		_0003_200A_2003 = new Label();
		_0005_200A_2003 = new Label();
		_0008_200A_2003 = new Label();
		_0006_200A_2003 = new Label();
		_000E_200A_2003 = new System.Windows.Forms.Timer(_000F_2007);
		_000F_200A_2003 = new Panel();
		_000E_2000_2004 = new PictureBox();
		_0006_2000_2004 = new PictureBox();
		_0003_200B_2003 = new PictureBox();
		_0002_200B_2003 = new Button();
		_0005_200B_2003 = new PictureBox();
		_0008_200B_2003 = new System.Windows.Forms.Timer(_000F_2007);
		_0006_200B_2003 = new System.Windows.Forms.Timer(_000F_2007);
		_000E_200B_2003 = new System.Windows.Forms.Timer(_000F_2007);
		_000F_200B_2003 = new System.Windows.Forms.Timer(_000F_2007);
		_0002_2000_2004 = new Label();
		_0003_2000_2004 = new Label();
		_0005_2000_2004 = new System.Windows.Forms.Timer(_000F_2007);
		_0008_2000_2004 = new System.Windows.Forms.Timer(_000F_2007);
		_000F_2000_2004 = new Label();
		_0002_2001_2004 = new Label();
		_0003_2001_2004 = new Label();
		_0005_2001_2004 = new Label();
		((ISupportInitialize)_0003_2009).BeginInit();
		((ISupportInitialize)_0002_2009).BeginInit();
		_000F_200A_2003.SuspendLayout();
		((ISupportInitialize)_000E_2000_2004).BeginInit();
		((ISupportInitialize)_0006_2000_2004).BeginInit();
		((ISupportInitialize)_0003_200B_2003).BeginInit();
		((ISupportInitialize)_0005_200B_2003).BeginInit();
		SuspendLayout();
		_0002_2008.Interval = 16;
		_0002_2008.Tick += _0008_2000;
		_000E_2008.BackColor = Color.Black;
		_000E_2008.Font = new Font(global::_000F_2000._0002(-380206080), 16f, FontStyle.Bold, GraphicsUnit.Point, 0);
		_000E_2008.ForeColor = Color.White;
		_000E_2008.Image = global::_000E_2000._0005_2005();
		_000E_2008.Location = new Point(16, 400);
		_000E_2008.Name = global::_000F_2000._0002(-380206053);
		_000E_2008.Size = new Size(84, 30);
		_000E_2008.TabIndex = 129;
		_000F_2008.BackColor = Color.Black;
		_000F_2008.Font = new Font(global::_000F_2000._0002(-380206080), 16f, FontStyle.Bold, GraphicsUnit.Point, 0);
		_000F_2008.ForeColor = Color.White;
		_000F_2008.Image = global::_000E_2000._000F_2001();
		_000F_2008.Location = new Point(226, 399);
		_000F_2008.Name = global::_000F_2000._0002(-380206042);
		_000F_2008.Size = new Size(69, 30);
		_000F_2008.TabIndex = 130;
		_0005_2009.BackColor = Color.Black;
		_0005_2009.Font = new Font(global::_000F_2000._0002(-380206080), 10f, FontStyle.Bold, GraphicsUnit.Point, 0);
		_0005_2009.ForeColor = Color.White;
		_0005_2009.Image = global::_000E_2000._0008_2001();
		_0005_2009.Location = new Point(123, 222);
		_0005_2009.Name = global::_000F_2000._0002(-380206031);
		_0005_2009.Size = new Size(125, 19);
		_0005_2009.TabIndex = 133;
		_0005_2009.Text = global::_000F_2000._0002(-380206020);
		_0005_2009.TextAlign = ContentAlignment.MiddleRight;
		_0008_2009.Interval = 3000;
		_0008_2009.Tick += _0006_2000;
		_0006_2009.Interval = 1;
		_0006_2009.Tick += _000E_2000;
		_000E_2009.Interval = 1;
		_000E_2009.Tick += _000F_2000;
		_000F_2009.Interval = 1;
		_000F_2009.Tick += _0002_2001;
		_0002_200A.Interval = 1;
		_0002_200A.Tick += _0003_2001;
		_0003_2009.BackgroundImageLayout = ImageLayout.Center;
		_0003_2009.Image = global::_000E_2000._0005();
		_0003_2009.Location = new Point(318, 402);
		_0003_2009.Name = global::_000F_2000._0002(-380205997);
		_0003_2009.Size = new Size(22, 22);
		_0003_2009.TabIndex = 132;
		_0003_2009.TabStop = false;
		_0002_2009.BackgroundImageLayout = ImageLayout.Center;
		_0002_2009.Image = global::_000E_2000._0005();
		_0002_2009.Location = new Point(297, 402);
		_0002_2009.Name = global::_000F_2000._0002(-380205983);
		_0002_2009.Size = new Size(22, 22);
		_0002_2009.TabIndex = 131;
		_0002_2009.TabStop = false;
		_0006_2008.BackColor = Color.Transparent;
		_0006_2008.Cursor = Cursors.Default;
		_0006_2008.ForeColor = Color.Transparent;
		_0006_2008.Image = global::_000E_2000._0003_2006();
		_0006_2008.Location = new Point(176, 185);
		_0006_2008.Margin = new Padding(0);
		_0006_2008.Name = global::_000F_2000._0002(-380205961);
		_0006_2008.Size = new Size(18, 18);
		_0006_2008.TabIndex = 127;
		_0008_2008.BackColor = Color.Transparent;
		_0008_2008.Cursor = Cursors.Default;
		_0008_2008.ForeColor = Color.Transparent;
		_0008_2008.Image = global::_000E_2000._000E_2001();
		_0008_2008.Location = new Point(199, 185);
		_0008_2008.Margin = new Padding(0);
		_0008_2008.Name = global::_000F_2000._0002(-380205694);
		_0008_2008.Size = new Size(18, 18);
		_0008_2008.TabIndex = 126;
		_0005_2008.BackColor = Color.Transparent;
		_0005_2008.Cursor = Cursors.Default;
		_0005_2008.ForeColor = Color.Transparent;
		_0005_2008.Image = global::_000E_2000._0002_2000();
		_0005_2008.Location = new Point(154, 185);
		_0005_2008.Margin = new Padding(0);
		_0005_2008.Name = global::_000F_2000._0002(-380205683);
		_0005_2008.Size = new Size(18, 18);
		_0005_2008.TabIndex = 125;
		_0003_2008.BackColor = Color.Transparent;
		_0003_2008.Cursor = Cursors.Default;
		_0003_2008.ForeColor = Color.Transparent;
		_0003_2008.Image = global::_000E_2000._0003_2005();
		_0003_2008.Location = new Point(176, 150);
		_0003_2008.Margin = new Padding(0);
		_0003_2008.Name = global::_000F_2000._0002(-380205672);
		_0003_2008.Size = new Size(18, 18);
		_0003_2008.TabIndex = 124;
		_0003_200A.BackColor = Color.White;
		_0003_200A.Location = new Point(102, 266);
		_0003_200A.Name = global::_000F_2000._0002(-380205653);
		_0003_200A.Size = new Size(2, 2);
		_0003_200A.TabIndex = 134;
		_0005_200A.BackColor = Color.White;
		_0005_200A.Location = new Point(111, 266);
		_0005_200A.Name = global::_000F_2000._0002(-380205642);
		_0005_200A.Size = new Size(2, 2);
		_0005_200A.TabIndex = 135;
		_0008_200A.BackColor = Color.White;
		_0008_200A.Location = new Point(129, 266);
		_0008_200A.Name = global::_000F_2000._0002(-380205631);
		_0008_200A.Size = new Size(2, 2);
		_0008_200A.TabIndex = 137;
		_0006_200A.BackColor = Color.White;
		_0006_200A.Location = new Point(120, 266);
		_0006_200A.Name = global::_000F_2000._0002(-380205620);
		_0006_200A.Size = new Size(2, 2);
		_0006_200A.TabIndex = 136;
		_000E_200A.BackColor = Color.White;
		_000E_200A.Location = new Point(165, 266);
		_000E_200A.Name = global::_000F_2000._0002(-380205601);
		_000E_200A.Size = new Size(2, 2);
		_000E_200A.TabIndex = 141;
		_000F_200A.BackColor = Color.White;
		_000F_200A.Location = new Point(156, 266);
		_000F_200A.Name = global::_000F_2000._0002(-380205590);
		_000F_200A.Size = new Size(2, 2);
		_000F_200A.TabIndex = 140;
		_0002_200B.BackColor = Color.White;
		_0002_200B.Location = new Point(147, 266);
		_0002_200B.Name = global::_000F_2000._0002(-380205579);
		_0002_200B.Size = new Size(2, 2);
		_0002_200B.TabIndex = 139;
		_0003_200B.BackColor = Color.White;
		_0003_200B.Location = new Point(138, 266);
		_0003_200B.Name = global::_000F_2000._0002(-380205817);
		_0003_200B.Size = new Size(2, 2);
		_0003_200B.TabIndex = 138;
		_0005_200B.BackColor = Color.White;
		_0005_200B.Location = new Point(94, 266);
		_0005_200B.Name = global::_000F_2000._0002(-380205807);
		_0005_200B.Size = new Size(2, 2);
		_0005_200B.TabIndex = 149;
		_0008_200B.BackColor = Color.White;
		_0008_200B.Location = new Point(78, 266);
		_0008_200B.Name = global::_000F_2000._0002(-380205789);
		_0008_200B.Size = new Size(2, 2);
		_0008_200B.TabIndex = 148;
		_0006_200B.BackColor = Color.White;
		_0006_200B.Location = new Point(69, 266);
		_0006_200B.Name = global::_000F_2000._0002(-380205779);
		_0006_200B.Size = new Size(2, 2);
		_0006_200B.TabIndex = 147;
		_000E_200B.BackColor = Color.White;
		_000E_200B.Location = new Point(60, 266);
		_000E_200B.Name = global::_000F_2000._0002(-380205761);
		_000E_200B.Size = new Size(2, 2);
		_000E_200B.TabIndex = 146;
		_000F_200B.BackColor = Color.White;
		_000F_200B.Location = new Point(52, 266);
		_000F_200B.Name = global::_000F_2000._0002(-380205751);
		_000F_200B.Size = new Size(2, 2);
		_000F_200B.TabIndex = 145;
		_0002_2000_2000.BackColor = Color.White;
		_0002_2000_2000.Location = new Point(43, 266);
		_0002_2000_2000.Name = global::_000F_2000._0002(-380205733);
		_0002_2000_2000.Size = new Size(2, 2);
		_0002_2000_2000.TabIndex = 144;
		_0003_2000_2000.BackColor = Color.White;
		_0003_2000_2000.Location = new Point(247, 266);
		_0003_2000_2000.Name = global::_000F_2000._0002(-380205723);
		_0003_2000_2000.Size = new Size(2, 2);
		_0003_2000_2000.TabIndex = 163;
		_0005_2000_2000.BackColor = Color.White;
		_0005_2000_2000.Location = new Point(238, 266);
		_0005_2000_2000.Name = global::_000F_2000._0002(-380205705);
		_0005_2000_2000.Size = new Size(2, 2);
		_0005_2000_2000.TabIndex = 162;
		_0008_2000_2000.BackColor = Color.White;
		_0008_2000_2000.Location = new Point(229, 266);
		_0008_2000_2000.Name = global::_000F_2000._0002(-380204415);
		_0008_2000_2000.Size = new Size(2, 2);
		_0008_2000_2000.TabIndex = 161;
		_0006_2000_2000.BackColor = Color.White;
		_0006_2000_2000.Location = new Point(220, 266);
		_0006_2000_2000.Name = global::_000F_2000._0002(-380204397);
		_0006_2000_2000.Size = new Size(2, 2);
		_0006_2000_2000.TabIndex = 160;
		_000E_2000_2000.BackColor = Color.White;
		_000E_2000_2000.Location = new Point(211, 266);
		_000E_2000_2000.Name = global::_000F_2000._0002(-380204387);
		_000E_2000_2000.Size = new Size(2, 2);
		_000E_2000_2000.TabIndex = 159;
		_000F_2000_2000.BackColor = Color.White;
		_000F_2000_2000.Location = new Point(202, 266);
		_000F_2000_2000.Name = global::_000F_2000._0002(-380204369);
		_000F_2000_2000.Size = new Size(2, 2);
		_000F_2000_2000.TabIndex = 158;
		_0002_2001_2000.BackColor = Color.White;
		_0002_2001_2000.Location = new Point(318, 266);
		_0002_2001_2000.Name = global::_000F_2000._0002(-380204359);
		_0002_2001_2000.Size = new Size(2, 2);
		_0002_2001_2000.TabIndex = 157;
		_0003_2001_2000.BackColor = Color.White;
		_0003_2001_2000.Location = new Point(310, 266);
		_0003_2001_2000.Name = global::_000F_2000._0002(-380204341);
		_0003_2001_2000.Size = new Size(2, 2);
		_0003_2001_2000.TabIndex = 156;
		_0005_2001_2000.BackColor = Color.White;
		_0005_2001_2000.Location = new Point(301, 266);
		_0005_2001_2000.Name = global::_000F_2000._0002(-380204331);
		_0005_2001_2000.Size = new Size(2, 2);
		_0005_2001_2000.TabIndex = 155;
		_0008_2001_2000.BackColor = Color.White;
		_0008_2001_2000.Location = new Point(292, 266);
		_0008_2001_2000.Name = global::_000F_2000._0002(-380204313);
		_0008_2001_2000.Size = new Size(2, 2);
		_0008_2001_2000.TabIndex = 154;
		_0006_2001_2000.BackColor = Color.White;
		_0006_2001_2000.Location = new Point(283, 266);
		_0006_2001_2000.Name = global::_000F_2000._0002(-380204303);
		_0006_2001_2000.Size = new Size(2, 2);
		_0006_2001_2000.TabIndex = 153;
		_000E_2001_2000.BackColor = Color.White;
		_000E_2001_2000.Location = new Point(274, 266);
		_000E_2001_2000.Name = global::_000F_2000._0002(-380204541);
		_000E_2001_2000.Size = new Size(2, 2);
		_000E_2001_2000.TabIndex = 152;
		_000F_2001_2000.BackColor = Color.White;
		_000F_2001_2000.Location = new Point(265, 266);
		_000F_2001_2000.Name = global::_000F_2000._0002(-380204531);
		_000F_2001_2000.Size = new Size(2, 2);
		_000F_2001_2000.TabIndex = 151;
		_0002_2002_2000.BackColor = Color.White;
		_0002_2002_2000.Location = new Point(256, 266);
		_0002_2002_2000.Name = global::_000F_2000._0002(-380204513);
		_0002_2002_2000.Size = new Size(2, 2);
		_0002_2002_2000.TabIndex = 150;
		_0003_2002_2000.AutoSize = true;
		_0003_2002_2000.Font = new Font(global::_000F_2000._0002(-380206080), 15f, FontStyle.Regular, GraphicsUnit.Point, 0);
		_0003_2002_2000.ForeColor = Color.FromArgb(255, 255, 51);
		_0003_2002_2000.Location = new Point(93, 399);
		_0003_2002_2000.Name = global::_000F_2000._0002(-380204503);
		_0003_2002_2000.Size = new Size(24, 28);
		_0003_2002_2000.TabIndex = 164;
		_0003_2002_2000.Text = global::_000F_2000._0002(-380205190);
		_0005_2002_2000.BackColor = Color.White;
		_0005_2002_2000.Location = new Point(165, 284);
		_0005_2002_2000.Name = global::_000F_2000._0002(-380204491);
		_0005_2002_2000.Size = new Size(2, 2);
		_0005_2002_2000.TabIndex = 180;
		_0008_2002_2000.BackColor = Color.White;
		_0008_2002_2000.Location = new Point(165, 293);
		_0008_2002_2000.Name = global::_000F_2000._0002(-380204473);
		_0008_2002_2000.Size = new Size(2, 2);
		_0008_2002_2000.TabIndex = 181;
		_0006_2002_2000.BackColor = Color.White;
		_0006_2002_2000.Location = new Point(165, 275);
		_0006_2002_2000.Name = global::_000F_2000._0002(-380204463);
		_0006_2002_2000.Size = new Size(2, 2);
		_0006_2002_2000.TabIndex = 179;
		_000E_2002_2000.BackColor = Color.White;
		_000E_2002_2000.Location = new Point(202, 293);
		_000E_2002_2000.Name = global::_000F_2000._0002(-380204445);
		_000E_2002_2000.Size = new Size(2, 2);
		_000E_2002_2000.TabIndex = 185;
		_000F_2002_2000.BackColor = Color.White;
		_000F_2002_2000.Location = new Point(202, 284);
		_000F_2002_2000.Name = global::_000F_2000._0002(-380204435);
		_000F_2002_2000.Size = new Size(2, 2);
		_000F_2002_2000.TabIndex = 184;
		_0002_2003_2000.BackColor = Color.White;
		_0002_2003_2000.Location = new Point(202, 275);
		_0002_2003_2000.Name = global::_000F_2000._0002(-380204417);
		_0002_2003_2000.Size = new Size(2, 2);
		_0002_2003_2000.TabIndex = 183;
		_0003_2003_2000.BackColor = Color.White;
		_0003_2003_2000.Location = new Point(326, 266);
		_0003_2003_2000.Name = global::_000F_2000._0002(-380204151);
		_0003_2003_2000.Size = new Size(2, 2);
		_0003_2003_2000.TabIndex = 186;
		_0005_2003_2000.BackColor = Color.White;
		_0005_2003_2000.Location = new Point(35, 266);
		_0005_2003_2000.Name = global::_000F_2000._0002(-380204133);
		_0005_2003_2000.Size = new Size(2, 2);
		_0005_2003_2000.TabIndex = 187;
		_0008_2003_2000.BackColor = Color.White;
		_0008_2003_2000.Location = new Point(94, 302);
		_0008_2003_2000.Name = global::_000F_2000._0002(-380204123);
		_0008_2003_2000.Size = new Size(2, 2);
		_0008_2003_2000.TabIndex = 196;
		_0006_2003_2000.BackColor = Color.White;
		_0006_2003_2000.Location = new Point(165, 302);
		_0006_2003_2000.Name = global::_000F_2000._0002(-380204105);
		_0006_2003_2000.Size = new Size(2, 2);
		_0006_2003_2000.TabIndex = 195;
		_000E_2003_2000.BackColor = Color.White;
		_000E_2003_2000.Location = new Point(156, 302);
		_000E_2003_2000.Name = global::_000F_2000._0002(-380204095);
		_000E_2003_2000.Size = new Size(2, 2);
		_000E_2003_2000.TabIndex = 194;
		_000F_2003_2000.BackColor = Color.White;
		_000F_2003_2000.Location = new Point(147, 302);
		_000F_2003_2000.Name = global::_000F_2000._0002(-380204077);
		_000F_2003_2000.Size = new Size(2, 2);
		_000F_2003_2000.TabIndex = 193;
		_0002_2004_2000.BackColor = Color.White;
		_0002_2004_2000.Location = new Point(138, 302);
		_0002_2004_2000.Name = global::_000F_2000._0002(-380204067);
		_0002_2004_2000.Size = new Size(2, 2);
		_0002_2004_2000.TabIndex = 192;
		_0003_2004_2000.BackColor = Color.White;
		_0003_2004_2000.Location = new Point(129, 302);
		_0003_2004_2000.Name = global::_000F_2000._0002(-380204049);
		_0003_2004_2000.Size = new Size(2, 2);
		_0003_2004_2000.TabIndex = 191;
		_0005_2004_2000.BackColor = Color.White;
		_0005_2004_2000.Location = new Point(120, 302);
		_0005_2004_2000.Name = global::_000F_2000._0002(-380204039);
		_0005_2004_2000.Size = new Size(2, 2);
		_0005_2004_2000.TabIndex = 190;
		_0008_2004_2000.BackColor = Color.White;
		_0008_2004_2000.Location = new Point(111, 302);
		_0008_2004_2000.Name = global::_000F_2000._0002(-380204277);
		_0008_2004_2000.Size = new Size(2, 2);
		_0008_2004_2000.TabIndex = 189;
		_0006_2004_2000.BackColor = Color.White;
		_0006_2004_2000.Location = new Point(102, 302);
		_0006_2004_2000.Name = global::_000F_2000._0002(-380204267);
		_0006_2004_2000.Size = new Size(2, 2);
		_0006_2004_2000.TabIndex = 188;
		_000E_2004_2000.BackColor = Color.White;
		_000E_2004_2000.Location = new Point(202, 302);
		_000E_2004_2000.Name = global::_000F_2000._0002(-380204249);
		_000E_2004_2000.Size = new Size(2, 2);
		_000E_2004_2000.TabIndex = 205;
		_000F_2004_2000.BackColor = Color.White;
		_000F_2004_2000.Location = new Point(274, 302);
		_000F_2004_2000.Name = global::_000F_2000._0002(-380204239);
		_000F_2004_2000.Size = new Size(2, 2);
		_000F_2004_2000.TabIndex = 204;
		_0002_2006_2000.BackColor = Color.White;
		_0002_2006_2000.Location = new Point(265, 302);
		_0002_2006_2000.Name = global::_000F_2000._0002(-380204221);
		_0002_2006_2000.Size = new Size(2, 2);
		_0002_2006_2000.TabIndex = 203;
		_0003_2006_2000.BackColor = Color.White;
		_0003_2006_2000.Location = new Point(256, 302);
		_0003_2006_2000.Name = global::_000F_2000._0002(-380204211);
		_0003_2006_2000.Size = new Size(2, 2);
		_0003_2006_2000.TabIndex = 202;
		_0005_2006_2000.BackColor = Color.White;
		_0005_2006_2000.Location = new Point(247, 302);
		_0005_2006_2000.Name = global::_000F_2000._0002(-380204193);
		_0005_2006_2000.Size = new Size(2, 2);
		_0005_2006_2000.TabIndex = 201;
		_0008_2006_2000.BackColor = Color.White;
		_0008_2006_2000.Location = new Point(238, 302);
		_0008_2006_2000.Name = global::_000F_2000._0002(-380204183);
		_0008_2006_2000.Size = new Size(2, 2);
		_0008_2006_2000.TabIndex = 200;
		_0006_2006_2000.BackColor = Color.White;
		_0006_2006_2000.Location = new Point(229, 302);
		_0006_2006_2000.Name = global::_000F_2000._0002(-380204165);
		_0006_2006_2000.Size = new Size(2, 2);
		_0006_2006_2000.TabIndex = 199;
		_000E_2006_2000.BackColor = Color.White;
		_000E_2006_2000.Location = new Point(220, 302);
		_000E_2006_2000.Name = global::_000F_2000._0002(-380204923);
		_000E_2006_2000.Size = new Size(2, 2);
		_000E_2006_2000.TabIndex = 198;
		_000F_2006_2000.BackColor = Color.White;
		_000F_2006_2000.Location = new Point(211, 302);
		_000F_2006_2000.Name = global::_000F_2000._0002(-380204905);
		_000F_2006_2000.Size = new Size(2, 2);
		_000F_2006_2000.TabIndex = 197;
		_0002_2007_2000.BackColor = Color.White;
		_0002_2007_2000.Location = new Point(94, 293);
		_0002_2007_2000.Name = global::_000F_2000._0002(-380204895);
		_0002_2007_2000.Size = new Size(2, 2);
		_0002_2007_2000.TabIndex = 208;
		_0003_2007_2000.BackColor = Color.White;
		_0003_2007_2000.Location = new Point(94, 284);
		_0003_2007_2000.Name = global::_000F_2000._0002(-380204877);
		_0003_2007_2000.Size = new Size(2, 2);
		_0003_2007_2000.TabIndex = 207;
		_0005_2007_2000.BackColor = Color.White;
		_0005_2007_2000.Location = new Point(94, 275);
		_0005_2007_2000.Name = global::_000F_2000._0002(-380204867);
		_0005_2007_2000.Size = new Size(2, 2);
		_0005_2007_2000.TabIndex = 206;
		_0008_2007_2000.BackColor = Color.White;
		_0008_2007_2000.Location = new Point(274, 293);
		_0008_2007_2000.Name = global::_000F_2000._0002(-380204849);
		_0008_2007_2000.Size = new Size(2, 2);
		_0008_2007_2000.TabIndex = 211;
		_0006_2007_2000.BackColor = Color.White;
		_0006_2007_2000.Location = new Point(274, 284);
		_0006_2007_2000.Name = global::_000F_2000._0002(-380204839);
		_0006_2007_2000.Size = new Size(2, 2);
		_0006_2007_2000.TabIndex = 210;
		_000E_2007_2000.BackColor = Color.White;
		_000E_2007_2000.Location = new Point(274, 275);
		_000E_2007_2000.Name = global::_000F_2000._0002(-380204821);
		_000E_2007_2000.Size = new Size(2, 2);
		_000E_2007_2000.TabIndex = 209;
		_000F_2007_2000.BackColor = Color.White;
		_000F_2007_2000.Location = new Point(183, 302);
		_000F_2007_2000.Name = global::_000F_2000._0002(-380204811);
		_000F_2007_2000.Size = new Size(2, 2);
		_000F_2007_2000.TabIndex = 213;
		_0002_2008_2000.BackColor = Color.White;
		_0002_2008_2000.Location = new Point(174, 302);
		_0002_2008_2000.Name = global::_000F_2000._0002(-380205049);
		_0002_2008_2000.Size = new Size(2, 2);
		_0002_2008_2000.TabIndex = 212;
		_0003_2008_2000.BackColor = Color.White;
		_0003_2008_2000.Location = new Point(192, 302);
		_0003_2008_2000.Name = global::_000F_2000._0002(-380205039);
		_0003_2008_2000.Size = new Size(2, 2);
		_0003_2008_2000.TabIndex = 214;
		_0005_2008_2000.BackColor = Color.White;
		_0005_2008_2000.Location = new Point(334, 293);
		_0005_2008_2000.Name = global::_000F_2000._0002(-380205021);
		_0005_2008_2000.Size = new Size(2, 2);
		_0005_2008_2000.TabIndex = 217;
		_0008_2008_2000.BackColor = Color.White;
		_0008_2008_2000.Location = new Point(334, 284);
		_0008_2008_2000.Name = global::_000F_2000._0002(-380205011);
		_0008_2008_2000.Size = new Size(2, 2);
		_0008_2008_2000.TabIndex = 216;
		_0006_2008_2000.BackColor = Color.White;
		_0006_2008_2000.Location = new Point(334, 275);
		_0006_2008_2000.Name = global::_000F_2000._0002(-380204993);
		_0006_2008_2000.Size = new Size(2, 2);
		_0006_2008_2000.TabIndex = 215;
		_000E_2008_2000.BackColor = Color.White;
		_000E_2008_2000.Location = new Point(334, 266);
		_000E_2008_2000.Name = global::_000F_2000._0002(-380204983);
		_000E_2008_2000.Size = new Size(2, 2);
		_000E_2008_2000.TabIndex = 218;
		_000F_2008_2000.BackColor = Color.Black;
		_000F_2008_2000.Image = (Image)componentResourceManager.GetObject(global::_000F_2000._0002(-380204965));
		_000F_2008_2000.Location = new Point(330, 298);
		_000F_2008_2000.Name = global::_000F_2000._0002(-380204945);
		_000F_2008_2000.Size = new Size(10, 10);
		_000F_2008_2000.TabIndex = 222;
		_0002_2009_2000.BackColor = Color.White;
		_0002_2009_2000.Location = new Point(326, 302);
		_0002_2009_2000.Name = global::_000F_2000._0002(-380204935);
		_0002_2009_2000.Size = new Size(2, 2);
		_0002_2009_2000.TabIndex = 221;
		_0003_2009_2000.BackColor = Color.White;
		_0003_2009_2000.Location = new Point(318, 302);
		_0003_2009_2000.Name = global::_000F_2000._0002(-380204661);
		_0003_2009_2000.Size = new Size(2, 2);
		_0003_2009_2000.TabIndex = 220;
		_0005_2009_2000.BackColor = Color.White;
		_0005_2009_2000.Location = new Point(310, 302);
		_0005_2009_2000.Name = global::_000F_2000._0002(-380204651);
		_0005_2009_2000.Size = new Size(2, 2);
		_0005_2009_2000.TabIndex = 219;
		_0008_2009_2000.BackColor = Color.White;
		_0008_2009_2000.Location = new Point(310, 311);
		_0008_2009_2000.Name = global::_000F_2000._0002(-380204633);
		_0008_2009_2000.Size = new Size(2, 2);
		_0008_2009_2000.TabIndex = 226;
		_0006_2009_2000.BackColor = Color.White;
		_0006_2009_2000.Location = new Point(310, 338);
		_0006_2009_2000.Name = global::_000F_2000._0002(-380204623);
		_0006_2009_2000.Size = new Size(2, 2);
		_0006_2009_2000.TabIndex = 225;
		_000E_2009_2000.BackColor = Color.White;
		_000E_2009_2000.Location = new Point(310, 329);
		_000E_2009_2000.Name = global::_000F_2000._0002(-380204605);
		_000E_2009_2000.Size = new Size(2, 2);
		_000E_2009_2000.TabIndex = 224;
		_000F_2009_2000.BackColor = Color.White;
		_000F_2009_2000.Location = new Point(310, 320);
		_000F_2009_2000.Name = global::_000F_2000._0002(-380204595);
		_000F_2009_2000.Size = new Size(2, 2);
		_000F_2009_2000.TabIndex = 223;
		_0002_200A_2000.BackColor = Color.White;
		_0002_200A_2000.Location = new Point(301, 338);
		_0002_200A_2000.Name = global::_000F_2000._0002(-380204577);
		_0002_200A_2000.Size = new Size(2, 2);
		_0002_200A_2000.TabIndex = 230;
		_0003_200A_2000.BackColor = Color.White;
		_0003_200A_2000.Location = new Point(292, 338);
		_0003_200A_2000.Name = global::_000F_2000._0002(-380204567);
		_0003_200A_2000.Size = new Size(2, 2);
		_0003_200A_2000.TabIndex = 229;
		_0005_200A_2000.BackColor = Color.White;
		_0005_200A_2000.Location = new Point(283, 338);
		_0005_200A_2000.Name = global::_000F_2000._0002(-380204549);
		_0005_200A_2000.Size = new Size(2, 2);
		_0005_200A_2000.TabIndex = 228;
		_0008_200A_2000.BackColor = Color.White;
		_0008_200A_2000.Location = new Point(274, 338);
		_0008_200A_2000.Name = global::_000F_2000._0002(-380204795);
		_0008_200A_2000.Size = new Size(2, 2);
		_0008_200A_2000.TabIndex = 227;
		_0006_200A_2000.BackColor = Color.White;
		_0006_200A_2000.Location = new Point(274, 311);
		_0006_200A_2000.Name = global::_000F_2000._0002(-380204777);
		_0006_200A_2000.Size = new Size(2, 2);
		_0006_200A_2000.TabIndex = 233;
		_000E_200A_2000.BackColor = Color.White;
		_000E_200A_2000.Location = new Point(274, 329);
		_000E_200A_2000.Name = global::_000F_2000._0002(-380204767);
		_000E_200A_2000.Size = new Size(2, 2);
		_000E_200A_2000.TabIndex = 232;
		_000F_200A_2000.BackColor = Color.White;
		_000F_200A_2000.Location = new Point(274, 320);
		_000F_200A_2000.Name = global::_000F_2000._0002(-380204749);
		_000F_200A_2000.Size = new Size(2, 2);
		_000F_200A_2000.TabIndex = 231;
		_0002_200B_2000.BackColor = Color.White;
		_0002_200B_2000.Location = new Point(238, 311);
		_0002_200B_2000.Name = global::_000F_2000._0002(-380204739);
		_0002_200B_2000.Size = new Size(2, 2);
		_0002_200B_2000.TabIndex = 237;
		_0003_200B_2000.BackColor = Color.White;
		_0003_200B_2000.Location = new Point(238, 329);
		_0003_200B_2000.Name = global::_000F_2000._0002(-380204721);
		_0003_200B_2000.Size = new Size(2, 2);
		_0003_200B_2000.TabIndex = 236;
		_0005_200B_2000.BackColor = Color.White;
		_0005_200B_2000.Location = new Point(238, 320);
		_0005_200B_2000.Name = global::_000F_2000._0002(-380204711);
		_0005_200B_2000.Size = new Size(2, 2);
		_0005_200B_2000.TabIndex = 235;
		_0008_200B_2000.BackColor = Color.White;
		_0008_200B_2000.Location = new Point(238, 338);
		_0008_200B_2000.Name = global::_000F_2000._0002(-380204693);
		_0008_200B_2000.Size = new Size(2, 2);
		_0008_200B_2000.TabIndex = 234;
		_0006_200B_2000.BackColor = Color.White;
		_0006_200B_2000.Location = new Point(220, 338);
		_0006_200B_2000.Name = global::_000F_2000._0002(-380204683);
		_0006_200B_2000.Size = new Size(2, 2);
		_0006_200B_2000.TabIndex = 242;
		_000E_200B_2000.BackColor = Color.White;
		_000E_200B_2000.Location = new Point(211, 338);
		_000E_200B_2000.Name = global::_000F_2000._0002(-380203385);
		_000E_200B_2000.Size = new Size(2, 2);
		_000E_200B_2000.TabIndex = 241;
		_000F_200B_2000.BackColor = Color.White;
		_000F_200B_2000.Location = new Point(202, 338);
		_000F_200B_2000.Name = global::_000F_2000._0002(-380203375);
		_000F_200B_2000.Size = new Size(2, 2);
		_000F_200B_2000.TabIndex = 240;
		_0002_2000_2001.BackColor = Color.White;
		_0002_2000_2001.Location = new Point(229, 338);
		_0002_2000_2001.Name = global::_000F_2000._0002(-380203357);
		_0002_2000_2001.Size = new Size(2, 2);
		_0002_2000_2001.TabIndex = 238;
		_0003_2000_2001.BackColor = Color.White;
		_0003_2000_2001.Location = new Point(202, 356);
		_0003_2000_2001.Name = global::_000F_2000._0002(-380203347);
		_0003_2000_2001.Size = new Size(2, 2);
		_0003_2000_2001.TabIndex = 247;
		_0005_2000_2001.BackColor = Color.White;
		_0005_2000_2001.Location = new Point(202, 374);
		_0005_2000_2001.Name = global::_000F_2000._0002(-380203329);
		_0005_2000_2001.Size = new Size(2, 2);
		_0005_2000_2001.TabIndex = 246;
		_0008_2000_2001.BackColor = Color.White;
		_0008_2000_2001.Location = new Point(202, 365);
		_0008_2000_2001.Name = global::_000F_2000._0002(-380203319);
		_0008_2000_2001.Size = new Size(2, 2);
		_0008_2000_2001.TabIndex = 245;
		_0006_2000_2001.BackColor = Color.White;
		_0006_2000_2001.Location = new Point(202, 347);
		_0006_2000_2001.Name = global::_000F_2000._0002(-380203301);
		_0006_2000_2001.Size = new Size(2, 2);
		_0006_2000_2001.TabIndex = 243;
		_000E_2000_2001.BackColor = Color.White;
		_000E_2000_2001.Location = new Point(334, 356);
		_000E_2000_2001.Name = global::_000F_2000._0002(-380203291);
		_000E_2000_2001.Size = new Size(2, 2);
		_000E_2000_2001.TabIndex = 252;
		_000F_2000_2001.BackColor = Color.White;
		_000F_2000_2001.Location = new Point(334, 374);
		_000F_2000_2001.Name = global::_000F_2000._0002(-380203273);
		_000F_2000_2001.Size = new Size(2, 2);
		_000F_2000_2001.TabIndex = 251;
		_0002_2001_2001.BackColor = Color.White;
		_0002_2001_2001.Location = new Point(334, 365);
		_0002_2001_2001.Name = global::_000F_2000._0002(-380203519);
		_0002_2001_2001.Size = new Size(2, 2);
		_0002_2001_2001.TabIndex = 250;
		_0003_2001_2001.BackColor = Color.White;
		_0003_2001_2001.Location = new Point(334, 347);
		_0003_2001_2001.Name = global::_000F_2000._0002(-380203502);
		_0003_2001_2001.Size = new Size(2, 2);
		_0003_2001_2001.TabIndex = 249;
		_0005_2001_2001.BackColor = Color.White;
		_0005_2001_2001.Location = new Point(334, 338);
		_0005_2001_2001.Name = global::_000F_2000._0002(-380203485);
		_0005_2001_2001.Size = new Size(2, 2);
		_0005_2001_2001.TabIndex = 248;
		_0008_2001_2001.BackColor = Color.White;
		_0008_2001_2001.Location = new Point(326, 338);
		_0008_2001_2001.Name = global::_000F_2000._0002(-380203476);
		_0008_2001_2001.Size = new Size(2, 2);
		_0008_2001_2001.TabIndex = 254;
		_0006_2001_2001.BackColor = Color.White;
		_0006_2001_2001.Location = new Point(318, 338);
		_0006_2001_2001.Name = global::_000F_2000._0002(-380203459);
		_0006_2001_2001.Size = new Size(2, 2);
		_0006_2001_2001.TabIndex = 253;
		_000E_2001_2001.BackColor = Color.White;
		_000E_2001_2001.Location = new Point(326, 374);
		_000E_2001_2001.Name = global::_000F_2000._0002(-380203442);
		_000E_2001_2001.Size = new Size(2, 2);
		_000E_2001_2001.TabIndex = 268;
		_000F_2001_2001.BackColor = Color.White;
		_000F_2001_2001.Location = new Point(247, 374);
		_000F_2001_2001.Name = global::_000F_2000._0002(-380203425);
		_000F_2001_2001.Size = new Size(2, 2);
		_000F_2001_2001.TabIndex = 267;
		_0002_2002_2001.BackColor = Color.White;
		_0002_2002_2001.Location = new Point(238, 374);
		_0002_2002_2001.Name = global::_000F_2000._0002(-380203416);
		_0002_2002_2001.Size = new Size(2, 2);
		_0002_2002_2001.TabIndex = 266;
		_0003_2002_2001.BackColor = Color.White;
		_0003_2002_2001.Location = new Point(229, 374);
		_0003_2002_2001.Name = global::_000F_2000._0002(-380203399);
		_0003_2002_2001.Size = new Size(2, 2);
		_0003_2002_2001.TabIndex = 265;
		_0005_2002_2001.BackColor = Color.White;
		_0005_2002_2001.Location = new Point(220, 374);
		_0005_2002_2001.Name = global::_000F_2000._0002(-380203126);
		_0005_2002_2001.Size = new Size(2, 2);
		_0005_2002_2001.TabIndex = 264;
		_0008_2002_2001.BackColor = Color.White;
		_0008_2002_2001.Location = new Point(211, 374);
		_0008_2002_2001.Name = global::_000F_2000._0002(-380203109);
		_0008_2002_2001.Size = new Size(2, 2);
		_0008_2002_2001.TabIndex = 263;
		_0006_2002_2001.BackColor = Color.White;
		_0006_2002_2001.Location = new Point(318, 374);
		_0006_2002_2001.Name = global::_000F_2000._0002(-380203100);
		_0006_2002_2001.Size = new Size(2, 2);
		_0006_2002_2001.TabIndex = 262;
		_000E_2002_2001.BackColor = Color.White;
		_000E_2002_2001.Location = new Point(310, 374);
		_000E_2002_2001.Name = global::_000F_2000._0002(-380203083);
		_000E_2002_2001.Size = new Size(2, 2);
		_000E_2002_2001.TabIndex = 261;
		_000F_2002_2001.BackColor = Color.White;
		_000F_2002_2001.Location = new Point(301, 374);
		_000F_2002_2001.Name = global::_000F_2000._0002(-380203066);
		_000F_2002_2001.Size = new Size(2, 2);
		_000F_2002_2001.TabIndex = 260;
		_0002_2003_2001.BackColor = Color.White;
		_0002_2003_2001.Location = new Point(292, 374);
		_0002_2003_2001.Name = global::_000F_2000._0002(-380203049);
		_0002_2003_2001.Size = new Size(2, 2);
		_0002_2003_2001.TabIndex = 259;
		_0003_2003_2001.BackColor = Color.White;
		_0003_2003_2001.Location = new Point(283, 374);
		_0003_2003_2001.Name = global::_000F_2000._0002(-380203040);
		_0003_2003_2001.Size = new Size(2, 2);
		_0003_2003_2001.TabIndex = 258;
		_0005_2003_2001.BackColor = Color.White;
		_0005_2003_2001.Location = new Point(274, 374);
		_0005_2003_2001.Name = global::_000F_2000._0002(-380203023);
		_0005_2003_2001.Size = new Size(2, 2);
		_0005_2003_2001.TabIndex = 257;
		_0008_2003_2001.BackColor = Color.White;
		_0008_2003_2001.Location = new Point(265, 374);
		_0008_2003_2001.Name = global::_000F_2000._0002(-380203262);
		_0008_2003_2001.Size = new Size(2, 2);
		_0008_2003_2001.TabIndex = 256;
		_0006_2003_2001.BackColor = Color.White;
		_0006_2003_2001.Location = new Point(256, 374);
		_0006_2003_2001.Name = global::_000F_2000._0002(-380203245);
		_0006_2003_2001.Size = new Size(2, 2);
		_0006_2003_2001.TabIndex = 255;
		_000E_2003_2001.BackColor = Color.White;
		_000E_2003_2001.Location = new Point(157, 374);
		_000E_2003_2001.Name = global::_000F_2000._0002(-380203236);
		_000E_2003_2001.Size = new Size(2, 2);
		_000E_2003_2001.TabIndex = 312;
		_000F_2003_2001.BackColor = Color.White;
		_000F_2003_2001.Location = new Point(78, 374);
		_000F_2003_2001.Name = global::_000F_2000._0002(-380203219);
		_000F_2003_2001.Size = new Size(2, 2);
		_000F_2003_2001.TabIndex = 311;
		_0002_2004_2001.BackColor = Color.White;
		_0002_2004_2001.Location = new Point(69, 374);
		_0002_2004_2001.Name = global::_000F_2000._0002(-380203202);
		_0002_2004_2001.Size = new Size(2, 2);
		_0002_2004_2001.TabIndex = 310;
		_0003_2004_2001.BackColor = Color.White;
		_0003_2004_2001.Location = new Point(60, 374);
		_0003_2004_2001.Name = global::_000F_2000._0002(-380203185);
		_0003_2004_2001.Size = new Size(2, 2);
		_0003_2004_2001.TabIndex = 309;
		_0005_2004_2001.BackColor = Color.White;
		_0005_2004_2001.Location = new Point(51, 374);
		_0005_2004_2001.Name = global::_000F_2000._0002(-380203176);
		_0005_2004_2001.Size = new Size(2, 2);
		_0005_2004_2001.TabIndex = 308;
		_0008_2004_2001.BackColor = Color.White;
		_0008_2004_2001.Location = new Point(149, 374);
		_0008_2004_2001.Name = global::_000F_2000._0002(-380203159);
		_0008_2004_2001.Size = new Size(2, 2);
		_0008_2004_2001.TabIndex = 306;
		_0006_2004_2001.BackColor = Color.White;
		_0006_2004_2001.Location = new Point(141, 374);
		_0006_2004_2001.Name = global::_000F_2000._0002(-380203142);
		_0006_2004_2001.Size = new Size(2, 2);
		_0006_2004_2001.TabIndex = 305;
		_000E_2004_2001.BackColor = Color.White;
		_000E_2004_2001.Location = new Point(132, 374);
		_000E_2004_2001.Name = global::_000F_2000._0002(-380203893);
		_000E_2004_2001.Size = new Size(2, 2);
		_000E_2004_2001.TabIndex = 304;
		_000F_2004_2001.BackColor = Color.White;
		_000F_2004_2001.Location = new Point(123, 374);
		_000F_2004_2001.Name = global::_000F_2000._0002(-380203884);
		_000F_2004_2001.Size = new Size(2, 2);
		_000F_2004_2001.TabIndex = 303;
		_0002_2005_2001.BackColor = Color.White;
		_0002_2005_2001.Location = new Point(114, 374);
		_0002_2005_2001.Name = global::_000F_2000._0002(-380203867);
		_0002_2005_2001.Size = new Size(2, 2);
		_0002_2005_2001.TabIndex = 302;
		_0003_2005_2001.BackColor = Color.White;
		_0003_2005_2001.Location = new Point(105, 374);
		_0003_2005_2001.Name = global::_000F_2000._0002(-380203850);
		_0003_2005_2001.Size = new Size(2, 2);
		_0003_2005_2001.TabIndex = 301;
		_0005_2005_2001.BackColor = Color.White;
		_0005_2005_2001.Location = new Point(96, 374);
		_0005_2005_2001.Name = global::_000F_2000._0002(-380203833);
		_0005_2005_2001.Size = new Size(2, 2);
		_0005_2005_2001.TabIndex = 300;
		_0008_2005_2001.BackColor = Color.White;
		_0008_2005_2001.Location = new Point(87, 374);
		_0008_2005_2001.Name = global::_000F_2000._0002(-380203824);
		_0008_2005_2001.Size = new Size(2, 2);
		_0008_2005_2001.TabIndex = 299;
		_0006_2005_2001.BackColor = Color.White;
		_0006_2005_2001.Location = new Point(156, 338);
		_0006_2005_2001.Name = global::_000F_2000._0002(-380203807);
		_0006_2005_2001.Size = new Size(2, 2);
		_0006_2005_2001.TabIndex = 298;
		_000E_2005_2001.BackColor = Color.White;
		_000E_2005_2001.Location = new Point(147, 338);
		_000E_2005_2001.Name = global::_000F_2000._0002(-380203790);
		_000E_2005_2001.Size = new Size(2, 2);
		_000E_2005_2001.TabIndex = 297;
		_000F_2005_2001.BackColor = Color.White;
		_000F_2005_2001.Location = new Point(165, 356);
		_000F_2005_2001.Name = global::_000F_2000._0002(-380204029);
		_000F_2005_2001.Size = new Size(2, 2);
		_000F_2005_2001.TabIndex = 296;
		_0002_2006_2001.BackColor = Color.White;
		_0002_2006_2001.Location = new Point(165, 374);
		_0002_2006_2001.Name = global::_000F_2000._0002(-380204020);
		_0002_2006_2001.Size = new Size(2, 2);
		_0002_2006_2001.TabIndex = 295;
		_0003_2006_2001.BackColor = Color.White;
		_0003_2006_2001.Location = new Point(165, 365);
		_0003_2006_2001.Name = global::_000F_2000._0002(-380204003);
		_0003_2006_2001.Size = new Size(2, 2);
		_0003_2006_2001.TabIndex = 294;
		_0005_2006_2001.BackColor = Color.White;
		_0005_2006_2001.Location = new Point(165, 347);
		_0005_2006_2001.Name = global::_000F_2000._0002(-380203986);
		_0005_2006_2001.Size = new Size(2, 2);
		_0005_2006_2001.TabIndex = 293;
		_0008_2006_2001.BackColor = Color.White;
		_0008_2006_2001.Location = new Point(165, 338);
		_0008_2006_2001.Name = global::_000F_2000._0002(-380203969);
		_0008_2006_2001.Size = new Size(2, 2);
		_0008_2006_2001.TabIndex = 292;
		_0006_2006_2001.BackColor = Color.White;
		_0006_2006_2001.Location = new Point(35, 356);
		_0006_2006_2001.Name = global::_000F_2000._0002(-380203960);
		_0006_2006_2001.Size = new Size(2, 2);
		_0006_2006_2001.TabIndex = 291;
		_000E_2006_2001.BackColor = Color.White;
		_000E_2006_2001.Location = new Point(35, 347);
		_000E_2006_2001.Name = global::_000F_2000._0002(-380203943);
		_000E_2006_2001.Size = new Size(2, 2);
		_000E_2006_2001.TabIndex = 288;
		_000F_2006_2001.BackColor = Color.White;
		_000F_2006_2001.Location = new Point(50, 338);
		_000F_2006_2001.Name = global::_000F_2000._0002(-380203926);
		_000F_2006_2001.Size = new Size(2, 2);
		_000F_2006_2001.TabIndex = 287;
		_0002_2007_2001.BackColor = Color.White;
		_0002_2007_2001.Location = new Point(42, 338);
		_0002_2007_2001.Name = global::_000F_2000._0002(-380203909);
		_0002_2007_2001.Size = new Size(2, 2);
		_0002_2007_2001.TabIndex = 286;
		_0003_2007_2001.BackColor = Color.White;
		_0003_2007_2001.Location = new Point(35, 338);
		_0003_2007_2001.Name = global::_000F_2000._0002(-380203644);
		_0003_2007_2001.Size = new Size(2, 2);
		_0003_2007_2001.TabIndex = 285;
		_0005_2007_2001.BackColor = Color.White;
		_0005_2007_2001.Location = new Point(59, 338);
		_0005_2007_2001.Name = global::_000F_2000._0002(-380203627);
		_0005_2007_2001.Size = new Size(2, 2);
		_0005_2007_2001.TabIndex = 284;
		_0008_2007_2001.BackColor = Color.White;
		_0008_2007_2001.Location = new Point(59, 311);
		_0008_2007_2001.Name = global::_000F_2000._0002(-380203610);
		_0008_2007_2001.Size = new Size(2, 2);
		_0008_2007_2001.TabIndex = 283;
		_0006_2007_2001.BackColor = Color.White;
		_0006_2007_2001.Location = new Point(59, 329);
		_0006_2007_2001.Name = global::_000F_2000._0002(-380203593);
		_0006_2007_2001.Size = new Size(2, 2);
		_0006_2007_2001.TabIndex = 282;
		_000E_2007_2001.BackColor = Color.White;
		_000E_2007_2001.Location = new Point(59, 320);
		_000E_2007_2001.Name = global::_000F_2000._0002(-380203584);
		_000E_2007_2001.Size = new Size(2, 2);
		_000E_2007_2001.TabIndex = 281;
		_000F_2007_2001.BackColor = Color.White;
		_000F_2007_2001.Location = new Point(68, 338);
		_000F_2007_2001.Name = global::_000F_2000._0002(-380203567);
		_000F_2007_2001.Size = new Size(2, 2);
		_000F_2007_2001.TabIndex = 280;
		_0002_2008_2001.BackColor = Color.White;
		_0002_2008_2001.Location = new Point(94, 311);
		_0002_2008_2001.Name = global::_000F_2000._0002(-380203550);
		_0002_2008_2001.Size = new Size(2, 2);
		_0002_2008_2001.TabIndex = 279;
		_0003_2008_2001.BackColor = Color.White;
		_0003_2008_2001.Location = new Point(94, 329);
		_0003_2008_2001.Name = global::_000F_2000._0002(-380203533);
		_0003_2008_2001.Size = new Size(2, 2);
		_0003_2008_2001.TabIndex = 278;
		_0005_2008_2001.BackColor = Color.White;
		_0005_2008_2001.Location = new Point(94, 320);
		_0005_2008_2001.Name = global::_000F_2000._0002(-380203524);
		_0005_2008_2001.Size = new Size(2, 2);
		_0005_2008_2001.TabIndex = 277;
		_0008_2008_2001.BackColor = Color.White;
		_0008_2008_2001.Location = new Point(129, 338);
		_0008_2008_2001.Name = global::_000F_2000._0002(-380203763);
		_0008_2008_2001.Size = new Size(2, 2);
		_0008_2008_2001.TabIndex = 276;
		_0006_2008_2001.BackColor = Color.White;
		_0006_2008_2001.Location = new Point(94, 338);
		_0006_2008_2001.Name = global::_000F_2000._0002(-380203746);
		_0006_2008_2001.Size = new Size(2, 2);
		_0006_2008_2001.TabIndex = 275;
		_000E_2008_2001.BackColor = Color.White;
		_000E_2008_2001.Location = new Point(85, 338);
		_000E_2008_2001.Name = global::_000F_2000._0002(-380203729);
		_000E_2008_2001.Size = new Size(2, 2);
		_000E_2008_2001.TabIndex = 274;
		_000F_2008_2001.BackColor = Color.White;
		_000F_2008_2001.Location = new Point(76, 338);
		_000F_2008_2001.Name = global::_000F_2000._0002(-380203720);
		_000F_2008_2001.Size = new Size(2, 2);
		_000F_2008_2001.TabIndex = 273;
		_0002_2009_2001.BackColor = Color.White;
		_0002_2009_2001.Location = new Point(129, 311);
		_0002_2009_2001.Name = global::_000F_2000._0002(-380203703);
		_0002_2009_2001.Size = new Size(2, 2);
		_0002_2009_2001.TabIndex = 272;
		_0003_2009_2001.BackColor = Color.White;
		_0003_2009_2001.Location = new Point(138, 338);
		_0003_2009_2001.Name = global::_000F_2000._0002(-380203686);
		_0003_2009_2001.Size = new Size(2, 2);
		_0003_2009_2001.TabIndex = 271;
		_0005_2009_2001.BackColor = Color.White;
		_0005_2009_2001.Location = new Point(129, 329);
		_0005_2009_2001.Name = global::_000F_2000._0002(-380203669);
		_0005_2009_2001.Size = new Size(2, 2);
		_0005_2009_2001.TabIndex = 270;
		_0008_2009_2001.BackColor = Color.White;
		_0008_2009_2001.Location = new Point(129, 320);
		_0008_2009_2001.Name = global::_000F_2000._0002(-380203660);
		_0008_2009_2001.Size = new Size(2, 2);
		_0008_2009_2001.TabIndex = 269;
		_0006_2009_2001.BackColor = Color.White;
		_0006_2009_2001.Location = new Point(192, 374);
		_0006_2009_2001.Name = global::_000F_2000._0002(-380202363);
		_0006_2009_2001.Size = new Size(2, 2);
		_0006_2009_2001.TabIndex = 315;
		_000E_2009_2001.BackColor = Color.White;
		_000E_2009_2001.Location = new Point(183, 374);
		_000E_2009_2001.Name = global::_000F_2000._0002(-380202346);
		_000E_2009_2001.Size = new Size(2, 2);
		_000E_2009_2001.TabIndex = 314;
		_000F_2009_2001.BackColor = Color.White;
		_000F_2009_2001.Location = new Point(174, 374);
		_000F_2009_2001.Name = global::_000F_2000._0002(-380202329);
		_000F_2009_2001.Size = new Size(2, 2);
		_000F_2009_2001.TabIndex = 313;
		_0002_200A_2001.BackColor = Color.White;
		_0002_200A_2001.Location = new Point(35, 293);
		_0002_200A_2001.Name = global::_000F_2000._0002(-380202320);
		_0002_200A_2001.Size = new Size(2, 2);
		_0002_200A_2001.TabIndex = 318;
		_0003_200A_2001.BackColor = Color.White;
		_0003_200A_2001.Location = new Point(35, 284);
		_0003_200A_2001.Name = global::_000F_2000._0002(-380202303);
		_0003_200A_2001.Size = new Size(2, 2);
		_0003_200A_2001.TabIndex = 317;
		_0005_200A_2001.BackColor = Color.White;
		_0005_200A_2001.Location = new Point(35, 275);
		_0005_200A_2001.Name = global::_000F_2000._0002(-380202286);
		_0005_200A_2001.Size = new Size(2, 2);
		_0005_200A_2001.TabIndex = 316;
		_0008_200A_2001.BackColor = Color.White;
		_0008_200A_2001.Location = new Point(86, 266);
		_0008_200A_2001.Name = global::_000F_2000._0002(-380202269);
		_0008_200A_2001.Size = new Size(2, 2);
		_0008_200A_2001.TabIndex = 319;
		_0006_200A_2001.BackColor = Color.White;
		_0006_200A_2001.Location = new Point(59, 302);
		_0006_200A_2001.Name = global::_000F_2000._0002(-380202260);
		_0006_200A_2001.Size = new Size(2, 2);
		_0006_200A_2001.TabIndex = 323;
		_000E_200A_2001.BackColor = Color.White;
		_000E_200A_2001.Location = new Point(51, 302);
		_000E_200A_2001.Name = global::_000F_2000._0002(-380202243);
		_000E_200A_2001.Size = new Size(2, 2);
		_000E_200A_2001.TabIndex = 322;
		_000F_200A_2001.BackColor = Color.White;
		_000F_200A_2001.Location = new Point(43, 302);
		_000F_200A_2001.Name = global::_000F_2000._0002(-380202482);
		_000F_200A_2001.Size = new Size(2, 2);
		_000F_200A_2001.TabIndex = 321;
		_0002_200B_2001.BackColor = Color.Black;
		_0002_200B_2001.Image = (Image)componentResourceManager.GetObject(global::_000F_2000._0002(-380202465));
		_0002_200B_2001.Location = new Point(31, 298);
		_0002_200B_2001.Name = global::_000F_2000._0002(-380202446);
		_0002_200B_2001.Size = new Size(10, 10);
		_0002_200B_2001.TabIndex = 320;
		_0003_200B_2001.BackColor = Color.White;
		_0003_200B_2001.Location = new Point(274, 230);
		_0003_200B_2001.Name = global::_000F_2000._0002(-380202429);
		_0003_200B_2001.Size = new Size(2, 2);
		_0003_200B_2001.TabIndex = 333;
		_0005_200B_2001.BackColor = Color.White;
		_0005_200B_2001.Location = new Point(274, 248);
		_0005_200B_2001.Name = global::_000F_2000._0002(-380202420);
		_0005_200B_2001.Size = new Size(2, 2);
		_0005_200B_2001.TabIndex = 332;
		_0008_200B_2001.BackColor = Color.White;
		_0008_200B_2001.Location = new Point(274, 239);
		_0008_200B_2001.Name = global::_000F_2000._0002(-380202403);
		_0008_200B_2001.Size = new Size(2, 2);
		_0008_200B_2001.TabIndex = 331;
		_0006_200B_2001.BackColor = Color.White;
		_0006_200B_2001.Location = new Point(274, 257);
		_0006_200B_2001.Name = global::_000F_2000._0002(-380202386);
		_0006_200B_2001.Size = new Size(2, 2);
		_0006_200B_2001.TabIndex = 330;
		_000E_200B_2001.BackColor = Color.White;
		_000E_200B_2001.Location = new Point(274, 212);
		_000E_200B_2001.Name = global::_000F_2000._0002(-380202369);
		_000E_200B_2001.Size = new Size(2, 2);
		_000E_200B_2001.TabIndex = 329;
		_000F_200B_2001.BackColor = Color.White;
		_000F_200B_2001.Location = new Point(274, 203);
		_000F_200B_2001.Name = global::_000F_2000._0002(-380202104);
		_000F_200B_2001.Size = new Size(2, 2);
		_000F_200B_2001.TabIndex = 328;
		_0002_2000_2002.BackColor = Color.White;
		_0002_2000_2002.Location = new Point(274, 194);
		_0002_2000_2002.Name = global::_000F_2000._0002(-380202087);
		_0002_2000_2002.Size = new Size(2, 2);
		_0002_2000_2002.TabIndex = 327;
		_0003_2000_2002.BackColor = Color.White;
		_0003_2000_2002.Location = new Point(274, 221);
		_0003_2000_2002.Name = global::_000F_2000._0002(-380202070);
		_0003_2000_2002.Size = new Size(2, 2);
		_0003_2000_2002.TabIndex = 326;
		_0005_2000_2002.BackColor = Color.White;
		_0005_2000_2002.Location = new Point(274, 185);
		_0005_2000_2002.Name = global::_000F_2000._0002(-380202053);
		_0005_2000_2002.Size = new Size(2, 2);
		_0005_2000_2002.TabIndex = 325;
		_0008_2000_2002.BackColor = Color.White;
		_0008_2000_2002.Location = new Point(274, 149);
		_0008_2000_2002.Name = global::_000F_2000._0002(-380202044);
		_0008_2000_2002.Size = new Size(2, 2);
		_0008_2000_2002.TabIndex = 342;
		_0006_2000_2002.BackColor = Color.White;
		_0006_2000_2002.Location = new Point(274, 167);
		_0006_2000_2002.Name = global::_000F_2000._0002(-380202027);
		_0006_2000_2002.Size = new Size(2, 2);
		_0006_2000_2002.TabIndex = 341;
		_000E_2000_2002.BackColor = Color.White;
		_000E_2000_2002.Location = new Point(274, 158);
		_000E_2000_2002.Name = global::_000F_2000._0002(-380202010);
		_000E_2000_2002.Size = new Size(2, 2);
		_000E_2000_2002.TabIndex = 340;
		_000F_2000_2002.BackColor = Color.White;
		_000F_2000_2002.Location = new Point(274, 176);
		_000F_2000_2002.Name = global::_000F_2000._0002(-380201993);
		_000F_2000_2002.Size = new Size(2, 2);
		_000F_2000_2002.TabIndex = 339;
		_0002_2001_2002.BackColor = Color.White;
		_0002_2001_2002.Location = new Point(274, 131);
		_0002_2001_2002.Name = global::_000F_2000._0002(-380202240);
		_0002_2001_2002.Size = new Size(2, 2);
		_0002_2001_2002.TabIndex = 338;
		_0003_2001_2002.BackColor = Color.White;
		_0003_2001_2002.Location = new Point(274, 122);
		_0003_2001_2002.Name = global::_000F_2000._0002(-380202223);
		_0003_2001_2002.Size = new Size(2, 2);
		_0003_2001_2002.TabIndex = 337;
		_0005_2001_2002.BackColor = Color.White;
		_0005_2001_2002.Location = new Point(274, 113);
		_0005_2001_2002.Name = global::_000F_2000._0002(-380202206);
		_0005_2001_2002.Size = new Size(2, 2);
		_0005_2001_2002.TabIndex = 336;
		_0008_2001_2002.BackColor = Color.White;
		_0008_2001_2002.Location = new Point(274, 140);
		_0008_2001_2002.Name = global::_000F_2000._0002(-380202189);
		_0008_2001_2002.Size = new Size(2, 2);
		_0008_2001_2002.TabIndex = 335;
		_0006_2001_2002.BackColor = Color.White;
		_0006_2001_2002.Location = new Point(274, 104);
		_0006_2001_2002.Name = global::_000F_2000._0002(-380202180);
		_0006_2001_2002.Size = new Size(2, 2);
		_0006_2001_2002.TabIndex = 334;
		_000E_2001_2002.BackColor = Color.White;
		_000E_2001_2002.Location = new Point(274, 66);
		_000E_2001_2002.Name = global::_000F_2000._0002(-380202163);
		_000E_2001_2002.Size = new Size(2, 2);
		_000E_2001_2002.TabIndex = 351;
		_000F_2001_2002.BackColor = Color.White;
		_000F_2001_2002.Location = new Point(274, 85);
		_000F_2001_2002.Name = global::_000F_2000._0002(-380202146);
		_000F_2001_2002.Size = new Size(2, 2);
		_000F_2001_2002.TabIndex = 350;
		_0002_2002_2002.BackColor = Color.White;
		_0002_2002_2002.Location = new Point(274, 76);
		_0002_2002_2002.Name = global::_000F_2000._0002(-380202129);
		_0002_2002_2002.Size = new Size(2, 2);
		_0002_2002_2002.TabIndex = 349;
		_0003_2002_2002.BackColor = Color.White;
		_0003_2002_2002.Location = new Point(274, 94);
		_0003_2002_2002.Name = global::_000F_2000._0002(-380202120);
		_0003_2002_2002.Size = new Size(2, 2);
		_0003_2002_2002.TabIndex = 348;
		_0005_2002_2002.BackColor = Color.White;
		_0005_2002_2002.Location = new Point(274, 47);
		_0005_2002_2002.Name = global::_000F_2000._0002(-380202871);
		_0005_2002_2002.Size = new Size(2, 2);
		_0005_2002_2002.TabIndex = 347;
		_0008_2002_2002.BackColor = Color.White;
		_0008_2002_2002.Location = new Point(274, 57);
		_0008_2002_2002.Name = global::_000F_2000._0002(-380202854);
		_0008_2002_2002.Size = new Size(2, 2);
		_0008_2002_2002.TabIndex = 344;
		_0006_2002_2002.BackColor = Color.White;
		_0006_2002_2002.Location = new Point(334, 38);
		_0006_2002_2002.Name = global::_000F_2000._0002(-380202837);
		_0006_2002_2002.Size = new Size(2, 2);
		_0006_2002_2002.TabIndex = 367;
		_000E_2002_2002.BackColor = Color.White;
		_000E_2002_2002.Location = new Point(326, 38);
		_000E_2002_2002.Name = global::_000F_2000._0002(-380202828);
		_000E_2002_2002.Size = new Size(2, 2);
		_000E_2002_2002.TabIndex = 366;
		_000F_2002_2002.BackColor = Color.White;
		_000F_2002_2002.Location = new Point(247, 38);
		_000F_2002_2002.Name = global::_000F_2000._0002(-380202811);
		_000F_2002_2002.Size = new Size(2, 2);
		_000F_2002_2002.TabIndex = 365;
		_0002_2003_2002.BackColor = Color.White;
		_0002_2003_2002.Location = new Point(238, 38);
		_0002_2003_2002.Name = global::_000F_2000._0002(-380202794);
		_0002_2003_2002.Size = new Size(2, 2);
		_0002_2003_2002.TabIndex = 364;
		_0003_2003_2002.BackColor = Color.White;
		_0003_2003_2002.Location = new Point(229, 38);
		_0003_2003_2002.Name = global::_000F_2000._0002(-380202777);
		_0003_2003_2002.Size = new Size(2, 2);
		_0003_2003_2002.TabIndex = 363;
		_0005_2003_2002.BackColor = Color.White;
		_0005_2003_2002.Location = new Point(220, 38);
		_0005_2003_2002.Name = global::_000F_2000._0002(-380202768);
		_0005_2003_2002.Size = new Size(2, 2);
		_0005_2003_2002.TabIndex = 362;
		_0008_2003_2002.BackColor = Color.White;
		_0008_2003_2002.Location = new Point(211, 38);
		_0008_2003_2002.Name = global::_000F_2000._0002(-380203007);
		_0008_2003_2002.Size = new Size(2, 2);
		_0008_2003_2002.TabIndex = 361;
		_0006_2003_2002.BackColor = Color.White;
		_0006_2003_2002.Location = new Point(202, 38);
		_0006_2003_2002.Name = global::_000F_2000._0002(-380202990);
		_0006_2003_2002.Size = new Size(2, 2);
		_0006_2003_2002.TabIndex = 360;
		_000E_2003_2002.BackColor = Color.White;
		_000E_2003_2002.Location = new Point(318, 38);
		_000E_2003_2002.Name = global::_000F_2000._0002(-380202973);
		_000E_2003_2002.Size = new Size(2, 2);
		_000E_2003_2002.TabIndex = 359;
		_000F_2003_2002.BackColor = Color.White;
		_000F_2003_2002.Location = new Point(310, 38);
		_000F_2003_2002.Name = global::_000F_2000._0002(-380202964);
		_000F_2003_2002.Size = new Size(2, 2);
		_000F_2003_2002.TabIndex = 358;
		_0002_2004_2002.BackColor = Color.White;
		_0002_2004_2002.Location = new Point(301, 38);
		_0002_2004_2002.Name = global::_000F_2000._0002(-380202947);
		_0002_2004_2002.Size = new Size(2, 2);
		_0002_2004_2002.TabIndex = 357;
		_0003_2004_2002.BackColor = Color.White;
		_0003_2004_2002.Location = new Point(292, 38);
		_0003_2004_2002.Name = global::_000F_2000._0002(-380202930);
		_0003_2004_2002.Size = new Size(2, 2);
		_0003_2004_2002.TabIndex = 356;
		_0005_2004_2002.BackColor = Color.White;
		_0005_2004_2002.Location = new Point(283, 38);
		_0005_2004_2002.Name = global::_000F_2000._0002(-380202913);
		_0005_2004_2002.Size = new Size(2, 2);
		_0005_2004_2002.TabIndex = 355;
		_0008_2004_2002.BackColor = Color.White;
		_0008_2004_2002.Location = new Point(274, 38);
		_0008_2004_2002.Name = global::_000F_2000._0002(-380202904);
		_0008_2004_2002.Size = new Size(2, 2);
		_0008_2004_2002.TabIndex = 354;
		_0006_2004_2002.BackColor = Color.White;
		_0006_2004_2002.Location = new Point(265, 38);
		_0006_2004_2002.Name = global::_000F_2000._0002(-380202887);
		_0006_2004_2002.Size = new Size(2, 2);
		_0006_2004_2002.TabIndex = 353;
		_000E_2004_2002.BackColor = Color.White;
		_000E_2004_2002.Location = new Point(256, 38);
		_000E_2004_2002.Name = global::_000F_2000._0002(-380202614);
		_000E_2004_2002.Size = new Size(2, 2);
		_000E_2004_2002.TabIndex = 352;
		_000F_2004_2002.BackColor = Color.White;
		_000F_2004_2002.Location = new Point(334, 94);
		_000F_2004_2002.Name = global::_000F_2000._0002(-380202597);
		_000F_2004_2002.Size = new Size(2, 2);
		_000F_2004_2002.TabIndex = 376;
		_0002_2005_2002.BackColor = Color.White;
		_0002_2005_2002.Location = new Point(334, 113);
		_0002_2005_2002.Name = global::_000F_2000._0002(-380202588);
		_0002_2005_2002.Size = new Size(2, 2);
		_0002_2005_2002.TabIndex = 375;
		_0003_2005_2002.BackColor = Color.White;
		_0003_2005_2002.Location = new Point(334, 104);
		_0003_2005_2002.Name = global::_000F_2000._0002(-380202571);
		_0003_2005_2002.Size = new Size(2, 2);
		_0003_2005_2002.TabIndex = 374;
		_0005_2005_2002.BackColor = Color.White;
		_0005_2005_2002.Location = new Point(334, 122);
		_0005_2005_2002.Name = global::_000F_2000._0002(-380202554);
		_0005_2005_2002.Size = new Size(2, 2);
		_0005_2005_2002.TabIndex = 373;
		_0008_2005_2002.BackColor = Color.White;
		_0008_2005_2002.Location = new Point(334, 76);
		_0008_2005_2002.Name = global::_000F_2000._0002(-380202537);
		_0008_2005_2002.Size = new Size(2, 2);
		_0008_2005_2002.TabIndex = 372;
		_0006_2005_2002.BackColor = Color.White;
		_0006_2005_2002.Location = new Point(334, 67);
		_0006_2005_2002.Name = global::_000F_2000._0002(-380202528);
		_0006_2005_2002.Size = new Size(2, 2);
		_0006_2005_2002.TabIndex = 371;
		_000E_2005_2002.BackColor = Color.Black;
		_000E_2005_2002.Image = (Image)componentResourceManager.GetObject(global::_000F_2000._0002(-380202511));
		_000E_2005_2002.Location = new Point(330, 54);
		_000E_2005_2002.Name = global::_000F_2000._0002(-380202748);
		_000E_2005_2002.Size = new Size(10, 10);
		_000E_2005_2002.TabIndex = 370;
		_000F_2005_2002.BackColor = Color.White;
		_000F_2005_2002.Location = new Point(334, 85);
		_000F_2005_2002.Name = global::_000F_2000._0002(-380202731);
		_000F_2005_2002.Size = new Size(2, 2);
		_000F_2005_2002.TabIndex = 369;
		_0002_2006_2002.BackColor = Color.White;
		_0002_2006_2002.Location = new Point(334, 48);
		_0002_2006_2002.Name = global::_000F_2000._0002(-380202714);
		_0002_2006_2002.Size = new Size(2, 2);
		_0002_2006_2002.TabIndex = 368;
		_0003_2006_2002.BackColor = Color.White;
		_0003_2006_2002.Location = new Point(326, 85);
		_0003_2006_2002.Name = global::_000F_2000._0002(-380202697);
		_0003_2006_2002.Size = new Size(2, 2);
		_0003_2006_2002.TabIndex = 382;
		_0005_2006_2002.BackColor = Color.White;
		_0005_2006_2002.Location = new Point(318, 85);
		_0005_2006_2002.Name = global::_000F_2000._0002(-380202688);
		_0005_2006_2002.Size = new Size(2, 2);
		_0005_2006_2002.TabIndex = 381;
		_0008_2006_2002.BackColor = Color.White;
		_0008_2006_2002.Location = new Point(310, 85);
		_0008_2006_2002.Name = global::_000F_2000._0002(-380202671);
		_0008_2006_2002.Size = new Size(2, 2);
		_0008_2006_2002.TabIndex = 380;
		_0006_2006_2002.BackColor = Color.White;
		_0006_2006_2002.Location = new Point(301, 85);
		_0006_2006_2002.Name = global::_000F_2000._0002(-380202654);
		_0006_2006_2002.Size = new Size(2, 2);
		_0006_2006_2002.TabIndex = 379;
		_000E_2006_2002.BackColor = Color.White;
		_000E_2006_2002.Location = new Point(292, 85);
		_000E_2006_2002.Name = global::_000F_2000._0002(-380202637);
		_000E_2006_2002.Size = new Size(2, 2);
		_000E_2006_2002.TabIndex = 378;
		_000F_2006_2002.BackColor = Color.White;
		_000F_2006_2002.Location = new Point(283, 85);
		_000F_2006_2002.Name = global::_000F_2000._0002(-380202628);
		_000F_2006_2002.Size = new Size(2, 2);
		_000F_2006_2002.TabIndex = 377;
		_0002_2007_2002.BackColor = Color.White;
		_0002_2007_2002.Location = new Point(326, 122);
		_0002_2007_2002.Name = global::_000F_2000._0002(-380201331);
		_0002_2007_2002.Size = new Size(2, 2);
		_0002_2007_2002.TabIndex = 388;
		_0003_2007_2002.BackColor = Color.White;
		_0003_2007_2002.Location = new Point(318, 122);
		_0003_2007_2002.Name = global::_000F_2000._0002(-380201314);
		_0003_2007_2002.Size = new Size(2, 2);
		_0003_2007_2002.TabIndex = 387;
		_0005_2007_2002.BackColor = Color.White;
		_0005_2007_2002.Location = new Point(310, 122);
		_0005_2007_2002.Name = global::_000F_2000._0002(-380201297);
		_0005_2007_2002.Size = new Size(2, 2);
		_0005_2007_2002.TabIndex = 386;
		_0008_2007_2002.BackColor = Color.White;
		_0008_2007_2002.Location = new Point(301, 122);
		_0008_2007_2002.Name = global::_000F_2000._0002(-380201288);
		_0008_2007_2002.Size = new Size(2, 2);
		_0008_2007_2002.TabIndex = 385;
		_0006_2007_2002.BackColor = Color.White;
		_0006_2007_2002.Location = new Point(292, 122);
		_0006_2007_2002.Name = global::_000F_2000._0002(-380201271);
		_0006_2007_2002.Size = new Size(2, 2);
		_0006_2007_2002.TabIndex = 384;
		_000E_2007_2002.BackColor = Color.White;
		_000E_2007_2002.Location = new Point(283, 122);
		_000E_2007_2002.Name = global::_000F_2000._0002(-380201254);
		_000E_2007_2002.Size = new Size(2, 2);
		_000E_2007_2002.TabIndex = 383;
		_000F_2007_2002.BackColor = Color.White;
		_000F_2007_2002.Location = new Point(247, 85);
		_000F_2007_2002.Name = global::_000F_2000._0002(-380201237);
		_000F_2007_2002.Size = new Size(2, 2);
		_000F_2007_2002.TabIndex = 396;
		_0002_2008_2002.BackColor = Color.White;
		_0002_2008_2002.Location = new Point(238, 85);
		_0002_2008_2002.Name = global::_000F_2000._0002(-380201228);
		_0002_2008_2002.Size = new Size(2, 2);
		_0002_2008_2002.TabIndex = 395;
		_0003_2008_2002.BackColor = Color.White;
		_0003_2008_2002.Location = new Point(229, 85);
		_0003_2008_2002.Name = global::_000F_2000._0002(-380201467);
		_0003_2008_2002.Size = new Size(2, 2);
		_0003_2008_2002.TabIndex = 394;
		_0005_2008_2002.BackColor = Color.White;
		_0005_2008_2002.Location = new Point(220, 85);
		_0005_2008_2002.Name = global::_000F_2000._0002(-380201450);
		_0005_2008_2002.Size = new Size(2, 2);
		_0005_2008_2002.TabIndex = 393;
		_0008_2008_2002.BackColor = Color.White;
		_0008_2008_2002.Location = new Point(211, 85);
		_0008_2008_2002.Name = global::_000F_2000._0002(-380201433);
		_0008_2008_2002.Size = new Size(2, 2);
		_0008_2008_2002.TabIndex = 392;
		_0006_2008_2002.BackColor = Color.White;
		_0006_2008_2002.Location = new Point(202, 85);
		_0006_2008_2002.Name = global::_000F_2000._0002(-380201424);
		_0006_2008_2002.Size = new Size(2, 2);
		_0006_2008_2002.TabIndex = 391;
		_000E_2008_2002.BackColor = Color.White;
		_000E_2008_2002.Location = new Point(265, 85);
		_000E_2008_2002.Name = global::_000F_2000._0002(-380201407);
		_000E_2008_2002.Size = new Size(2, 2);
		_000E_2008_2002.TabIndex = 390;
		_000F_2008_2002.BackColor = Color.White;
		_000F_2008_2002.Location = new Point(256, 85);
		_000F_2008_2002.Name = global::_000F_2000._0002(-380201390);
		_000F_2008_2002.Size = new Size(2, 2);
		_000F_2008_2002.TabIndex = 389;
		_0002_2009_2002.BackColor = Color.White;
		_0002_2009_2002.Location = new Point(202, 66);
		_0002_2009_2002.Name = global::_000F_2000._0002(-380201373);
		_0002_2009_2002.Size = new Size(2, 2);
		_0002_2009_2002.TabIndex = 400;
		_0003_2009_2002.BackColor = Color.White;
		_0003_2009_2002.Location = new Point(202, 76);
		_0003_2009_2002.Name = global::_000F_2000._0002(-380201364);
		_0003_2009_2002.Size = new Size(2, 2);
		_0003_2009_2002.TabIndex = 399;
		_0005_2009_2002.BackColor = Color.White;
		_0005_2009_2002.Location = new Point(202, 47);
		_0005_2009_2002.Name = global::_000F_2000._0002(-380201347);
		_0005_2009_2002.Size = new Size(2, 2);
		_0005_2009_2002.TabIndex = 398;
		_0008_2009_2002.BackColor = Color.White;
		_0008_2009_2002.Location = new Point(202, 57);
		_0008_2009_2002.Name = global::_000F_2000._0002(-380201074);
		_0008_2009_2002.Size = new Size(2, 2);
		_0008_2009_2002.TabIndex = 397;
		_0006_2009_2002.BackColor = Color.White;
		_0006_2009_2002.Location = new Point(129, 94);
		_0006_2009_2002.Name = global::_000F_2000._0002(-380201057);
		_0006_2009_2002.Size = new Size(2, 2);
		_0006_2009_2002.TabIndex = 419;
		_000E_2009_2002.BackColor = Color.White;
		_000E_2009_2002.Location = new Point(129, 112);
		_000E_2009_2002.Name = global::_000F_2000._0002(-380201048);
		_000E_2009_2002.Size = new Size(2, 2);
		_000E_2009_2002.TabIndex = 418;
		_000F_2009_2002.BackColor = Color.White;
		_000F_2009_2002.Location = new Point(129, 103);
		_000F_2009_2002.Name = global::_000F_2000._0002(-380201031);
		_000F_2009_2002.Size = new Size(2, 2);
		_000F_2009_2002.TabIndex = 417;
		_0002_200A_2002.BackColor = Color.White;
		_0002_200A_2002.Location = new Point(238, 94);
		_0002_200A_2002.Name = global::_000F_2000._0002(-380201014);
		_0002_200A_2002.Size = new Size(2, 2);
		_0002_200A_2002.TabIndex = 416;
		_0003_200A_2002.BackColor = Color.White;
		_0003_200A_2002.Location = new Point(238, 112);
		_0003_200A_2002.Name = global::_000F_2000._0002(-380200997);
		_0003_200A_2002.Size = new Size(2, 2);
		_0003_200A_2002.TabIndex = 415;
		_0005_200A_2002.BackColor = Color.White;
		_0005_200A_2002.Location = new Point(238, 103);
		_0005_200A_2002.Name = global::_000F_2000._0002(-380200988);
		_0005_200A_2002.Size = new Size(2, 2);
		_0005_200A_2002.TabIndex = 414;
		_0008_200A_2002.BackColor = Color.White;
		_0008_200A_2002.Location = new Point(202, 122);
		_0008_200A_2002.Name = global::_000F_2000._0002(-380200971);
		_0008_200A_2002.Size = new Size(2, 2);
		_0008_200A_2002.TabIndex = 410;
		_0006_200A_2002.BackColor = Color.White;
		_0006_200A_2002.Location = new Point(238, 122);
		_0006_200A_2002.Name = global::_000F_2000._0002(-380201210);
		_0006_200A_2002.Size = new Size(2, 2);
		_0006_200A_2002.TabIndex = 409;
		_000E_200A_2002.BackColor = Color.White;
		_000E_200A_2002.Location = new Point(229, 122);
		_000E_200A_2002.Name = global::_000F_2000._0002(-380201193);
		_000E_200A_2002.Size = new Size(2, 2);
		_000E_200A_2002.TabIndex = 408;
		_000F_200A_2002.BackColor = Color.White;
		_000F_200A_2002.Location = new Point(220, 122);
		_000F_200A_2002.Name = global::_000F_2000._0002(-380201184);
		_000F_200A_2002.Size = new Size(2, 2);
		_000F_200A_2002.TabIndex = 407;
		_0002_200B_2002.BackColor = Color.White;
		_0002_200B_2002.Location = new Point(211, 122);
		_0002_200B_2002.Name = global::_000F_2000._0002(-380201167);
		_0002_200B_2002.Size = new Size(2, 2);
		_0002_200B_2002.TabIndex = 406;
		_0003_200B_2002.BackColor = Color.White;
		_0003_200B_2002.Location = new Point(165, 122);
		_0003_200B_2002.Name = global::_000F_2000._0002(-380201150);
		_0003_200B_2002.Size = new Size(2, 2);
		_0003_200B_2002.TabIndex = 405;
		_0005_200B_2002.BackColor = Color.White;
		_0005_200B_2002.Location = new Point(156, 122);
		_0005_200B_2002.Name = global::_000F_2000._0002(-380201133);
		_0005_200B_2002.Size = new Size(2, 2);
		_0005_200B_2002.TabIndex = 404;
		_0008_200B_2002.BackColor = Color.White;
		_0008_200B_2002.Location = new Point(147, 122);
		_0008_200B_2002.Name = global::_000F_2000._0002(-380201124);
		_0008_200B_2002.Size = new Size(2, 2);
		_0008_200B_2002.TabIndex = 403;
		_0006_200B_2002.BackColor = Color.White;
		_0006_200B_2002.Location = new Point(138, 122);
		_0006_200B_2002.Name = global::_000F_2000._0002(-380201107);
		_0006_200B_2002.Size = new Size(2, 2);
		_0006_200B_2002.TabIndex = 402;
		_000E_200B_2002.BackColor = Color.White;
		_000E_200B_2002.Location = new Point(129, 122);
		_000E_200B_2002.Name = global::_000F_2000._0002(-380201090);
		_000E_200B_2002.Size = new Size(2, 2);
		_000E_200B_2002.TabIndex = 401;
		_000F_200B_2002.BackColor = Color.White;
		_000F_200B_2002.Location = new Point(192, 85);
		_000F_200B_2002.Name = global::_000F_2000._0002(-380201841);
		_000F_200B_2002.Size = new Size(2, 2);
		_000F_200B_2002.TabIndex = 432;
		_0002_2000_2003.BackColor = Color.White;
		_0002_2000_2003.Location = new Point(183, 85);
		_0002_2000_2003.Name = global::_000F_2000._0002(-380201832);
		_0002_2000_2003.Size = new Size(2, 2);
		_0002_2000_2003.TabIndex = 431;
		_0003_2000_2003.BackColor = Color.White;
		_0003_2000_2003.Location = new Point(174, 85);
		_0003_2000_2003.Name = global::_000F_2000._0002(-380201815);
		_0003_2000_2003.Size = new Size(2, 2);
		_0003_2000_2003.TabIndex = 430;
		_0005_2000_2003.BackColor = Color.White;
		_0005_2000_2003.Location = new Point(165, 85);
		_0005_2000_2003.Name = global::_000F_2000._0002(-380201798);
		_0005_2000_2003.Size = new Size(2, 2);
		_0005_2000_2003.TabIndex = 424;
		_0008_2000_2003.BackColor = Color.White;
		_0008_2000_2003.Location = new Point(156, 85);
		_0008_2000_2003.Name = global::_000F_2000._0002(-380201781);
		_0008_2000_2003.Size = new Size(2, 2);
		_0008_2000_2003.TabIndex = 423;
		_0006_2000_2003.BackColor = Color.White;
		_0006_2000_2003.Location = new Point(147, 85);
		_0006_2000_2003.Name = global::_000F_2000._0002(-380201772);
		_0006_2000_2003.Size = new Size(2, 2);
		_0006_2000_2003.TabIndex = 422;
		_000E_2000_2003.BackColor = Color.White;
		_000E_2000_2003.Location = new Point(138, 85);
		_000E_2000_2003.Name = global::_000F_2000._0002(-380201755);
		_000E_2000_2003.Size = new Size(2, 2);
		_000E_2000_2003.TabIndex = 421;
		_000F_2000_2003.BackColor = Color.White;
		_000F_2000_2003.Location = new Point(129, 85);
		_000F_2000_2003.Name = global::_000F_2000._0002(-380201738);
		_000F_2000_2003.Size = new Size(2, 2);
		_000F_2000_2003.TabIndex = 420;
		_0002_2001_2003.BackColor = Color.White;
		_0002_2001_2003.Location = new Point(94, 66);
		_0002_2001_2003.Name = global::_000F_2000._0002(-380201977);
		_0002_2001_2003.Size = new Size(2, 2);
		_0002_2001_2003.TabIndex = 449;
		_0003_2001_2003.BackColor = Color.White;
		_0003_2001_2003.Location = new Point(94, 76);
		_0003_2001_2003.Name = global::_000F_2000._0002(-380201968);
		_0003_2001_2003.Size = new Size(2, 2);
		_0003_2001_2003.TabIndex = 448;
		_0005_2001_2003.BackColor = Color.White;
		_0005_2001_2003.Location = new Point(94, 47);
		_0005_2001_2003.Name = global::_000F_2000._0002(-380201951);
		_0005_2001_2003.Size = new Size(2, 2);
		_0005_2001_2003.TabIndex = 447;
		_0008_2001_2003.BackColor = Color.White;
		_0008_2001_2003.Location = new Point(94, 57);
		_0008_2001_2003.Name = global::_000F_2000._0002(-380201934);
		_0008_2001_2003.Size = new Size(2, 2);
		_0008_2001_2003.TabIndex = 446;
		_0006_2001_2003.BackColor = Color.White;
		_0006_2001_2003.Location = new Point(138, 38);
		_0006_2001_2003.Name = global::_000F_2000._0002(-380201917);
		_0006_2001_2003.Size = new Size(2, 2);
		_0006_2001_2003.TabIndex = 445;
		_000E_2001_2003.BackColor = Color.White;
		_000E_2001_2003.Location = new Point(129, 38);
		_000E_2001_2003.Name = global::_000F_2000._0002(-380201908);
		_000E_2001_2003.Size = new Size(2, 2);
		_000E_2001_2003.TabIndex = 444;
		_000F_2001_2003.BackColor = Color.White;
		_000F_2001_2003.Location = new Point(120, 38);
		_000F_2001_2003.Name = global::_000F_2000._0002(-380201891);
		_000F_2001_2003.Size = new Size(2, 2);
		_000F_2001_2003.TabIndex = 443;
		_0002_2002_2003.BackColor = Color.White;
		_0002_2002_2003.Location = new Point(111, 38);
		_0002_2002_2003.Name = global::_000F_2000._0002(-380201874);
		_0002_2002_2003.Size = new Size(2, 2);
		_0002_2002_2003.TabIndex = 442;
		_0003_2002_2003.BackColor = Color.White;
		_0003_2002_2003.Location = new Point(102, 38);
		_0003_2002_2003.Name = global::_000F_2000._0002(-380201857);
		_0003_2002_2003.Size = new Size(2, 2);
		_0003_2002_2003.TabIndex = 441;
		_0005_2002_2003.BackColor = Color.White;
		_0005_2002_2003.Location = new Point(94, 38);
		_0005_2002_2003.Name = global::_000F_2000._0002(-380201592);
		_0005_2002_2003.Size = new Size(2, 2);
		_0005_2002_2003.TabIndex = 440;
		_0008_2002_2003.BackColor = Color.White;
		_0008_2002_2003.Location = new Point(165, 38);
		_0008_2002_2003.Name = global::_000F_2000._0002(-380201575);
		_0008_2002_2003.Size = new Size(2, 2);
		_0008_2002_2003.TabIndex = 439;
		_0006_2002_2003.BackColor = Color.White;
		_0006_2002_2003.Location = new Point(156, 38);
		_0006_2002_2003.Name = global::_000F_2000._0002(-380201558);
		_0006_2002_2003.Size = new Size(2, 2);
		_0006_2002_2003.TabIndex = 438;
		_000E_2002_2003.BackColor = Color.White;
		_000E_2002_2003.Location = new Point(147, 38);
		_000E_2002_2003.Name = global::_000F_2000._0002(-380201541);
		_000E_2002_2003.Size = new Size(2, 2);
		_000E_2002_2003.TabIndex = 437;
		_000F_2002_2003.BackColor = Color.White;
		_000F_2002_2003.Location = new Point(165, 66);
		_000F_2002_2003.Name = global::_000F_2000._0002(-380201532);
		_000F_2002_2003.Size = new Size(2, 2);
		_000F_2002_2003.TabIndex = 436;
		_0002_2003_2003.BackColor = Color.White;
		_0002_2003_2003.Location = new Point(165, 76);
		_0002_2003_2003.Name = global::_000F_2000._0002(-380201515);
		_0002_2003_2003.Size = new Size(2, 2);
		_0002_2003_2003.TabIndex = 435;
		_0003_2003_2003.BackColor = Color.White;
		_0003_2003_2003.Location = new Point(165, 47);
		_0003_2003_2003.Name = global::_000F_2000._0002(-380201498);
		_0003_2003_2003.Size = new Size(2, 2);
		_0003_2003_2003.TabIndex = 434;
		_0005_2003_2003.BackColor = Color.White;
		_0005_2003_2003.Location = new Point(165, 57);
		_0005_2003_2003.Name = global::_000F_2000._0002(-380201481);
		_0005_2003_2003.Size = new Size(2, 2);
		_0005_2003_2003.TabIndex = 433;
		_0008_2003_2003.BackColor = Color.White;
		_0008_2003_2003.Location = new Point(49, 85);
		_0008_2003_2003.Name = global::_000F_2000._0002(-380201728);
		_0008_2003_2003.Size = new Size(2, 2);
		_0008_2003_2003.TabIndex = 459;
		_0006_2003_2003.BackColor = Color.White;
		_0006_2003_2003.Location = new Point(40, 85);
		_0006_2003_2003.Name = global::_000F_2000._0002(-380201711);
		_0006_2003_2003.Size = new Size(2, 2);
		_0006_2003_2003.TabIndex = 458;
		_000E_2003_2003.BackColor = Color.White;
		_000E_2003_2003.Location = new Point(111, 85);
		_000E_2003_2003.Name = global::_000F_2000._0002(-380201694);
		_000E_2003_2003.Size = new Size(2, 2);
		_000E_2003_2003.TabIndex = 457;
		_000F_2003_2003.BackColor = Color.White;
		_000F_2003_2003.Location = new Point(103, 85);
		_000F_2003_2003.Name = global::_000F_2000._0002(-380201677);
		_000F_2003_2003.Size = new Size(2, 2);
		_000F_2003_2003.TabIndex = 456;
		_0002_2004_2003.BackColor = Color.White;
		_0002_2004_2003.Location = new Point(94, 85);
		_0002_2004_2003.Name = global::_000F_2000._0002(-380201668);
		_0002_2004_2003.Size = new Size(2, 2);
		_0002_2004_2003.TabIndex = 455;
		_0003_2004_2003.BackColor = Color.White;
		_0003_2004_2003.Location = new Point(85, 85);
		_0003_2004_2003.Name = global::_000F_2000._0002(-380201651);
		_0003_2004_2003.Size = new Size(2, 2);
		_0003_2004_2003.TabIndex = 454;
		_0005_2004_2003.BackColor = Color.White;
		_0005_2004_2003.Location = new Point(76, 85);
		_0005_2004_2003.Name = global::_000F_2000._0002(-380201634);
		_0005_2004_2003.Size = new Size(2, 2);
		_0005_2004_2003.TabIndex = 453;
		_0008_2004_2003.BackColor = Color.White;
		_0008_2004_2003.Location = new Point(67, 85);
		_0008_2004_2003.Name = global::_000F_2000._0002(-380201617);
		_0008_2004_2003.Size = new Size(2, 2);
		_0008_2004_2003.TabIndex = 452;
		_0006_2004_2003.BackColor = Color.White;
		_0006_2004_2003.Location = new Point(120, 85);
		_0006_2004_2003.Name = global::_000F_2000._0002(-380201608);
		_0006_2004_2003.Size = new Size(2, 2);
		_0006_2004_2003.TabIndex = 451;
		_000E_2004_2003.BackColor = Color.White;
		_000E_2004_2003.Location = new Point(58, 85);
		_000E_2004_2003.Name = global::_000F_2000._0002(-380200311);
		_000E_2004_2003.Size = new Size(2, 2);
		_000E_2004_2003.TabIndex = 450;
		_000F_2004_2003.BackColor = Color.White;
		_000F_2004_2003.Location = new Point(32, 94);
		_000F_2004_2003.Name = global::_000F_2000._0002(-380200294);
		_000F_2004_2003.Size = new Size(2, 2);
		_000F_2004_2003.TabIndex = 469;
		_0002_2005_2003.BackColor = Color.White;
		_0002_2005_2003.Location = new Point(32, 113);
		_0002_2005_2003.Name = global::_000F_2000._0002(-380200277);
		_0002_2005_2003.Size = new Size(2, 2);
		_0002_2005_2003.TabIndex = 468;
		_0003_2005_2003.BackColor = Color.White;
		_0003_2005_2003.Location = new Point(32, 104);
		_0003_2005_2003.Name = global::_000F_2000._0002(-380200268);
		_0003_2005_2003.Size = new Size(2, 2);
		_0003_2005_2003.TabIndex = 467;
		_0005_2005_2003.BackColor = Color.White;
		_0005_2005_2003.Location = new Point(32, 122);
		_0005_2005_2003.Name = global::_000F_2000._0002(-380200251);
		_0005_2005_2003.Size = new Size(2, 2);
		_0005_2005_2003.TabIndex = 466;
		_0008_2005_2003.BackColor = Color.White;
		_0008_2005_2003.Location = new Point(32, 76);
		_0008_2005_2003.Name = global::_000F_2000._0002(-380200234);
		_0008_2005_2003.Size = new Size(2, 2);
		_0008_2005_2003.TabIndex = 465;
		_0006_2005_2003.BackColor = Color.White;
		_0006_2005_2003.Location = new Point(32, 67);
		_0006_2005_2003.Name = global::_000F_2000._0002(-380200217);
		_0006_2005_2003.Size = new Size(2, 2);
		_0006_2005_2003.TabIndex = 464;
		_000E_2005_2003.BackColor = Color.Black;
		_000E_2005_2003.Image = (Image)componentResourceManager.GetObject(global::_000F_2000._0002(-380200208));
		_000E_2005_2003.Location = new Point(28, 54);
		_000E_2005_2003.Name = global::_000F_2000._0002(-380200437);
		_000E_2005_2003.Size = new Size(10, 10);
		_000E_2005_2003.TabIndex = 463;
		_000F_2005_2003.BackColor = Color.White;
		_000F_2005_2003.Location = new Point(32, 85);
		_000F_2005_2003.Name = global::_000F_2000._0002(-380200428);
		_000F_2005_2003.Size = new Size(2, 2);
		_000F_2005_2003.TabIndex = 462;
		_0002_2006_2003.BackColor = Color.White;
		_0002_2006_2003.Location = new Point(32, 48);
		_0002_2006_2003.Name = global::_000F_2000._0002(-380200411);
		_0002_2006_2003.Size = new Size(2, 2);
		_0002_2006_2003.TabIndex = 461;
		_0003_2006_2003.BackColor = Color.White;
		_0003_2006_2003.Location = new Point(32, 38);
		_0003_2006_2003.Name = global::_000F_2000._0002(-380200394);
		_0003_2006_2003.Size = new Size(2, 2);
		_0003_2006_2003.TabIndex = 460;
		_0005_2006_2003.BackColor = Color.White;
		_0005_2006_2003.Location = new Point(85, 38);
		_0005_2006_2003.Name = global::_000F_2000._0002(-380200377);
		_0005_2006_2003.Size = new Size(2, 2);
		_0005_2006_2003.TabIndex = 475;
		_0008_2006_2003.BackColor = Color.White;
		_0008_2006_2003.Location = new Point(77, 38);
		_0008_2006_2003.Name = global::_000F_2000._0002(-380200368);
		_0008_2006_2003.Size = new Size(2, 2);
		_0008_2006_2003.TabIndex = 474;
		_0006_2006_2003.BackColor = Color.White;
		_0006_2006_2003.Location = new Point(68, 38);
		_0006_2006_2003.Name = global::_000F_2000._0002(-380200351);
		_0006_2006_2003.Size = new Size(2, 2);
		_0006_2006_2003.TabIndex = 473;
		_000E_2006_2003.BackColor = Color.White;
		_000E_2006_2003.Location = new Point(59, 38);
		_000E_2006_2003.Name = global::_000F_2000._0002(-380200334);
		_000E_2006_2003.Size = new Size(2, 2);
		_000E_2006_2003.TabIndex = 472;
		_000F_2006_2003.BackColor = Color.White;
		_000F_2006_2003.Location = new Point(50, 38);
		_000F_2006_2003.Name = global::_000F_2000._0002(-380200061);
		_000F_2006_2003.Size = new Size(2, 2);
		_000F_2006_2003.TabIndex = 471;
		_0002_2007_2003.BackColor = Color.White;
		_0002_2007_2003.Location = new Point(41, 38);
		_0002_2007_2003.Name = global::_000F_2000._0002(-380200052);
		_0002_2007_2003.Size = new Size(2, 2);
		_0002_2007_2003.TabIndex = 470;
		_0003_2007_2003.BackColor = Color.White;
		_0003_2007_2003.Location = new Point(85, 122);
		_0003_2007_2003.Name = global::_000F_2000._0002(-380200035);
		_0003_2007_2003.Size = new Size(2, 2);
		_0003_2007_2003.TabIndex = 482;
		_0005_2007_2003.BackColor = Color.White;
		_0005_2007_2003.Location = new Point(76, 122);
		_0005_2007_2003.Name = global::_000F_2000._0002(-380200018);
		_0005_2007_2003.Size = new Size(2, 2);
		_0005_2007_2003.TabIndex = 481;
		_0008_2007_2003.BackColor = Color.White;
		_0008_2007_2003.Location = new Point(67, 122);
		_0008_2007_2003.Name = global::_000F_2000._0002(-380200001);
		_0008_2007_2003.Size = new Size(2, 2);
		_0008_2007_2003.TabIndex = 480;
		_0006_2007_2003.BackColor = Color.White;
		_0006_2007_2003.Location = new Point(58, 122);
		_0006_2007_2003.Name = global::_000F_2000._0002(-380199992);
		_0006_2007_2003.Size = new Size(2, 2);
		_0006_2007_2003.TabIndex = 479;
		_000E_2007_2003.BackColor = Color.White;
		_000E_2007_2003.Location = new Point(49, 122);
		_000E_2007_2003.Name = global::_000F_2000._0002(-380199975);
		_000E_2007_2003.Size = new Size(2, 2);
		_000E_2007_2003.TabIndex = 478;
		_000F_2007_2003.BackColor = Color.White;
		_000F_2007_2003.Location = new Point(40, 122);
		_000F_2007_2003.Name = global::_000F_2000._0002(-380199958);
		_000F_2007_2003.Size = new Size(2, 2);
		_000F_2007_2003.TabIndex = 477;
		_0002_2008_2003.BackColor = Color.White;
		_0002_2008_2003.Location = new Point(94, 122);
		_0002_2008_2003.Name = global::_000F_2000._0002(-380199941);
		_0002_2008_2003.Size = new Size(2, 2);
		_0002_2008_2003.TabIndex = 476;
		_0003_2008_2003.BackColor = Color.White;
		_0003_2008_2003.Location = new Point(94, 103);
		_0003_2008_2003.Name = global::_000F_2000._0002(-380200188);
		_0003_2008_2003.Size = new Size(2, 2);
		_0003_2008_2003.TabIndex = 486;
		_0005_2008_2003.BackColor = Color.White;
		_0005_2008_2003.Location = new Point(94, 113);
		_0005_2008_2003.Name = global::_000F_2000._0002(-380200171);
		_0005_2008_2003.Size = new Size(2, 2);
		_0005_2008_2003.TabIndex = 485;
		_0008_2008_2003.BackColor = Color.White;
		_0008_2008_2003.Location = new Point(94, 94);
		_0008_2008_2003.Name = global::_000F_2000._0002(-380200154);
		_0008_2008_2003.Size = new Size(2, 2);
		_0008_2008_2003.TabIndex = 483;
		_0006_2008_2003.BackColor = Color.White;
		_0006_2008_2003.Location = new Point(94, 149);
		_0006_2008_2003.Name = global::_000F_2000._0002(-380200137);
		_0006_2008_2003.Size = new Size(2, 2);
		_0006_2008_2003.TabIndex = 501;
		_000E_2008_2003.BackColor = Color.White;
		_000E_2008_2003.Location = new Point(94, 167);
		_000E_2008_2003.Name = global::_000F_2000._0002(-380200128);
		_000E_2008_2003.Size = new Size(2, 2);
		_000E_2008_2003.TabIndex = 500;
		_000F_2008_2003.BackColor = Color.White;
		_000F_2008_2003.Location = new Point(94, 158);
		_000F_2008_2003.Name = global::_000F_2000._0002(-380200111);
		_000F_2008_2003.Size = new Size(2, 2);
		_000F_2008_2003.TabIndex = 499;
		_0002_2009_2003.BackColor = Color.White;
		_0002_2009_2003.Location = new Point(94, 176);
		_0002_2009_2003.Name = global::_000F_2000._0002(-380200094);
		_0002_2009_2003.Size = new Size(2, 2);
		_0002_2009_2003.TabIndex = 498;
		_0003_2009_2003.BackColor = Color.White;
		_0003_2009_2003.Location = new Point(94, 131);
		_0003_2009_2003.Name = global::_000F_2000._0002(-380200077);
		_0003_2009_2003.Size = new Size(2, 2);
		_0003_2009_2003.TabIndex = 497;
		_0005_2009_2003.BackColor = Color.White;
		_0005_2009_2003.Location = new Point(94, 140);
		_0005_2009_2003.Name = global::_000F_2000._0002(-380200068);
		_0005_2009_2003.Size = new Size(2, 2);
		_0005_2009_2003.TabIndex = 496;
		_0008_2009_2003.BackColor = Color.White;
		_0008_2009_2003.Location = new Point(94, 230);
		_0008_2009_2003.Name = global::_000F_2000._0002(-380200819);
		_0008_2009_2003.Size = new Size(2, 2);
		_0008_2009_2003.TabIndex = 495;
		_0006_2009_2003.BackColor = Color.White;
		_0006_2009_2003.Location = new Point(94, 248);
		_0006_2009_2003.Name = global::_000F_2000._0002(-380200802);
		_0006_2009_2003.Size = new Size(2, 2);
		_0006_2009_2003.TabIndex = 494;
		_000E_2009_2003.BackColor = Color.White;
		_000E_2009_2003.Location = new Point(94, 239);
		_000E_2009_2003.Name = global::_000F_2000._0002(-380200785);
		_000E_2009_2003.Size = new Size(2, 2);
		_000E_2009_2003.TabIndex = 493;
		_000F_2009_2003.BackColor = Color.White;
		_000F_2009_2003.Location = new Point(94, 257);
		_000F_2009_2003.Name = global::_000F_2000._0002(-380200776);
		_000F_2009_2003.Size = new Size(2, 2);
		_000F_2009_2003.TabIndex = 492;
		_0002_200A_2003.BackColor = Color.White;
		_0002_200A_2003.Location = new Point(94, 212);
		_0002_200A_2003.Name = global::_000F_2000._0002(-380200759);
		_0002_200A_2003.Size = new Size(2, 2);
		_0002_200A_2003.TabIndex = 491;
		_0003_200A_2003.BackColor = Color.White;
		_0003_200A_2003.Location = new Point(94, 203);
		_0003_200A_2003.Name = global::_000F_2000._0002(-380200742);
		_0003_200A_2003.Size = new Size(2, 2);
		_0003_200A_2003.TabIndex = 490;
		_0005_200A_2003.BackColor = Color.White;
		_0005_200A_2003.Location = new Point(94, 194);
		_0005_200A_2003.Name = global::_000F_2000._0002(-380200725);
		_0005_200A_2003.Size = new Size(2, 2);
		_0005_200A_2003.TabIndex = 489;
		_0008_200A_2003.BackColor = Color.White;
		_0008_200A_2003.Location = new Point(94, 221);
		_0008_200A_2003.Name = global::_000F_2000._0002(-380200716);
		_0008_200A_2003.Size = new Size(2, 2);
		_0008_200A_2003.TabIndex = 488;
		_0006_200A_2003.BackColor = Color.White;
		_0006_200A_2003.Location = new Point(94, 185);
		_0006_200A_2003.Name = global::_000F_2000._0002(-380200955);
		_0006_200A_2003.Size = new Size(2, 2);
		_0006_200A_2003.TabIndex = 487;
		_000E_200A_2003.Interval = 700;
		_000E_200A_2003.Tick += _0008_2001;
		_000F_200A_2003.Controls.Add(_000F_2000_2004);
		_000F_200A_2003.Controls.Add(_0002_2001_2004);
		_000F_200A_2003.Controls.Add(_0003_2001_2004);
		_000F_200A_2003.Controls.Add(_0005_2001_2004);
		_000F_200A_2003.Controls.Add(_000E_2000_2004);
		_000F_200A_2003.Controls.Add(_0006_2000_2004);
		_000F_200A_2003.Controls.Add(_0003_200B_2003);
		_000F_200A_2003.Controls.Add(_0002_200B_2003);
		_000F_200A_2003.Dock = DockStyle.Fill;
		_000F_200A_2003.Location = new Point(0, 0);
		_000F_200A_2003.Name = global::_000F_2000._0002(-380200938);
		_000F_200A_2003.Size = new Size(370, 430);
		_000F_200A_2003.TabIndex = 502;
		_000F_200A_2003.Paint += _0002;
		_000E_2000_2004.Image = global::_000E_2000._0005_2000();
		_000E_2000_2004.Location = new Point(12, 226);
		_000E_2000_2004.Name = global::_000F_2000._0002(-380200927);
		_000E_2000_2004.Size = new Size(348, 171);
		_000E_2000_2004.SizeMode = PictureBoxSizeMode.StretchImage;
		_000E_2000_2004.TabIndex = 7;
		_000E_2000_2004.TabStop = false;
		_000E_2000_2004.Click += _0003;
		_0006_2000_2004.Image = global::_000E_2000._0006_2000();
		_0006_2000_2004.Location = new Point(163, 158);
		_0006_2000_2004.Name = global::_000F_2000._0002(-380200905);
		_0006_2000_2004.Size = new Size(50, 50);
		_0006_2000_2004.SizeMode = PictureBoxSizeMode.StretchImage;
		_0006_2000_2004.TabIndex = 2;
		_0006_2000_2004.TabStop = false;
		_0006_2000_2004.Click += _000E;
		_0003_200B_2003.Image = global::_000E_2000._0006_2003();
		_0003_200B_2003.Location = new Point(12, 18);
		_0003_200B_2003.Name = global::_000F_2000._0002(-380200891);
		_0003_200B_2003.Size = new Size(348, 101);
		_0003_200B_2003.SizeMode = PictureBoxSizeMode.StretchImage;
		_0003_200B_2003.TabIndex = 1;
		_0003_200B_2003.TabStop = false;
		_0003_200B_2003.Visible = false;
		_0002_200B_2003.Cursor = Cursors.Hand;
		_0002_200B_2003.FlatAppearance.BorderColor = Color.Black;
		_0002_200B_2003.FlatAppearance.BorderSize = 0;
		_0002_200B_2003.FlatAppearance.MouseDownBackColor = Color.Black;
		_0002_200B_2003.FlatAppearance.MouseOverBackColor = Color.Black;
		_0002_200B_2003.FlatStyle = FlatStyle.Flat;
		_0002_200B_2003.Image = global::_000E_2000._0005_2004();
		_0002_200B_2003.Location = new Point(123, 124);
		_0002_200B_2003.Name = global::_000F_2000._0002(-380200869);
		_0002_200B_2003.Size = new Size(136, 36);
		_0002_200B_2003.TabIndex = 0;
		_0002_200B_2003.UseVisualStyleBackColor = true;
		_0002_200B_2003.Visible = false;
		_0002_200B_2003.Click += _0002_2000;
		_0002_200B_2003.MouseEnter += _0005_2000;
		_0002_200B_2003.MouseLeave += _0003_2000;
		_0005_200B_2003.BackgroundImageLayout = ImageLayout.None;
		_0005_200B_2003.Cursor = Cursors.Default;
		_0005_200B_2003.Image = global::_000E_2000._0008_2003();
		_0005_200B_2003.Location = new Point(24, 364);
		_0005_200B_2003.Name = global::_000F_2000._0002(-380200859);
		_0005_200B_2003.Size = new Size(22, 22);
		_0005_200B_2003.TabIndex = 503;
		_0005_200B_2003.TabStop = false;
		_0008_200B_2003.Interval = 10000;
		_0008_200B_2003.Tick += _0005_2001;
		_0006_200B_2003.Interval = 2500;
		_0006_200B_2003.Tick += _000E_2001;
		_000E_200B_2003.Enabled = true;
		_000E_200B_2003.Interval = 200;
		_000E_200B_2003.Tick += _0006_2001;
		_000F_200B_2003.Interval = 500;
		_000F_200B_2003.Tick += _0003_2002;
		_0002_2000_2004.BackColor = Color.Black;
		_0002_2000_2004.Font = new Font(global::_000F_2000._0002(-380206080), 10f, FontStyle.Bold, GraphicsUnit.Point, 0);
		_0002_2000_2004.ForeColor = Color.White;
		_0002_2000_2004.Image = global::_000E_2000._000E_2000();
		_0002_2000_2004.Location = new Point(123, 222);
		_0002_2000_2004.Name = global::_000F_2000._0002(-380200848);
		_0002_2000_2004.Size = new Size(125, 19);
		_0002_2000_2004.TabIndex = 504;
		_0002_2000_2004.Text = global::_000F_2000._0002(-380206020);
		_0002_2000_2004.TextAlign = ContentAlignment.MiddleRight;
		_0002_2000_2004.Visible = false;
		_0003_2000_2004.BackColor = Color.Black;
		_0003_2000_2004.Font = new Font(global::_000F_2000._0002(-380206080), 10f, FontStyle.Bold, GraphicsUnit.Point, 0);
		_0003_2000_2004.ForeColor = Color.White;
		_0003_2000_2004.Image = global::_000E_2000._0002_2001();
		_0003_2000_2004.Location = new Point(125, 222);
		_0003_2000_2004.Name = global::_000F_2000._0002(-380200575);
		_0003_2000_2004.Size = new Size(125, 19);
		_0003_2000_2004.TabIndex = 505;
		_0003_2000_2004.Text = global::_000F_2000._0002(-380206020);
		_0003_2000_2004.TextAlign = ContentAlignment.MiddleRight;
		_0003_2000_2004.Visible = false;
		_0005_2000_2004.Interval = 7000;
		_0005_2000_2004.Tick += _0002_2002;
		_0008_2000_2004.Interval = 400;
		_0008_2000_2004.Tick += _000F_2001;
		_000F_2000_2004.AutoSize = true;
		_000F_2000_2004.Font = new Font(global::_000F_2000._0002(-380200558), 12.25f, FontStyle.Bold);
		_000F_2000_2004.ForeColor = Color.White;
		_000F_2000_2004.Location = new Point(128, 354);
		_000F_2000_2004.Name = global::_000F_2000._0002(-380200543);
		_000F_2000_2004.Size = new Size(122, 20);
		_000F_2000_2004.TabIndex = 11;
		_000F_2000_2004.Text = global::_000F_2000._0002(-380200526);
		_000F_2000_2004.Click += _0002;
		_0002_2001_2004.AutoSize = true;
		_0002_2001_2004.Font = new Font(global::_000F_2000._0002(-380200558), 13.25f, FontStyle.Bold);
		_0002_2001_2004.ForeColor = Color.White;
		_0002_2001_2004.Location = new Point(97, 331);
		_0002_2001_2004.Name = global::_000F_2000._0002(-380200506);
		_0002_2001_2004.Size = new Size(197, 21);
		_0002_2001_2004.TabIndex = 10;
		_0002_2001_2004.Text = global::_000F_2000._0002(-380200489);
		_0003_2001_2004.AutoSize = true;
		_0003_2001_2004.Font = new Font(global::_000F_2000._0002(-380200558), 12.25f, FontStyle.Bold);
		_0003_2001_2004.ForeColor = Color.White;
		_0003_2001_2004.Location = new Point(126, 277);
		_0003_2001_2004.Name = global::_000F_2000._0002(-380200467);
		_0003_2001_2004.Size = new Size(122, 20);
		_0003_2001_2004.TabIndex = 9;
		_0003_2001_2004.Text = global::_000F_2000._0002(-380200450);
		_0005_2001_2004.AutoSize = true;
		_0005_2001_2004.BackColor = Color.Transparent;
		_0005_2001_2004.Font = new Font(global::_000F_2000._0002(-380200558), 12.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		_0005_2001_2004.ForeColor = SystemColors.Window;
		_0005_2001_2004.Location = new Point(53, 255);
		_0005_2001_2004.Name = global::_000F_2000._0002(-380200686);
		_0005_2001_2004.Size = new Size(266, 20);
		_0005_2001_2004.TabIndex = 8;
		_0005_2001_2004.Text = global::_000F_2000._0002(-380200669);
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.Black;
		BackgroundImage = global::_000E_2000._0003_2004();
		BackgroundImageLayout = ImageLayout.None;
		base.ClientSize = new Size(370, 430);
		base.Controls.Add(_000F_200A_2003);
		base.Controls.Add(_0006_2008);
		base.Controls.Add(_0008_2008);
		base.Controls.Add(_0005_2008);
		base.Controls.Add(_0003_2008);
		base.Controls.Add(_0003_2000_2004);
		base.Controls.Add(_0002_2000_2004);
		base.Controls.Add(_0005_200B_2003);
		base.Controls.Add(_0005_2009);
		base.Controls.Add(_0006_2008_2003);
		base.Controls.Add(_000E_2008_2003);
		base.Controls.Add(_000F_2008_2003);
		base.Controls.Add(_0002_2009_2003);
		base.Controls.Add(_0003_2009_2003);
		base.Controls.Add(_0005_2009_2003);
		base.Controls.Add(_0008_2009_2003);
		base.Controls.Add(_0006_2009_2003);
		base.Controls.Add(_000E_2009_2003);
		base.Controls.Add(_000F_2009_2003);
		base.Controls.Add(_0002_200A_2003);
		base.Controls.Add(_0003_200A_2003);
		base.Controls.Add(_0005_200A_2003);
		base.Controls.Add(_0008_200A_2003);
		base.Controls.Add(_0006_200A_2003);
		base.Controls.Add(_0003_2008_2003);
		base.Controls.Add(_0005_2008_2003);
		base.Controls.Add(_0008_2008_2003);
		base.Controls.Add(_0003_2007_2003);
		base.Controls.Add(_0005_2007_2003);
		base.Controls.Add(_0008_2007_2003);
		base.Controls.Add(_0006_2007_2003);
		base.Controls.Add(_000E_2007_2003);
		base.Controls.Add(_000F_2007_2003);
		base.Controls.Add(_0002_2008_2003);
		base.Controls.Add(_0005_2006_2003);
		base.Controls.Add(_0008_2006_2003);
		base.Controls.Add(_0006_2006_2003);
		base.Controls.Add(_000E_2006_2003);
		base.Controls.Add(_000F_2006_2003);
		base.Controls.Add(_0002_2007_2003);
		base.Controls.Add(_000F_2004_2003);
		base.Controls.Add(_0002_2005_2003);
		base.Controls.Add(_0003_2005_2003);
		base.Controls.Add(_0005_2005_2003);
		base.Controls.Add(_0008_2005_2003);
		base.Controls.Add(_0006_2005_2003);
		base.Controls.Add(_000E_2005_2003);
		base.Controls.Add(_000F_2005_2003);
		base.Controls.Add(_0002_2006_2003);
		base.Controls.Add(_0003_2006_2003);
		base.Controls.Add(_0008_2003_2003);
		base.Controls.Add(_0006_2003_2003);
		base.Controls.Add(_000E_2003_2003);
		base.Controls.Add(_000F_2003_2003);
		base.Controls.Add(_0002_2004_2003);
		base.Controls.Add(_0003_2004_2003);
		base.Controls.Add(_0005_2004_2003);
		base.Controls.Add(_0008_2004_2003);
		base.Controls.Add(_0006_2004_2003);
		base.Controls.Add(_000E_2004_2003);
		base.Controls.Add(_0002_2001_2003);
		base.Controls.Add(_0003_2001_2003);
		base.Controls.Add(_0005_2001_2003);
		base.Controls.Add(_0008_2001_2003);
		base.Controls.Add(_0006_2001_2003);
		base.Controls.Add(_000E_2001_2003);
		base.Controls.Add(_000F_2001_2003);
		base.Controls.Add(_0002_2002_2003);
		base.Controls.Add(_0003_2002_2003);
		base.Controls.Add(_0005_2002_2003);
		base.Controls.Add(_0008_2002_2003);
		base.Controls.Add(_0006_2002_2003);
		base.Controls.Add(_000E_2002_2003);
		base.Controls.Add(_000F_2002_2003);
		base.Controls.Add(_0002_2003_2003);
		base.Controls.Add(_0003_2003_2003);
		base.Controls.Add(_0005_2003_2003);
		base.Controls.Add(_000F_200B_2002);
		base.Controls.Add(_0002_2000_2003);
		base.Controls.Add(_0003_2000_2003);
		base.Controls.Add(_0005_2000_2003);
		base.Controls.Add(_0008_2000_2003);
		base.Controls.Add(_0006_2000_2003);
		base.Controls.Add(_000E_2000_2003);
		base.Controls.Add(_000F_2000_2003);
		base.Controls.Add(_0006_2009_2002);
		base.Controls.Add(_000E_2009_2002);
		base.Controls.Add(_000F_2009_2002);
		base.Controls.Add(_0002_200A_2002);
		base.Controls.Add(_0003_200A_2002);
		base.Controls.Add(_0005_200A_2002);
		base.Controls.Add(_0008_200A_2002);
		base.Controls.Add(_0006_200A_2002);
		base.Controls.Add(_000E_200A_2002);
		base.Controls.Add(_000F_200A_2002);
		base.Controls.Add(_0002_200B_2002);
		base.Controls.Add(_0003_200B_2002);
		base.Controls.Add(_0005_200B_2002);
		base.Controls.Add(_0008_200B_2002);
		base.Controls.Add(_0006_200B_2002);
		base.Controls.Add(_000E_200B_2002);
		base.Controls.Add(_0002_2009_2002);
		base.Controls.Add(_0003_2009_2002);
		base.Controls.Add(_0005_2009_2002);
		base.Controls.Add(_0008_2009_2002);
		base.Controls.Add(_000F_2007_2002);
		base.Controls.Add(_0002_2008_2002);
		base.Controls.Add(_0003_2008_2002);
		base.Controls.Add(_0005_2008_2002);
		base.Controls.Add(_0008_2008_2002);
		base.Controls.Add(_0006_2008_2002);
		base.Controls.Add(_000E_2008_2002);
		base.Controls.Add(_000F_2008_2002);
		base.Controls.Add(_0002_2007_2002);
		base.Controls.Add(_0003_2007_2002);
		base.Controls.Add(_0005_2007_2002);
		base.Controls.Add(_0008_2007_2002);
		base.Controls.Add(_0006_2007_2002);
		base.Controls.Add(_000E_2007_2002);
		base.Controls.Add(_0003_2006_2002);
		base.Controls.Add(_0005_2006_2002);
		base.Controls.Add(_0008_2006_2002);
		base.Controls.Add(_0006_2006_2002);
		base.Controls.Add(_000E_2006_2002);
		base.Controls.Add(_000F_2006_2002);
		base.Controls.Add(_000F_2004_2002);
		base.Controls.Add(_0002_2005_2002);
		base.Controls.Add(_0003_2005_2002);
		base.Controls.Add(_0005_2005_2002);
		base.Controls.Add(_0008_2005_2002);
		base.Controls.Add(_0006_2005_2002);
		base.Controls.Add(_000E_2005_2002);
		base.Controls.Add(_000F_2005_2002);
		base.Controls.Add(_0002_2006_2002);
		base.Controls.Add(_0006_2002_2002);
		base.Controls.Add(_000E_2002_2002);
		base.Controls.Add(_000F_2002_2002);
		base.Controls.Add(_0002_2003_2002);
		base.Controls.Add(_0003_2003_2002);
		base.Controls.Add(_0005_2003_2002);
		base.Controls.Add(_0008_2003_2002);
		base.Controls.Add(_0006_2003_2002);
		base.Controls.Add(_000E_2003_2002);
		base.Controls.Add(_000F_2003_2002);
		base.Controls.Add(_0002_2004_2002);
		base.Controls.Add(_0003_2004_2002);
		base.Controls.Add(_0005_2004_2002);
		base.Controls.Add(_0008_2004_2002);
		base.Controls.Add(_0006_2004_2002);
		base.Controls.Add(_000E_2004_2002);
		base.Controls.Add(_000E_2001_2002);
		base.Controls.Add(_000F_2001_2002);
		base.Controls.Add(_0002_2002_2002);
		base.Controls.Add(_0003_2002_2002);
		base.Controls.Add(_0005_2002_2002);
		base.Controls.Add(_0008_2002_2002);
		base.Controls.Add(_0008_2000_2002);
		base.Controls.Add(_0006_2000_2002);
		base.Controls.Add(_000E_2000_2002);
		base.Controls.Add(_000F_2000_2002);
		base.Controls.Add(_0002_2001_2002);
		base.Controls.Add(_0003_2001_2002);
		base.Controls.Add(_0005_2001_2002);
		base.Controls.Add(_0008_2001_2002);
		base.Controls.Add(_0006_2001_2002);
		base.Controls.Add(_0003_200B_2001);
		base.Controls.Add(_0005_200B_2001);
		base.Controls.Add(_0008_200B_2001);
		base.Controls.Add(_0006_200B_2001);
		base.Controls.Add(_000E_200B_2001);
		base.Controls.Add(_000F_200B_2001);
		base.Controls.Add(_0002_2000_2002);
		base.Controls.Add(_0003_2000_2002);
		base.Controls.Add(_0005_2000_2002);
		base.Controls.Add(_0006_200A_2001);
		base.Controls.Add(_000E_200A_2001);
		base.Controls.Add(_000F_200A_2001);
		base.Controls.Add(_0002_200B_2001);
		base.Controls.Add(_0008_200A_2001);
		base.Controls.Add(_0002_200A_2001);
		base.Controls.Add(_0003_200A_2001);
		base.Controls.Add(_0005_200A_2001);
		base.Controls.Add(_0006_2009_2001);
		base.Controls.Add(_000E_2009_2001);
		base.Controls.Add(_000F_2009_2001);
		base.Controls.Add(_000E_2003_2001);
		base.Controls.Add(_000F_2003_2001);
		base.Controls.Add(_0002_2004_2001);
		base.Controls.Add(_0003_2004_2001);
		base.Controls.Add(_0005_2004_2001);
		base.Controls.Add(_0008_2004_2001);
		base.Controls.Add(_0006_2004_2001);
		base.Controls.Add(_000E_2004_2001);
		base.Controls.Add(_000F_2004_2001);
		base.Controls.Add(_0002_2005_2001);
		base.Controls.Add(_0003_2005_2001);
		base.Controls.Add(_0005_2005_2001);
		base.Controls.Add(_0008_2005_2001);
		base.Controls.Add(_0006_2005_2001);
		base.Controls.Add(_000E_2005_2001);
		base.Controls.Add(_000F_2005_2001);
		base.Controls.Add(_0002_2006_2001);
		base.Controls.Add(_0003_2006_2001);
		base.Controls.Add(_0005_2006_2001);
		base.Controls.Add(_0008_2006_2001);
		base.Controls.Add(_0006_2006_2001);
		base.Controls.Add(_000E_2006_2001);
		base.Controls.Add(_000F_2006_2001);
		base.Controls.Add(_0002_2007_2001);
		base.Controls.Add(_0003_2007_2001);
		base.Controls.Add(_0005_2007_2001);
		base.Controls.Add(_0008_2007_2001);
		base.Controls.Add(_0006_2007_2001);
		base.Controls.Add(_000E_2007_2001);
		base.Controls.Add(_000F_2007_2001);
		base.Controls.Add(_0002_2008_2001);
		base.Controls.Add(_0003_2008_2001);
		base.Controls.Add(_0005_2008_2001);
		base.Controls.Add(_0008_2008_2001);
		base.Controls.Add(_0006_2008_2001);
		base.Controls.Add(_000E_2008_2001);
		base.Controls.Add(_000F_2008_2001);
		base.Controls.Add(_0002_2009_2001);
		base.Controls.Add(_0003_2009_2001);
		base.Controls.Add(_0005_2009_2001);
		base.Controls.Add(_0008_2009_2001);
		base.Controls.Add(_000E_2001_2001);
		base.Controls.Add(_000F_2001_2001);
		base.Controls.Add(_0002_2002_2001);
		base.Controls.Add(_0003_2002_2001);
		base.Controls.Add(_0005_2002_2001);
		base.Controls.Add(_0008_2002_2001);
		base.Controls.Add(_0006_2002_2001);
		base.Controls.Add(_000E_2002_2001);
		base.Controls.Add(_000F_2002_2001);
		base.Controls.Add(_0002_2003_2001);
		base.Controls.Add(_0003_2003_2001);
		base.Controls.Add(_0005_2003_2001);
		base.Controls.Add(_0008_2003_2001);
		base.Controls.Add(_0006_2003_2001);
		base.Controls.Add(_0008_2001_2001);
		base.Controls.Add(_0006_2001_2001);
		base.Controls.Add(_000E_2000_2001);
		base.Controls.Add(_000F_2000_2001);
		base.Controls.Add(_0002_2001_2001);
		base.Controls.Add(_0003_2001_2001);
		base.Controls.Add(_0005_2001_2001);
		base.Controls.Add(_0003_2000_2001);
		base.Controls.Add(_0005_2000_2001);
		base.Controls.Add(_0008_2000_2001);
		base.Controls.Add(_0006_2000_2001);
		base.Controls.Add(_0006_200B_2000);
		base.Controls.Add(_000E_200B_2000);
		base.Controls.Add(_000F_200B_2000);
		base.Controls.Add(_0002_2000_2001);
		base.Controls.Add(_0002_200B_2000);
		base.Controls.Add(_0003_200B_2000);
		base.Controls.Add(_0005_200B_2000);
		base.Controls.Add(_0008_200B_2000);
		base.Controls.Add(_0006_200A_2000);
		base.Controls.Add(_000E_200A_2000);
		base.Controls.Add(_000F_200A_2000);
		base.Controls.Add(_0002_200A_2000);
		base.Controls.Add(_0003_200A_2000);
		base.Controls.Add(_0005_200A_2000);
		base.Controls.Add(_0008_200A_2000);
		base.Controls.Add(_0008_2009_2000);
		base.Controls.Add(_0006_2009_2000);
		base.Controls.Add(_000E_2009_2000);
		base.Controls.Add(_000F_2009_2000);
		base.Controls.Add(_000F_2008_2000);
		base.Controls.Add(_0002_2009_2000);
		base.Controls.Add(_0003_2009_2000);
		base.Controls.Add(_0005_2009_2000);
		base.Controls.Add(_000E_2008_2000);
		base.Controls.Add(_0005_2008_2000);
		base.Controls.Add(_0008_2008_2000);
		base.Controls.Add(_0006_2008_2000);
		base.Controls.Add(_0003_2008_2000);
		base.Controls.Add(_000F_2007_2000);
		base.Controls.Add(_0002_2008_2000);
		base.Controls.Add(_0008_2007_2000);
		base.Controls.Add(_0006_2007_2000);
		base.Controls.Add(_000E_2007_2000);
		base.Controls.Add(_0002_2007_2000);
		base.Controls.Add(_0003_2007_2000);
		base.Controls.Add(_0005_2007_2000);
		base.Controls.Add(_000E_2004_2000);
		base.Controls.Add(_000F_2004_2000);
		base.Controls.Add(_0002_2006_2000);
		base.Controls.Add(_0003_2006_2000);
		base.Controls.Add(_0005_2006_2000);
		base.Controls.Add(_0008_2006_2000);
		base.Controls.Add(_0006_2006_2000);
		base.Controls.Add(_000E_2006_2000);
		base.Controls.Add(_000F_2006_2000);
		base.Controls.Add(_0008_2003_2000);
		base.Controls.Add(_0006_2003_2000);
		base.Controls.Add(_000E_2003_2000);
		base.Controls.Add(_000F_2003_2000);
		base.Controls.Add(_0002_2004_2000);
		base.Controls.Add(_0003_2004_2000);
		base.Controls.Add(_0005_2004_2000);
		base.Controls.Add(_0008_2004_2000);
		base.Controls.Add(_0006_2004_2000);
		base.Controls.Add(_0005_2003_2000);
		base.Controls.Add(_0003_2003_2000);
		base.Controls.Add(_000E_2002_2000);
		base.Controls.Add(_000F_2002_2000);
		base.Controls.Add(_0002_2003_2000);
		base.Controls.Add(_0008_2002_2000);
		base.Controls.Add(_0005_2002_2000);
		base.Controls.Add(_0006_2002_2000);
		base.Controls.Add(_0003_2000_2000);
		base.Controls.Add(_0005_2000_2000);
		base.Controls.Add(_0008_2000_2000);
		base.Controls.Add(_0006_2000_2000);
		base.Controls.Add(_000E_2000_2000);
		base.Controls.Add(_000F_2000_2000);
		base.Controls.Add(_0002_2001_2000);
		base.Controls.Add(_0003_2001_2000);
		base.Controls.Add(_0005_2001_2000);
		base.Controls.Add(_0008_2001_2000);
		base.Controls.Add(_0006_2001_2000);
		base.Controls.Add(_000E_2001_2000);
		base.Controls.Add(_000F_2001_2000);
		base.Controls.Add(_0002_2002_2000);
		base.Controls.Add(_0005_200B);
		base.Controls.Add(_0008_200B);
		base.Controls.Add(_0006_200B);
		base.Controls.Add(_000E_200B);
		base.Controls.Add(_000F_200B);
		base.Controls.Add(_0002_2000_2000);
		base.Controls.Add(_000E_200A);
		base.Controls.Add(_000F_200A);
		base.Controls.Add(_0002_200B);
		base.Controls.Add(_0003_200B);
		base.Controls.Add(_0008_200A);
		base.Controls.Add(_0006_200A);
		base.Controls.Add(_0005_200A);
		base.Controls.Add(_0003_200A);
		base.Controls.Add(_0003_2002_2000);
		base.Controls.Add(_0003_2009);
		base.Controls.Add(_0002_2009);
		base.Controls.Add(_000F_2008);
		base.Controls.Add(_000E_2008);
		Cursor = Cursors.Default;
		DoubleBuffered = true;
		Font = new Font(global::_000F_2000._0002(-380200637), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ForeColor = Color.Black;
		base.Icon = (Icon)componentResourceManager.GetObject(global::_000F_2000._0002(-380200616));
		base.KeyPreview = true;
		base.MaximizeBox = false;
		MaximumSize = new Size(386, 469);
		base.MinimizeBox = false;
		MinimumSize = new Size(386, 469);
		base.Name = global::_000F_2000._0002(-380200593);
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = global::_000F_2000._0002(-380200581);
		base.TransparencyKey = Color.Fuchsia;
		base.KeyDown += _0002;
		((ISupportInitialize)_0003_2009).EndInit();
		((ISupportInitialize)_0002_2009).EndInit();
		_000F_200A_2003.ResumeLayout(performLayout: false);
		_000F_200A_2003.PerformLayout();
		((ISupportInitialize)_000E_2000_2004).EndInit();
		((ISupportInitialize)_0006_2000_2004).EndInit();
		((ISupportInitialize)_0003_200B_2003).EndInit();
		((ISupportInitialize)_0005_200B_2003).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
internal interface _000E<_0002> : _0006
{
	global::_0003_2000<_0002> GetEnumerator();
}
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
internal sealed class _000E_2000
{
	private static ResourceManager m__0002;

	private static CultureInfo m__0003;

	internal _000E_2000()
	{
	}

	internal static ResourceManager _0002()
	{
		if (global::_000E_2000.m__0002 == null)
		{
			ResourceManager resourceManager = global::_000E_2000.m__0002 = new ResourceManager(global::_000F_2000._0002(-380199291), typeof(_000E_2000).Assembly);
		}
		return global::_000E_2000.m__0002;
	}

	internal static CultureInfo _0002()
	{
		return global::_000E_2000.m__0003;
	}

	internal static void _0002(CultureInfo _0002)
	{
		global::_000E_2000.m__0003 = _0002;
	}

	internal static Bitmap _0002()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380199278), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _0003()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380199267), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _0005()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380199254), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _0008()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380199241), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _0006()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380199236), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _000E()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380199224), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _000F()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380199210), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _0002_2000()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380199204), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _0003_2000()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380199190), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _0005_2000()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380199177), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _0008_2000()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380199423), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _0006_2000()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380199411), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _000E_2000()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380199398), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _000F_2000()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380199381), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _0002_2001()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380199371), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _0003_2001()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380199354), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _0005_2001()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380199342), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _0008_2001()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380199336), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _0006_2001()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380199319), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _000E_2001()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380199305), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _000F_2001()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380199299), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _0002_2002()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380199031), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _0003_2002()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380199018), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _0005_2002()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380199006), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _0008_2002()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380198995), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _0006_2002()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380198984), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _000E_2002()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380198972), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _000F_2002()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380198958), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _0002_2003()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380198952), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _0003_2003()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380198938), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _0005_2003()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380198925), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _0008_2003()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380198915), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _0006_2003()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380199159), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _000E_2003()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380199143), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _000F_2003()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380199126), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _0002_2004()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380199114), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _0003_2004()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380199102), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _0005_2004()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380199085), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _0008_2004()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380199076), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _0006_2004()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380199060), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _000E_2004()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380199048), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _000F_2004()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380199802), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _0002_2005()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380199789), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _0003_2005()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380199783), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _0005_2005()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380204503), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _0008_2005()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380199769), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _0006_2005()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380199757), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _000E_2005()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380199745), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _000F_2005()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380199739), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _0002_2006()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380199726), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}

	internal static Bitmap _0003_2006()
	{
		object @object = global::_000E_2000._0002().GetObject(global::_000F_2000._0002(-380199720), global::_000E_2000.m__0003);
		return (Bitmap)@object;
	}
}
internal interface _000F
{
	bool _000F_2005_2000_0002();

	object _000F_2005_2000_0002();

	void _000F_2005_2000_0002();
}
internal static class _000F_2000
{
	private enum _0002
	{

	}

	private sealed class _0003
	{
		private Stream m__0002;

		private byte[] m__0003;

		public _0003(Stream _0002)
		{
			this.m__0002 = _0002;
			this.m__0003 = new byte[4];
		}

		public Stream _0002()
		{
			return this.m__0002;
		}

		public short _0002()
		{
			this._0002(2);
			return (short)(this.m__0003[0] | (this.m__0003[1] << 8));
		}

		public int _0002()
		{
			this._0002(4);
			return this.m__0003[0] | (this.m__0003[1] << 8) | (this.m__0003[2] << 16) | (this.m__0003[3] << 24);
		}

		private void _0002()
		{
			throw new EndOfStreamException();
		}

		private void _0002(int _0002)
		{
			int num = 0;
			int num2 = 0;
			if (_0002 == 1)
			{
				num2 = this.m__0002.ReadByte();
				if (num2 == -1)
				{
					this._0002();
				}
				this.m__0003[0] = (byte)num2;
				return;
			}
			do
			{
				num2 = this.m__0002.Read(this.m__0003, num, _0002 - num);
				if (num2 == 0)
				{
					this._0002();
				}
				num += num2;
			}
			while (num < _0002);
		}

		public void _0003()
		{
			Stream stream = this.m__0002;
			this.m__0002 = null;
			stream?.Close();
			this.m__0003 = null;
		}

		public byte[] _0002(int _0002)
		{
			if (_0002 < 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			byte[] array = new byte[_0002];
			int num = 0;
			do
			{
				int num2 = this.m__0002.Read(array, num, _0002);
				if (num2 == 0)
				{
					break;
				}
				num += num2;
				_0002 -= num2;
			}
			while (_0002 > 0);
			if (num != array.Length)
			{
				byte[] array2 = new byte[num];
				Buffer.BlockCopy(array, 0, array2, 0, num);
				array = array2;
			}
			return array;
		}
	}

	private static _0003 m__0003;

	private static byte[] _0005;

	private static int _000F;

	private static short _0008;

	private static _0002 _0003_2000;

	private static int _0002_2000;

	private static int _0006;

	private static byte[] _000E;

	private static Dictionary<int, string> m__0002;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static _000F_2000()
	{
		int num = -297420002;
		int num2 = num ^ -905966255;
		_000F_2000.m__0002 = new Dictionary<int, string>((311128851 - num) ^ num2);
		int num3 = 2;
		StackTrace stackTrace = new StackTrace(num3, fNeedFileInfo: false);
		num3 -= 2;
		StackFrame frame = stackTrace.GetFrame(num3);
		int index = num3;
		if (frame == null)
		{
			stackTrace = new StackTrace();
			index = 1;
			frame = stackTrace.GetFrame(index);
		}
		int num4 = ~(-(-(~(~(-(~(-(~(-(~(-613784086 + num - num2))))))))))) ^ -(~(-(~(-(~(~(-(~((-1220161680 - num) ^ num2)))))))));
		MethodBase methodBase = frame?.GetMethod();
		if (frame != null)
		{
			num4 ^= -(~(~(-(-(~(-(~(-(~(~((-3273393 ^ num) - num2)))))))))));
		}
		Type type = methodBase?.DeclaringType;
		if ((object)type == typeof(RuntimeMethodHandle))
		{
			_0003_2000 = ((_0002)4 | _0003_2000);
			num4 ^= ((311128198 - num) ^ num2) + num3;
		}
		else if ((object)type == null)
		{
			if (_0002(stackTrace, index))
			{
				_0003_2000 = ((_0002)16 | _0003_2000);
				num4 ^= -(~(~(-(-(~(-(~(~(num + -311152464 + num2))))))))) - num3;
			}
			else
			{
				num4 ^= -(~(~(-(-(~(-(~(~(0x35FF621A ^ num ^ num2)))))))));
				_0003_2000 |= (_0002)1;
			}
		}
		else
		{
			_0003_2000 = ((_0002)16 | _0003_2000);
			num4 ^= -(~(~(-(-(~(~(-(-(~(~(num + -311152465 + num2))))))))))) - num3;
		}
		_0002_2000 += num4;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static string _0002(int _0002)
	{
		lock (_000F_2000.m__0002)
		{
			if (_000F_2000.m__0002.TryGetValue(_0002, out string value))
			{
				return value;
			}
			return _000F_2000._0002(_0002, _0003: true);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string _0002(int _0002, bool _0003)
	{
		int num = 710889651;
		int num2 = -199636051 - num;
		string value = null;
		byte[] array;
		int num19;
		while (true)
		{
			int num6;
			if (_000F_2000.m__0003 == null)
			{
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				Assembly callingAssembly = Assembly.GetCallingAssembly();
				_0006 |= (-477340209 ^ num) - num2;
				StringBuilder stringBuilder = new StringBuilder();
				int num3 = num + 737104987 + num2;
				stringBuilder.Append((char)(num3 >> 16)).Append((char)num3);
				num3 = ((336571310 - num) ^ num2);
				stringBuilder.Append((char)(num3 >> 16)).Append((char)num3);
				num3 = (num ^ -1008612432) - num2;
				stringBuilder.Append((char)(num3 >> 16)).Append((char)num3);
				num3 = num + 737170524 + num2;
				stringBuilder.Append((char)(num3 >> 16)).Append((char)num3);
				num3 = (-1008399797 ^ num ^ num2);
				stringBuilder.Append((char)num3).Append((char)(num3 >> 16));
				num3 = 737236062 + num + num2;
				stringBuilder.Append((char)(num3 >> 16)).Append((char)num3);
				num3 = (num ^ -471479736) - num2;
				stringBuilder.Append((char)num3);
				Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(stringBuilder.ToString());
				int num4 = 2;
				StackTrace stackTrace = new StackTrace(num4, fNeedFileInfo: false);
				_0006 ^= (((-199642001 - num) ^ num2) | num4);
				num4 -= 2;
				StackFrame frame = stackTrace.GetFrame(num4);
				int index = num4;
				if (frame == null)
				{
					stackTrace = new StackTrace();
					index = 1;
					frame = stackTrace.GetFrame(index);
				}
				MethodBase methodBase = frame?.GetMethod();
				_0006 ^= num4 + ((num ^ 0x1C1AD535) + num2);
				Type type = methodBase?.DeclaringType;
				if (frame == null)
				{
					_0006 ^= ((-1621503594 + num) ^ num2);
				}
				bool flag = (object)type == typeof(RuntimeMethodHandle);
				_0006 ^= 1621415513 - num + num2;
				if (!flag)
				{
					flag = ((object)type == null);
					if (flag)
					{
						if (_000F_2000._0002(stackTrace, index))
						{
							flag = false;
						}
						else
						{
							_0006 ^= (num ^ -471694530) - num2;
						}
					}
				}
				if (flag == (stackTrace != null))
				{
					_0006 ^= 32;
				}
				_0006 ^= ((199642553 + num + num2) | (1 + num4));
				_000F_2000.m__0003 = new _0003(manifestResourceStream);
				short num5 = (short)(_000F_2000.m__0003._0002() ^ (short)(~(-(-(~(~(-(~(-(~(-(~(-199609777 - num - num2)))))))))))));
				if (num5 == 0)
				{
					_0008 = (short)(_000F_2000.m__0003._0002() ^ (short)(~(-(~(-(-(~(~(-(~((num ^ 0x1C1A65EC) + num2)))))))))));
				}
				else
				{
					_0005 = _000F_2000.m__0003._0002(num5);
				}
				callingAssembly = executingAssembly;
				AssemblyName assemblyName = _000F_2000._0002(callingAssembly);
				_000E = _000F_2000._0002(assemblyName);
				num6 = _0002_2000;
				num6 ^= ((-879198228 - num) ^ num2);
				_0002_2000 = 0;
				long num7 = _0003_2001._0002();
				num6 ^= (int)num7;
				num6 ^= -1313528180 + num - num2;
				int num8 = num6;
				int num9 = num8;
				int num10 = 0;
				int num11 = ((num ^ 0x411E5FEE ^ num2) + num9) ^ (-1408456491 - num + num2);
				int num12 = num11 * (num + -1621410060 - num2) % ((-226719798 - num) ^ num2);
				int num13 = num12;
				global::_0003_2000<int> enumerator = ((global::_000E<int>)new _0008._0002((199636049 + num) | num2)
				{
					_0006 = num13
				}).GetEnumerator();
				try
				{
					while (((_000F)enumerator)._000F_2005_2000_0002())
					{
						int num14 = enumerator._000F_2005_2000_0002();
						num12 ^= num14 - num10;
						num10 += num12 >> 1;
					}
				}
				finally
				{
					enumerator?._0002_2000_2005_2000_0002();
				}
				int num15 = num12;
				num6 ^= ~(-(~(-(-(~(~(-(~(-(~(-1246473112 - num + num2)))))))))));
				num6 = num15 + num6;
				_0006 = ((_0006 & (-333785797 ^ num ^ num2)) ^ (num + -1621408565 - num2));
				_000F = num6;
				if (((int)_0003_2000 & -(~(-(~(~(-(~(-(~(-(~((num ^ 0x1C1AD447) + num2)))))))))))) == 0)
				{
					_0006 = -199592089 - num - num2;
				}
			}
			else
			{
				num6 = _000F;
			}
			if (_0006 == (0x1C196073 ^ num) + num2)
			{
				return new string(new char[3]
				{
					(char)(num + -1621415265 - num2),
					'0',
					(char)(-471520751 ^ num ^ num2)
				});
			}
			int num16 = _0002 ^ (266843397 + num - num2) ^ num6;
			num16 ^= ((-347264904 - num) ^ num2);
			_000F_2000.m__0003._0002().Position = num16;
			if (_0005 != null)
			{
				array = _0005;
			}
			else
			{
				short num17 = (_0008 != -1) ? _0008 : ((short)(_000F_2000.m__0003._0002() ^ (num + 199628377 + num2) ^ num16));
				if (num17 == 0)
				{
					array = null;
				}
				else
				{
					array = _000F_2000.m__0003._0002(num17);
					for (int num18 = 0; num18 != array.Length; num18 = 1 + num18)
					{
						array[num18] ^= (byte)(_000F >> ((3 & num18) << 3));
					}
				}
			}
			num19 = (_000F_2000.m__0003._0002() ^ num16 ^ ~(-(~(-(-(~(~(-(~((0x38149345 ^ num) - num2))))))))) ^ num6);
			if (num19 != ((1621415351 - num) | num2))
			{
				break;
			}
			byte[] array2 = _000F_2000.m__0003._0002(4);
			_0002 = (((-940872524 ^ num) + num2) ^ num6);
			_0002 = ((array2[2] | (array2[3] << 16) | (array2[0] << 8) | (array2[1] << 24)) ^ -_0002);
			if (_000F_2000.m__0002.TryGetValue(_0002, out value))
			{
				return value;
			}
		}
		bool flag2 = (num19 & (526068295 + num - num2)) != 0;
		bool flag3 = (num19 & (-1008391607 ^ num ^ num2)) != 0;
		bool flag4 = (num19 & (-1599810119 - num + num2)) != 0;
		num19 &= ((num + -1679412142) ^ num2);
		byte[] array3 = array;
		byte[] array4 = _000F_2000.m__0003._0002(num19);
		byte[] array5 = array3;
		byte b = array5[1];
		int num20 = array4.Length;
		byte b2 = (byte)((num20 + 11) ^ (b + 7));
		uint num21 = (uint)((array5[0] | (array5[2] << 8)) + (b2 << 3));
		ushort num22 = 0;
		int num23 = 0;
		while (num23 < num20)
		{
			if ((1 & num23) == 0)
			{
				num21 = (uint)((int)num21 * ((num ^ 0x1C1799B0) + num2) + (num + -1618884342 - num2));
				num22 = (ushort)(num21 >> 16);
			}
			byte b3 = (byte)num22;
			num22 = (ushort)(num22 >> 8);
			byte b4 = array4[num23];
			array4[num23] = (byte)(b ^ b4 ^ (3 + b2) ^ b3);
			num23 = 1 + num23;
			b2 = b4;
		}
		byte[] array6 = array4;
		if (_000E != null != (_0006 != 1623023167 - num + num2))
		{
			for (int num24 = 0; num24 < num19; num24 = 1 + num24)
			{
				byte b5 = _000E[7 & num24];
				b5 = (byte)((b5 << 3) | (b5 >> 5));
				array6[num24] = (byte)(array6[num24] ^ b5);
			}
		}
		int num25 = _0006 - 12;
		byte[] array7;
		int num26;
		if (!flag3)
		{
			array7 = array6;
			num26 = num19;
		}
		else
		{
			num26 = (array6[2] | (array6[0] << 16) | (array6[3] << 8) | (array6[1] << 24));
			array7 = new byte[num26];
			_000F_2000._0002(array6, 4, array7);
		}
		if (flag2 && num25 == -1619807551 + num - num2)
		{
			char[] array8 = new char[num26];
			for (int i = 0; i < num26; i++)
			{
				array8[i] = (char)array7[i];
			}
			value = new string(array8);
		}
		else
		{
			value = Encoding.Unicode.GetString(array7, 0, array7.Length);
		}
		num25 += (num ^ -471520714 ^ num2) + (3 & num25) << 5;
		if (num25 != num + -1619803423 - num2)
		{
			int num27 = (_0002 + num19) ^ (-471113679 ^ num ^ num2) ^ (num25 & (-199634758 - num - num2));
			StringBuilder stringBuilder = new StringBuilder();
			int num3 = num ^ -471520751 ^ num2;
			stringBuilder.Append((char)(byte)num3);
			value = num27.ToString(stringBuilder.ToString());
		}
		if (!flag4 && _0003)
		{
			value = string.Intern(value);
			_000F_2000.m__0002[_0002] = value;
			if (_000F_2000.m__0002.Count == -199635609 - num - num2)
			{
				_000F_2000.m__0003._0003();
				_000F_2000.m__0003 = null;
				_0005 = null;
				_000E = null;
			}
		}
		return value;
	}

	private static AssemblyName _0002(Assembly _0002)
	{
		try
		{
			return _0002.GetName();
		}
		catch
		{
			return new AssemblyName(_0002.FullName);
		}
	}

	private static byte[] _0002(AssemblyName _0002)
	{
		byte[] array = _0002.GetPublicKeyToken();
		if (array != null && array.Length == 0)
		{
			array = null;
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool _0002(StackTrace _0002, int _0003)
	{
		Assembly assembly = _0002.GetFrame(++_0003)?.GetMethod()?.DeclaringType?.Assembly;
		if ((object)assembly != null)
		{
			AssemblyName assemblyName = _000F_2000._0002(assembly);
			byte[] array = _000F_2000._0002(assemblyName);
			if (array != null && array.Length == 8 && array[0] == 183 && array[7] == 137)
			{
				return true;
			}
		}
		while (true)
		{
			StackFrame frame = _0002.GetFrame(++_0003);
			if (frame == null)
			{
				break;
			}
			assembly = frame.GetMethod()?.DeclaringType?.Assembly;
			if ((object)assembly != null && (object)assembly == typeof(_000F_2000).Assembly)
			{
				return true;
			}
		}
		return false;
	}

	private static void _0002(byte[] _0002, int _0003, byte[] _0005)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 128;
		int num4 = _0005.Length;
		while (num < num4)
		{
			if ((num3 <<= 1) == 256)
			{
				num3 = 1;
				num2 = _0002[_0003++];
			}
			if ((num2 & num3) != 0)
			{
				int num5 = (_0002[_0003] >> 2) + 3;
				int num6 = ((_0002[_0003] << 8) | _0002[_0003 + 1]) & 0x3FF;
				_0003 += 2;
				int num7 = num - num6;
				if (num7 < 0)
				{
					break;
				}
				while (--num5 >= 0 && num < num4)
				{
					_0005[num++] = _0005[num7++];
				}
			}
			else
			{
				_0005[num++] = _0002[_0003++];
			}
		}
	}
}
