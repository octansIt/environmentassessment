namespace EnvironmentAssessment.Common.VimApi
{
	public class DVSNetworkResourcePoolConfigSpec : DynamicData
	{
		protected string _key;
		protected string _configVersion;
		protected DVSNetworkResourcePoolAllocationInfo _allocationInfo;
		protected string _name;
		protected string _description;
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
		public string ConfigVersion
		{
			get
			{
				return this._configVersion;
			}
			set
			{
				this._configVersion = value;
			}
		}
		public DVSNetworkResourcePoolAllocationInfo AllocationInfo
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
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
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
	}
}
