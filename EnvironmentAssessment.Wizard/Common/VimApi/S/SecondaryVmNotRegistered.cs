namespace EnvironmentAssessment.Common.VimApi
{
	public class SecondaryVmNotRegistered : VmFaultToleranceIssue
	{
		protected string _instanceUuid;
		public string InstanceUuid
		{
			get
			{
				return this._instanceUuid;
			}
			set
			{
				this._instanceUuid = value;
			}
		}
	}
}
