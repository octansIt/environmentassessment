namespace EnvironmentAssessment.Common.VimApi
{
	public class CryptoSpecRegister : CryptoSpecNoOp
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
