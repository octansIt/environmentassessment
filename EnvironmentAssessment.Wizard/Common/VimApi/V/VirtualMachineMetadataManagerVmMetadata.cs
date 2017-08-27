namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineMetadataManagerVmMetadata : DynamicData
	{
		protected string _vmId;
		protected string _metadata;
		public string VmId
		{
			get
			{
				return this._vmId;
			}
			set
			{
				this._vmId = value;
			}
		}
		public string Metadata
		{
			get
			{
				return this._metadata;
			}
			set
			{
				this._metadata = value;
			}
		}
	}
}
