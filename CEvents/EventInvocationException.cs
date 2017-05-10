namespace CEvents
{
	using System;

	public class EventInvocationException : Exception
	{
		internal EventInvocationException(string message)
			: base(message)
		{
		}

		internal EventInvocationException(string message, Exception innerException)
			: base(message, innerException)
		{
		}
	}
}