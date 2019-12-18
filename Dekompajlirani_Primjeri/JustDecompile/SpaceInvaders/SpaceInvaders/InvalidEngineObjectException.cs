using System;

namespace SpaceInvaders
{
	public class InvalidEngineObjectException : ApplicationException
	{
		public InvalidEngineObjectException(string msg) : base(msg)
		{
		}

		public InvalidEngineObjectException(string msg, Exception innerEx) : base(msg, innerEx)
		{
		}
	}
}