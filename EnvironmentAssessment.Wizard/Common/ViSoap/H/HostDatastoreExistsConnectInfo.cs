namespace EnvironmentAssessment.Common.VISoap
{
    public class HostDatastoreExistsConnectInfo : HostDatastoreConnectInfo
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
