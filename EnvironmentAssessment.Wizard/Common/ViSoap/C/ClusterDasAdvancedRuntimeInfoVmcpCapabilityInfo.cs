namespace EnvironmentAssessment.Common.VISoap
{
    public class ClusterDasAdvancedRuntimeInfoVmcpCapabilityInfo : DynamicData
	{
		protected bool _storageAPDSupported;
		protected bool _storagePDLSupported;
		public bool StorageAPDSupported
		{
			get
			{
				return this._storageAPDSupported;
			}
			set
			{
				this._storageAPDSupported = value;
			}
		}
		public bool StoragePDLSupported
		{
			get
			{
				return this._storagePDLSupported;
			}
			set
			{
				this._storagePDLSupported = value;
			}
		}
	}
}
