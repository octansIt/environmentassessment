namespace EnvironmentAssessment.Common.VISoap
{
    public class DvsHostBackInSyncEvent : DvsEvent
	{
		protected HostEventArgument _hostBackInSync;
		public HostEventArgument HostBackInSync
		{
			get
			{
				return this._hostBackInSync;
			}
			set
			{
				this._hostBackInSync = value;
			}
		}
	}
}
