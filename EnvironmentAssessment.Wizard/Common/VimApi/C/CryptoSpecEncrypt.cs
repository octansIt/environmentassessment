namespace EnvironmentAssessment.Common.VimApi
{
	public class CryptoSpecEncrypt : CryptoSpec
	{
		protected CryptoKeyId _cryptoKeyId;
		public CryptoKeyId CryptoKeyId
		{
			get
			{
				return this._cryptoKeyId;
			}
			set
			{
				this._cryptoKeyId = value;
			}
		}
	}
}
