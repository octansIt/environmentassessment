namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineSriovInfo : VirtualMachinePciPassthroughInfo
	{
		protected bool _virtualFunction;
		protected string _pnic;
		protected VirtualMachineSriovDevicePoolInfo _devicePool;
		public bool VirtualFunction
		{
			get
			{
				return this._virtualFunction;
			}
			set
			{
				this._virtualFunction = value;
			}
		}
		public string Pnic
		{
			get
			{
				return this._pnic;
			}
			set
			{
				this._pnic = value;
			}
		}
		public VirtualMachineSriovDevicePoolInfo DevicePool
		{
			get
			{
				return this._devicePool;
			}
			set
			{
				this._devicePool = value;
			}
		}
	}
}
