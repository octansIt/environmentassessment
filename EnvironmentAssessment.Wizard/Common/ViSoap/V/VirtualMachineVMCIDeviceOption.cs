namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualMachineVMCIDeviceOption : VirtualDeviceOption
	{
		protected BoolOption _allowUnrestrictedCommunication;
		protected VirtualMachineVMCIDeviceOptionFilterSpecOption _filterSpecOption;
		protected BoolOption _filterSupported;
		public BoolOption AllowUnrestrictedCommunication
		{
			get
			{
				return this._allowUnrestrictedCommunication;
			}
			set
			{
				this._allowUnrestrictedCommunication = value;
			}
		}
		public VirtualMachineVMCIDeviceOptionFilterSpecOption FilterSpecOption
		{
			get
			{
				return this._filterSpecOption;
			}
			set
			{
				this._filterSpecOption = value;
			}
		}
		public BoolOption FilterSupported
		{
			get
			{
				return this._filterSupported;
			}
			set
			{
				this._filterSupported = value;
			}
		}
	}
}
