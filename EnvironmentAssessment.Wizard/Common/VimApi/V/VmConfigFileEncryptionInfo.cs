namespace EnvironmentAssessment.Common.VimApi
{
	public class VmConfigFileEncryptionInfo : DynamicData
	{
		protected CryptoKeyId _keyId;
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
	}
}
