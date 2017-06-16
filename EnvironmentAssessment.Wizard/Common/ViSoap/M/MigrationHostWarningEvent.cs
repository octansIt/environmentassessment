namespace EnvironmentAssessment.Common.VISoap
{
    public class MigrationHostWarningEvent : MigrationEvent
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
