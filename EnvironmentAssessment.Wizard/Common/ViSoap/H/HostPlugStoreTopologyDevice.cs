namespace EnvironmentAssessment.Common.VISoap
{
    public class HostPlugStoreTopologyDevice : DynamicData
	{
		protected string _key;
		protected string _lun;
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
		public string Lun
		{
			get
			{
				return this._lun;
			}
			set
			{
				this._lun = value;
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
