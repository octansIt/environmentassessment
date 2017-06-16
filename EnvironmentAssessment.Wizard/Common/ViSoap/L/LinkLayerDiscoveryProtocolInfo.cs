namespace EnvironmentAssessment.Common.VISoap
{
    public class LinkLayerDiscoveryProtocolInfo : DynamicData
	{
		protected string _chassisId;
		protected string _portId;
		protected int _timeToLive;
		protected KeyAnyValue[] _parameter;
		public string ChassisId
		{
			get
			{
				return this._chassisId;
			}
			set
			{
				this._chassisId = value;
			}
		}
		public string PortId
		{
			get
			{
				return this._portId;
			}
			set
			{
				this._portId = value;
			}
		}
		public int TimeToLive
		{
			get
			{
				return this._timeToLive;
			}
			set
			{
				this._timeToLive = value;
			}
		}
		public KeyAnyValue[] Parameter
		{
			get
			{
				return this._parameter;
			}
			set
			{
				this._parameter = value;
			}
		}
	}
}
