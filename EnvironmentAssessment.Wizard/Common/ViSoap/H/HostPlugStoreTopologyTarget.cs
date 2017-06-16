namespace EnvironmentAssessment.Common.VISoap
{
    public class HostPlugStoreTopologyTarget : DynamicData
	{
		protected string _key;
		protected HostTargetTransport _transport;
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
		public HostTargetTransport Transport
		{
			get
			{
				return this._transport;
			}
			set
			{
				this._transport = value;
			}
		}
	}
}
