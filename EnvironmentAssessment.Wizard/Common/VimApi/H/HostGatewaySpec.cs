namespace EnvironmentAssessment.Common.VimApi
{
	public class HostGatewaySpec : DynamicData
	{
		protected string _gatewayType;
		protected string _gatewayId;
		protected string _trustVerificationToken;
		protected KeyValue[] _hostAuthParams;
		public string GatewayType
		{
			get
			{
				return this._gatewayType;
			}
			set
			{
				this._gatewayType = value;
			}
		}
		public string GatewayId
		{
			get
			{
				return this._gatewayId;
			}
			set
			{
				this._gatewayId = value;
			}
		}
		public string TrustVerificationToken
		{
			get
			{
				return this._trustVerificationToken;
			}
			set
			{
				this._trustVerificationToken = value;
			}
		}
		public KeyValue[] HostAuthParams
		{
			get
			{
				return this._hostAuthParams;
			}
			set
			{
				this._hostAuthParams = value;
			}
		}
	}
}
