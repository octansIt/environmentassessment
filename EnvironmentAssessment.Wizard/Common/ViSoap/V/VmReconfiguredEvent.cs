namespace EnvironmentAssessment.Common.VISoap
{
    public class VmReconfiguredEvent : VmEvent
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
