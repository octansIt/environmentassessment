namespace EnvironmentAssessment.Common.VimApi
{
    public class VirtualMachinePowerPolicy : DynamicData
	{
		protected string _powerMode;
		protected VirtualMachinePowerPolicyProfile _acProfile;
		protected VirtualMachinePowerPolicyProfile _batteryProfile;
		public string PowerMode
		{
			get
			{
				return this._powerMode;
			}
			set
			{
				this._powerMode = value;
			}
		}
		public VirtualMachinePowerPolicyProfile AcProfile
		{
			get
			{
				return this._acProfile;
			}
			set
			{
				this._acProfile = value;
			}
		}
		public VirtualMachinePowerPolicyProfile BatteryProfile
		{
			get
			{
				return this._batteryProfile;
			}
			set
			{
				this._batteryProfile = value;
			}
		}
	}
}
