namespace EnvironmentAssessment.Common.VimApi
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
