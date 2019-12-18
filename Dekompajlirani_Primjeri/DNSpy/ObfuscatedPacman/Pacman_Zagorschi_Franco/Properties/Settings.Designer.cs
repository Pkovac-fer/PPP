using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Pacman_Zagorschi_Franco.Properties
{
	// Token: 0x0200001F RID: 31
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00015BD0 File Offset: 0x00013DD0
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x040001C8 RID: 456
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
