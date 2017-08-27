namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineVMCIDeviceFilterInfo : DynamicData
	{
		protected VirtualMachineVMCIDeviceFilterSpec[] _filters;
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
