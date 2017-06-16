namespace EnvironmentAssessment.Common.VISoap
{
    public class VmFaultToleranceStateChangedEvent : VmEvent
	{
		protected VirtualMachineFaultToleranceState _oldState;
		protected VirtualMachineFaultToleranceState _newState;
		public VirtualMachineFaultToleranceState OldState
		{
			get
			{
				return this._oldState;
			}
			set
			{
				this._oldState = value;
			}
		}
		public VirtualMachineFaultToleranceState NewState
		{
			get
			{
				return this._newState;
			}
			set
			{
				this._newState = value;
			}
		}
	}
}
