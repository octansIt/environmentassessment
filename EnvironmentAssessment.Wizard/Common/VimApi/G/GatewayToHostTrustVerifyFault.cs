namespace EnvironmentAssessment.Common.VimApi
{
	public class GatewayToHostTrustVerifyFault : GatewayToHostConnectFault
	{
		protected string _verificationToken;
		protected KeyValue[] _propertiesToVerify;
		public string VerificationToken
		{
			get
			{
				return this._verificationToken;
			}
			set
			{
				this._verificationToken = value;
			}
		}
		public KeyValue[] PropertiesToVerify
		{
			get
			{
				return this._propertiesToVerify;
			}
			set
			{
				this._propertiesToVerify = value;
			}
		}
	}
}
