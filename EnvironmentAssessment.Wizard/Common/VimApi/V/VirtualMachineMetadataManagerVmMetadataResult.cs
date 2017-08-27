namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineMetadataManagerVmMetadataResult : DynamicData
	{
		protected VirtualMachineMetadataManagerVmMetadata _vmMetadata;
		protected LocalizedMethodFault _error;
		public VirtualMachineMetadataManagerVmMetadata VmMetadata
		{
			get
			{
				return this._vmMetadata;
			}
			set
			{
				this._vmMetadata = value;
			}
		}
		public LocalizedMethodFault Error
		{
			get
			{
				return this._error;
			}
			set
			{
				this._error = value;
			}
		}
	}
}
