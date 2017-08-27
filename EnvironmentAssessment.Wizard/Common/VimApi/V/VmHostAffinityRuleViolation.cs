namespace EnvironmentAssessment.Common.VimApi
{
	public class VmHostAffinityRuleViolation : VmConfigFault
	{
		protected string _vmName;
		protected string _hostName;
		public string VmName
		{
			get
			{
				return this._vmName;
			}
			set
			{
				this._vmName = value;
			}
		}
		public string HostName
		{
			get
			{
				return this._hostName;
			}
			set
			{
				this._hostName = value;
			}
		}
	}
}
