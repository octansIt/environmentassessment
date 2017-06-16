namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualMachineVMCIDevice : VirtualDevice
	{
		protected long? _id;
		protected bool? _allowUnrestrictedCommunication;
		protected bool? _filterEnable;
		protected VirtualMachineVMCIDeviceFilterSpec[] _filters;
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
		public VirtualMachineVMCIDeviceFilterSpec[] Filters
		{
			get
			{
				return this._filters;
			}
			set
			{
				this._filters = value;
			}
		}
	}
}
