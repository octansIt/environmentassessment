namespace EnvironmentAssessment.Common.VISoap
{
    public class MigrationHostErrorEvent : MigrationEvent
	{
		protected HostEventArgument _dstHost;
		public HostEventArgument DstHost
		{
			get
			{
				return this._dstHost;
			}
			set
			{
				this._dstHost = value;
			}
		}
	}
}
