namespace EnvironmentAssessment.Common.VimApi
{
	public class NoDiskSpace : FileFault
	{
		protected string _datastore;
		public string Datastore
		{
			get
			{
				return this._datastore;
			}
			set
			{
				this._datastore = value;
			}
		}
	}
}
