using System;

namespace SpaceInvaders
{
	public class Cursor : GameObject
	{
		public bool isActive;

		public bool IsActive
		{
			get
			{
				return this.isActive;
			}
			set
			{
				this.isActive = value;
			}
		}

		public Cursor(MatrixPosition topLeft)
		{
			char[,] chrArray = new char[1, 2];
			chrArray[0, 0] = '>';
			chrArray[0, 1] = '>';
			base(topLeft, chrArray);
			this.isActive = false;
		}

		public void MoveDown()
		{
			MatrixPosition row = this.topLeft;
			row.Row = row.Row + 2;
		}

		public void MoveUp()
		{
			if (this.topLeft.Row > 3)
			{
				MatrixPosition row = this.topLeft;
				row.Row = row.Row - 2;
			}
		}
	}
}