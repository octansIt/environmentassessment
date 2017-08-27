namespace EnvironmentAssessment.Common.VimApi
{
	public class CryptoKeyPlain : DynamicData
	{
		protected CryptoKeyId _keyId;
		protected string _algorithm;
		protected string _keyData;
		public CryptoKeyId KeyId
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
		public string Algorithm
		{
			get
			{
				return this._algorithm;
			}
			set
			{
				this._algorithm = value;
			}
		}
		public string KeyData
		{
			get
			{
				return this._keyData;
			}
			set
			{
				this._keyData = value;
			}
		}
	}
}
