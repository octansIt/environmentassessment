namespace EnvironmentAssessment.Common.VimApi
{
	public class VmFaultToleranceOpIssuesList : VmFaultToleranceIssue
	{
		protected LocalizedMethodFault[] _errors;
		protected LocalizedMethodFault[] _warnings;
		public LocalizedMethodFault[] Errors
		{
			get
			{
				return this._errors;
			}
			set
			{
				this._errors = value;
			}
		}
		public LocalizedMethodFault[] Warnings
		{
			get
			{
				return this._warnings;
			}
			set
			{
				this._warnings = value;
			}
		}
	}
}
