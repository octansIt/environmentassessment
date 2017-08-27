namespace EnvironmentAssessment.Common.VimApi
{
	public class CryptoKeyResult : DynamicData
	{
		protected CryptoKeyId _keyId;
		protected bool _success;
		protected string _reason;
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
		public bool Success
		{
			get
			{
				return this._success;
			}
			set
			{
				this._success = value;
			}
		}
		public string Reason
		{
			get
			{
				return this._reason;
			}
			set
			{
				this._reason = value;
			}
		}
	}
}
