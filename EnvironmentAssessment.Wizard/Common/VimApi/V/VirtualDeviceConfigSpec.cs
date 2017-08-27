namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualDeviceConfigSpec : DynamicData
	{
		protected VirtualDeviceConfigSpecOperation? _operation;
		protected VirtualDeviceConfigSpecFileOperation? _fileOperation;
		protected VirtualDevice _device;
		protected VirtualMachineProfileSpec[] _profile;
		protected VirtualDeviceConfigSpecBackingSpec _backing;
		public VirtualDeviceConfigSpecOperation? Operation
		{
			get
			{
				return this._operation;
			}
			set
			{
				this._operation = value;
			}
		}
		public VirtualDeviceConfigSpecFileOperation? FileOperation
		{
			get
			{
				return this._fileOperation;
			}
			set
			{
				this._fileOperation = value;
			}
		}
		public VirtualDevice Device
		{
			get
			{
				return this._device;
			}
			set
			{
				this._device = value;
			}
		}
		public VirtualMachineProfileSpec[] Profile
		{
			get
			{
				return this._profile;
			}
			set
			{
				this._profile = value;
			}
		}
		public VirtualDeviceConfigSpecBackingSpec Backing
		{
			get
			{
				return this._backing;
			}
			set
			{
				this._backing = value;
			}
		}
	}
}
