namespace EnvironmentAssessment.Common.VimApi
{
	public class FaultTolerancePrimaryPowerOnNotAttempted : VmFaultToleranceIssue
	{
		protected ManagedObjectReference _secondaryVm;
		protected ManagedObjectReference _primaryVm;
		protected FaultTolerancePrimaryPowerOnNotAttempted_LinkedView _linkedView;
		public ManagedObjectReference SecondaryVm
		{
			get
			{
				return this._secondaryVm;
			}
			set
			{
				this._secondaryVm = value;
			}
		}
		public ManagedObjectReference PrimaryVm
		{
			get
			{
				return this._primaryVm;
			}
			set
			{
				this._primaryVm = value;
			}
		}
		public FaultTolerancePrimaryPowerOnNotAttempted_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
