using System;
using System.Windows.Forms;

namespace Pacman_Zagorschi_Franco
{
	// Token: 0x02000003 RID: 3
	internal static class Program
	{
		// Token: 0x0600002C RID: 44 RVA: 0x000139CC File Offset: 0x00011BCC
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
