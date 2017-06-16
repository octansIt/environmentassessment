namespace EnvironmentAssessment.Common.VISoap
{
    public class DistributedVirtualSwitchManagerImportResult : DynamicData
	{
		protected ManagedObjectReference[] _distributedVirtualSwitch;
		protected ManagedObjectReference[] _distributedVirtualPortgroup;
		protected ImportOperationBulkFaultFaultOnImport[] _importFault;
		protected DistributedVirtualSwitchManagerImportResult_LinkedView _linkedView;
		public ManagedObjectReference[] DistributedVirtualSwitch
		{
			get
			{
				return this._distributedVirtualSwitch;
			}
			set
			{
				this._distributedVirtualSwitch = value;
			}
		}
		public ManagedObjectReference[] DistributedVirtualPortgroup
		{
			get
			{
				return this._distributedVirtualPortgroup;
			}
			set
			{
				this._distributedVirtualPortgroup = value;
			}
		}
		public ImportOperationBulkFaultFaultOnImport[] ImportFault
		{
			get
			{
				return this._importFault;
			}
			set
			{
				this._importFault = value;
			}
		}
		public DistributedVirtualSwitchManagerImportResult_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
