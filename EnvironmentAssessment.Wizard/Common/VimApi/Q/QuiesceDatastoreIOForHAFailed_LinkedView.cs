namespace EnvironmentAssessment.Common.VimApi
{
	public class QuiesceDatastoreIOForHAFailed_LinkedView
	{
		protected HostSystem _host;
		protected Datastore _ds;
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
		public Datastore Ds
		{
			get
			{
				return this._ds;
			}
			set
			{
				this._ds = value;
			}
		}
	}
}
