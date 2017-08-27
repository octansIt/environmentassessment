namespace EnvironmentAssessment.Common.VimApi
{
	public class VStorageObject : DynamicData
	{
		protected VStorageObjectConfigInfo _config;
		public VStorageObjectConfigInfo Config
		{
			get
			{
				return this._config;
			}
			set
			{
				this._config = value;
			}
		}
	}
}
