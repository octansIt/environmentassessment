namespace EnvironmentAssessment.Common.VimApi
{
	public class VmBeingCreatedEvent : VmEvent
	{
		protected VirtualMachineConfigSpec _configSpec;
		public VirtualMachineConfigSpec ConfigSpec
		{
			get
			{
				return this._configSpec;
			}
			set
			{
				this._configSpec = value;
			}
		}
	}
}
