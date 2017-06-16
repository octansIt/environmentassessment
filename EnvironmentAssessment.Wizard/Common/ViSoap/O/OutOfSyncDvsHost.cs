namespace EnvironmentAssessment.Common.VISoap
{
    public class OutOfSyncDvsHost : DvsEvent
	{
		protected DvsOutOfSyncHostArgument[] _hostOutOfSync;
		public DvsOutOfSyncHostArgument[] HostOutOfSync
		{
			get
			{
				return this._hostOutOfSync;
			}
			set
			{
				this._hostOutOfSync = value;
			}
		}
	}
}
