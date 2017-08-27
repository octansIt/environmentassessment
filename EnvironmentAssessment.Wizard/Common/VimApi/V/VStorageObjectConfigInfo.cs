namespace EnvironmentAssessment.Common.VimApi
{
	public class VStorageObjectConfigInfo : BaseConfigInfo
	{
		protected long _capacityInMB;
		protected string[] _consumptionType;
		protected ID[] _consumerId;
		public long CapacityInMB
		{
			get
			{
				return this._capacityInMB;
			}
			set
			{
				this._capacityInMB = value;
			}
		}
		public string[] ConsumptionType
		{
			get
			{
				return this._consumptionType;
			}
			set
			{
				this._consumptionType = value;
			}
		}
		public ID[] ConsumerId
		{
			get
			{
				return this._consumerId;
			}
			set
			{
				this._consumerId = value;
			}
		}
	}
}
