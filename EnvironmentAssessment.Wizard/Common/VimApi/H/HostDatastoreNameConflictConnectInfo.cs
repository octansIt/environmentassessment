namespace EnvironmentAssessment.Common.VimApi
{
	public class HostDatastoreNameConflictConnectInfo : HostDatastoreConnectInfo
	{
		protected string _newDatastoreName;
		public string NewDatastoreName
		{
			get
			{
				return this._newDatastoreName;
			}
			set
			{
				this._newDatastoreName = value;
			}
		}
	}
}
