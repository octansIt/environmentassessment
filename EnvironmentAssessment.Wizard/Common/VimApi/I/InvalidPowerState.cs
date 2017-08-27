namespace EnvironmentAssessment.Common.VimApi
{
	public class InvalidPowerState : InvalidState
	{
		protected VirtualMachinePowerState? _requestedState;
		protected VirtualMachinePowerState _existingState;
		public VirtualMachinePowerState? RequestedState
		{
			get
			{
				return this._requestedState;
			}
			set
			{
				this._requestedState = value;
			}
		}
		public VirtualMachinePowerState ExistingState
		{
			get
			{
				return this._existingState;
			}
			set
			{
				this._existingState = value;
			}
		}
	}
}
