namespace EnvironmentAssessment.Common.VimApi
{
	public class CryptoSpecShallowRecrypt : CryptoSpec
	{
		protected CryptoKeyId _newKeyId;
		public CryptoKeyId NewKeyId
		{
			get
			{
				return this._newKeyId;
			}
			set
			{
				this._newKeyId = value;
			}
		}
	}
}
