using System;

namespace SpaceInvaders
{
	public class StartResume : MenuItem
	{
		public static char[,] message;

		static StartResume()
		{
			StartResume.message = new char[,] { { 'S', 'T', 'A', 'R', 'T', '/', 'R', 'E', 'S', 'U', 'M', 'E' } };
		}

		public StartResume(MatrixPosition topLeft) : base(topLeft, StartResume.message)
		{
		}

		public override void TakeAction(Engine engine)
		{
			engine.Run();
		}
	}
}