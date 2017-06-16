namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualMachineMetadataManagerVmMetadataInput : DynamicData
	{
		protected string _operation;
		protected VirtualMachineMetadataManagerVmMetadata _vmMetadata;
		public string Operation
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
	}
}
