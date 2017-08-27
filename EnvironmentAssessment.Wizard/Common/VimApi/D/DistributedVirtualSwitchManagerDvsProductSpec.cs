namespace EnvironmentAssessment.Common.VimApi
{
	public class DistributedVirtualSwitchManagerDvsProductSpec : DynamicData
	{
		protected DistributedVirtualSwitchProductSpec _newSwitchProductSpec;
		protected ManagedObjectReference _distributedVirtualSwitch;
		protected DistributedVirtualSwitchManagerDvsProductSpec_LinkedView _linkedView;
		public DistributedVirtualSwitchProductSpec NewSwitchProductSpec
		{
			get
			{
				return this._newSwitchProductSpec;
			}
			set
			{
				this._newSwitchProductSpec = value;
			}
		}
		public ManagedObjectReference DistributedVirtualSwitch
		{
			get
			{
				return this._distributedVirtualSwitch;
			}
			set
			{
				this._distributedVirtualSwitch = value;
			}
		}
		public DistributedVirtualSwitchManagerDvsProductSpec_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
