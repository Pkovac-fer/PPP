using System;
using System.Runtime.CompilerServices;

namespace SpaceInvaders
{
	public interface IUserInterface
	{
		void PauseProcessInput();

		void RunProcessInput();

		event EventHandler OnActionPressed;

		event EventHandler OnDownPressed;

		event EventHandler OnEnterPressed;

		event EventHandler OnEscapePressed;

		event EventHandler OnLeftPressed;

		event EventHandler OnRightPressed;

		event EventHandler OnUpPressed;
	}
}