using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Pacman_Zagorschi_Franco.Properties
{
	// Token: 0x02000005 RID: 5
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000064 RID: 100 RVA: 0x000143EC File Offset: 0x000125EC
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x040001B1 RID: 433
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
