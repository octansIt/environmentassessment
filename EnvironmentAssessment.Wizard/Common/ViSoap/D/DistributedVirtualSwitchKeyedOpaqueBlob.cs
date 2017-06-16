namespace EnvironmentAssessment.Common.VISoap
{
    public class DistributedVirtualSwitchKeyedOpaqueBlob : DynamicData
	{
		protected string _key;
		protected string _opaqueData;
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
		public string OpaqueData
		{
			get
			{
				return this._opaqueData;
			}
			set
			{
				this._opaqueData = value;
			}
		}
	}
}
