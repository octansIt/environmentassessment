namespace EnvironmentAssessment.Common.VimApi
{
	public class CryptoKeyId : DynamicData
	{
		protected string _keyId;
		protected KeyProviderId _providerId;
		public string KeyId
		{
			get
			{
				return this._keyId;
			}
			set
			{
				this._keyId = value;
			}
		}
		public KeyProviderId ProviderId
		{
			get
			{
				return this._providerId;
			}
			set
			{
				this._providerId = value;
			}
		}
	}
}
