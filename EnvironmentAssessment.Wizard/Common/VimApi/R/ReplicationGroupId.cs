namespace EnvironmentAssessment.Common.VimApi
{
	public class ReplicationGroupId : DynamicData
	{
		protected FaultDomainId _faultDomainId;
		protected DeviceGroupId _deviceGroupId;
		public FaultDomainId FaultDomainId
		{
			get
			{
				return this._faultDomainId;
			}
			set
			{
				this._faultDomainId = value;
			}
		}
		public DeviceGroupId DeviceGroupId
		{
			get
			{
				return this._deviceGroupId;
			}
			set
			{
				this._deviceGroupId = value;
			}
		}
	}
}
