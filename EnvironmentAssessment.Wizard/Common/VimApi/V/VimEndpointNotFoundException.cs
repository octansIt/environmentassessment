using System;

namespace EnvironmentAssessment.Common.VimApi
{
	public class VimEndpointNotFoundException : VimException
	{
		public VimEndpointNotFoundException(string message, Exception innerException = null) : base(message, innerException)
		{
		}
	}
}
