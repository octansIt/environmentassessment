namespace EnvironmentAssessment.Common.VimApi
{
	public class DvsHostInfrastructureTrafficResource : DynamicData
	{
		protected string _key;
		protected string _description;
		protected DvsHostInfrastructureTrafficResourceAllocation _allocationInfo;
		public string Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				this._description = value;
			}
		}
		public DvsHostInfrastructureTrafficResourceAllocation AllocationInfo
		{
			get
			{
				return this._allocationInfo;
			}
			set
			{
				this._allocationInfo = value;
			}
		}
	}
}
