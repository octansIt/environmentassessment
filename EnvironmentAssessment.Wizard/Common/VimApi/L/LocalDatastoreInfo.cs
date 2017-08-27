namespace EnvironmentAssessment.Common.VimApi
{
	public class LocalDatastoreInfo : DatastoreInfo
	{
		protected string _path;
		public string Path
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
