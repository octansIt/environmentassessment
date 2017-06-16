namespace EnvironmentAssessment.Common.VISoap
{
    public class DistributedVirtualSwitchManagerCompatibilityResult : DynamicData
	{
		protected ManagedObjectReference _host;
		protected LocalizedMethodFault[] _error;
		protected DistributedVirtualSwitchManagerCompatibilityResult_LinkedView _linkedView;
		public ManagedObjectReference Host
		{
			get
			{
				return this._host;
			}
			set
			{
				this._host = value;
			}
		}
		public LocalizedMethodFault[] Error
		{
			get
			{
				return this._error;
			}
			set
			{
				this._error = value;
			}
		}
		public DistributedVirtualSwitchManagerCompatibilityResult_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
