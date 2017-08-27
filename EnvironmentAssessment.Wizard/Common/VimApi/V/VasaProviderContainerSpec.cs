namespace EnvironmentAssessment.Common.VimApi
{
	public class VasaProviderContainerSpec : DynamicData
	{
		protected VimVasaProviderInfo[] _vasaProviderInfo;
		protected string _scId;
		protected bool _deleted;
		public VimVasaProviderInfo[] VasaProviderInfo
		{
			get
			{
				return this._vasaProviderInfo;
			}
			set
			{
				this._vasaProviderInfo = value;
			}
		}
		public string ScId
		{
			get
			{
				return this._scId;
			}
			set
			{
				this._scId = value;
			}
		}
		public bool Deleted
		{
			get
			{
				return this._deleted;
			}
			set
			{
				this._deleted = value;
			}
		}
	}
}
