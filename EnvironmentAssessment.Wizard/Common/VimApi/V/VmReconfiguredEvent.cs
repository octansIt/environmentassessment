namespace EnvironmentAssessment.Common.VimApi
{
	public class VmReconfiguredEvent : VmEvent
	{
		protected VirtualMachineConfigSpec _configSpec;
		protected ChangesInfoEventArgument _configChanges;
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
		public ChangesInfoEventArgument ConfigChanges
		{
			get
			{
				return this._configChanges;
			}
			set
			{
				this._configChanges = value;
			}
		}
	}
}
