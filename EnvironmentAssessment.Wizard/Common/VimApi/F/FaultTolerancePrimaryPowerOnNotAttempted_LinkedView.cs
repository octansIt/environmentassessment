namespace EnvironmentAssessment.Common.VimApi
{
	public class FaultTolerancePrimaryPowerOnNotAttempted_LinkedView
	{
		protected VirtualMachine _secondaryVm;
		protected VirtualMachine _primaryVm;
		public VirtualMachine SecondaryVm
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
		public VirtualMachine PrimaryVm
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
	}
}
