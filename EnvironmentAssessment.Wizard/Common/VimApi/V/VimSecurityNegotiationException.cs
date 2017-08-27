using System;

namespace EnvironmentAssessment.Common.VimApi
{
	public class VimSecurityNegotiationException : VimException
	{
		public VimSecurityNegotiationException(string message, Exception innerException = null) : base(message, innerException)
		{
		}
	}
}
