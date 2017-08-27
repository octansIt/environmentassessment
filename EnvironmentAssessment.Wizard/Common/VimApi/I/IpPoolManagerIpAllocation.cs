namespace EnvironmentAssessment.Common.VimApi
{
	public class IpPoolManagerIpAllocation : DynamicData
	{
		protected string _ipAddress;
		protected string _allocationId;
		public string IpAddress
		{
			get
			{
				return this._ipAddress;
			}
			set
			{
				this._ipAddress = value;
			}
		}
		public string AllocationId
		{
			get
			{
				return this._allocationId;
			}
			set
			{
				this._allocationId = value;
			}
		}
	}
}
