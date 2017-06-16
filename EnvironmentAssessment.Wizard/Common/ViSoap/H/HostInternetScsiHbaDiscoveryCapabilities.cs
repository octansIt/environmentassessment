namespace EnvironmentAssessment.Common.VISoap
{
    public class HostInternetScsiHbaDiscoveryCapabilities : DynamicData
	{
		protected bool _iSnsDiscoverySettable;
		protected bool _slpDiscoverySettable;
		protected bool _staticTargetDiscoverySettable;
		protected bool _sendTargetsDiscoverySettable;
		public bool ISnsDiscoverySettable
		{
			get
			{
				return this._iSnsDiscoverySettable;
			}
			set
			{
				this._iSnsDiscoverySettable = value;
			}
		}
		public bool SlpDiscoverySettable
		{
			get
			{
				return this._slpDiscoverySettable;
			}
			set
			{
				this._slpDiscoverySettable = value;
			}
		}
		public bool StaticTargetDiscoverySettable
		{
			get
			{
				return this._staticTargetDiscoverySettable;
			}
			set
			{
				this._staticTargetDiscoverySettable = value;
			}
		}
		public bool SendTargetsDiscoverySettable
		{
			get
			{
				return this._sendTargetsDiscoverySettable;
			}
			set
			{
				this._sendTargetsDiscoverySettable = value;
			}
		}
	}
}
