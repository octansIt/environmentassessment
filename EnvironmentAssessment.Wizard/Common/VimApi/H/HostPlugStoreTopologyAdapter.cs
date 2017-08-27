namespace EnvironmentAssessment.Common.VimApi
{
	public class HostPlugStoreTopologyAdapter : DynamicData
	{
		protected string _key;
		protected string _adapter;
		protected string[] _path;
		public string Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
		public string Adapter
		{
			get
			{
				return this._adapter;
			}
			set
			{
				this._adapter = value;
			}
		}
		public string[] Path
		{
			get
			{
				return this._path;
			}
			set
			{
				this._path = value;
			}
		}
	}
}
