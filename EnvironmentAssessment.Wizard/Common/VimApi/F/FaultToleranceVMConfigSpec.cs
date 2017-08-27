namespace EnvironmentAssessment.Common.VimApi
{
	public class FaultToleranceVMConfigSpec : DynamicData
	{
		protected ManagedObjectReference _vmConfig;
		protected FaultToleranceDiskSpec[] _disks;
		protected FaultToleranceVMConfigSpec_LinkedView _linkedView;
		public ManagedObjectReference VmConfig
		{
			get
			{
				return this._vmConfig;
			}
			set
			{
				this._vmConfig = value;
			}
		}
		public FaultToleranceDiskSpec[] Disks
		{
			get
			{
				return this._disks;
			}
			set
			{
				this._disks = value;
			}
		}
		public FaultToleranceVMConfigSpec_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
