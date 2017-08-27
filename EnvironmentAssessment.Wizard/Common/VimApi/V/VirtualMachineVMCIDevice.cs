namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineVMCIDevice : VirtualDevice
	{
		protected long? _id;
		protected bool? _allowUnrestrictedCommunication;
		protected bool? _filterEnable;
		protected VirtualMachineVMCIDeviceFilterInfo _filterInfo;
		public long? Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}
		public bool? AllowUnrestrictedCommunication
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
		public bool? FilterEnable
		{
			get
			{
				return this._filterEnable;
			}
			set
			{
				this._filterEnable = value;
			}
		}
		public VirtualMachineVMCIDeviceFilterInfo FilterInfo
		{
			get
			{
				return this._filterInfo;
			}
			set
			{
				this._filterInfo = value;
			}
		}
	}
}
