using System.Diagnostics;
namespace EnvironmentAssessment.Common.VISoap
{
    public class VITrace
	{
		private static TraceSource s_trace = new TraceSource("VMware.Vim");
		public static TraceSource Trace
		{
			get
			{
				return VITrace.s_trace;
			}
		}
	}
}
