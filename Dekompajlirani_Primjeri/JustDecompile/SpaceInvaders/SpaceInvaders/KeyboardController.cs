using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace SpaceInvaders
{
	public class KeyboardController : IUserInterface
	{
		public KeyboardController()
		{
		}

		public void PauseProcessInput()
		{
			if (Console.KeyAvailable)
			{
				ConsoleKeyInfo keyInfo = Console.ReadKey(true);
				while (Console.KeyAvailable)
				{
					Console.ReadKey();
				}
				if (keyInfo.Key.Equals(ConsoleKey.Escape))
				{
					if (this.OnEscapePressed != null)
					{
						this.OnEscapePressed(this, new EventArgs());
					}
				}
				if (keyInfo.Key.Equals(ConsoleKey.UpArrow))
				{
					if (this.OnUpPressed != null)
					{
						this.OnUpPressed(this, new EventArgs());
					}
				}
				if (keyInfo.Key.Equals(ConsoleKey.DownArrow))
				{
					if (this.OnDownPressed != null)
					{
						this.OnDownPressed(this, new EventArgs());
					}
				}
				if (keyInfo.Key.Equals(ConsoleKey.Enter))
				{
					if (this.OnEnterPressed != null)
					{
						this.OnEnterPressed(this, new EventArgs());
					}
				}
			}
		}

		public void RunProcessInput()
		{
			if (Console.KeyAvailable)
			{
				ConsoleKeyInfo keyInfo = Console.ReadKey(true);
				while (Console.KeyAvailable)
				{
					Console.ReadKey();
				}
				if (keyInfo.Key.Equals(ConsoleKey.LeftArrow))
				{
					if (this.OnLeftPressed != null)
					{
						this.OnLeftPressed(this, new EventArgs());
					}
				}
				if (keyInfo.Key.Equals(ConsoleKey.RightArrow))
				{
					if (this.OnRightPressed != null)
					{
						this.OnRightPressed(this, new EventArgs());
					}
				}
				if (keyInfo.Key.Equals(ConsoleKey.Spacebar))
				{
					if (this.OnActionPressed != null)
					{
						this.OnActionPressed(this, new EventArgs());
					}
				}
				if (keyInfo.Key.Equals(ConsoleKey.Escape))
				{
					if (this.OnEscapePressed != null)
					{
						this.OnEscapePressed(this, new EventArgs());
					}
				}
			}
		}

		public event EventHandler OnActionPressed;

		public event EventHandler OnDownPressed;

		public event EventHandler OnEnterPressed;

		public event EventHandler OnEscapePressed;

		public event EventHandler OnLeftPressed;

		public event EventHandler OnRightPressed;

		public event EventHandler OnUpPressed;
	}
}