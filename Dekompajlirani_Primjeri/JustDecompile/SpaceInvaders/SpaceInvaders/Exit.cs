using System;

namespace SpaceInvaders
{
	public class Exit : MenuItem
	{
		public static char[,] message;

		static Exit()
		{
			Exit.message = new char[,] { { 'E', 'X', 'I', 'T' } };
		}

		public Exit(MatrixPosition topLeft) : base(topLeft, Exit.message)
		{
		}

		public override void TakeAction(Engine engine)
		{
			Environment.Exit(0);
		}
	}
}