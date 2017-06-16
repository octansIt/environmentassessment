namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualMachinePciPassthroughInfo : VirtualMachineTargetInfo
	{
		protected HostPciDevice _pciDevice;
		protected string _systemId;
		public HostPciDevice PciDevice
		{
			get
			{
				return this._pciDevice;
			}
			set
			{
				this._pciDevice = value;
			}
		}
		public string SystemId
		{
			get
			{
				return this._systemId;
			}
			set
			{
				this._systemId = value;
			}
		}
	}
}
