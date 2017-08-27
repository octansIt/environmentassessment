namespace EnvironmentAssessment.Common.VimApi
{
	public class InsufficientAgentVmsDeployed : InsufficientResourcesFault
	{
		protected string _hostName;
		protected int _requiredNumAgentVms;
		protected int _currentNumAgentVms;
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
		public int RequiredNumAgentVms
		{
			get
			{
				return this._requiredNumAgentVms;
			}
			set
			{
				this._requiredNumAgentVms = value;
			}
		}
		public int CurrentNumAgentVms
		{
			get
			{
				return this._currentNumAgentVms;
			}
			set
			{
				this._currentNumAgentVms = value;
			}
		}
	}
}
