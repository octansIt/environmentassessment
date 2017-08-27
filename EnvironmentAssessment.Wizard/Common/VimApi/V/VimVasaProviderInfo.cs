namespace EnvironmentAssessment.Common.VimApi
{
	public class VimVasaProviderInfo : DynamicData
	{
		protected VimVasaProvider _provider;
		protected VimVasaProviderStatePerArray[] _arrayState;
		public VimVasaProvider Provider
		{
			get
			{
				return this._provider;
			}
			set
			{
				this._provider = value;
			}
		}
		public VimVasaProviderStatePerArray[] ArrayState
		{
			get
			{
				return this._arrayState;
			}
			set
			{
				this._arrayState = value;
			}
		}
	}
}
