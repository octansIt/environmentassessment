using System;

namespace EnvironmentAssessment.Common.VimApi
{
	public class VimProtocolException : VimException
	{
		public VimProtocolException(string message, Exception innerException = null) : base(message, innerException)
		{
		}
	}
}
