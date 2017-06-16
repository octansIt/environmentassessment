namespace EnvironmentAssessment.Common.VISoap
{
    public class HostConfigInfo_LinkedView
	{
		protected HostSystem _host;
		protected Datastore _localSwapDatastore;
		public HostSystem Host
		{
			get
			{
				return this._host;
			}
			set
			{
				this._host = value;
			}
		}
		public Datastore LocalSwapDatastore
		{
			get
			{
				return this._localSwapDatastore;
			}
			set
			{
				this._localSwapDatastore = value;
			}
		}
	}
}
